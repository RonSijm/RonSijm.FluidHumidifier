// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolDeviceConfigurationFactory(Action<Humidifier.Cognito.UserPoolTypes.DeviceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolTypes.DeviceConfiguration>
{

    protected override Humidifier.Cognito.UserPoolTypes.DeviceConfiguration Create()
    {
        var deviceConfigurationResult = CreateDeviceConfiguration();
        factoryAction?.Invoke(deviceConfigurationResult);

        return deviceConfigurationResult;
    }

    private Humidifier.Cognito.UserPoolTypes.DeviceConfiguration CreateDeviceConfiguration()
    {
        var deviceConfigurationResult = new Humidifier.Cognito.UserPoolTypes.DeviceConfiguration();

        return deviceConfigurationResult;
    }

} // End Of Class

public static class InnerUserPoolDeviceConfigurationFactoryExtensions
{
}
