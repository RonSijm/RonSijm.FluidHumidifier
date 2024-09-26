// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerAliasAliasRoutingConfigurationFactory(Action<Humidifier.Lambda.AliasTypes.AliasRoutingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.AliasTypes.AliasRoutingConfiguration>
{

    protected override Humidifier.Lambda.AliasTypes.AliasRoutingConfiguration Create()
    {
        var aliasRoutingConfigurationResult = CreateAliasRoutingConfiguration();
        factoryAction?.Invoke(aliasRoutingConfigurationResult);

        return aliasRoutingConfigurationResult;
    }

    private Humidifier.Lambda.AliasTypes.AliasRoutingConfiguration CreateAliasRoutingConfiguration()
    {
        var aliasRoutingConfigurationResult = new Humidifier.Lambda.AliasTypes.AliasRoutingConfiguration();

        return aliasRoutingConfigurationResult;
    }

} // End Of Class

public static class InnerAliasAliasRoutingConfigurationFactoryExtensions
{
}
