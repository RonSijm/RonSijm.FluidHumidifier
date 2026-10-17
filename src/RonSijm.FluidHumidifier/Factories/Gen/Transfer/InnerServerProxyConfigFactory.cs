// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerServerProxyConfigFactory(Action<Humidifier.Transfer.ServerTypes.ProxyConfig> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.ServerTypes.ProxyConfig>
{

    protected override Humidifier.Transfer.ServerTypes.ProxyConfig Create()
    {
        var proxyConfigResult = CreateProxyConfig();
        factoryAction?.Invoke(proxyConfigResult);

        return proxyConfigResult;
    }

    private Humidifier.Transfer.ServerTypes.ProxyConfig CreateProxyConfig()
    {
        var proxyConfigResult = new Humidifier.Transfer.ServerTypes.ProxyConfig();

        return proxyConfigResult;
    }

} // End Of Class

public static class InnerServerProxyConfigFactoryExtensions
{
}
