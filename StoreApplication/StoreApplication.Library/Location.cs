using System;
namespace StoreApplication.Library
{
    public class Location
    {
       

        string storePicked = "";
        public string pickingStore(int num)
        {
            switch(num)
            {
                case 1:
                    storePicked = "Walmart";
                    break;
                case 2:
                    storePicked = "Target";
                    break;
                default:
                    Console.WriteLine("Sorry we do not have any store at that area");
                    break;

            }
            return storePicked;
        }
    }

}