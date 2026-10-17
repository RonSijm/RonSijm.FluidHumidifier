// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Synthetics;

public class InnerCanaryRetryConfigFactory(Action<Humidifier.Synthetics.CanaryTypes.RetryConfig> factoryAction = null) : SubResourceFactory<Humidifier.Synthetics.CanaryTypes.RetryConfig>
{

    protected override Humidifier.Synthetics.CanaryTypes.RetryConfig Create()
    {
        var retryConfigResult = CreateRetryConfig();
        factoryAction?.Invoke(retryConfigResult);

        return retryConfigResult;
    }

    private Humidifier.Synthetics.CanaryTypes.RetryConfig CreateRetryConfig()
    {
        var retryConfigResult = new Humidifier.Synthetics.CanaryTypes.RetryConfig();

        return retryConfigResult;
    }

} // End Of Class

public static class InnerCanaryRetryConfigFactoryExtensions
{
}
