// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerFunctionVastRequestConfigurationFactory(Action<Humidifier.MediaTailor.FunctionTypes.VastRequestConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.FunctionTypes.VastRequestConfiguration>
{

    protected override Humidifier.MediaTailor.FunctionTypes.VastRequestConfiguration Create()
    {
        var vastRequestConfigurationResult = CreateVastRequestConfiguration();
        factoryAction?.Invoke(vastRequestConfigurationResult);

        return vastRequestConfigurationResult;
    }

    private Humidifier.MediaTailor.FunctionTypes.VastRequestConfiguration CreateVastRequestConfiguration()
    {
        var vastRequestConfigurationResult = new Humidifier.MediaTailor.FunctionTypes.VastRequestConfiguration();

        return vastRequestConfigurationResult;
    }

} // End Of Class

public static class InnerFunctionVastRequestConfigurationFactoryExtensions
{
}
