using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
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
            emp.JobRole = "c0der";

            Console.WriteLine($"ID : {emp.ID} | Name : {emp.Name} | SSnumber : {emp.SSNumber} | Entry Date: {emp.EntryDate}");

            string filePath = @"C:\Users\Moe\Desktop\";
            string fileName = "oksecondpart.xml";

            //TextWriter writer = new StreamWriter(filePath + fileName);

            //XmlSerializer ser = new XmlSerializer(typeof(Employee));
            //ser.Serialize(writer, emp);
            //writer.Close();

            XmlSerializer des = new XmlSerializer(typeof(Employee));
            using (XmlReader reader = XmlReader.Create(filePath + fileName))
            {
                emp = (Employee)des.Deserialize(reader);
                Console.WriteLine($"EMP ID: {emp.ID}\nname:{emp.Name}\nSSN:{emp.SSNumber}\nDate:{emp.EntryDate}");
            }

            Console.ReadLine();
        }
    }
}
