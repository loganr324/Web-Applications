using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HA2.MyClasses
{
    public class GenerateSessionObjects
    {
        List<Account> accountList = new List<Account>();

        public GenerateSessionObjects()
        {
            Account savings1 = new Account();
            savings1.Type = "Savings";
            savings1.Balance = 8750;
            savings1.Nickname = "MySav1";
            Account checking1 = new Account();
            checking1.Type = "Checking";
            checking1.Balance = 12500;
            checking1.Nickname = "MyChk1";
            Account checking2 = new Account();
            checking2.Type = "Checking";
            checking2.Balance = 25000;
            checking2.Nickname = "MyChk2";
            accountList.Add(savings1);
            accountList.Add(checking1);
            accountList.Add(checking2);
            Customer cust1 = new Customer("9999 Made Up Lane","Logan Robinson");
            HttpContext.Current.Session["customer"] = cust1;
            HttpContext.Current.Session["AccountsList"] = accountList;
        }
    }
}