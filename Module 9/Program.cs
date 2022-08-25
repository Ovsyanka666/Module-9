namespace TryCatchPractices
{
    class Program
    {
        static void Main()
        {

            try
            {
                Console.WriteLine("Block try is working");
                throw new RankException();
                //Создайте консольное решение, в котором реализуйте конструкцию Try / Catch / Finally для обработки исключения ArgumentOutOfRangeException.
                //В случае исключения отобразите в консоль сообщение об ошибке.
            }

            catch (Exception ex) when (ex is RankException)
            {
                Console.WriteLine("Argument is out of range");
                Console.WriteLine(ex.GetType());
                
            }

          



            finally
            {
                Console.WriteLine("Finally works");
            }

            

            Console.ReadLine();

        }
    }
}