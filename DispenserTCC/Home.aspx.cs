﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DispenserTCC
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRelatorio_Click(object sender, EventArgs e)
        {
            Response.Redirect("RelatorioDispenser.aspx");
        }
        
        protected void btnDispenser_Click(object sender, EventArgs e)
        {
            Response.Redirect("Configuracoes.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}