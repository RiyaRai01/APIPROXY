using System.Xml.Serialization;
using Proxy.Policies;

namespace Proxy.Target;

[XmlRoot(ElementName="TargetEndpoint")]
public class TargetEndpoint
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
	public List<Flow> Flows { get; set; }
	
	[XmlElement(ElementName="HTTPTargetConnection")] 
	public HTTPTargetConnection HTTPTargetConnection { get; set; } 

	[XmlAttribute(AttributeName="name")] 
	public string Name { get; set; }

}

[XmlRoot(ElementName="FaultRule")]
public class FaultRule
{
	
}

[XmlRoot(ElementName="PreFlow")]
public class PreFlow { 

	[XmlElement(ElementName="Request")] 
	public Request Request { get; set; } 

	[XmlElement(ElementName="Response")] 
	public string Response { get; set; } 
	
	[XmlAttribute(AttributeName="name")] 
	public string Name { get; set; } 
}


[XmlRoot(ElementName="PostFlow")]
public class PostFlow { 

	[XmlElement(ElementName="Request")] 
	public Request Request { get; set; } 

	[XmlElement(ElementName="Response")] 
	public string Response { get; set; } 

	[XmlAttribute(AttributeName="name")] 
	public string Name { get; set; }
}

[XmlRoot(ElementName="Flow")]
public class Flow
{
	
}