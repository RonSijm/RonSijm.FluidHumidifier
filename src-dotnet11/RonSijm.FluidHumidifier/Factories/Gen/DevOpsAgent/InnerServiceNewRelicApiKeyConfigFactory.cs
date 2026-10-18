// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServiceNewRelicApiKeyConfigFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicApiKeyConfig> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.NewRelicApiKeyConfig>
{

    protected override Humidifier.DevOpsAgent.ServiceTypes.NewRelicApiKeyConfig Create()
    {
        var newRelicApiKeyConfigResult = CreateNewRelicApiKeyConfig();
        factoryAction?.Invoke(newRelicApiKeyConfigResult);

        return newRelicApiKeyConfigResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.NewRelicApiKeyConfig CreateNewRelicApiKeyConfig()
    {
        var newRelicApiKeyConfigResult = new Humidifier.DevOpsAgent.ServiceTypes.NewRelicApiKeyConfig();

        return newRelicApiKeyConfigResult;
    }

} // End Of Class

public static class InnerServiceNewRelicApiKeyConfigFactoryExtensions
{
}
