using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer.EmployeeModels
{
    public class EmpGetModel
    {
        public int EmpId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public long MobileNo { get; set; } 
    }
}
