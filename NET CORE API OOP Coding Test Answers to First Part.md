If..then..else code could be turned into a factory pattern or a class that creates the classes. You could also use a strategy pattern, i.e. the factory could call the strategy and the strategy class could do the implementation of each class for a particular instance.

You could write something like this:
```
  IStrategy strategy = Factory.GetStrategy(int strategyType);//the input here could be something that was a result of the previous boolean logic

  SomeClass clazz = strategy.Create(string input1, string input2);
```

  if...then...else could be replaced by changing the boolean logic to a type, like something = true and someValue ="test" 
  
  could be changed farther up into objects like a type or enum

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
