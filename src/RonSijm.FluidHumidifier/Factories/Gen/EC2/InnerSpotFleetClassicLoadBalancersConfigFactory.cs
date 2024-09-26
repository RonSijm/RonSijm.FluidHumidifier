// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerSpotFleetClassicLoadBalancersConfigFactory(Action<Humidifier.EC2.SpotFleetTypes.ClassicLoadBalancersConfig> factoryAction = null) : SubResourceFactory<Humidifier.EC2.SpotFleetTypes.ClassicLoadBalancersConfig>
{

    protected override Humidifier.EC2.SpotFleetTypes.ClassicLoadBalancersConfig Create()
    {
        var classicLoadBalancersConfigResult = CreateClassicLoadBalancersConfig();
        factoryAction?.Invoke(classicLoadBalancersConfigResult);

        return classicLoadBalancersConfigResult;
    }

    private Humidifier.EC2.SpotFleetTypes.ClassicLoadBalancersConfig CreateClassicLoadBalancersConfig()
    {
        var classicLoadBalancersConfigResult = new Humidifier.EC2.SpotFleetTypes.ClassicLoadBalancersConfig();

        return classicLoadBalancersConfigResult;
    }

} // End Of Class

public static class InnerSpotFleetClassicLoadBalancersConfigFactoryExtensions
{
}
