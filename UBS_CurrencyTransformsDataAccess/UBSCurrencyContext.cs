using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBS_CurrencyTransformsDataAccess
{
    public class UBSCurrencyContext : DbContext
    {
        public DbSet<CurrencyTransform> CurrencyTransforms { get; set; }
    }
}
