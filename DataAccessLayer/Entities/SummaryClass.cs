using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class SummaryClass : PersonInfo
    {
        private string number;
        private string skills;
        private string category;

        public SummaryClass(string number, string skills, string category, string name, string lastName, string fatherName) 
            : base (name, lastName, fatherName)
        {
            this.number = number;
            this.skills = skills;
            this.category = category;
        }

        public string Number { get => number; set => number = value; }
        public string Skills { get => skills; set => skills = value; }
        public string Category { get => category; set => category = value; }
    }
}
