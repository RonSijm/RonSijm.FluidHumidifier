// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DirectoryService;

public class InnerMicrosoftADVpcSettingsFactory(Action<Humidifier.DirectoryService.MicrosoftADTypes.VpcSettings> factoryAction = null) : SubResourceFactory<Humidifier.DirectoryService.MicrosoftADTypes.VpcSettings>
{

    protected override Humidifier.DirectoryService.MicrosoftADTypes.VpcSettings Create()
    {
        var vpcSettingsResult = CreateVpcSettings();
        factoryAction?.Invoke(vpcSettingsResult);

        return vpcSettingsResult;
    }

    private Humidifier.DirectoryService.MicrosoftADTypes.VpcSettings CreateVpcSettings()
    {
        var vpcSettingsResult = new Humidifier.DirectoryService.MicrosoftADTypes.VpcSettings();

        return vpcSettingsResult;
    }

} // End Of Class

public static class InnerMicrosoftADVpcSettingsFactoryExtensions
{
}
