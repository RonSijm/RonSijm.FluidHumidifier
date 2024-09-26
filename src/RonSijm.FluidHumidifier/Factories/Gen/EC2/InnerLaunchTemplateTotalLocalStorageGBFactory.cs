// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateTotalLocalStorageGBFactory(Action<Humidifier.EC2.LaunchTemplateTypes.TotalLocalStorageGB> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.TotalLocalStorageGB>
{

    protected override Humidifier.EC2.LaunchTemplateTypes.TotalLocalStorageGB Create()
    {
        var totalLocalStorageGBResult = CreateTotalLocalStorageGB();
        factoryAction?.Invoke(totalLocalStorageGBResult);

        return totalLocalStorageGBResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.TotalLocalStorageGB CreateTotalLocalStorageGB()
    {
        var totalLocalStorageGBResult = new Humidifier.EC2.LaunchTemplateTypes.TotalLocalStorageGB();

        return totalLocalStorageGBResult;
    }

} // End Of Class

public static class InnerLaunchTemplateTotalLocalStorageGBFactoryExtensions
{
}
