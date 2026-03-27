using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollegerSystem.Models
{
    public partial class Colleger
    {

        public int ID { get; set; }
        public String Name { get; set; }
        public String Sexo { get; set; }
        public String CPF { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}