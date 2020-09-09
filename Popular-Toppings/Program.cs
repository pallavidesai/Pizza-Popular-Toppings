using Popular_Toppings.Model;
using Popular_Toppings.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popular_Toppings
{
    class Program
    {
        static void Main(string[] args)
        {
            if (DataLoadService.LoadJsonData())
            {
                IComputeService service = new ComputeService(DataLoadService.Pizzas);
                ResultService result = new ResultService(service);
                result.ComputeResult(20);
                result.OutputResult();
            }
        }

    }
}
