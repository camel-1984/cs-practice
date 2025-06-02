namespace HelloCSharp
{

    using System.Collections.Generic;
    
    // List<T> — динамический массив
    // SortedList<T>
    
    // Dictionary<TKey, TValue> — ассоциативный массив (hashmap)
    // SortedDictionary<TKey, TValue>
    
    // Queue<T> — очередь
    // Stack<T> — стек
    
    // HashSet<T> — множество
    // SortedSet<int> 
    
    public class MyArray
    {
        int[] numbers = new int[3]; // [0, 0, 0] статичный массив 
        int[] primes = { 2, 3, 5, 7, 11 };
        
        static void ArrayFunc() // создание массив в функциях иначе будет полями так как все в классах
        {
            List<string> names = new List<string>(); // динамический массив 
            names.Add("Аня");
            names.Add("Борис");
            
            // List<T> == vector<T>
            
            //     .Add(item)	Добавить элемент
            //     .Remove(item)	Удалить элемент
            //     .Contains(x)	Проверка наличия
            //     .IndexOf(x)	Индекс элемента
            //     .Sort()	Сортировка по умолчанию
            //     .Clear()	Очистить список
            
            string name = "Привет, мир!";
            Console.WriteLine(name.Length);            // длина
            Console.WriteLine(name.ToUpper());         // caps
            Console.WriteLine(name.ToLower());         // lower
            Console.WriteLine(name.Contains("мир"));   // true
            Console.WriteLine(name.Replace("мир", "C#")); // заменит
            
            string sentence = "яблоко,груша,слива";
            string[] fruits = sentence.Split(',');
            
            // int[] — это ссылочный тип (reference type), даже если сам int — это значимый тип (value type).
            // int[] arr = new int[5] вызывает выделение памяти в куче, а переменная arr — это ссылка на этот массив (находится в стеке).
            // В C# массивы — всегда живут в куче.
            
        }

        public static void ArrayFunc2()
        {
            char[] staticList2 = { 'a', 'b', 'c' };
            foreach (var variable in staticList2)
            {
                Console.Write(variable + " ");
                
            }
        }
        
        public static void ArrayFunc3()
        {
            int[] staticList3 = new int[5];

            for (int i = 0; i < 5; ++i)
            {
                staticList3[i] = i+1;
            }
            
            foreach (var variable in staticList3)
            {
                Console.Write(variable);
                
                
            }
            
            Console.WriteLine();

            List<string> listik = new List<string>() { "banana", "apple", "grapes" };
            listik.Remove("banana");
            var my = listik.Where(n => n.Length >= 6);
            foreach (var varik in my)
            {
                Console.WriteLine(varik);
            }
        }
        
    }
}