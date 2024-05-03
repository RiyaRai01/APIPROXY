// using System.Xml.Serialization;

// namespace App.Apigeemig
// {
// 	[XmlRoot(ElementName="Policies")]
// 	public class Policies
// 	{ 

// 		[XmlElement(ElementName="Policy")] 
// 		public List<string> Policy { get; set; } 
// 	}

// 	[XmlRoot(ElementName="ProxyEndpoints")]
// 	public class ProxyEndpoints 
// 	{ 

// 		[XmlElement(ElementName="ProxyEndpoint")] 
// 		public string ProxyEndpoint { get; set; } 
// 	}

// 	[XmlRoot(ElementName="TargetEndpoints")]
// 	public class TargetEndpoints 
// 	{ 

// 		[XmlElement(ElementName="TargetEndpoint")] 
// 		public string TargetEndpoint { get; set; } 	
// 	}

// 	[XmlRoot(ElementName="APIProxy")]
// 	public class APIProxy 
// 	{ 

// 		[XmlElement(ElementName="DisplayName")] 
// 		public object DisplayName { get; set; } 

// 		[XmlElement(ElementName="Description")] 
// 		public object Description { get; set; } 

// 		[XmlElement(ElementName="CreatedAt")] 
// 		public double CreatedAt { get; set; } 

// 		[XmlElement(ElementName="LastModifiedAt")] 
// 		public double LastModifiedAt { get; set; } 

// 		[XmlElement(ElementName="BasePaths")] 
// 		public string BasePaths { get; set; } 

// 		[XmlElement(ElementName="Policies")] 
// 		public Policies Policies { get; set; } 

// 		[XmlElement(ElementName="ProxyEndpoints")] 
// 		public ProxyEndpoints ProxyEndpoints { get; set; } 

// 		[XmlElement(ElementName="TargetEndpoints")] 
// 		public TargetEndpoints TargetEndpoints { get; set; } 

// 		[XmlAttribute(AttributeName="revision")] 
// 		public int Revision { get; set; } 

// 		[XmlAttribute(AttributeName="name")] 
// 		public string Name { get; set; } 

// 	}
// }