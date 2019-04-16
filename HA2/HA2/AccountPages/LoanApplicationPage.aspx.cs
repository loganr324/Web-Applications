using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HA2.MyClasses;

namespace HA2.AccountPages
{
    public partial class LoanApplicationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Account> accountList = (List<Account>)Session["AccountsList"];
            Customer cust1 = (Customer)Session["customer"];
            int selectedAccountIndex = (int)Session["SelectedAccountIndex"];
            nameLabel.Text = cust1.FullName;
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            List<Account> accountList = (List<Account>)Session["AccountsList"];
            Customer cust1 = (Customer)Session["customer"];
            int selectedAccountIndex = (int)Session["SelectedAccountIndex"];
            if (double.Parse(ageText.Text) > 18 &&
                double.Parse(amountText.Text) < accountList[selectedAccountIndex].Balance &&
                double.Parse(amountText.Text) < (0.5 * double.Parse(salaryText.Text)))
            {
                approvalLabel.Text = "Congratulations!! Your loan is approved.";
            }
            else
            {
                approvalLabel.Text = "Your loan is not approved. Sorry!!";
            }
        }
    }
}