using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.Common.VModels
{
    public class EmployeeLeaveTypeVM
    {
        [Required]
        public string Name { get; set; }
        public int DefaultDays { get; set; }
        public DateTime DateCreated { get; set; }

        public void SetEmployeeType(string name)
        {
            this.Name = name;
        }
    }
}
