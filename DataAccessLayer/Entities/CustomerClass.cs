using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class CustomerClass : PersonInfo
    {
        private string aboutProject;
        public CustomerClass(string aboutProject, string name, string lastName, string fatherName)
            :base(name, lastName, fatherName)
        {
            this.aboutProject = aboutProject;
        }

        public string AboutProject { get => aboutProject; set => aboutProject = value; }
    }
}
