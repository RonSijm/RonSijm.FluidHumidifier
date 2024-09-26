namespace RonSijm.FluidHumidifier.Factories.Custom;

public class PolicyDocumentFactory : SubResourceFactory<PolicyDocument>
{
    public List<StatementFactory> StatementFactories { get; set; } = [];

    protected override PolicyDocument Create()
    {
        var statements = StatementFactories.Select(factory => factory.Build()).ToList();

        var policyDocument = new PolicyDocument
        {
            Statement = statements
        };

        return policyDocument;
    }

    // ReSharper disable once MethodOverloadWithOptionalParameter
    public StatementFactory WithStatement(string action, dynamic principle, dynamic resource = null, string effect = "Allow", Dictionary<string, Dictionary<string, dynamic>> condition = null, dynamic sid = null)
    {
        var factory = new StatementFactory(new List<string>() { action }, principle, resource, effect, condition, sid);
        StatementFactories.Add(factory);

        return factory;
    }

    public StatementFactory WithStatement(string action, dynamic resource, string effect = "Allow", dynamic sid = null)
    {
        var factory = new StatementFactory(new List<string>() { action }, null, resource, effect, sid: sid);
        StatementFactories.Add(factory);

        return factory;
    }

    public StatementFactory WithStatement(List<string> action, dynamic principle, dynamic resource = null, string effect = "Allow", Dictionary<string, Dictionary<string, dynamic>> condition = null, dynamic sid = null)
    {
        var factory = new StatementFactory(action, principle, resource, effect, condition, sid);
        StatementFactories.Add(factory);

        return factory;
    }

    public StatementFactory WithStatement(List<string> action, dynamic resource, string effect = "Allow", dynamic sid = null)
    {
        var factory = new StatementFactory(action, null, resource, effect, sid: sid);
        StatementFactories.Add(factory);

        return factory;
    }
}