using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HA2.MyClasses;

namespace HA2
{
    public partial class AccountSelection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["AccountsList"] == null)
            {
                new GenerateSessionObjects();
            }

            List<Account> accountList = (List<Account>)Session["AccountsList"];
            Customer cust1 = (Customer)Session["customer"];
            welcomeLabel.Text = "Welcome " + cust1.FullName;
            foreach(Account acct in accountList)
            {
                accountListBox.Items.Add(acct.Nickname);
            }
        }

        protected void detailsButton_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/AccountPages/AccountDetails.aspx");
        }

        protected void accountListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedAccountIndex = accountListBox.SelectedIndex;
            HttpContext.Current.Session["SelectedAccountIndex"] = selectedAccountIndex;
        }
    }
}