using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Sonda
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
           if (Helper.IsNumeric(CordX.Text) && Helper.IsNumeric(CordY.Text))
            {
                int cordx = Convert.ToInt32(CordX.Text);
                int cordy = Convert.ToInt32(CordY.Text);
                if (Helper.IsPositive(cordx) && Helper.IsPositive(cordy))
                {
                    CriarPlanalto(cordx, cordy);
                    Session["cordx"] = cordx;
                    Session["cordy"] = cordy;
                    Response.Redirect("Planalto.aspx");

                }
            }

        }

        public void CriarPlanalto(int cordx, int cordy)
        {
            
        }
       
        protected void BtnNovaSonda_Click(object sender, ImageClickEventArgs e)
        {
           

           
        }
    }
}