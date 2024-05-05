using System.Xml.Serialization;
using Apigeemig;
using Proxy.Endpoint;

namespace Proxy.Policies
{ 
   
    public class Policy
    {

        public string Name { get; set; }
        public bool continueOnError { get; set; }
        public bool Enabled { get; set; }
        public string DisplayName { get; set; }
        public List<Property> properties { get; set; }

    }
     
    [XmlRoot(ElementName = "ServiceCallout")]
    public class ServiceCallout : Policy
    {
        public Request Request { get; set; }
        public string Response { get; set; }
        public HTTPTargetConnection HTTPTargetConnection { get; set; }

    }

    
    [XmlRoot(ElementName = "SpikeArrest")]
    public class SpikeArrest : Policy
    {
        public Identifier Identifier { get; set; } 
    	public MessageWeight MessageWeight { get; set; } 
    	public string Rate { get; set; } 
    }

    
    [XmlRoot(ElementName = "VerifyAPIKey")]
    public class VerifyAPIKey : Policy
    {
        public APIKey APIKey { get; set; } 

    }

    [XmlRoot(ElementName = "Request")] 
    public class Request
    {
        [XmlElement(ElementName = "Step")]
	    public List<Step> Steps { get; set; }
        public bool IgnoreUnresolvedVariables { get; set; }
        public bool ClearPayload { get; set; }
        public string Variable { get; set; }
    }

    public class HTTPTargetConnection
    {
        public List<Property> Properties { get; set; }
        public string URL { get; set; }
         public string BasePath { get; set; } 
        public string VirtualHost { get; set; }
    }

    public class RouteRule 
    {
        
    	public TargetEndpointName TargetEndpoint { get; set; }  

        [XmlText]
	    public string Name { get; set; } 
    }

    public class Identifier 
    { 
	    public string Ref { get; set; }
    }

    public class MessageWeight 
    { 
	    public string Ref { get; set; } 
    }

    public class APIKey 
    { 
	    public string Ref { get; set; }
    }

    public class Property
    {
        //need fields
    }
}