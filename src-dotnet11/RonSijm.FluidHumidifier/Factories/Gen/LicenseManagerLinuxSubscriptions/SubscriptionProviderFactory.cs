// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManagerLinuxSubscriptions;

public class SubscriptionProviderFactory(string resourceName = null, Action<Humidifier.LicenseManagerLinuxSubscriptions.SubscriptionProvider> factoryAction = null) : ResourceFactory<Humidifier.LicenseManagerLinuxSubscriptions.SubscriptionProvider>(resourceName)
{

    protected override Humidifier.LicenseManagerLinuxSubscriptions.SubscriptionProvider Create()
    {
        var subscriptionProviderResult = CreateSubscriptionProvider();
        factoryAction?.Invoke(subscriptionProviderResult);

        return subscriptionProviderResult;
    }

    private Humidifier.LicenseManagerLinuxSubscriptions.SubscriptionProvider CreateSubscriptionProvider()
    {
        var subscriptionProviderResult = new Humidifier.LicenseManagerLinuxSubscriptions.SubscriptionProvider
        {
            GivenName = InputResourceName,
        };

        return subscriptionProviderResult;
    }

} // End Of Class

public static class SubscriptionProviderFactoryExtensions
{
}
