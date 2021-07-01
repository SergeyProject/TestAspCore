using TestAspCore.MyShoppings.EF;
using TestAspCore.MyShoppings.Models;

namespace TestAspCore.MyShoppings.DAL
{
    public class ApplicationDataAccess
    {
        public string CreateNew(ShoppingList list)
        {
            ShoppingListContext db = new ShoppingListContext();
            db.ShoppingLists.Add(list);
            db.SaveChanges();
            return "OK!";
        }

        public bool Delete(int id)
        {
            ShoppingListContext db = new ShoppingListContext();
            ShoppingList slist = new ShoppingList { Id = id };
            db.ShoppingLists.Attach(slist);
            db.ShoppingLists.Remove(slist);
            db.SaveChanges();
            return true;
        }
    }
}
