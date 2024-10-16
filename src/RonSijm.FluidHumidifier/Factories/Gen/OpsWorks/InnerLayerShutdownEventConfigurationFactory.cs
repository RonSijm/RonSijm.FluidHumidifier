// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorks;

public class InnerLayerShutdownEventConfigurationFactory(Action<Humidifier.OpsWorks.LayerTypes.ShutdownEventConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.OpsWorks.LayerTypes.ShutdownEventConfiguration>
{

    protected override Humidifier.OpsWorks.LayerTypes.ShutdownEventConfiguration Create()
    {
        var shutdownEventConfigurationResult = CreateShutdownEventConfiguration();
        factoryAction?.Invoke(shutdownEventConfigurationResult);

        return shutdownEventConfigurationResult;
    }

    private Humidifier.OpsWorks.LayerTypes.ShutdownEventConfiguration CreateShutdownEventConfiguration()
    {
        var shutdownEventConfigurationResult = new Humidifier.OpsWorks.LayerTypes.ShutdownEventConfiguration();

        return shutdownEventConfigurationResult;
    }

} // End Of Class

public static class InnerLayerShutdownEventConfigurationFactoryExtensions
{
}
