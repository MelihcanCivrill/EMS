using EMS.Data.Contracts;
using EMS.Data.DataContext;
using EMS.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Data.Implementation
{
    public class EmployeeLeaveAllocationRepository:Repository<EmployeeLeaveAllocation>, IEmployeeLeaveAllocationRepository
    {
        private readonly EMSContext _ctx;
        public EmployeeLeaveAllocationRepository(EMSContext ctx):base(ctx)
        {
            _ctx = ctx;
        }
    }
}
