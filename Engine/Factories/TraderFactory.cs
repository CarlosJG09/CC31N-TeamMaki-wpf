using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class TraderFactory
    {
        private static readonly List<Trader> _traders = new List<Trader>();
        static TraderFactory()
        {
            Trader merchant = new Trader("Merchant");
            merchant.AddItemToInventory(ItemFactory.CreateGameItem(101));

            Trader shopowner = new Trader("Shop Owner");
            shopowner.AddItemToInventory(ItemFactory.CreateGameItem(102));


            AddTraderToList(merchant);
            AddTraderToList(shopowner);
           
        }
        public static Trader GetTraderByName(string name)
        {
            return _traders.FirstOrDefault(t => t.Name == name);
        }
        private static void AddTraderToList(Trader trader)
        {
            if (_traders.Any(t => t.Name == trader.Name))
            {
                throw new ArgumentException($"There is already a trader named '{trader.Name}'");
            }
            _traders.Add(trader);
        }
    }
}
