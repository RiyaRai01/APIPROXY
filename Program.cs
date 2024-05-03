// using System.Diagnostics;
// using System.Globalization;
// using System.Net.NetworkInformation;
// using System.Reflection;
// using System.Runtime.ConstrainedExecution;
// using System.Text;
// using System.Xml.Serialization;
// using App.Policies;
// using App.Proxies;
// using CsvHelper;

// namespace ApiProxy
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //CSV file  path
//             string serviceCalloutPath_Out = @"C:\Users\RRai\Downloads\apigeemig_rev2_2024_03_12\apiproxy\policies\serviceCallout.csv";
           
//             string spikeArrestPath_Out = @"C:\Users\RRai\Downloads\apigeemig_rev2_2024_03_12\apiproxy\policies\spikeArrest.csv";
           
//             string verifyAPIKeyPath_Out = @"C:\Users\RRai\Downloads\apigeemig_rev2_2024_03_12\apiproxy\policies\verifyAPIKey.csv";

//             string proxyEndPointPath_Out = @"C:\Users\RRai\Downloads\apigeemig_rev2_2024_03_12\apiproxy\proxies\proxyEndPoint.csv";

//             string tragetEndPointPath_Out = @"C:\Users\RRai\Downloads\apigeemig_rev2_2024_03_12\apiproxy\targets\targetEndPoint.csv";

//             //RootDirectory Path
//             string rootDirectory = @"C:\Users\RRai\Downloads\apigeemig_rev2_2024_03_12\apiproxy";

//             //XML File Path
//             string serviceCallOutPolicies_Path = Path.Combine(rootDirectory, "policies", "Service-Callout-1.xml");
//             string spikeArrestPolicies_path = Path.Combine(rootDirectory,"policies","Spike-Arrest-1.xml");
//             string verifyAPIKeyolicies_path = Path.Combine(rootDirectory,"policies","Verify-API-Key-1.xml"); 
//             string proxyEndPointProxies_path = Path.Combine(rootDirectory,"proxies","default.xml");
//             string tragetEndPointTarget_path = Path.Combine(rootDirectory,"targets","default.xml");
            
//             //Calling Methood 
//             WriteObjectsToCsv<ServiceCallout>( serviceCallOutPolicies_Path,serviceCalloutPath_Out);
//             WriteObjectsToCsv<SpikeArrest>(spikeArrestPolicies_path,spikeArrestPath_Out);
//             WriteObjectsToCsv<VerifyAPIKey>(verifyAPIKeyolicies_path ,verifyAPIKeyPath_Out);
//             WriteObjectsToCsv<ProxyEndpoint>(proxyEndPointProxies_path,proxyEndPointPath_Out);
//             WriteObjectsToCsv<TargetEndpoint>(tragetEndPointTarget_path,tragetEndPointPath_Out);
//         }

//         public static void WriteObjectsToCsv<T>(string xmlpath, string outputfilePath)
//         {
//             T obj = Deserialize<T>(xmlpath);

//             var properties = typeof(T).GetProperties();

//             StringBuilder csvContent = new StringBuilder();

//             //Append header
//             csvContent.AppendLine(GetCsvHeader(properties));

//             // Get values of properties
//             var values = GetPropertyValues(properties,obj);

//             // Append values to CSV content
//             csvContent.AppendLine(string.Join(",", values));

//             System.Console.WriteLine(csvContent);

//             // Write content to file
//             File.WriteAllText(outputfilePath, csvContent.ToString());
//         }

//         private static string GetCsvHeader(PropertyInfo[] properties)
//         {
//             List<string> header = new List<string>();
//             foreach (var property in properties)
//             {
//                 if (property.PropertyType.IsPrimitive || property.PropertyType == typeof(string)|| property.PropertyType == typeof(object))
//                 {
//                     header.Add(property.Name);
//                 }
//                 else
//                 {
//                     var subObjectProperties = property.PropertyType.GetProperties();
//                     header.AddRange(subObjectProperties.Select(subProperty => $"{property.Name}.{subProperty.Name}"));
//                 }
//             }
//             return string.Join(",", header);
//         }

//         private static IEnumerable<object> GetPropertyValues(PropertyInfo[] properties, object obj)
//         {
//             List<object> values = new List<object>();
//             foreach (var property in properties)
//             {
//                 var value = property.GetValue(obj);


//                 if (value != null)
//                 {
//                     if (property.PropertyType.IsPrimitive || property.PropertyType == typeof(string)|| property.PropertyType == typeof(object))
//                     {
//                         values.Add(value);
//                     }
//                     else
//                     {
//                         var subObjectProperties = property.PropertyType.GetProperties();
//                         values.AddRange(GetPropertyValues(subObjectProperties, value));
//                     }
//                 }
//                 else
//                 {
//                     values.Add(""); // If the property is null, add an empty string to maintain CSV structure
//                 }
//             }
    
//             return values;
//         }
//         public static T Deserialize<T>(string filePath)
//         {
//             try
//             {
//                 XmlSerializer serializer = new XmlSerializer(typeof(T));

//                 using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
//                 {
//                     T obj = (T)serializer.Deserialize(fileStream);


//                     // System.Console.WriteLine("Desrialize object from {filePath} : {obj}");
//                     return obj;
//                 }

//             }
//             catch (Exception ex)
//             {
//                 System.Console.WriteLine($"Error deserializing xml file {filePath} : {ex.Message} ");
//                 throw new Exception(ex.Message);
//             }
//         }

//     }
// }

