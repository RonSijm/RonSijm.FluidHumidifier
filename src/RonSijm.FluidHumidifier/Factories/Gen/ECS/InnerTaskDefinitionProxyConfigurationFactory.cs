// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskDefinitionProxyConfigurationFactory(Action<Humidifier.ECS.TaskDefinitionTypes.ProxyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskDefinitionTypes.ProxyConfiguration>
{

    protected override Humidifier.ECS.TaskDefinitionTypes.ProxyConfiguration Create()
    {
        var proxyConfigurationResult = CreateProxyConfiguration();
        factoryAction?.Invoke(proxyConfigurationResult);

        return proxyConfigurationResult;
    }

    private Humidifier.ECS.TaskDefinitionTypes.ProxyConfiguration CreateProxyConfiguration()
    {
        var proxyConfigurationResult = new Humidifier.ECS.TaskDefinitionTypes.ProxyConfiguration();

        return proxyConfigurationResult;
    }

} // End Of Class

public static class InnerTaskDefinitionProxyConfigurationFactoryExtensions
{
}
