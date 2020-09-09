# Pizza-Popular-Toppings

### This is a small application that let restaurant clients know which pizza topping combinations are the most popular.
### This appication output which are top topping combinations 

## Implementation details

* Application is implemented using C# .Net 4.6

### Reading JSon Data:

* DataLoadService does load data into models 
* Json is deserialized using Newtonsoft.Json

### Model 

* Following are models in application
1) Pizza
2) PizzaToppingCombinations


### Service in application

*  IComputeService is interface 
*  ComputeService implements IComputeService 
*  ComputeService has all business logic 
*  ResultService calls ComputeServiceImpl methods and output the data


### Unit test cases 

* Unit test cases are written to test ComputeService  methods 

### Logging 

* Logging is done using log4net

## Input / Output

* Output for requested questions 
https://github.com/pallavidesai/Pizza-Popular-Toppings/blob/master/documents/Result.PNG




