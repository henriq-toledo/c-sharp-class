using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ClassNumber07_Collections.Classes;

namespace ClassNumber07_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;

            do
            {
                Console.WriteLine("Type the option and press enter");

				Console.WriteLine(" 0 - List");
                Console.WriteLine(" 1 - Dictionary");
                Console.WriteLine(" 2 - ArrayList");
                Console.WriteLine(" 3 - HashSet");
                Console.WriteLine(" 4 - HashTable");
                Console.WriteLine(" 5 - Stack");
                Console.WriteLine(" 6 - Queue");
                Console.WriteLine(" 7 - SortedList");
                Console.WriteLine(" 8 - Linq: Join with class");
                Console.WriteLine(" 9 - Linq: let");
                Console.WriteLine("10 - Linq");
                Console.WriteLine("11 - Linq: Join");
                Console.WriteLine("12 - Linq: FirstOrDefault");
                Console.WriteLine("13 - Linq: SingleOrDefault");
                Console.WriteLine("14 - Linq: Intersect");
                Console.WriteLine("15 - Lambda");
                Console.WriteLine("16 - Linq: Except");
                Console.WriteLine("17 - Linq: Anonymous");
                Console.WriteLine("18 - Lambda: OrderBy");
                Console.WriteLine("19 - Linq: OrderBy");
                Console.WriteLine("20 - Lambda: Join");
                Console.WriteLine("99 - Exit");

                input = Console.ReadLine();

                Console.Clear();

                switch (input)
                {
					case "0":

                        ShowExampleTitle(" 0 - List");

                        ListExample();

                        break;
					
                    case "1":

                        ShowExampleTitle(" 1 - Dictionary");

                        DictionaryExample();

                        break;

                    case "2":

                        ShowExampleTitle("2 - ArrayList");

                        ArrayListExample();

                        break;

                    case "3":

                        ShowExampleTitle(" 3 - HashSet");

                        HashSetExample();

                        break;

                    case "4":

                        ShowExampleTitle("4 - HashTable");

                        HashTableExample();

                        break;

                    case "5":

                        ShowExampleTitle(" 5 - Stack");

                        StackExample();

                        break;

                    case "6":

                        ShowExampleTitle(" 6 - Queue");

                        QueueExample();

                        break;

                    case "7":

                        ShowExampleTitle(" 7 - SortedList");

                        SortedListExample();

                        break;

                    case "8":

                        ShowExampleTitle(" 8 - Linq: Join with class");

                        LinqJoinExample();

                        break;

                    case "9":

                        ShowExampleTitle(" 9 - Linq: let");

                        LinqLetExample();

                        break;

                    case "10":

                        ShowExampleTitle("10 - Linq");

                        LinqExample();

                        break;

                    case "11":

                        ShowExampleTitle("11 - Linq: Join");

                        LinqJoinDemo();

                        break;

                    case "12":

                        ShowExampleTitle("12 - Linq: FirstOrDefault");

                        LinqFirstOrDefaultDemo();

                        break;

                    case "13":

                        ShowExampleTitle("13 - Linq: SingleOrDefault");

                        LinqSingleOrDefaultDemo();

                        break;

                    case "14":

                        ShowExampleTitle("14 - Linq: Intersect");

                        LinqIntersectExample();

                        break;

                    case "15":

                        ShowExampleTitle("15 - Lambda");

                        LambdaExample();

                        break;

                    case "16":

                        ShowExampleTitle("16 - Linq: Except");

                        LinqExceptExample();

                        break;

                    case "17":

                        ShowExampleTitle("17 - Linq: Anonymous");

                        AnonymousExample();

                        break;

                    case "18":

                        ShowExampleTitle("18 - Lambda: OrderBy");

                        LambdaOrderByExample();

                        break;

                    case "19":

                        ShowExampleTitle("19 - Linq: OrderBy");

                        LinqOrderByExample();

                        break;

                    case "20":

                        ShowExampleTitle("20 - Lambda: Join");

                        JoinLambdaExample();

                        break;

                    case "99":
                        break;

                    default:

                        Console.WriteLine("Invalid option.");

                        Console.WriteLine();

                        continue;
                }

                if (input == "99" == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("End of the example, press a key to return to the main menu.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            while (input == "99" == false);
        }

        static void ShowExampleTitle(string title)
        {
            Console.WriteLine(title);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
        }
		
		static void ListExample()
		{
			var names = new List<string>();
            names.Add("João"); // Position - 0
            names.Add("Ginni"); // Position - 1
            names.Insert(index: 1, item: "Lucas");
            
            var newNames = new string[] {"Jose", "Ana"};
            names.AddRange(newNames);
            names.InsertRange(index: 3, collection: new string[] {"Bob", "June"});

            Console.WriteLine($"Count {names.Count}");

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine($"After remove");

            names.Remove("Ginni");

            Console.WriteLine($"Count {names.Count}");

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine($"After remove at");

            names.RemoveAt(index: 1);

            Console.WriteLine($"Count {names.Count}");

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine($"After remove range");

            names.RemoveRange(index: 2, 2);

            Console.WriteLine($"Count {names.Count}");

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine($"After remove all");

            names.RemoveAll(name => 
            {
                if (name == "Ana")
                {
                    return true;
                }

                if(name.Length == 4)
                {
                    return true;
                }

                return false;
            });

            Console.WriteLine($"Count {names.Count}");

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
		}

        static void DictionaryExample()
        {
            // In the Dictionary the key value is unique, but the value can be equals an another item
            // In case of duplicated key, an exception will be thrown
            var dictionary = new Dictionary<string, int>();
            dictionary.Add("Monday", 1);
            dictionary.Add("Sunday", 2);

            foreach (var item in dictionary)
            {
                Console.WriteLine($"Key: {item.Key}");
                Console.WriteLine($"Value: {item.Value}");
                Console.WriteLine("------");
            }

            dictionary.Remove("Sunday");

            foreach (var item in dictionary)
            {
                Console.WriteLine($"Key: {item.Key}");
                Console.WriteLine($"Value: {item.Value}");
                Console.WriteLine("------");
            }
        }

        /// <summary>         
        /// If the duplicate order or element is more important than your app's performance,
        /// consider using the List <T> class along with the Sort method.
        /// </summary>
        static void HashSetExample()
        {
            var hashSet = new HashSet<int>();
            hashSet.Add(1);
            hashSet.Add(3);
            hashSet.Add(2);
            hashSet.Add(2); // inserting duplicated value
            hashSet.Add(5);

            foreach (var item in hashSet)
            {
                Console.WriteLine(item); // the item 2 will be shown once
            }
        }

        /// <summary>
        /// A casting is necessary in the key and value
        /// The key must be unique from the same type
        /// In the case below, was added 1 int and "1" string that are from different types,
        /// if both were string or int, an exception would be thrown
        /// </summary>
        static void HashTableExample()
        {
            var hashTable = new Hashtable();
            hashTable.Add("1", "um");
            hashTable.Add(1, "um");

            foreach (DictionaryEntry item in hashTable)
            {
                if (item.Value.GetType() == typeof(int))
                {
                    Console.WriteLine($"Value like an int: {(int)item.Value}");
                }
                else if (item.Value.GetType() == typeof(string))
                {
                    Console.WriteLine($"Value like a string: {(string)item.Value}");
                }
            }
        }

        /// <summary>
        /// Need be a casting of the value
        /// </summary>
        static void ArrayListExample()
        {
            var arrayList = new ArrayList();
            arrayList.Add(2);
            arrayList.Add(1);
            arrayList.Add(1);
            arrayList.Add(3);

            if (arrayList.Contains(1))
            {
                Console.WriteLine("The value 1 already exist in the arrayList");
            }

            foreach (var item in arrayList.Cast<int>())
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Stack, last in first out (LIFO)
        /// Mind like a stack dish, it gets easier =)
        /// </summary>
        static void StackExample()
        {
            var stack = new Stack<string>();
            stack.Push("Um");
            stack.Push("Dois");
            stack.Push("Três");
            stack.Push("Quatro");

            var last = stack.Peek();//without remove the item
            last = stack.Pop();//return and remove the item

            // Pop to return the last item

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Queue, first in frist out (FIFO)
        /// </summary>
        static void QueueExample()
        {
            var queue = new Queue<string>();

            queue.Enqueue("Um");
            queue.Enqueue("Dois");
            queue.Enqueue("Três");

            var first = queue.Peek(); // return and no remove
            first = queue.Dequeue(); // return and remove
            // .Dequeue to return the first item from the queue

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Operations on a SortedList object tend to be slower than operations on a Hashtable object due to sorting. 
        /// However, SortedList offers more flexibility by allowing access to values through the associated keys or indexes.
        /// </summary>
        static void SortedListExample()
        {
            var sortedList = new SortedList<string, int>();

            sortedList.Add("Five", 5);
            sortedList.Add("One", 1);
            sortedList.Add("Three", 3);

            sortedList.Remove("Three");

            sortedList.Add("Seven", 7);
            sortedList.Add("Se", 7);

            foreach (var item in sortedList)
            {
                Console.WriteLine(item.Key);
            }
        }

        /// <summary>
        /// Join in Linq using classes
        /// </summary>
        static void LinqJoinExample()
        {
            var people = from person in Person.GetAll()
                         join pet in Pet.GetAll()
                         on new { Id = person.PetId, person.Name } equals new { Id = pet.Id, pet.Name }
                         select person;

            foreach (var item in people)
            {
                Console.WriteLine(item.Name);
            }
        }

        /// <summary>
        /// Using the lets clausule from Linq
        /// </summary>
        static void LinqLetExample()
        {
            string[] films =
            {
                "Star Wars",
                "Avengers End Game",
                "Alladin",
            };

            var result =
                from film in films
                let words = film.Split(' ')
                from word in words
                let w = word.ToLower()
                where w[0] == 'a'
                    || w[0] == 'e'
                    || w[0] == 'i'
                    || w[0] == 'o'
                    || w[0] == 'u'
                select word;

            // Execute the query.
            foreach (var item in result)
            {
                Console.WriteLine("\"{0}\" start with vowel.", item);
            }
        }

        /// <summary>
        /// Linq
        /// </summary>
        static void LinqExample()
        {
            var values = new string[]
            {
                "Igor",
                "Maria",
                "Gabriel",
                "Elen",
                "mario"
            };

            /*from alias in collection
              select alias*/

            var result = from value in values
                         where value.ToUpper().StartsWith("M")
                         select value;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Lambda
        /// </summary>
        static void LambdaExample()
        {
            var values = new string[]
            {
                "Igor",
                "Maria",
                "Gabriel",
                "Elen",
                "mario"
            };

            var result = values.Where(value => value.ToUpper().StartsWith("M"));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Join in Linq
        /// </summary>
        static void LinqJoinDemo()
        {
            var names1 = new string[]
            {
                "Maria",
                "Gabriel",
                "Elen",
                "mario"
            };

            var names2 = new string[]
            {
                "Igor",
                "Maria",
                "Gabriel",
                "Elen"
            };

            var result = from name1 in names1
                         join name2 in names2
                         on name1 equals name2
                         select name1;

            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }

        /// <summary>
        /// FirstOrDefault in Linq
        /// </summary>
        static void LinqFirstOrDefaultDemo()
        {
            var names = new List<string>
            {
                "Igor",
                "Maria",
                "Gabriel",
                "Elen",
                "Elen"
            };

            Console.WriteLine("The name Igor2 does not exist in the list of names, so the default value will be shown");

            Console.WriteLine();

            Console.WriteLine(names.Where(name => name == "Igor2").DefaultIfEmpty("Without name").FirstOrDefault());

            Console.WriteLine();

            Console.WriteLine("In this case Maria exists, so the Maria's name will be shown.");

            Console.WriteLine(names.Where(name => name == "Maria").DefaultIfEmpty("Without name").FirstOrDefault());
        }

        /// <summary>
        /// SingleOrDefault in Linq
        /// </summary>
        static void LinqSingleOrDefaultDemo()
        {
            var names = new List<string>
            {
                "Igor",
                "Maria",
                "Gabriel",
                "Elen"
            };

            // The Single or SingleOrDefault must return just one record/item from the list,
            // otherwise will be thrown an exception
            Console.WriteLine(names.Where(name => name == "Igor2").DefaultIfEmpty("Sem nome").SingleOrDefault());
        }

        /// <summary>
        /// Intersect
        /// </summary>
        static void LinqIntersectExample()
        {
            var names1 = new string[]
            {
                "Maria",
                "Gabriel",
                "Elen",
                "mario"
            };

            var names2 = new string[]
            {
                "Igor",
                "Maria",
                "Gabriel",
                "Elen"
            };

            var result = names1.Intersect(names2);

            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }

        /// <summary>
        /// Join in Linq
        /// </summary>
        static void LinqExceptExample()
        {
            var names1 = new string[]
            {
                "Maria",
                "Gabriel",
                "Elen",
                "mario"
            };

            var names2 = new string[]
            {
                "Igor",
                "Maria",
                "Gabriel",
                "Elen"
            };

            var result = names1.Except(names2);

            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }

        /// <summary>
        /// Anonymous in Linq
        /// </summary>
        static void AnonymousExample()
        {
            var names = new string[]
            {
                "Maria",
                "Gabriel",
                "Elen",
                "mario"
            };

            Console.WriteLine("List of names:");

            Console.WriteLine();

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            var result = from name in names
                         select new { Minusculo = name.ToLower(), Maiusculo = name.ToUpper() };

            Console.WriteLine();

            Console.WriteLine("Showing names with anonymous:");

            Console.WriteLine();

            foreach (var item in result)
            {
                Console.WriteLine($"Tiny name: {item.Minusculo} - Capital name {item.Maiusculo}");
            }
        }

        /// <summary>
        /// OrderBy using Lambda
        /// </summary>
        static void LambdaOrderByExample()
        {
            var names = new string[]
            {
                "Maria",
                "Gabriel",
                "Elen",
                "Mario"
            };

            Console.WriteLine("List of names:");

            Console.WriteLine();

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Ascending order");

            Console.WriteLine();

            foreach (var item in names.OrderBy(name => name))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Descending order");

            Console.WriteLine();

            foreach (var item in names.OrderByDescending(name => name))
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// OrderBy em Linq
        /// </summary>
        static void LinqOrderByExample()
        {
            var names = new string[]
            {
                "Maria",
                "Gabriel",
                "Elen",
                "Mario"
            };

            Console.WriteLine("List of names:");

            Console.WriteLine();

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Ascending order");

            Console.WriteLine();

            var query = from n in names
                        orderby n
                        select n;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Descending order");

            Console.WriteLine();

            query = from n in names
                    orderby n descending
                    select n;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Join in Lambda
        /// </summary>
        static void JoinLambdaExample()
        {
            var people = Person.GetAll();
            var pets = Pet.GetAll();

            Console.WriteLine("Listing the people");

            foreach (var personItem in people)
            {
                Console.WriteLine($"Name: {personItem.Name} - PetId: {personItem.PetId}");
            }

            Console.WriteLine();

            Console.WriteLine("Listing the pets");

            foreach (var petItem in pets)
            {
                Console.WriteLine($"Id: {petItem.Id} - Name: {petItem.Name}");
            }

            var query = people.Join(pets, person => person.PetId, pet => pet.Id, (person, pet) => new { PersonName = person.Name, PetName = pet.Name });

            Console.WriteLine();

            Console.WriteLine("The owner's name and the pet's name");

            // Irá retornar os nomes das pessoas que tem um pet
            foreach (var item in query)
            {
                Console.WriteLine($"Owner's name {item.PersonName} - Pet's name: {item.PetName}");
            }
        }
    }
}
