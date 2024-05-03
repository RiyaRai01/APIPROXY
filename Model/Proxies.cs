using System.Xml.Serialization;
using Proxy.Policies;
using Proxy.Target;

namespace Proxy.Endpoint;

[XmlRoot(ElementName="ProxyEndpoint")] 
public class ProxyEndpoint
{
	[XmlElement(ElementName="Description")] 	
	public string Description { get; set; }

	[XmlElement(ElementName="FaultRules")] 
	public List<FaultRule> FaultRules { get; set; }

	[XmlElement(ElementName="PreFlow")] 
	public PreFlow PreFlow { get; set; }

	[XmlElement(ElementName="PostFlow")] 
	public PostFlow PostFlow { get; set; }
	
	[XmlElement(ElementName="Flows")] 
	public List<Flow> Flows {get; set;}
	
	[XmlElement(ElementName="HTTPProxyConnection")] 
	public HTTPProxyConnection HTTPProxyConnection { get; set; }
	
	[XmlElement(ElementName="RouteRule")] 
	public RouteRule RouteRule {get; set;}

}

public class PreFlow
{
	public string Name { get; set; }
	public Request Request { get; set; }
	public string Response { get; set; }

}

public class Request
{
	List<Step> Steps { get; set; }
}

public class Step
{
	public string Name { get; set; }
}

public class HTTPProxyConnection
{
	public string BasePath;
	public  
	public string VirtualHost;
}