// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerPluginBasicAuthConfigurationFactory(Action<Humidifier.QBusiness.PluginTypes.BasicAuthConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.PluginTypes.BasicAuthConfiguration>
{

    protected override Humidifier.QBusiness.PluginTypes.BasicAuthConfiguration Create()
    {
        var basicAuthConfigurationResult = CreateBasicAuthConfiguration();
        factoryAction?.Invoke(basicAuthConfigurationResult);

        return basicAuthConfigurationResult;
    }

    private Humidifier.QBusiness.PluginTypes.BasicAuthConfiguration CreateBasicAuthConfiguration()
    {
        var basicAuthConfigurationResult = new Humidifier.QBusiness.PluginTypes.BasicAuthConfiguration();

        return basicAuthConfigurationResult;
    }

} // End Of Class

public static class InnerPluginBasicAuthConfigurationFactoryExtensions
{
}
