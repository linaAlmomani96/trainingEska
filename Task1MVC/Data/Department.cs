﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task1MVC.Data
{
    public class Department
    {
        public int Id { get; set; }
        [Required(ErrorMessage = " * Required")]
        public string Name { get; set; }
        public string Description { get; set; }

       public List<Employee> employees { set; get; }

    }
}
