using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapeau_Model
{
    public enum MenuType
    {
        Lunch = 1, Dinner, Drink
    }

    public enum SubMenuType
    {
        LunchMain=1, Specials, Bites, Starters, Mains, Desserts, SoftDrinks, HotDrinks, Beers, Wines
    }

    public enum PaymentMethod
    {
        Cash, Debit, Credit
    }

    public enum JobRole
    {
        Bar, Kitchen, Wait, Manager
    }

    public enum OrderStatus
    {
        Sent, Ready, Served
    }

    public enum TableStatus
    {
        Available, Occupied, Reserved
    }

}
