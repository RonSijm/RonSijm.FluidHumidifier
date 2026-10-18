// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerIntegrationIntegrationConfigFactory(Action<Humidifier.Glue.IntegrationTypes.IntegrationConfig> factoryAction = null) : SubResourceFactory<Humidifier.Glue.IntegrationTypes.IntegrationConfig>
{

    protected override Humidifier.Glue.IntegrationTypes.IntegrationConfig Create()
    {
        var integrationConfigResult = CreateIntegrationConfig();
        factoryAction?.Invoke(integrationConfigResult);

        return integrationConfigResult;
    }

    private Humidifier.Glue.IntegrationTypes.IntegrationConfig CreateIntegrationConfig()
    {
        var integrationConfigResult = new Humidifier.Glue.IntegrationTypes.IntegrationConfig();

        return integrationConfigResult;
    }

} // End Of Class

public static class InnerIntegrationIntegrationConfigFactoryExtensions
{
}
