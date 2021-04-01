using System;
using System.IO;

namespace Processing_a_CSV_File
{
    class Program
    {
        static void Main(string[] args)
        {

            var lines = File.ReadAllLines("sales_data_sample.csv");

            double sum2003 = 0; 
            double sum2004 = 0;
            double sum2005 = 0;
                               
                               

            for (int i = 1; i < lines.Length; i++)
            {
                //     0              1            2           3 
                //ORDERNUMBER,QUANTITYORDERED,PRICEEACH,ORDERLINENUMBER,SALES,ORDERDATE,STATUS,QTR_ID,MONTH_ID,YEAR_ID,PRODUCTLINE,MSRP,PRODUCTCODE,CUSTOMERNAME,PHONE,ADDRESSLINE1,ADDRESSLINE2,CITY,STATE,POSTALCODE,COUNTRY,TERRITORY,CONTACTLASTNAME,CONTACTFIRSTNAME,DEALSIZE
                string currentLine = lines[i];
                
                string[] pieces = currentLine.Split(",");

                string status = pieces[6];
                double sales = Convert.ToDouble(pieces[4]);
                int year = Convert.ToInt32(pieces[9]);
                int month = Convert.ToInt32(pieces[8]);
                double[] sumMonths = new double[13];
                

                if (status == "Shipped")
                {
                    sumMonths[month] += sales;
                    switch (year)
                    {
                        case 2003:
                            sum2003 = sum2003 + sales;
                            break;

                        case 2004:
                            sum2004 = sum2004 + sales;
                            break;

                        case 2005:
                            sum2005 = sum2005 + sales;
                            break;



                    }
                }
                Console.WriteLine($"The sum for 2003 is {sum2003.ToString("C2")}");
                Console.WriteLine($"The sum for 2004 is {sum2004.ToString("C2")}");
                Console.WriteLine($"The sum for 2005 is {sum2005.ToString("C2")}");

                for (int i = 1; i < sumMonths.Length; i++)
                {

                }




            }

        }
    }
}
