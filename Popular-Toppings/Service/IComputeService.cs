using Popular_Toppings.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popular_Toppings.Service
{
    interface IComputeService
    {
        IEnumerable<PizzaToppingCombinations> GetAllToppings();
        IEnumerable<PizzaToppingCombinations> GetPopularToppings(IEnumerable<PizzaToppingCombinations> pizzaCombinations, int topCombinations);
    }
}
