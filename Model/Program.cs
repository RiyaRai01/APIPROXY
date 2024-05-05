using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Apigeemig;
using Newtonsoft.Json.Serialization;
using Proxy.Endpoint;

namespace Proxy.Model
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\Admin\Downloads\apigeemig_rev2_2024_03_12\apiproxy";
            string apigeemigxmlFilePath = Path.Combine(rootDirectory, "apigeemig.xml");
            string proxiesxmlFilePath = Path.Combine(rootDirectory, "proxies", "default.xml");
            
            ApiProxy apiProxy = DeserializeXml<ApiProxy>(apigeemigxmlFilePath);
            System.Console.WriteLine(ObjectToString<ApiProxy>(apiProxy));

            ProxyEndpoint proxyEndPoint = DeserializeXml<ProxyEndpoint>(proxiesxmlFilePath);
            System.Console.WriteLine(ObjectToString<ProxyEndpoint>(proxyEndPoint));

            // string apigeemigxmlFilePath = "path_to_xml_file.xml"; // Provide the path to your XML file here
            // Proxy.Endpoint.ProxyEndpoint apiProxy = DeserializeXml<Proxy.Endpoint.ProxyEndpoint>(apigeemigxmlFilePath);
            // Console.WriteLine(ObjectToString(apiProxy));


            // XmlSerializer xmlSerializer = new XmlSerializer(typeof(ApiProxy));
            // using (FileStream fileStream = new FileStream(apigeemigxmlFilePath, FileMode.Open))
            // {
            //     ApiProxy apiProxy = (ApiProxy)xmlSerializer.Deserialize(fileStream)!;
            //     System.Console.WriteLine( apiProxy.ToString());
            // }
        }
        public static T DeserializeXml<T>(string xmlFilePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
            {
                return (T)xmlSerializer.Deserialize(fileStream)!;
                
            }
        }

        public static string ObjectToString<T>(T obj)
        {
            return obj.ToString();
        }
    }

}
