// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancing;

public class InnerLoadBalancerConnectionSettingsFactory(Action<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.ConnectionSettings> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.ConnectionSettings>
{

    protected override Humidifier.ElasticLoadBalancing.LoadBalancerTypes.ConnectionSettings Create()
    {
        var connectionSettingsResult = CreateConnectionSettings();
        factoryAction?.Invoke(connectionSettingsResult);

        return connectionSettingsResult;
    }

    private Humidifier.ElasticLoadBalancing.LoadBalancerTypes.ConnectionSettings CreateConnectionSettings()
    {
        var connectionSettingsResult = new Humidifier.ElasticLoadBalancing.LoadBalancerTypes.ConnectionSettings();

        return connectionSettingsResult;
    }

} // End Of Class

public static class InnerLoadBalancerConnectionSettingsFactoryExtensions
{
}
