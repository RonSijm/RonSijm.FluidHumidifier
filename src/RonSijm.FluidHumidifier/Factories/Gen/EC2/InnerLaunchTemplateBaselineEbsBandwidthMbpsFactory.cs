// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateBaselineEbsBandwidthMbpsFactory(Action<Humidifier.EC2.LaunchTemplateTypes.BaselineEbsBandwidthMbps> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.BaselineEbsBandwidthMbps>
{

    protected override Humidifier.EC2.LaunchTemplateTypes.BaselineEbsBandwidthMbps Create()
    {
        var baselineEbsBandwidthMbpsResult = CreateBaselineEbsBandwidthMbps();
        factoryAction?.Invoke(baselineEbsBandwidthMbpsResult);

        return baselineEbsBandwidthMbpsResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.BaselineEbsBandwidthMbps CreateBaselineEbsBandwidthMbps()
    {
        var baselineEbsBandwidthMbpsResult = new Humidifier.EC2.LaunchTemplateTypes.BaselineEbsBandwidthMbps();

        return baselineEbsBandwidthMbpsResult;
    }

} // End Of Class

public static class InnerLaunchTemplateBaselineEbsBandwidthMbpsFactoryExtensions
{
}
