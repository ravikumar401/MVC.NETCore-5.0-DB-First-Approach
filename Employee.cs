using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.NETCore5DBFirstApproach
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string LoginId { get; set; }
        public string JobTitle { get; set; }
        public DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
    }
}
