using DispenserTCC.Objetos;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DispenserTCC
{
    public partial class Relatorio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGerarRelatorio_Click(object sender, EventArgs e)
        {

            var memStream = new MemoryStream();

            string pathPlanilhaBase;
            string pathPlanilha;

            pathPlanilhaBase = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Relatorio_Dispenser\Relatorio_Dispenser.xlsx");

            pathPlanilha = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, String.Format(@"Relatorio_{0}.xlsx", DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss")) + ".xlsx");

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            File.Copy(pathPlanilhaBase, pathPlanilha);

            FileInfo fileInfo = new FileInfo(pathPlanilha);
            ExcelPackage excelPackage = new ExcelPackage(fileInfo);

            ExcelWorksheet Dispensado = excelPackage.Workbook.Worksheets[0];
            ExcelWorksheet Programado = excelPackage.Workbook.Worksheets[1];
            ExcelWorksheet Total = excelPackage.Workbook.Worksheets[2];

            Relatorios obj = new Relatorios();

            List<Horarios> listaRelatorio = obj.BuscarRelatorio();

            var usuarios = listaRelatorio.GroupBy(x => x.Nome);

            List<TotalRelatorio> totalRelatorio = new List<TotalRelatorio>();

            foreach ( var u in usuarios)
            {
                totalRelatorio.Add(new TotalRelatorio()
                {
                    Usuario = u.Key,
                    QtdIngerido = u.Where(r => r.Dispensado == 1).ToList().Sum(r => r.Quantidade),
                    QtdTotal = u.Sum(r => r.Quantidade)
                });
            }

            List<Horarios> listaDispensado = listaRelatorio.Where(r => r.Dispensado == 1).ToList();
            List<Horarios> listaProgramado = listaRelatorio.Where(r => r.Dispensado == 0).ToList();

            int linha = 2;

            foreach (var item in listaDispensado)
            {
                Dispensado.Cells[linha, 1].Value = item.Nome;
                Dispensado.Cells[linha, 2].Value = item.Medicamento;
                Dispensado.Cells[linha, 3].Value = item.Quantidade;
                Dispensado.Cells[linha, 4].Value = item.DatPrescricao;
                Dispensado.Cells[linha, 5].Value = item.HoraPrescricao;
                linha++;
            }

            linha = 2;
            foreach (var item in listaProgramado)
            {
                Programado.Cells[linha, 1].Value = item.Nome;
                Programado.Cells[linha, 2].Value = item.Medicamento;
                Programado.Cells[linha, 3].Value = item.Quantidade;
                Programado.Cells[linha, 4].Value = item.DatPrescricao;
                Programado.Cells[linha, 5].Value = item.HoraPrescricao;
                linha++;
            }

            linha = 2;
            foreach (var item in totalRelatorio)
            {
                Total.Cells[linha, 1].Value = item.Usuario;
                Total.Cells[linha, 2].Value = item.QtdIngerido;
                Total.Cells[linha, 3].Value = item.QtdTotal;
                linha++;
            }

            excelPackage.SaveAs(fileInfo);
            excelPackage.Dispose();

            //Clears all content output from the buffer stream.  
            Response.ClearContent();
            //Adds HTTP header to the output stream  
            Response.AddHeader("content-disposition", string.Format("attachment; filename=Relatorio_{0}.xlsx", DateTime.Now.ToString("dd-MM-yyyy_HH-mm")));

            // Gets or sets the HTTP MIME type of the output stream  
            Response.ContentType = "application/vnd.ms-excel";
            Response.WriteFile(fileInfo.FullName);
            Response.End();

            File.Delete(fileInfo.FullName);
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}