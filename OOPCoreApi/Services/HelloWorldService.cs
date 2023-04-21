using OOPCoreApi.Models;

namespace OOPCoreApi.Services
{
    public class HelloWorldService : IHelloWorldService
    {
        public SomethingModel DoSomething(string input)
        {
            return new SomethingModel { Id=1, Name=input };
        }

        public SomethingModel DoSomethingElse(SomethingModel input)
        {
            throw new NotImplementedException();
        }
    }
}
