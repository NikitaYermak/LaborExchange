using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    class CustomerClass : PersonInfo
    {
        private string aboutCompany;
        public CustomerClass(string aboutCompany, string name, string lastName, string fatherName)
            :base(name, lastName, fatherName)
        {
            this.aboutCompany = aboutCompany;
        }

        public string AboutCompany { get => aboutCompany; set => aboutCompany = value; }
    }
}
