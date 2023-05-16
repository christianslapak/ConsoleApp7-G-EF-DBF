﻿using System;
using System.Collections.Generic;

namespace ConsoleApp7_G_EF_DBF.Modelos
{
    public partial class Standard
    {
        public Standard()
        {
            Student = new HashSet<Student>();
            Teacher = new HashSet<Teacher>();
        }

        public int StandardId { get; set; }
        public string StandardName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Student> Student { get; set; }
        public virtual ICollection<Teacher> Teacher { get; set; }
    }
}
