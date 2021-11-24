using System;


namespace EMS.Common.VModels
{
    public class EmployeeLeaveAllocationsVM:BaseVM
    {
        public int NumberOfDays { get; set; }
        public DateTime DataCreated { get; set; }
        public int Period { get; set; }
 
        public EmployeeVM Employee { get; set; }
        public string EmployeeIdVm { get; set; }

        public int EmployeeLeayeTypeId { get; set; }

        public EmployeeLeaveTypeVM EmployeeLeaveTypeVm { get; set; }
    }
}
