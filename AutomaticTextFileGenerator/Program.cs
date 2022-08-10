using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticTextFileGenerator
{
	public class Program
	{
		static void Main(string[] args)
		{
            DateTime curDate = DateTime.Now;
            string output = curDate.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            string fileName = @"F:\Temp\"+output+".txt";

            Int32 number = 1;
            string curdte = curDate.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            string curTime = curDate.ToString("HHmm", CultureInfo.InvariantCulture);
            string cardNumber = "123654789";
            string printToFile = curdte + " " + curTime + " " + cardNumber + " " + (number + 1);


			try
			{
                if (!File.Exists(fileName))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(fileName))
                    {
                        sw.WriteLine(printToFile);
                    }
                }
                else
                {
                    // This text is always added, making the file longer over time
                    // if it is not deleted.
                    using (StreamWriter sw = File.AppendText(fileName))
                    {
                        sw.WriteLine(printToFile);
                    }
                }
            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }
	}
}
