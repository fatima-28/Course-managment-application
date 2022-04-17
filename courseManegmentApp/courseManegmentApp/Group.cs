using System;
using System.Collections.Generic;

namespace courseManegmentApp
{

    public enum Category { Programming = 1, Design, SystemAdmin }
    public class Group

    {

        public Category Category { get; set; }
        public string No { get; set; }
        public bool isOnline { get; set; }
        public int Limit { get; set; }

        public static int Bp = 200;
        public static int Dn = 200;
        public static int System = 200;

        public Group(Category category, bool isonline)
        {
            Category = category;
            isOnline = isonline;

            switch (Category)
            {
                case Category.Programming:
                    No = $"BP{Bp}";
                    Bp++;
                    break;
                case Category.Design:
                    No = $"DN{Dn}";
                    Dn++;
                    break;
                case Category.SystemAdmin:
                    No = $"System{System}";
                    System++;
                    break;
                default:
                    Console.WriteLine("This Category is not exist");
                    break;
            }
            if (isOnline)
            {
                Limit = 15;
            }
            else
            {
                Limit = 10;
            }

        }

    }
}
