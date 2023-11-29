using DispenserTCC.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DispenserTCC
{
    public partial class Configuracoes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Horarios obj = new Horarios();

            var intervalo = Convert.ToInt32(txtIntervalo.Text);
            var qtdDias = Convert.ToInt32(txtQtdDias.Text);
            var qtdPorDia = 24 / intervalo;
            var qtdTotal = qtdPorDia * qtdDias;
            var dataPrescricao = Convert.ToDateTime(txtData_prescricao.Text + " " + txtHora_prescricao.Text).ToString("yyyy-MM-dd HH:mm:ss");
            string horaPrescricao = txtHora_prescricao.Text;

            if (!String.IsNullOrEmpty(txtNome.Text) && 
                !String.IsNullOrEmpty(txtMedicamento.Text) && 
                !String.IsNullOrEmpty(txtQuantidade.Text) &&
                !String.IsNullOrEmpty(txtData_prescricao.Text) &&
                !String.IsNullOrEmpty(txtHora_prescricao.Text))
            {
                if (!String.IsNullOrEmpty(txtData_prescricao.Text))
                {
                    dataPrescricao = Convert.ToDateTime(dataPrescricao).ToString("yyyy-MM-dd HH:mm:ss");
                }
                if (!String.IsNullOrEmpty(txtHora_prescricao.Text))
                {
                    horaPrescricao = Convert.ToDateTime(horaPrescricao).ToString("HH:mm");
                }
                obj.InserirHorario(txtNome.Text, txtMedicamento.Text, Convert.ToInt32(txtQuantidade.Text), dataPrescricao.Split(' ').FirstOrDefault(), horaPrescricao, 0);


                for (int i = 0; i < qtdTotal; i++)
                {
                    if (!String.IsNullOrEmpty(txtData_prescricao.Text))
                    {
                        dataPrescricao = Convert.ToDateTime(dataPrescricao).AddHours(intervalo).ToString("yyyy-MM-dd HH:mm:ss");
                    }
                    if (!String.IsNullOrEmpty(txtHora_prescricao.Text))
                    {
                        horaPrescricao = Convert.ToDateTime(horaPrescricao).AddHours(intervalo).ToString("HH:mm");
                    }

                    
                    obj.InserirHorario(txtNome.Text, txtMedicamento.Text, Convert.ToInt32(txtQuantidade.Text), dataPrescricao.Split(' ').FirstOrDefault(), horaPrescricao, 0);
                }
            }
            Response.Redirect("Home.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}