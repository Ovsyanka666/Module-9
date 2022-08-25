namespace Practice2
{
    class Program
    {
        static void Main()
        {       
            NumberReader Reader = new NumberReader();
            Reader.NumberEnteredEvent += SortNames;

            while (true)
            {
                try
                {
                    Reader.Read();
                }
                catch (Error ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Значение некорректно");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Значение некорректно");
                } 
            }

            static void SortNames(int i)
            {
                string[] lastNames = new string[] { "Иванов", "Петров", "Леченков", "Яковлев", "Антонов" };
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Сортировка списка по алфавиту:");
                        Array.Sort(lastNames);
                        ShowArray(lastNames);
                        break;
                    case 2:
                        Console.WriteLine("Сортировка списка в обратном порядке:");
                        Array.Sort(lastNames);
                        string[] array = AntiSort(lastNames);
                        ShowArray(array);
                        break;
                }
            }
        }

        static string[] AntiSort(string[] array)
        {
            string[] sorted = new string[array.Length];
            int length = array.Length - 1;
            foreach (string el in array)
            {                
                sorted[length] = el;
                
                if (length > 0)
                    length--;
            }
            return sorted;
        }

        static void ShowArray(string[] array)
        {
            foreach (string el in array)
                Console.WriteLine(el);
        }
    }

    class NumberReader
    {
        public delegate void NumberEnteredDelegate(int number);
        public event NumberEnteredDelegate NumberEnteredEvent;

        public void Read()
        {
            Console.WriteLine();
            Console.WriteLine("Введите число 1 или 2");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number != 1 && number != 2)
                throw new Error("Введено некорректное число.");

            NumberEntered(number);
        }

        protected virtual void NumberEntered(int number)
        {
            NumberEnteredEvent?.Invoke(number);
        }
    }

    public class Error : Exception
    {
        public Error()
        { }
        public Error(string message) : base(message)
        { }
    }
}