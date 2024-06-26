﻿namespace VioletPOS.Share.ViewModels
{


    public class EmployeeViewModel
    {

        public int EmployeeID { get; set; }
        public string Code { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime DOB { get; set; }

        public DateTime DOE { get; set; }

        public DateTime? DOR { get; set; }

        public decimal BasicSalary { get; set; }

        public string Gender { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
    }
}
