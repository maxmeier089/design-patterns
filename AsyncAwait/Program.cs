using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {

        async static Task Main()
        {

            await new AsyncAwaitBasic().CreateAndAwaitSomeTasks();

            //await ReturnTypesAndExceptions.StartExample();

            //await new MultipleTasks().StartMultipleTasks();

        }

    }
}
