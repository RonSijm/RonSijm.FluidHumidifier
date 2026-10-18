// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateNetworkPerformanceOptionsFactory(Action<Humidifier.EC2.LaunchTemplateTypes.NetworkPerformanceOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.NetworkPerformanceOptions>
{

    protected override Humidifier.EC2.LaunchTemplateTypes.NetworkPerformanceOptions Create()
    {
        var networkPerformanceOptionsResult = CreateNetworkPerformanceOptions();
        factoryAction?.Invoke(networkPerformanceOptionsResult);

        return networkPerformanceOptionsResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.NetworkPerformanceOptions CreateNetworkPerformanceOptions()
    {
        var networkPerformanceOptionsResult = new Humidifier.EC2.LaunchTemplateTypes.NetworkPerformanceOptions();

        return networkPerformanceOptionsResult;
    }

} // End Of Class

public static class InnerLaunchTemplateNetworkPerformanceOptionsFactoryExtensions
{
}
