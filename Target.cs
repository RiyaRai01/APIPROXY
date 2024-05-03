// using System.Xml.Serialization;
// using Apiproxy.Policies;

// [XmlRoot(ElementName="PreFlow")]
// public class PreFlow { 

// 	[XmlElement(ElementName="Request")] 
// 	public object Request { get; set; } 

// 	[XmlElement(ElementName="Response")] 
// 	public object Response { get; set; } 

// 	[XmlAttribute(AttributeName="name")] 
// 	public string Name { get; set; } 
// }

// [XmlRoot(ElementName="PostFlow")]
// public class PostFlow { 

// 	[XmlElement(ElementName="Request")] 
// 	public object Request { get; set; } 

// 	[XmlElement(ElementName="Response")] 
// 	public object Response { get; set; } 

// 	[XmlAttribute(AttributeName="name")] 
// 	public string Name { get; set; } 
// }

// [XmlRoot(ElementName="HTTPTargetConnection")]
// public class HTTPTargetConnection { 

// 	[XmlElement(ElementName="Properties")] 
// 	public List<Property> Properties { get; set; } 

// 	[XmlElement(ElementName="URL")] 
// 	public string URL { get; set; } 
// }

// [XmlRoot(ElementName="TargetEndpoint")]
// public class TargetEndpoint { 

// 	[XmlElement(ElementName="Description")] 
// 	public object Description { get; set; } 

// 	[XmlElement(ElementName="FaultRules")] 
// 	public object FaultRules { get; set; } 

// 	[XmlElement(ElementName="PreFlow")] 
// 	public PreFlow PreFlow { get; set; } 

// 	[XmlElement(ElementName="PostFlow")] 
// 	public PostFlow PostFlow { get; set; } 

// 	[XmlElement(ElementName="Flows")] 
// 	public object Flows { get; set; } 

// 	[XmlElement(ElementName="HTTPTargetConnection")] 
// 	public HTTPTargetConnection HTTPTargetConnection { get; set; } 

// 	[XmlAttribute(AttributeName="name")] 
// 	public string Name { get; set; } 
// }
