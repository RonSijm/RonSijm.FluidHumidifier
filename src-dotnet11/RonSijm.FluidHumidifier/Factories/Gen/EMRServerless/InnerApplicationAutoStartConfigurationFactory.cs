// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRServerless;

public class InnerApplicationAutoStartConfigurationFactory(Action<Humidifier.EMRServerless.ApplicationTypes.AutoStartConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRServerless.ApplicationTypes.AutoStartConfiguration>
{

    protected override Humidifier.EMRServerless.ApplicationTypes.AutoStartConfiguration Create()
    {
        var autoStartConfigurationResult = CreateAutoStartConfiguration();
        factoryAction?.Invoke(autoStartConfigurationResult);

        return autoStartConfigurationResult;
    }

    private Humidifier.EMRServerless.ApplicationTypes.AutoStartConfiguration CreateAutoStartConfiguration()
    {
        var autoStartConfigurationResult = new Humidifier.EMRServerless.ApplicationTypes.AutoStartConfiguration();

        return autoStartConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationAutoStartConfigurationFactoryExtensions
{
}
