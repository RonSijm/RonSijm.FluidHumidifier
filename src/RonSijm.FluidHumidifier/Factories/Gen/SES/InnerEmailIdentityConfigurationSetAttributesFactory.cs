// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerEmailIdentityConfigurationSetAttributesFactory(Action<Humidifier.SES.EmailIdentityTypes.ConfigurationSetAttributes> factoryAction = null) : SubResourceFactory<Humidifier.SES.EmailIdentityTypes.ConfigurationSetAttributes>
{

    protected override Humidifier.SES.EmailIdentityTypes.ConfigurationSetAttributes Create()
    {
        var configurationSetAttributesResult = CreateConfigurationSetAttributes();
        factoryAction?.Invoke(configurationSetAttributesResult);

        return configurationSetAttributesResult;
    }

    private Humidifier.SES.EmailIdentityTypes.ConfigurationSetAttributes CreateConfigurationSetAttributes()
    {
        var configurationSetAttributesResult = new Humidifier.SES.EmailIdentityTypes.ConfigurationSetAttributes();

        return configurationSetAttributesResult;
    }

} // End Of Class

public static class InnerEmailIdentityConfigurationSetAttributesFactoryExtensions
{
}
