using System.Xml.Serialization;

namespace App.Proxies
{
    [XmlRoot(ElementName="ProxyEndpoint")]
    public class ProxyEndpoint
    { 

	    [XmlElement(ElementName="Description")] 
	    public object Description { get; set; } 

	    [XmlElement(ElementName="FaultRules")] 
	    public object FaultRules { get; set; } 

	    [XmlElement(ElementName="PreFlow")] 
	    public PreFlow PreFlow { get; set; } 

	    [XmlElement(ElementName="PostFlow")] 
	    public PostFlow PostFlow { get; set; } 

	    [XmlElement(ElementName="Flows")] 
	    public object Flows { get; set; } 

	    [XmlElement(ElementName="HTTPProxyConnection")] 
	    public HTTPProxyConnection HTTPProxyConnection { get; set; } 

	    [XmlElement(ElementName="RouteRule")] 
	    public RouteRule RouteRule { get; set; } 

	    [XmlAttribute(AttributeName="name")] 
	    public string Name { get; set; } 
    }

    [XmlRoot(ElementName="PreFlow")]
    public class PreFlow 
    { 

	    [XmlElement(ElementName="Request")] 
	    public Request Request { get; set; } 

	    [XmlElement(ElementName="Response")] 
	    public object Response { get; set; } 

	    [XmlAttribute(AttributeName="name")] 
	    public string Name { get; set; } 

	    [XmlText] 
	    public string Text { get; set; } 
    }

    [XmlRoot(ElementName="Request")]
    public class Request 
    { 

	    [XmlElement(ElementName="Step")] 
	    public List<Step> Step { get; set; } 
    }
    [XmlRoot(ElementName ="Step")]

    public class Step
    {
        [XmlElement(ElementName="Step")]
        public string Name {get; set; }
    }
    
    [XmlRoot(ElementName="PostFlow")]
    public class PostFlow 
    { 

	    [XmlElement(ElementName="Request")] 
	    public object Request { get; set; } 

	    [XmlElement(ElementName="Response")] 
    	public object Response { get; set; } 

	    [XmlAttribute(AttributeName="name")] 
    	public string Name { get; set; } 
    }

    [XmlRoot(ElementName="HTTPProxyConnection")]
    public class HTTPProxyConnection
    { 

	    [XmlElement(ElementName="BasePath")] 
	    public string BasePath { get; set; } 

	    [XmlElement(ElementName="Properties")] 
    	public object Properties { get; set; } 

	    [XmlElement(ElementName="VirtualHost")] 
	    public string VirtualHost { get; set; } 
    }

    
    [XmlRoot(ElementName="RouteRule")]
    public class RouteRule 
    { 

    	[XmlElement(ElementName="TargetEndpoint")] 
    	public string TargetEndpoint { get; set; } 

	    [XmlAttribute(AttributeName="name")] 
	    public string Name { get; set; } 

	    [XmlText] 
	    public string Text { get; set; } 
    }

}    













