namespace HelloCSharp;

public class Basics2
{
    public static void References()
    {
        int a = 5;
        int b = a; // b — копия a, изменения не затронут друг друга

        List<int> list1 = new List<int>() { 1, 2 };
        List<int> list2 = list1; // list2 — это ссылка на list1
        list2.Add(3); // list1 тоже изменится!
        
        
        // Value types	int, bool, char, struct	-> stack // by value
        // Reference types	class, array, string, List<T> -> heap // by reference
        
        int c = 5;
        Foo(c);
        Console.WriteLine(c); // всё ещё 5
        
        int d = 5;
        Foo2(ref d);
        Console.WriteLine(d); // теперь 10
        
        int[] myArray = { 1, 2, 3 };
        ModifyArray(myArray);
        
    }

    public static void Casts()
    {
        int x = 42;
        string s = x.ToString(); // "42"
        
        int.Parse("123"); // прямой аналог stoi
        int.TryParse("123", out int y); // безопасный вариант
        
        string strok = "123";
        int k = Convert.ToInt32(strok); // работает как Parse
        
        double d = 3.14;
        int i = (int)d; // 3 — обрезает дробную часть, как static_cast<int>
        
        int a = 10;
        double b = a;        // неявное — безопасное расширение
        
        double z = 3.5;
        int g = (int)z;      // явное — возможно потеря данных
        
        object o = "test";
        string str = o as string;  // вернёт null, если не string
        if (o is string) {}   // проверка типа
    }
    static void Foo2(ref int x) {
        x = 10;
    }
    
    static void Foo(int x) {
        x = 10;
    }
    
    static void ModifyArray(int[] arr) // ссылочный тип 
    {
        arr[0] = 42;      // изменит оригинал
        arr = new int[3]; // не изменит оригинал
    }
    
    static void ReplaceArray(ref int[] arr)
    {
        arr = new int[] { 9, 9, 9 }; // заменит оригинал новым массивом 
    }
    
    // unsafe class UnsafeClass
    // {
    //     public void DoStuff()
    //     {
    //         int x = 1;
    //         int* p = &x;
    //         Console.WriteLine(*p);
    //     }
    // }
    
    // unsafe нужен, например, в низкоуровневом interop или game dev,
    // но в обычной практике — не используется.
    // Вместо указателей C# активно использует ссылки и ref/out.
    
    

    class Program
    {
        static void Out()
        {
            
            bool success = TryParseToInt("123", out int number);

            if (success)
                Console.WriteLine("Успешно: " + number);  // → Успешно: 123
            else
                Console.WriteLine("Ошибка!");
        }

        static bool TryParseToInt(string input, out int result)
        {
            if (int.TryParse(input, out result))  
            {
                return true;
            }

            // обязательно что-то присвоить result
            result = 0;
            return false;
        }
    }
    class Program2
    {
        static void Read()
        {
            Console.Write("Введите количество элементов: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                var u = Console.ReadLine();
                if (int.TryParse(u, out int o))
                {
                    numbers[i] = o;

                }
            }

            Console.WriteLine("Вы ввели:");
            foreach (int x in numbers)
                Console.Write(x + " ");
        }
        
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

    }
}




