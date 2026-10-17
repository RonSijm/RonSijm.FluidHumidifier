// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerFunctionHttpRequestConfigurationFactory(Action<Humidifier.MediaTailor.FunctionTypes.HttpRequestConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.FunctionTypes.HttpRequestConfiguration>
{

    protected override Humidifier.MediaTailor.FunctionTypes.HttpRequestConfiguration Create()
    {
        var httpRequestConfigurationResult = CreateHttpRequestConfiguration();
        factoryAction?.Invoke(httpRequestConfigurationResult);

        return httpRequestConfigurationResult;
    }

    private Humidifier.MediaTailor.FunctionTypes.HttpRequestConfiguration CreateHttpRequestConfiguration()
    {
        var httpRequestConfigurationResult = new Humidifier.MediaTailor.FunctionTypes.HttpRequestConfiguration();

        return httpRequestConfigurationResult;
    }

} // End Of Class

public static class InnerFunctionHttpRequestConfigurationFactoryExtensions
{
}
