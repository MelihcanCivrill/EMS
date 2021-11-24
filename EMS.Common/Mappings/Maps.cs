using AutoMapper;
using EMS.Common.VModels;
using EMS.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Common.Mappings
{
    public class Maps:Profile
    {
        public Maps()
        {
            CreateMap<EmployeeLeaveType,EmployeeLeaveTypeVM>().ReverseMap();
            CreateMap<EmployeeLeaveAllocation, EmployeeLeaveAllocationsVM>().ReverseMap();
            CreateMap<EmployeeLeaveRequest, EmployeeLeaveRequestVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();
        }
    }
}
