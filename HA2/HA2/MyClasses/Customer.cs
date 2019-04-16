using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HA2.MyClasses
{
    public class Customer
    {
        string _address;
        string _name;

        public Customer(string add, string name)
        {
            _address = add;
            _name = name;
        }

        public string FullAddress
        {
            get { return _address; }
        }

        public string FullName
        {
            get { return _name; }
        }
    }
}