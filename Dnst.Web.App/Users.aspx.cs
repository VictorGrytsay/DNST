using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dnst.DataLayer;
using Dnst.DataLayer.Models;

namespace Dnst.Web.App
{
    public partial class Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnBtnCreateUserClick(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            using (UserRepository repository = new UserRepository("dnst"))
            {
                UserModel newUser = repository.CreateUser(name, email, password);
            }

            btnCreateUser.BackColor = System.Drawing.Color.Blue;
        }

        protected void btnNothin_Click(object sender, EventArgs e)
        {

        }

        protected void btnAjx_Click(object sender, EventArgs e)
        {
            //txtName.Text = "333";
            txtName2.Text = "222";

            lbl1.Text = "Aync request was handled";
            btnCreateUser.BackColor = System.Drawing.Color.Blue;
        }
    }
}