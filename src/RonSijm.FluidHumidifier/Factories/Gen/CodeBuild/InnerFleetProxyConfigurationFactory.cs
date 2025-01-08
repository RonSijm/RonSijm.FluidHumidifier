// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerFleetProxyConfigurationFactory(Action<Humidifier.CodeBuild.FleetTypes.ProxyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.FleetTypes.ProxyConfiguration>
{

    protected override Humidifier.CodeBuild.FleetTypes.ProxyConfiguration Create()
    {
        var proxyConfigurationResult = CreateProxyConfiguration();
        factoryAction?.Invoke(proxyConfigurationResult);

        return proxyConfigurationResult;
    }

    private Humidifier.CodeBuild.FleetTypes.ProxyConfiguration CreateProxyConfiguration()
    {
        var proxyConfigurationResult = new Humidifier.CodeBuild.FleetTypes.ProxyConfiguration();

        return proxyConfigurationResult;
    }

} // End Of Class

public static class InnerFleetProxyConfigurationFactoryExtensions
{
}
