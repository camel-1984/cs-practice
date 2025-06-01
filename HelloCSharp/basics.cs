using System; // iostream + std

// Solution (root) - projects (Cmake) - cs (cpp)

    public class HelloCSharp // все в классах 
    {
        public static void Main() // PascalCase
        {
            Console.WriteLine("your name?"); // Console - все методы static 
            string nameBen = Console.ReadLine(); // cin  
            Console.WriteLine("ok " + nameBen); // cout + '\n'
            Console.Write("key? "); // cout

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine("\nВы нажали: " + keyInfo.Key);
            Console.WriteLine("Символ: " + keyInfo.KeyChar);
            Console.WriteLine("Модификаторы: " + keyInfo.Modifiers);
            // структура, содержащая сведения о клавише

            myClass.Func(); // из другого файла проекта

            var book = new Book("Graph Monte-kristo", // var == auto 
                "Duma", 1200 ); // создание объекта
            book.PrintInfo();
            // аналогично C++: Book* b = new Book(...),
            // ссылка на объект в памяти на куче
            // но в C# всё управляется сборщиком мусора (GC)
            // var i = book.pageCount; // вызов getter
            book.pageCount = 1984; // вызов setter
        }

        // класс по умолчанию - internal
        // поля по умолчанию - private

        // camelCase
        public int age; // доступен всем
        private int a; // только внутри этого класса
        protected int b; // доступен в классах-наследниках
        internal static int comp = 0; // доступен только в этом проекте

    }


