namespace RonSijm.FluidHumidifier.Factories.Custom;

public class StatementFactory(List<string> action, PolicyPrincipalValue principle, PolicyResourceValue resource, string effect = "Allow", Dictionary<string, Dictionary<string, object>> condition = null, string sid = null) : SubResourceFactory<Statement>
{
    protected override Statement Create()
    {
        var statement = new Statement
        {
            Effect = effect,
            Action = action,
            Principal = principle,
            Resource = resource,
            Condition = condition,
            Sid = sid
        };

        return statement;
    }
}