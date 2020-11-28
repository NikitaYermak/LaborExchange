using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    class SummaryClass : PersonInfo
    {
        private string number;
        private string skills;
        private string experience;

        public SummaryClass(string number, string skills, string experience, string name, string lastName, string fatherName) 
            : base (name, lastName, fatherName)
        {
            this.number = number;
            this.skills = skills;
            this.experience = experience;
        }

        public string Number { get => number; set => number = value; }
        public string Skills { get => skills; set => skills = value; }
        public string Experience { get => experience; set => experience = value; }
    }
}
