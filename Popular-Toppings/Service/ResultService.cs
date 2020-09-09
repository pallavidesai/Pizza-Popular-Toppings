using Popular_Toppings.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popular_Toppings.Service
{
    class ResultService
    {
        private IComputeService _service;
        private IEnumerable<PizzaToppingCombinations> _topPopularToppings;

        public ResultService(IComputeService service)
        {
            this._service = service;
        }

        public void ComputeResult(int Top)
        {
            var allToppings =  _service.GetAllToppings();
            _topPopularToppings = _service.GetPopularToppings(allToppings, Top);
        }

        public void OutputResult()
        {
            int rank = 1;
            string sample = "Number {0} Topping \t: {1}(was ordered {2} times)";

            foreach (PizzaToppingCombinations combo in _topPopularToppings)
            {
                Console.WriteLine(String.Format(sample, rank, combo.toppings, combo.count));
                rank++;
            }
        }
    }
}
