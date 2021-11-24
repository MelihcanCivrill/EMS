using EMS.Data.Contracts;
using EMS.Data.DataContext;
using EMS.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Data.Implementation
{
    public class EmployeeLeaveRequestRepository : Repository<EmployeeLeaveRequest>, IEmployeeLeaveRequestRepository
    {
        private readonly EMSContext _ctx;
        public EmployeeLeaveRequestRepository(EMSContext ctx) : base(ctx)
        {
            
        }
    }
}
