using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ThreeAmigosReveseProxy.Controllers
{   
    [ApiController]
    public class GeneralProxyController : ControllerBase
    {

        //Have a look at introducing middleware to this.

        #region Products
        [Route("Products")]
        public ActionResult RerouteProductsPage()
        {
            string uri = "https://msproductsfe.azurewebsites.net/";
            return Redirect(uri);
        }

        [Route("Products/Review/{prodID}")]
        public ActionResult RerouteProductsReviewPage(Guid prodID)
        {
            if(prodID == Guid.Empty) 
            {
                return BadRequest();
            }

            string uri = "https://msproductsfe.azurewebsites.net/" + prodID;
            return Redirect(uri);
        }



        #endregion

        #region Orders
        [Route("Orders/Active")]
        public ActionResult RerouteActiveOrdersPage()
        {
            string uri = "https://orders-frontend-prod.azurewebsites.net/Order/Active/";
            return Redirect(uri);
        }

        [Route("Orders/History")]
        public ActionResult RerouteHistoryOrdersPage()
        {
            string uri = "https://orders-frontend-prod.azurewebsites.net/Order/History/";
            return Redirect(uri);
        }

        
        #endregion


        #region New Product
        [Route("NewProduct/CreateSearch")]
        public ActionResult RerouteCreateSearchPage()
        {
            string uri = "https://localhost:44353/NewProduct/CreateSearch/";
            return Redirect(uri);
        }

        [Route("NewProduct")]
        public ActionResult RerouteNewProductsPage()
        {
            string uri = "https://localhost:44353/NewProduct/";
            return Redirect(uri);
        }

        #endregion





    }
}
