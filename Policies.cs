using System.Xml.Serialization;

namespace App.Policies
{
    [XmlRoot(ElementName="ServiceCallout")]
    public class ServiceCallout 
    { 

    	[XmlElement(ElementName="DisplayName")] 
	    public string DisplayName { get; set; } 

	    [XmlElement(ElementName="Properties")] 
	    public object Properties { get; set; } 

	    [XmlElement(ElementName="Request")] 
	    public Request Request { get; set; } 

	    [XmlElement(ElementName="Response")] 
	    public string Response { get; set; } 

	    [XmlElement(ElementName="HTTPTargetConnection")] 
	    public HTTPTargetConnection HTTPTargetConnection { get; set; } 

	    [XmlAttribute(AttributeName="continueOnError")] 
	    public bool ContinueOnError { get; set; } 

	    [XmlAttribute(AttributeName="enabled")] 
	    public bool Enabled { get; set; } 

	    [XmlAttribute(AttributeName="name")] 
	    public string Name { get; set; } 

        // public override string ToString()
        // {
        //     return $"ContinueOnError : {ContinueOnError}, Enabled : {Enabled}, Name : {Name}, DisplayName : {DisplayName}, Properties : {Properties}, Request : {Request}, Response : {Response}, HTTPTargetConnection : {HTTPTargetConnection}";

        // }
    }


    [XmlRoot(ElementName="Request")]
    public class Request
    {
        [XmlElement(ElementName="IgnoreUnresolvedVariables")] 
        public bool IgnoreUnresolvedVariables { get; set; }
        
        [XmlAttribute(AttributeName="clearPayload")] 
        public bool ClearPayload { get; set; }

        [XmlAttribute(AttributeName="variable")] 
        public string Variable { get; set; }

        // public override string ToString()
        // {
        //     return $"ClearPayload :{ClearPayload}, Variable : {Variable}, IgnoreUnresolvedVariables : {IgnoreUnresolvedVariables}";
        // }

    }

    [XmlRoot(ElementName="HTTPTargetConnection")]
    public class HTTPTargetConnection
    {
        [XmlElement(ElementName="Properties")] 
        public object Properties { get; set; }

        [XmlElement(ElementName="URL")] 
        public string URL { get; set; }

        // public override string ToString()
        // {
        //     return $"Properties : {Properties}, URL : {URL}";
        // }
    }

    [XmlRoot(ElementName="SpikeArrest")]
    public class SpikeArrest { 

	    [XmlElement(ElementName="DisplayName")] 
    	public string DisplayName { get; set; } 

    	[XmlElement(ElementName="Properties")] 
    	public object Properties { get; set; } 

    	[XmlElement(ElementName="Identifier")] 
    	public Identifier Identifier { get; set; } 

    	[XmlElement(ElementName="MessageWeight")] 
    	public MessageWeight MessageWeight { get; set; } 

    	[XmlElement(ElementName="Rate")] 
    	public string Rate { get; set; } 

    	[XmlAttribute(AttributeName="continueOnError")] 
    	public bool ContinueOnError { get; set; } 

    	[XmlAttribute(AttributeName="enabled")] 
    	public bool Enabled { get; set; } 

    	[XmlAttribute(AttributeName="name")] 
    	public string Name { get; set; } 

        // public override string ToString()
        // {
        //     return $"ContinueOnError : {ContinueOnError}, Enabled:{Enabled},Name : {Name},DisplayName : {DisplayName},Properties : {Properties},Identifier: {Identifier},MessageWeight :{MessageWeight}, Rate: {Rate}";
        // }


    }
    
    [XmlRoot(ElementName="Identifier")]
    public class Identifier 
    { 

	    [XmlAttribute(AttributeName="ref")] 
	    public string Ref { get; set; }

        // public override string ToString()
        // {
        //     return $"Ref : {Ref}";
        // }
    }

    [XmlRoot(ElementName="MessageWeight")]
    public class MessageWeight 
    { 

	    [XmlAttribute(AttributeName="ref")] 
	    public string Ref { get; set; } 

        // public override string ToString()
        // {
        //     return $"Ref : {Ref}";
        // }
    }

    [XmlRoot(ElementName="VerifyAPIKey")]
    public class VerifyAPIKey 
    { 

	    [XmlElement(ElementName="DisplayName")] 
	    public string DisplayName { get; set; } 

	    [XmlElement(ElementName="Properties")] 
	    public object Properties { get; set; } 

	    [XmlElement(ElementName="APIKey")] 
	    public APIKey APIKey { get; set; } 

	    [XmlAttribute(AttributeName="continueOnError")] 
	    public bool ContinueOnError { get; set; } 

	    [XmlAttribute(AttributeName="enabled")] 
	    public bool Enabled { get; set; } 

	    [XmlAttribute(AttributeName="name")] 
	    public string Name { get; set; }  

        // public override string ToString()
        // {
        //     return $"ContinueOnError : {ContinueOnError},Enabled: {Enabled}, Name : {Name}, DisplayName : {DisplayName}, Properties : {Properties}, APIKey : {APIKey}";
        // }
    }

    [XmlRoot(ElementName="APIKey")]
    public class APIKey 
    { 

	    [XmlAttribute(AttributeName="ref")] 
	    public string Ref { get; set; }

        // public override string ToString()
        // {
        //     return $"Ref:{Ref}";
        // }
    }

}