using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ThreeAmigosReveseProxy.Controllers
{
    [Route("Admin/")]
    [ApiController]
    public class AdminProxyController : ControllerBase
    {
        #region Staff
        [Route("Staff")]
        public ActionResult RerouteStaffPage()
        {
            string uri = "https://thamco-staffmanagement.azurewebsites.net/Staff?";
            return Redirect(uri);
        }
        #endregion


        #region Orders
        [Route("Orders/PendingDispatch")]
        public ActionResult ReroutePendingOrdersPage()
        {
            string uri = "https://orders-frontend-prod.azurewebsites.net/Order/PendingDispatch/";
            return Redirect(uri);
        }

        [Route("Orders/Invoice")]
        public ActionResult RerouteInvoceOrdersPage()
        {
            string uri = "https://invoices-frontend-prod.azurewebsites.net/invoice/";
            return Redirect(uri);
        }


        #endregion





    }
}