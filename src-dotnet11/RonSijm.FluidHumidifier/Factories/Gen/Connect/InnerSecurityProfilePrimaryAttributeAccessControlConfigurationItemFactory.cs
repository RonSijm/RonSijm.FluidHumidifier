// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerSecurityProfilePrimaryAttributeAccessControlConfigurationItemFactory(Action<Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeAccessControlConfigurationItem> factoryAction = null) : SubResourceFactory<Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeAccessControlConfigurationItem>
{

    protected override Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeAccessControlConfigurationItem Create()
    {
        var primaryAttributeAccessControlConfigurationItemResult = CreatePrimaryAttributeAccessControlConfigurationItem();
        factoryAction?.Invoke(primaryAttributeAccessControlConfigurationItemResult);

        return primaryAttributeAccessControlConfigurationItemResult;
    }

    private Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeAccessControlConfigurationItem CreatePrimaryAttributeAccessControlConfigurationItem()
    {
        var primaryAttributeAccessControlConfigurationItemResult = new Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeAccessControlConfigurationItem();

        return primaryAttributeAccessControlConfigurationItemResult;
    }

} // End Of Class

public static class InnerSecurityProfilePrimaryAttributeAccessControlConfigurationItemFactoryExtensions
{
}
