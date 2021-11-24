using EMS.Data.Contracts;
using EMS.Data.DataContext;
using EMS.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Data.Implementation
{
    public class EmployeeLeaveTypeRepository : Repository<EmployeeLeaveType>, IEmployeeLeaveTypeRepository
    {
        private readonly EMSContext _ctx;
        public EmployeeLeaveTypeRepository(EMSContext ctx) : base(ctx)
        {
            _ctx= ctx;
        }


    }
}
