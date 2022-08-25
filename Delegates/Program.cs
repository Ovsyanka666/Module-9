namespace DelegatePractices
{
    class Program
    {
        delegate void ShowMessageDelegate(string _message);
        delegate int RandomNumberDelegate();
        static void Main(string[] args)
        {
            ShowMessageDelegate showMessageDelegate = (string _message) => Console.WriteLine(_message);
            
            showMessageDelegate.Invoke("Hello World!");
            Console.Read();

            RandomNumberDelegate randomNumberDelegate = () => new Random().Next(0, 100);
            
            int result = randomNumberDelegate.Invoke();
            Console.WriteLine(result);
            Console.Read();
        }
    }
}

//namespace DelegatePractices
//{
//    class Program
//    {
//        delegate int RandomNumberDelegate();
//        static void Main(string[] args)
//        {
//            RandomNumberDelegate randomNumberDelegate = delegate ()
//            {
//                return new Random().Next(0, 100);
//            };
//            int result = randomNumberDelegate.Invoke();
//            Console.WriteLine(result);
            
//        }

        
//    }
//}