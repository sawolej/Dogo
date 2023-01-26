using System;
using Dogo.Models;

namespace Dogo.DB.CardF
{
    public class ShoppingCard
    {
        public DogoDBContext _context { get; set; }

        public string ShoppingCartId { get; set; }
        public List<Card> ShoppingCardItems { get; set; }

        public ShoppingCard(DogoDBContext context)
        {
            _context = context;
        }

       /* public static ShoppingCard GetShoppingCard(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<DogoDBContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new ShoppingCard(context) { ShoppingCardId = cartId };
        }

        public void AddItemToCart(Dog Dog)
        {
            var ShoppingCardItem = _context.ShoppingCardItems.FirstOrDefault(n => n.Dog.Id == Dog.Id && n.ShoppingCardId == ShoppingCardId);

            if (ShoppingCardItem == null)
            {
                ShoppingCardItem = new ShoppingCardItem()
                {
                    ShoppingCardId = ShoppingCardId,
                    Dog = Dog,
                    Amount = 1
                };

                _context.ShoppingCardItems.Add(ShoppingCardItem);
            }
            else
            {
                ShoppingCardItem.Amount++;
            }
            _context.SaveChanges();
        }

        public void RemoveItemFromCart(Dog Dog)
        {
            var ShoppingCardItem = _context.ShoppingCardItems.FirstOrDefault(n => n.Dog.Id == Dog.Id && n.ShoppingCardId == ShoppingCardId);

            if (ShoppingCardItem != null)
            {
                if (ShoppingCardItem.Amount > 1)
                {
                    ShoppingCardItem.Amount--;
                }
                else
                {
                    _context.ShoppingCardItems.Remove(ShoppingCardItem);
                }
            }
            _context.SaveChanges();
        }

        public List<ShoppingCardItem> GetShoppingCardItems()
        {
            return ShoppingCardItems ?? (ShoppingCardItems = _context.ShoppingCardItems.Where(n => n.ShoppingCardId == ShoppingCardId).Include(n => n.Dog).ToList());
        }

        public double GetShoppingCardTotal() => _context.ShoppingCardItems.Where(n => n.ShoppingCardId == ShoppingCardId).Select(n => n.Dog.Price * n.Amount).Sum();

        public async Task ClearShoppingCardAsync()
        {
            var items = await _context.ShoppingCardItems.Where(n => n.ShoppingCardId == ShoppingCardId).ToListAsync();
            _context.ShoppingCardItems.RemoveRange(items);
            await _context.SaveChangesAsync();
        }*/
    }
}
