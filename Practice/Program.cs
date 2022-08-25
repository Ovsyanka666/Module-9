namespace Practice
{
    class Programe
    {                       
        static void Main()
        {                  
            Exception[] exceptions = new Exception[] { new Error(), new DivideByZeroException(), new ArgumentOutOfRangeException(), new InvalidCastException(), new ArgumentException() };
            Error error = new Error("Incorrect data.");


            foreach (Exception exeption in exceptions)
            {
                try
                {
                    throw exeption;
                }

                catch (Exception ex) when (ex is Error)
                {
                    Console.WriteLine(error.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }                          
            }
        }
    }

    public class Error : Exception
    {
        public Error()
        {}
        public Error(string message) : base(message)
        {}
    }
}