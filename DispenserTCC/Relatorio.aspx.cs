﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
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
            //var memStream = new MemoryStream();

            //string pathPlanilha;

            //pathPlanilha = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Relatorios\planilha_portalXMassificado.xlsx");

            //FileInfo fileInfo = new FileInfo(pathPlanilha);
            //ExcelPackage excelPackage = new ExcelPackage(fileInfo);

            //ExcelWorksheet worksheetPart = excelPackage.Workbook.Worksheets[0];
            //ExcelWorksheet worksheetPartDuplicados = excelPackage.Workbook.Worksheets[1];
            //ExcelWorksheet worksheetPartApolices = excelPackage.Workbook.Worksheets[2];

            //List<PortalXMassificado> listaItemCotacao = new DomainModel.SubConta<TransferObject.SubConta>().ObterPortalXMassificado();
            //List<TransferObject.Item> listaItensDuplicados = new DomainModel.SubConta<TransferObject.SubConta>().ObterItensDuplicados(datCancelamento);



            //int linha = 2;
            //foreach (var item in listaItemCotacao)
            //{
            //    DateTime dataItem = new DateTime();
            //    DateTime dataCotacao = new DateTime();

            //    if (!String.IsNullOrEmpty(item.DatCancelamentoItem))
            //    {
            //        dataItem = Convert.ToDateTime(item.DatCancelamentoItem);
            //    }

            //    if (!String.IsNullOrEmpty(item.DatCancelamentoCotacao))
            //    {
            //        dataCotacao = Convert.ToDateTime(item.DatCancelamentoCotacao);
            //    }

            //    worksheetPart.Cells[linha, 1].Value = item.NumConta;
            //    worksheetPart.Cells[linha, 2].Style.Numberformat.Format = "@";
            //    worksheetPart.Cells[linha, 2].Value = item.NumSubConta;
            //    worksheetPart.Cells[linha, 3].Value = item.CodItem;
            //    worksheetPart.Cells[linha, 4].Value = item.CodCotacaoPortal;
            //    worksheetPart.Cells[linha, 5].Value = item.NomSegurado;
            //    worksheetPart.Cells[linha, 6].Value = item.StatusItem;
            //    worksheetPart.Cells[linha, 7].Value = item.StatusCotacao;
            //    worksheetPart.Cells[linha, 8].Value = item.NumDocumentoItem;
            //    worksheetPart.Cells[linha, 9].Value = item.NumDocumentoCotacao;
            //    worksheetPart.Cells[linha, 10].Value = dataItem.ToString("dd/MM/yyyy HH:mm:ss");
            //    worksheetPart.Cells[linha, 11].Value = dataCotacao.ToString("dd/MM/yyyy HH:mm:ss");
            //    worksheetPart.Cells[linha, 12].Value = item.TelefoneItem;
            //    worksheetPart.Cells[linha, 13].Value = item.TelefoneCotacao;
            //    worksheetPart.Cells[linha, 14].Value = item.CelularItem;
            //    worksheetPart.Cells[linha, 15].Value = item.CelularCotacao;
            //    worksheetPart.Cells[linha, 16].Value = item.LogradouroItem;
            //    worksheetPart.Cells[linha, 17].Value = item.LogradouroCotacao;
            //    worksheetPart.Cells[linha, 18].Value = item.CodCnaeItem;
            //    worksheetPart.Cells[linha, 19].Value = item.NomPlano;
            //    worksheetPart.Cells[linha, 20].Value = item.CidadeItem;
            //    worksheetPart.Cells[linha, 21].Value = item.CidadeCotacao;
            //    worksheetPart.Cells[linha, 22].Value = item.EnderecoItem;
            //    worksheetPart.Cells[linha, 23].Value = item.EnderecoCotacao;
            //    worksheetPart.Cells[linha, 24].Value = item.CompItem;
            //    worksheetPart.Cells[linha, 25].Value = item.CompCotacao;
            //    worksheetPart.Cells[linha, 26].Value = item.DatCotacao;
            //    worksheetPart.Cells[linha, 27].Value = item.Contrato;
            //    worksheetPart.Cells[linha, 28].Value = item.Cep;
            //    worksheetPart.Cells[linha, 29].Value = item.Descricao;
            //    linha++;
            //}

            //excelPackage.SaveAs(memStream);
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}