using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StockManagement
{
    internal class StockManager
    {
        double totalValue;
        public void StockDataReport(string file)
        {
            //checking if json file exists
            if (File.Exists(file))
            {
                //Reading all data from json file & storing it in a variable
                var json = File.ReadAllText(file);
                //Converting & mapping json objects into list of Stock objects
                var items = JsonConvert.DeserializeObject<List<StockPortfolio>>(json);
                Console.WriteLine("Stock Management Data Report :");
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Company\t\tNoOfShares\tShare_Price\tAmount");
                Console.WriteLine("");
                //traversing each item from list of  items & printing the data
                foreach (var item in items)
                {
                    // calculating total value of all company stocks
                    totalValue  = totalValue + (item.NumberOfShare* item.SharePrice);
                    Console.WriteLine("{0}" + "\t\t" + "{1}" + "\t\t" + "{2}" + "\t\t" + "{3}", item.companyName, item.NumberOfShare, item.SharePrice, item.NumberOfShare * item.SharePrice);
                }
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("The Total Amount is : \t\t\t\t"+totalValue);
            }
            else
            {
                Console.WriteLine("data file does not exist in the path");
            }


        }
    }
}
