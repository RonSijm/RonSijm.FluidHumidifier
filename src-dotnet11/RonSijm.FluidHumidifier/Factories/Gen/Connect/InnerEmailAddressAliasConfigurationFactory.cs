// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerEmailAddressAliasConfigurationFactory(Action<Humidifier.Connect.EmailAddressTypes.AliasConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Connect.EmailAddressTypes.AliasConfiguration>
{

    protected override Humidifier.Connect.EmailAddressTypes.AliasConfiguration Create()
    {
        var aliasConfigurationResult = CreateAliasConfiguration();
        factoryAction?.Invoke(aliasConfigurationResult);

        return aliasConfigurationResult;
    }

    private Humidifier.Connect.EmailAddressTypes.AliasConfiguration CreateAliasConfiguration()
    {
        var aliasConfigurationResult = new Humidifier.Connect.EmailAddressTypes.AliasConfiguration();

        return aliasConfigurationResult;
    }

} // End Of Class

public static class InnerEmailAddressAliasConfigurationFactoryExtensions
{
}
