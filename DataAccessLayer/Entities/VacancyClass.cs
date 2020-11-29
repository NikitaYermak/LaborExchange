﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class VacancyClass
    {
        private string requiredSkills;
        private string duties;
        private string category;
        private int id;

        public VacancyClass(string requiredSkills, string duties, string category)
        {
            this.requiredSkills = requiredSkills;
            this.duties = duties;
            this.category = category;
        }

        public string RequiredSkills { get => requiredSkills; set => requiredSkills = value; }
        public string Duties { get => duties; set => duties = value; }
        public string Category { get => category; set => category = value; }
        public int Id { get => id; set => id = value; }
    }
}
