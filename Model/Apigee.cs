using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Proxy.Policies;
using Proxy.Target;

namespace Apigeemig
{
    [XmlRoot(ElementName="APIProxy")]
    public class ApiProxy
    {
	    [XmlElement(ElementName="DisplayName")] 
        public string DisplayName { get; set; }
        
	    [XmlElement(ElementName="Description")] 
        public string Description { get; set; }
        
	    [XmlElement(ElementName="CreatedAt")] 
        public long CreatedAt { get; set; }
        
	    [XmlElement(ElementName="LastModifiedAt")] 
        public long LastModifiedAt { get; set; }
        
	    [XmlElement(ElementName="BasePaths")] 
        public string BasePaths { get; set; }
        
        [XmlArray(ElementName = "Policies")]
	    [XmlArrayItem(ElementName="Policy")] 
        public List<Policy> Policies { get; set; }

        [XmlArray(ElementName = "ProxyEndpoints")]
	    [XmlArrayItem(ElementName="ProxyEndpoint")] 
        public List<ProxyEndpoint> ProxyEndpoints { get; set; } 

        [XmlArray(ElementName = "TargetEndpoints")]
	    [XmlArrayItem(ElementName="TargetEndpoint")] 
        public List<TargetEndpoint> TargetEndpoints { get; set; }

        [XmlAttribute(AttributeName="revision")] 
        public int Revision {get; set;} 

        [XmlAttribute(AttributeName="name")]
        public string Name {get; set;}
        public DateTime GetCreatedAtDateTime()
        {
           return DateTimeOffset.FromUnixTimeMilliseconds(CreatedAt).DateTime;
        }

        public DateTime GetLastModifiedAtDateTime()
        {
            return DateTimeOffset.FromUnixTimeMilliseconds(LastModifiedAt).DateTime;
        }

        public override string ToString()
        {
            string result = $"Name: {Name}\n";
            result += $"Revision: {Revision}\n";
            result += $"DisplayName: {DisplayName}\n";
            result += $"Description: {Description}\n";
            result += $"CreatedAt: {GetCreatedAtDateTime()}\n";
            result += $"LastModifiedAt: {GetLastModifiedAtDateTime()}\n";
            result += $"BasePaths: {BasePaths}\n";

            result += "Policies:\n";
            foreach (var policy in Policies)
            {
                result += $"- {policy.Name}\n";
            }
            
            result += "ProxyEndpoints:\n"; 
            foreach (var endpoint in ProxyEndpoints)
            {
                result += $"- {endpoint.Name}\n";
               
            }

            result += "TargetEndpoints:\n";
            foreach (var endpoint in TargetEndpoints)
            {
                result += $"- {endpoint.Name}\n";
               
            }
            return result;
        }
    }
    public class Policy
    {
        [XmlText]
        public string Name 
        {
            get;
            set;
        }

    }
    
    public class ProxyEndpoint
	{ 
        [XmlText]
		public string Name { get; set; } 
	}

    
    public class TargetEndpoint
	{
        [XmlText]
		public string Name { get; set; }

	}
}