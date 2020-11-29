using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    public abstract class PersonInfo
    {
        private string name;
        private string lastName;
        private string fatherName;
        private int id;

        public PersonInfo(string name, string lastName, string fatherName)
        {
            this.name = name;
            this.lastName = lastName;
            this.fatherName = fatherName;
        }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FatherName { get => fatherName; set => fatherName = value; }
        public int Id { get => id; set => id = value; }
    }
}
