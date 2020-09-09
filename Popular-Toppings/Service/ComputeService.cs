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
            var orderedPizzaToppings = _pizzas.Select(p => p.Toppings.OrderBy(t => t));

            // Aggregate toppings list into a comma delimited string
            IEnumerable<string> aggregatedToppings = orderedPizzaToppings.Select((toppings => toppings.Aggregate((x, y) => x + "," + y)));

            // Group toppings and get counts of each
            IEnumerable<PizzaToppingCombinations> groupedToppings = aggregatedToppings
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
            return pizzaCombinations.OrderByDescending(ag => ag.count).Take(topCombinations);
        }
    }
}
