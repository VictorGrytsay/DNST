using Dnst.Web.App.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dnst.Web.App
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {

        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Headers.Add("test1", "a%0aa");
            Response.Headers.Add("test2", "d%0dd");

            if (!base.Page.IsPostBack)
            {
                listItems.Items.Add("One");
                listItems.Items.Add("Two");
                listItems.Items.Add("Three");
            }

            CustomButton cb = new CustomButton();
            cb.Text = "Custom button";
            pnlButtons.Controls.Add(cb);
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
        }

        protected void OnBtnAction1Click(object sender, EventArgs e)
        {

        }
    }
}