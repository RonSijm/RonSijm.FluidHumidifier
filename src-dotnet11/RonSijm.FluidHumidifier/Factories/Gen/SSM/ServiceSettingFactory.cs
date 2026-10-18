// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class ServiceSettingFactory(string resourceName = null, Action<Humidifier.SSM.ServiceSetting> factoryAction = null) : ResourceFactory<Humidifier.SSM.ServiceSetting>(resourceName)
{

    protected override Humidifier.SSM.ServiceSetting Create()
    {
        var serviceSettingResult = CreateServiceSetting();
        factoryAction?.Invoke(serviceSettingResult);

        return serviceSettingResult;
    }

    private Humidifier.SSM.ServiceSetting CreateServiceSetting()
    {
        var serviceSettingResult = new Humidifier.SSM.ServiceSetting
        {
            GivenName = InputResourceName,
        };

        return serviceSettingResult;
    }

} // End Of Class

public static class ServiceSettingFactoryExtensions
{
}
