using OOPCoreApi.Models;

namespace OOPCoreApi.Services
{
    public interface IHelloWorldService
    {
        SomethingModel DoSomething(string input);

        SomethingModel DoSomethingElse(SomethingModel input);
    }
}
