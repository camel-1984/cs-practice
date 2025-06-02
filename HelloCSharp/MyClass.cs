namespace HelloCSharp
{
    using System; 

    public class MyClass
    {
        public static void Func()
        {
            Basics.comp = 2;
            Console.WriteLine(Basics.comp);
        }

    }

// struct - на стеке
// class - на куче

    internal class Book
    {
        private string title;
        private string author;

        public int pageCount { private get; set; } // под капотом getter и setter

        public Book(string tit, string aut, int pg)
        {
            title = tit;
            author = aut;
            pageCount = pg;
        }

        // деструктора нет - работает GC

        public void PrintInfo()
        {
            Console.WriteLine("Название: " + title + ", "
                              + "Автор: " + author + 
                              ", " + "Страниц: " + pageCount);

        }

    }
}