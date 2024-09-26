// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRServerless;

public class InnerApplicationAutoStopConfigurationFactory(Action<Humidifier.EMRServerless.ApplicationTypes.AutoStopConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRServerless.ApplicationTypes.AutoStopConfiguration>
{

    protected override Humidifier.EMRServerless.ApplicationTypes.AutoStopConfiguration Create()
    {
        var autoStopConfigurationResult = CreateAutoStopConfiguration();
        factoryAction?.Invoke(autoStopConfigurationResult);

        return autoStopConfigurationResult;
    }

    private Humidifier.EMRServerless.ApplicationTypes.AutoStopConfiguration CreateAutoStopConfiguration()
    {
        var autoStopConfigurationResult = new Humidifier.EMRServerless.ApplicationTypes.AutoStopConfiguration();

        return autoStopConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationAutoStopConfigurationFactoryExtensions
{
}
