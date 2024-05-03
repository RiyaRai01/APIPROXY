using System.Xml.Serialization;
using Apigeemig;

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

    public class ServiceCallout : Policy
    {
        public Request Request { get; set; }
        public string Response { get; set; }
        public HTTPTargetConnection HTTPTargetConnection { get; set; }

    }

    public class SpikeArrest : Policy
    {
        public Identifier Identifier { get; set; } 
    	public MessageWeight MessageWeight { get; set; } 
    	public string Rate { get; set; } 
    }

    public class VerifyAPIKey : Policy
    {
        public APIKey APIKey { get; set; } 

    }

    public class Request
    {
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
    	public TargetEndpoint TargetEndpoint { get; set; }  
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