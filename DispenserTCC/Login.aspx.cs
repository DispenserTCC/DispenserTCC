using DispenserTCC.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DispenserTCC
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuarios obj = new Usuarios();
            var nome = obj.VerificaUsuario(txtEmail.Text, txtSenha.Text);

            if (!String.IsNullOrEmpty(nome))
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastroUsuario.aspx");
        }
    }
}