using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Data.DbModels
{
    public class EmployeeLeaveType:BaseEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
