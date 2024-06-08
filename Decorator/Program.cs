using Decorator;

PizzaAbstract pizza = new CaliforniaBase();
pizza = new TomatoAddition(pizza);
pizza = new MozarellaAddition(pizza);
pizza = new MozarellaAddition(pizza);
pizza = new PepperoniAddition(pizza);
pizza = new PepperoniAddition(pizza);
pizza = new PepperoniAddition(pizza);

Console.WriteLine(pizza.getDescription());
Console.WriteLine($"Total - {pizza.getCost()}$");
