using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q2
{
    public partial class Question_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                bookList.Items.Add("Introduction to MIS");
                bookList.Items.Add("Introduction to Marketing");
                bookList.Items.Add("Introduction to Finanace");
            }
        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            if (bookList.SelectedIndex == -1)
            {
                messageLabel.Text = "Select a book to purchase.";
            }
            else
            {
                messageLabel.Text = "You have selected " + int.Parse(quantityText.Text) +
                    " copies of " + bookList.SelectedValue + ".";
            }
        }
    }
}