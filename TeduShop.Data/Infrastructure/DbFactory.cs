using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    public class DbFactory : IDisposable, IDbFactory
    {
        private TeduShopDbContext dbContext;

        public void Dispose()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }

        public TeduShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TeduShopDbContext());
        }
    }
}
