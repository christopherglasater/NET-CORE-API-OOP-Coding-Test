If..then..else code could be turned into a factory pattern or a class that creates the classes. You could also use a strategy pattern, i.e. the factory could call the strategy and the strategy class could do the implementation of each class for a particular instance.

You could write something like this:
```
  IStrategy strategy = Factory.GetStrategy(int strategyType);

  SomeClass clazz = strategy.Create(string input1, string input2);
````
Code for Strategy class:

```
  public class SomeStrategy : IStrategy
  {
      public SomeClass Create(string input1, string input2)
      {
        SomeClass clazz = new SomeClass(input1, input2);
        //do something else here special to the strategy
        return clazz;
      }
  }
```
