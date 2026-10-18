// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InspectorV2;

public class InnerConnectorScopeConfigurationFactory(Action<Humidifier.InspectorV2.ConnectorTypes.ScopeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.InspectorV2.ConnectorTypes.ScopeConfiguration>
{

    protected override Humidifier.InspectorV2.ConnectorTypes.ScopeConfiguration Create()
    {
        var scopeConfigurationResult = CreateScopeConfiguration();
        factoryAction?.Invoke(scopeConfigurationResult);

        return scopeConfigurationResult;
    }

    private Humidifier.InspectorV2.ConnectorTypes.ScopeConfiguration CreateScopeConfiguration()
    {
        var scopeConfigurationResult = new Humidifier.InspectorV2.ConnectorTypes.ScopeConfiguration();

        return scopeConfigurationResult;
    }

} // End Of Class

public static class InnerConnectorScopeConfigurationFactoryExtensions
{
}
