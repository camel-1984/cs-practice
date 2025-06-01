namespace HelloCSharp
{

    using System; 

// Solution (root) - projects (Cmake) - cs (cpp)

    public class Basics // все в классах 
    {
        public static void Base() // PascalCase
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

            Klass.Func(); // из другого файла проекта

            var book = new Book("Graph Monte-kristo", // var == auto 
                "Duma", 1200); // создание объекта
            book.PrintInfo();
            // аналогично C++: Book* b = new Book(...),
            // ссылка на объект в памяти на куче
            // но в C# всё управляется сборщиком мусора (GC)
            // var i = book.pageCount; // вызов getter
            book.pageCount = 1984; // вызов setter

            char[] container = { 'a', 'b', 'c' };

            foreach (var x in container) // range-based for
            {
                Console.Write(x + " ");
            }


            // LINQ - SQL-подобные запросы к массивам...
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            var evens = numbers.Where(n => n % 2 == 0);
            // (parameters) => expression_or_block
            foreach (var n in evens)
                Console.WriteLine(n);

            // .Where()	Фильтрация
            // .Select() Проекция 
            // .OrderBy() Сортировка
            // ...

            // лямбды в C# всегда представляют собой делегаты
            // универсальная делегаты
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5)); // 
            // Func<T, R> - делегат возвращающий R 

            Action<string> sayHello = name => { Console.WriteLine("Привет, " + name); };
            sayHello("Мир");
            // Action<T> - делегат == void
            // Predicate<T> - делегат == bool


            MyDelegate d = x => x * 2;
            int result = Apply(d, 10);
            Console.WriteLine(result);

        }

        public delegate int MyDelegate(int x); // кастомный делегат

        public static int Apply(MyDelegate d, int value)
        {
            return d(value);
        }

        // camelCase
        public int age; // доступен всем
        private int a; // только внутри этого класса
        protected int b; // доступен в классах-наследниках

        internal static int comp = 0; // доступен только в этом проекте
        // класс по умолчанию - internal
        // поля по умолчанию - private

    }
}


