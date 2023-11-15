using DispenserTCC.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DispenserTCC
{
    public partial class CadastroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuarios obj = new Usuarios();
            if (!String.IsNullOrEmpty(txtNome.Text) && !String.IsNullOrEmpty(txtEmail.Text) && !String.IsNullOrEmpty(txtSenha.Text))
            {
                obj.InserirUsuario(txtNome.Text, txtNumDocumento.Text, txtNumTelefone.Text, txtEmail.Text, txtSenha.Text);
            }

            Response.Redirect("Login.aspx");
        }
    }
}