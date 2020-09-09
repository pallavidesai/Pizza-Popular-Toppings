using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Popular_Toppings.Model;

namespace Popular_Toppings.Service
{
    public class ComputeService : IComputeService
    {
        private List<Pizza> _pizzas;

        public ComputeService(List<Pizza> pizzas)
        {
            this._pizzas = pizzas;
        }

        public IEnumerable<PizzaToppingCombinations> GetAllToppings()
        {
            // Order toppings in each pizza object 
            var orderedToppings = _pizzas.Select(p => p.Toppings.OrderBy(t => t));

            // convert toppings list into a comma separated string
            var commaSeparatedToppings = orderedToppings.Select((toppings => toppings.Aggregate((m, n) => m + "," + n)));

            // Group and count toppings
            var groupedToppings = commaSeparatedToppings
                .GroupBy(toppingsGroup => toppingsGroup)
                .Select(toppingsGroup => new PizzaToppingCombinations()
                {
                    toppings = toppingsGroup.Key,
                    count = toppingsGroup.Count()
                });

            return groupedToppings;
        }

        public IEnumerable<PizzaToppingCombinations> GetPopularToppings(IEnumerable<PizzaToppingCombinations> pizzaCombinations, int topCombinations)
        {
            return pizzaCombinations.OrderByDescending(x => x.count).Take(topCombinations);
        }
    }
}
