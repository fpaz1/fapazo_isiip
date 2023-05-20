using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Runtime;
using Entities.Sales;

namespace AwBll.Interfaces.Sales
{
    public interface IReasonBll
    {
        Task<List<SalesReason>> GetAll();
        Task<int> Create(string Name);
        Task<SalesReason> GetById(int SalesReasonID);
        Task<ExecutionResult> Save(string Name);
    }
}
