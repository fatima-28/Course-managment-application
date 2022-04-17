using System;
using System.Collections.Generic;

namespace courseManegmentApp
{
   public class Program
    {
        
        static void Main(string[] args)
        {
          
            Start();
            
        }
        static void Start()
        {
           

            Console.WriteLine("1.Yeni qrup yarat");
            Console.WriteLine("2.Qrup siyahisini goster");
            Console.WriteLine("3.Qrup uzerinde duzelish et");
            Console.WriteLine("4.Qrupdaki telebelerin siyasini goster");
            Console.WriteLine("5.Butun telebelerin siyahisini goster");
            Console.WriteLine("6.Telebe yarat");

            Console.Write("Bir sechim edin:");
            List<Student> stuList = new List<Student>();
            List<Group> groupsList = new List<Group>();
            List<Category> categories = new List<Category>();
            int num = int.Parse(Console.ReadLine());

            //1.Yeni qrup yarat
            if (num == 1)
            {

                Console.WriteLine("Kategoryalardan birini sechin:");
                Console.WriteLine("1.Programming");
                Console.WriteLine("2.Design");
                Console.WriteLine("3.System Adminstration");

                Category category = (Category)Convert.ToInt32(Console.ReadLine());
                if ((int)category != 1|| (int)category != 2|| (int)category != 3)
                {
                    Console.WriteLine("BELE BIR KATEGORIYA YOXDUR!!!");
                    Start();

                }
                else if ((int?)category==null)
                {
                    throw new Exception("Daxil etdiyiniz format sehvdir");
                    
                }
                Console.Write("Online kategoriyasini sechin");
                bool isOnline = bool.Parse(Console.ReadLine());
            }

            //2.Qrup siyahisini goster
            else if (num == 2)
            {
                if (groupsList.Count == 0)
                {
                    Console.WriteLine("say sifira beraberdir");
                }
                else
                {
                    foreach (var item in groupsList)
                    {
                        Console.WriteLine($"kategoriya:{item.Category}, Nov:{item.isOnline}, Nomre:{item.No}");
                    }
                }

            }
            //3.Qrup uzerinde duzelish et
            else if (num == 3)
            {
                Method();

                void Method()
                {
                    Console.Write("Enter group Number:");
                    string inputNo = Console.ReadLine();
                    foreach (var item in categories)
                    {

                        if (inputNo == item.ToString())
                        {
                            throw new Exception("Bele bir grup var!");
                            Method();
                        }
                        else
                        {

                            Console.WriteLine($"{inputNo} group created succsessfully!");
                        }
                    }
                }

            }

            //4.Qrupdaki telebelerin siyasini goster
            else if (num == 4)
            {
                int inputNo = int.Parse(Console.ReadLine());
                foreach (var item in groupsList)
                {
                    if (item.No != inputNo.ToString())
                    {
                        throw new Exception("Daxil etdiyiniz grup movcud deyil!");
                    }
                   
                        else if (stuList.Count == 0)
                        {
                            Console.WriteLine("Student list is empty");
                            
                        }
                    
                    else
                    {
                        foreach (var items in stuList)
                        {
                            Console.WriteLine($"FullName:{items.FullName},Tipi:{items.Type}");
                        }

                    }

                }
            }
            //5.Butun telebelerin siyahisini goster

            else if (num == 5)
            {

                if (stuList.Count == 0)
                {
                    Console.WriteLine("List is empty");
                }
                else
                {
                    foreach (var item in stuList)
                    {
                        Console.WriteLine($"FullName:{item.FullName},Tipi:{item.Type},Qrup nomresi:{item.GroupNo}");
                    }
                }
            }

            //6.Telebe yarat
            else if (num == 6)
            {
                Console.Write("Tam adinizi daxil edin:");
                string inputName = Console.ReadLine();
                Console.WriteLine("Kategoryalardan birini sechin:");
                Console.WriteLine("1.Programming");
                Console.WriteLine("2.Design");
                Console.WriteLine("3.System Adminstration");

                Category category = (Category)Convert.ToInt32(Console.ReadLine());
                Console.Write("Tipi sechin:");
                bool inputType = bool.Parse(Console.ReadLine());

            }

            else
            {
                Console.WriteLine("Bele bir sechim yoxdur! Bir daha sechim edin");
                Start();
            }
        }

    }
}
