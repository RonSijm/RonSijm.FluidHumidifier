// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DirectoryService;

public class InnerSimpleADVpcSettingsFactory(Action<Humidifier.DirectoryService.SimpleADTypes.VpcSettings> factoryAction = null) : SubResourceFactory<Humidifier.DirectoryService.SimpleADTypes.VpcSettings>
{

    protected override Humidifier.DirectoryService.SimpleADTypes.VpcSettings Create()
    {
        var vpcSettingsResult = CreateVpcSettings();
        factoryAction?.Invoke(vpcSettingsResult);

        return vpcSettingsResult;
    }

    private Humidifier.DirectoryService.SimpleADTypes.VpcSettings CreateVpcSettings()
    {
        var vpcSettingsResult = new Humidifier.DirectoryService.SimpleADTypes.VpcSettings();

        return vpcSettingsResult;
    }

} // End Of Class

public static class InnerSimpleADVpcSettingsFactoryExtensions
{
}
