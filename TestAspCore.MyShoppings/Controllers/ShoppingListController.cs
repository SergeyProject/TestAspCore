using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TestAspCore.MyShoppings.DAL;
using TestAspCore.MyShoppings.EF;
using TestAspCore.MyShoppings.Models;

namespace TestAspCore.MyShoppings.Controllers
{
    public class ShoppingListController : Controller
    {
        [HttpGet]
        [Route("api/GetAllProducts")]
        public IActionResult GetAllProducts()
        {
            try
            {
                ShoppingListContext db = new ShoppingListContext();
                return Ok(db.ShoppingLists.ToList());
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        [HttpPost]
        [Route("api/CreateProduct")]
        public IActionResult CreateProduct([FromBody] ShoppingList item)
        {
            //ApplicationDataAccess dataAccess = new ApplicationDataAccess();
            //string str = dataAccess.CreateNew(item);
            return Ok("ok");
        }

        [HttpGet]
        [Route("api/DeleteProduct")]
        public IActionResult DeleteProduct(int id)
        {
            ApplicationDataAccess dataAccess = new ApplicationDataAccess();           
            bool str = dataAccess.Delete(id);
            return Ok(str.ToString());
        }

    }
}
