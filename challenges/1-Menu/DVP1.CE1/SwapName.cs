namespace DVP1.CE1
{
    public class SwapName
    {
        namespace SwapName
{ {
    public static void GetSwapName()

        {

            Console.WriteLine("Welcome to SwapName:");
            Console.WriteLine("To begin enter your first name...");
            string inputText = Console.ReadLine();

            Console.WriteLine("Thank you " + inputText + " ,now enter your last name");
            string inputText2 = Console.ReadLine();
            Console.WriteLine("Excellent! Your name is " + inputText + " "+ inputText2 +" reversed would be "+ inputText2 +" " + inputText);
            Console.ReadLine();
        }
    }
}
}
