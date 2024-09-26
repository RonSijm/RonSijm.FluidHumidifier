// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class QueryDefinitionFactory(string resourceName = null, Action<Humidifier.Logs.QueryDefinition> factoryAction = null) : ResourceFactory<Humidifier.Logs.QueryDefinition>(resourceName)
{

    protected override Humidifier.Logs.QueryDefinition Create()
    {
        var queryDefinitionResult = CreateQueryDefinition();
        factoryAction?.Invoke(queryDefinitionResult);

        return queryDefinitionResult;
    }

    private Humidifier.Logs.QueryDefinition CreateQueryDefinition()
    {
        var queryDefinitionResult = new Humidifier.Logs.QueryDefinition
        {
            GivenName = InputResourceName,
        };

        return queryDefinitionResult;
    }

} // End Of Class

public static class QueryDefinitionFactoryExtensions
{
}
