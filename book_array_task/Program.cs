using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_array_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList books = new ArrayList();
            books.Add(new { ad = "fizika", muellif = "newton", janr = "elm" });
            bool exit = true;
           
            while (exit)
            {
                Console.WriteLine("1-book add");
                Console.WriteLine("2-book show");
                Console.WriteLine("3-book delete");
                Console.WriteLine("4-book list search");
                Console.WriteLine("5-book update");
                Console.WriteLine("6-exit");
                Console.Write("\nSelect option:");
                char emeliyyat = Convert.ToChar(Console.ReadLine());
                switch (emeliyyat)
                {
                    case '1':
                        Console.WriteLine("How many books do you add");
                        int count =Convert.ToInt32(Console.ReadLine());
                        for(int i = 0; i<count;i++)
                        {
                            Console.Write("Add a book name: ");
                            string bookName = Console.ReadLine();
                            Console.Write("Add a book author: ");
                            string bookAutor = Console.ReadLine();
                            Console.Write("Add a book janr: ");
                            string bookJanr = Console.ReadLine();
                            object book = new { ad = bookName, muellif = bookAutor, janr = bookJanr };
                            books.Add(book);
                            Console.WriteLine((i+1)+".books added.");
                        }
                       
                        break;

                    case '2':
                        foreach (dynamic item in books)
                        {
                            Console.WriteLine("name: " + item.ad + "\nauthor: " + item.muellif + "\njanr: " + item.janr + "\n");

                        }
                        break;

                    case '3':
                        bool found = false;
                        string name = Console.ReadLine();
                        foreach (dynamic item in books)
                        {
                            if (name == item.ad)
                            {
                                books.Remove(item);
                                Console.WriteLine("Book removed");
                                found = true;
                                break;
                            }
                          
                        }
                        if(!found)
                        {
                            Console.WriteLine("\n Not found \n");
                        }

                        break;

                    case '4':
                        bool tapıldı = false;
                        Console.WriteLine("\n Book search ");
                        string search_name = Console.ReadLine();
                        foreach(dynamic item in books)
                        {
                            if (search_name == item.ad)
                            {
                                tapıldı = true;
                                Console.WriteLine("name: " + item.ad + "\nauthor: " + item.muellif + "\njanr: " + item.janr + "\n");
                                break;
                            }
                        }
                        if (!tapıldı)
                        {
                            Console.WriteLine("\n Not found \n");
                        }
                        break;

                    //case '5':
                    //    bool found2 = false;
                    //    Console.WriteLine("Which book do you update?");
                    //    string searchName = Console.ReadLine();
                    //    foreach (dynamic item in books)
                    //    {
                    //        if (searchName == item.ad)
                    //        {
                    //            Console.WriteLine("Please add new name");
                    //            string newName = Console.ReadLine();
                    //            item.ad = newName;
                    //            Console.WriteLine("new name" + item.ad);
                    //            found2 = true;
                    //            break;
                    //        }
                    //    }
                    //    if(!found2)
                    //    {
                    //        Console.WriteLine("\n Not found \n");
                    //    }
                    //    break;


                    case '6':
                        exit = false;
                        Console.WriteLine("Exited");
                        break;
                }

            }
        }

    }
}