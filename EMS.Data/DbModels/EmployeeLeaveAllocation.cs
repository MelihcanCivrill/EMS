using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EMS.Data.DbModels
{
    public class EmployeeLeaveAllocation:BaseEntity
    {
        public int NumberOfDays { get; set; }
        public DateTime DataCreated { get; set; }
        public int Period { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
        public string EmployeeId { get; set; }

        public int EmployeeLeayeTypeId { get; set; }
        [ForeignKey("EmployeeLeayeTypeId")]
        public EmployeeLeaveType EmployeeLeaveType  { get; set; }
    }
}
