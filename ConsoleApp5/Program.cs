using Ganss.Excel;
using System.IO;
namespace CustommerService { 
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Please, give the path to the file.");

            
           // string path = Console.ReadLine();

            String path = @"C:\Users\irrae\Downloads\CustommerData.csv";

            var custommers = new List<Custommer>();

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    var firstLine = reader.ReadLine();
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                       
                        string[] data = line.Split("|");

                        string price = data[8];
                        string subPrice = price.Substring(1);
                        subPrice = subPrice.Replace(".", ",");
                        double endPrice = Convert.ToDouble(subPrice);

                      
                        Custommer custommer = new Custommer(int.Parse(data[0]), data[1], data[2], data[3], data[4], data[5], data[6], data[7], endPrice, DateTime.Parse(data[9]));
                        custommers.Add(custommer);

                        line = reader.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            ExcelMapper mapper = new ExcelMapper();
            var newFile = @"C:\Users\irrae\excel.xlsx";
            mapper.HeaderRow = true;
            
            mapper.Save(newFile, custommers, "SheetName", true);
        }
    }
}