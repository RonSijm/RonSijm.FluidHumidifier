// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerIntegrationOpenSearchResourceConfigFactory(Action<Humidifier.Logs.IntegrationTypes.OpenSearchResourceConfig> factoryAction = null) : SubResourceFactory<Humidifier.Logs.IntegrationTypes.OpenSearchResourceConfig>
{

    protected override Humidifier.Logs.IntegrationTypes.OpenSearchResourceConfig Create()
    {
        var openSearchResourceConfigResult = CreateOpenSearchResourceConfig();
        factoryAction?.Invoke(openSearchResourceConfigResult);

        return openSearchResourceConfigResult;
    }

    private Humidifier.Logs.IntegrationTypes.OpenSearchResourceConfig CreateOpenSearchResourceConfig()
    {
        var openSearchResourceConfigResult = new Humidifier.Logs.IntegrationTypes.OpenSearchResourceConfig();

        return openSearchResourceConfigResult;
    }

} // End Of Class

public static class InnerIntegrationOpenSearchResourceConfigFactoryExtensions
{
}
