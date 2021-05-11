using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz {
    public partial class Quiz20210511_1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            string tb_ID = "";
            string tb_Name = "";
            if(Session["ID"] != null || Session["name"] != null)
            {
                tb_ID = (string)Session["ID"];
                tb_Name = (string)Session["name"];
                Response.Write(tb_ID +"<br />"+tb_Name);
            }
        }
    }
}