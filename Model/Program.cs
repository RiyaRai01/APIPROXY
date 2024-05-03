using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Apigeemig;
using Newtonsoft.Json.Serialization;

namespace Proxy.Model
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\RRai\Downloads\apigeemig_rev2_2024_03_12\apiproxy";
            string xmlFilePath = Path.Combine(rootDirectory, "apigeemig.xml");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ApiProxy));
            using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
            {
                ApiProxy apiProxy = (ApiProxy)xmlSerializer.Deserialize(fileStream)!;
                System.Console.WriteLine( apiProxy.ToString());
            }

        }

    }

}
