using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace XMLSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.ID = 12;
            emp.Name = "Moe Alshoubaki";
            emp.SSNumber = 123456789;
            emp.EntryDate = DateTime.Now;

            Console.WriteLine($"ID : {emp.ID} | Name : {emp.Name} | SSnumber : {emp.SSNumber} | Entry Date: {emp.EntryDate}");

            string filePath = @"C:\Users\Moe\Desktop\";
            string fileName = "oksecondpart.xml";

            TextWriter writer = new StreamWriter(filePath + fileName);

            XmlSerializer ser = new XmlSerializer(typeof(Employee));
            ser.Serialize(writer, emp);
            writer.Close();


            Console.ReadLine();
        }
    }
}
