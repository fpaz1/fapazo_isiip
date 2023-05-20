using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwBll.Interfaces.Sales;
using Common.Runtime;
using Entities.Sales;
using AwDal.Sales;
using Common.Runtime;
using Entities.Production;
using Microsoft.Extensions.Configuration;

namespace AwBll.Implementations.Sales
{
    public class ReasonBll : IReasonBll
    {
        private readonly IConfiguration _configuration;
        private readonly SalesReasonDal dbReason;
    

    public ReasonBll(IConfiguration configuration)
    {
        _configuration = configuration;
        string connectionString = _configuration.GetConnectionString(name: "AwConnectionString");
        dbReason = new SalesReasonDal(connectionString);
    }
        public Task<int> Create(string Name)
        {
            return dbReason.Create(Name);
        }

        public async Task<List<ProductCategory>> GetAll()
        {
            return dbReason.GetAll();
        }

        public async Task<ProductCategory> GetById(int categoryId)
        {
            return await dbCategory.GetById(categoryId);
        }

        public Task<ExecutionResult> Save(string categoryName)
        {
            return dbCategory.Save(categoryName);
        }
    }
}
