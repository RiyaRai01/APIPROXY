using Proxy.Policies;

namespace Proxy.Target;
public class TargetEndpoint
{
	public string Description { get; set; }
	public List<FaultRule> FaultRules { get; set; } 
	public PreFlow PreFlow { get; set; } 
	public PostFlow PostFlow { get; set; }
	public List<Flow> Flows { get; set; }
	public HTTPTargetConnection HTTPTargetConnection { get; set; } 
}

public class FaultRule
{
	
}

public class PreFlow { 
	public Request Request { get; set; } 
	public string Response { get; set; } 
	public string Name { get; set; } 
}

public class PostFlow { 
	public Request Request { get; set; } 
	public string Response { get; set; } 
	public string Name { get; set; }
}

public class Flow
{
}