using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using UBS_CurrencyTransformsDataAccess;

namespace UBS_API.Controllers
{
    public class CurrencyTransformsController : ApiController
    {
        private UBSCurrencyContext db = new UBSCurrencyContext();

        // POST: api/CurrencyTransforms
        [ResponseType(typeof(CurrencyTransform))]
        public IHttpActionResult PostCurrencyTransform(int id)
        {
            if (id < 0)
            {
                return BadRequest();
            }
            if (db.CurrencyTransforms.Any(ct => ct.CurrencyAmt == id))
            {
                return Ok(db.CurrencyTransforms.FirstOrDefault(ct => ct.CurrencyAmt == id));
            }
            try
            {
                UBS_TransformService.CurrencyTransformClient client = new UBS_TransformService.CurrencyTransformClient("NetTcpBinding_ICurrencyTransform");
                string lstrAmtWords = client.Humanize(id);
                CurrencyTransform lcurrencyTransform = new CurrencyTransform() { CurrencyAmt = id, CurrencyAmtWords = lstrAmtWords };
                db.CurrencyTransforms.Add(lcurrencyTransform);
                db.SaveChanges();
                return Ok(lcurrencyTransform);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public IHttpActionResult GetTest236()
        {
            return ok();
        }

    }
}
