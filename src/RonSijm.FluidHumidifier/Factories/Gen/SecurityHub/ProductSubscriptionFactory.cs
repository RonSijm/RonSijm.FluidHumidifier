// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class ProductSubscriptionFactory(string resourceName = null, Action<Humidifier.SecurityHub.ProductSubscription> factoryAction = null) : ResourceFactory<Humidifier.SecurityHub.ProductSubscription>(resourceName)
{

    protected override Humidifier.SecurityHub.ProductSubscription Create()
    {
        var productSubscriptionResult = CreateProductSubscription();
        factoryAction?.Invoke(productSubscriptionResult);

        return productSubscriptionResult;
    }

    private Humidifier.SecurityHub.ProductSubscription CreateProductSubscription()
    {
        var productSubscriptionResult = new Humidifier.SecurityHub.ProductSubscription
        {
            GivenName = InputResourceName,
        };

        return productSubscriptionResult;
    }

} // End Of Class

public static class ProductSubscriptionFactoryExtensions
{
}
