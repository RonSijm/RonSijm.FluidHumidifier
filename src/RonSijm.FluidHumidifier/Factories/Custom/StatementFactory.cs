namespace RonSijm.FluidHumidifier.Factories.Custom;

public class StatementFactory(List<string> action, dynamic principle, dynamic resource, string effect = "Allow", Dictionary<string, Dictionary<string, dynamic>> condition = null, dynamic sid = null) : SubResourceFactory<Statement>
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