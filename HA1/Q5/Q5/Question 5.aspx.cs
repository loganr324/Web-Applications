using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q5
{
    public partial class Question_5 : System.Web.UI.Page
    {
        double savings = 30345.90;
        double checking = 40785.22;
        double student = 5643.23;

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                accountList.Items.Add("Savings Account");
                accountList.Items.Add("Checking Account");
                accountList.Items.Add("Student Account");
            }
        }

        protected void withdrawButton_Click(object sender, EventArgs e)
        {
            if (accountList.SelectedValue == "Savings Account")
            {
                if (savings - double.Parse(amountText.Text) >= 0)
                {
                    savings = savings - double.Parse(amountText.Text);
                    withdrawalMessage.Text = "Withdrawal successful. Your new balance is " + savings.ToString("c");
                }
                else
                {
                    withdrawalMessage.Text = "Withdrawal amount is greater than the balance which is " +
                        savings.ToString("c");
                }
            }
            if (accountList.SelectedValue == "Checking Account")
            {
                if (checking - double.Parse(amountText.Text) >= 0)
                {
                    checking = checking - double.Parse(amountText.Text);
                    withdrawalMessage.Text = "Withdrawal successful. Your new balance is " + checking.ToString("c");
                }
                else
                {
                    withdrawalMessage.Text = "Withdrawal amount is greater than the balance which is " +
                        checking.ToString("c");
                }
            }
            if (accountList.SelectedValue == "Savings Account")
            {
                if (student - double.Parse(amountText.Text) >= 0)
                {
                    student = student - double.Parse(amountText.Text);
                    withdrawalMessage.Text = "Withdrawal successful. Your new balance is " + student.ToString("c");
                }
                else
                {
                    withdrawalMessage.Text = "Withdrawal amount is greater than the balance which is " +
                        student.ToString("c");
                }
            }
        }
    }
}