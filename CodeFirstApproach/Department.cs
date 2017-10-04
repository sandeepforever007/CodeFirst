using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstApproach
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string Dname { get; set; }
        public string Location { get; set; }
        public List<Employee> Employees { get; set; }
    }
}