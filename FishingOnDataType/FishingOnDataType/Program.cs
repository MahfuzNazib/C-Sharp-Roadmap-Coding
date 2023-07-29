using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FishingOnDataType
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fishing On C# DataType");

            CatchingString catchingString = new CatchingString();
            catchingString.PrintString();

            Console.WriteLine("Playing with C# DateTime");
            PickingDateTime pickingDateTime = new PickingDateTime();
            pickingDateTime.Print();

            Console.WriteLine("Play With String Builder");
            PlayWithStringBuilder playWithStringBuilder = new PlayWithStringBuilder();
            playWithStringBuilder.Print();
            StringBuilder sb = new StringBuilder("Nazib");
            playWithStringBuilder.MemoryAllocationInformation(sb);
            playWithStringBuilder.MemoryAddress();


            AnonymousType anonymousType = new AnonymousType();
            anonymousType.Print();


            DynamicType dynamicType = new DynamicType();
            dynamicType.PrintDynamicType();
        }
    }
}