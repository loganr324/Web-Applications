using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HA2.MyClasses;

namespace HA2.AccountPages
{
    public partial class AccountDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Account> accountList = (List<Account>)Session["AccountsList"];
            Customer cust1 = (Customer)Session["customer"];
            int selectedAccountIndex = (int)Session["SelectedAccountIndex"];
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                nameLabel.Text = accountList[selectedAccountIndex].Nickname;
                typeLabel.Text = accountList[selectedAccountIndex].Type;
                balanceLabel.Text = accountList[selectedAccountIndex].Balance.ToString("c");
                if(accountList[selectedAccountIndex].hasLoanOffer() == true)
                {
                    eligibilityLabel.Text = "Yes";
                }
                else
                {
                    eligibilityLabel.Text = "No";
                }
                addressLabel.Text = cust1.FullAddress;
            }
        }

        protected void withdrawalButton_Click(object sender, EventArgs e)
        {
            List<Account> accountList = (List<Account>)Session["AccountsList"];
            Customer cust1 = (Customer)Session["customer"];
            int selectedAccountIndex = (int)Session["SelectedAccountIndex"];
            double withdrawalAmount = double.Parse(withdrawalText.Text);
            if(withdrawalAmount <= accountList[selectedAccountIndex].Balance)
            {
                accountList[selectedAccountIndex].Balance = accountList[selectedAccountIndex].Balance - withdrawalAmount;
                balanceLabel.Text = accountList[selectedAccountIndex].Balance.ToString("c");
                if (accountList[selectedAccountIndex].hasLoanOffer() == true)
                {
                    eligibilityLabel.Text = "Yes";
                }
                else
                {
                    eligibilityLabel.Text = "No";
                }
                Session["AccountsList"] = accountList;
                ErrorLabel.Text = "";
            }
            else
            {
                ErrorLabel.Text = "Withdrawal amount is greater than balance";
            }
        }
    }
}