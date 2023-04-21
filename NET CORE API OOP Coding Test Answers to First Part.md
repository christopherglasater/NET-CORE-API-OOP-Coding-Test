1.	If..then..else code could be turned into a factory pattern or a class that creates the classes. You could also use a strategy pattern, i.e. the factory could call the strategy and the strategy class could do the implementation of each class for a particular instance.
2.	You could write something like this:
IStrategy strategy = Factory.GetStrategy(int strategyType);
SomeClass clazz = strategy.Create(string input1, string input2…etc);
