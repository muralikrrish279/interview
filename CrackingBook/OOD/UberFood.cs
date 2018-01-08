using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.OOD
{
    class UberFood
    {
        private User user;
        private static List<Restaurant> restuarants;
        private Restaurant selectedRestuarants;

        void login(string creds) { }
        void SearchRestaurants() {
            restuarants.Add(new Restaurant());
        }
         void selectRestuarant()
        {
            this.selectedRestuarants  = restuarants[0];
        }

        //select items from restaurant menu
        //Order

    }

    class User
    {
        private string id;
        private Order activeOrder;
    }

    class Restaurant
    {
        private string id;
        private Menu latestMenu;
        private Dictionary<int,Order> activeOrders;
        public bool ProcessOrder(string id,List<Item> items) {
            return true;
        }
    }

    class Order
    {
        private string id;
        private Restaurant selectedRestaurant;
        private List<Item> itemsOrdered;
        private User Orderby;
        private DateTime Ordertime;
        private DateTime DeliveredTime;
    }

    class Menu
    {
        public int RestaurantId { get; set; }
        public List<Item> items { get; set; }
    }

    class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Currency { get; set; }

    }
}
