using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    class UnemployedClass : PersonInfo
    {
        private int age;
        private string specialty;
        public UnemployedClass(int age, string specialty, string name, string lastName, string fatherName)
            : base(name, lastName, fatherName)
        {
            this.age = age;
            this.specialty = specialty;
        }

        public int Age { get => age; set => age = value; }
        public string Specialty { get => specialty; set => specialty = value; }
    }
}
