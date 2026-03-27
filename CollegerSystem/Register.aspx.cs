using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Compilation;
using System.Web.UI;
using System.Web.UI.WebControls;
using CollegerSystem.Models;

namespace CollegerSystem
{
    public partial class Register : System.Web.UI.Page
    {
        public static List<Colleger> users = new List<Colleger>();
        public static int ContInt = 1;
        protected void btncadastrar_Click(object sender, EventArgs e)
        {
            Colleger c = new Colleger();

            c.Name = txtName.Text;
            c.CPF = txtCPF.Text;
            c.Sexo = txtSexo.Text;
            c.ID = ContInt;
            ContInt++;

            users.Add(c);

            GridBolsistas.DataSource = users;
            GridBolsistas.DataBind();

            Response.Write("Bolsista adicionado com sucesso!");
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}