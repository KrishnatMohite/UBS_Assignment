using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBS_CurrencyTransformsDataAccess
{
    //Entity Framework by convention seems to look for CurrencyTransforms
    //table rather than CurrencyTransform table without this attribute
    [Table("CurrencyTransform")]
    public class CurrencyTransform
    {
        public int CurrencyTransformId { get; set; }
        public int CurrencyAmt { get; set; }
        public string CurrencyAmtWords { get; set; }
    }
}
