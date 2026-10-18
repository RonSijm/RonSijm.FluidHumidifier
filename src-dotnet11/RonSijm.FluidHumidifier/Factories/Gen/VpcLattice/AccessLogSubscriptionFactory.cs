// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class AccessLogSubscriptionFactory(string resourceName = null, Action<Humidifier.VpcLattice.AccessLogSubscription> factoryAction = null) : ResourceFactory<Humidifier.VpcLattice.AccessLogSubscription>(resourceName)
{

    protected override Humidifier.VpcLattice.AccessLogSubscription Create()
    {
        var accessLogSubscriptionResult = CreateAccessLogSubscription();
        factoryAction?.Invoke(accessLogSubscriptionResult);

        return accessLogSubscriptionResult;
    }

    private Humidifier.VpcLattice.AccessLogSubscription CreateAccessLogSubscription()
    {
        var accessLogSubscriptionResult = new Humidifier.VpcLattice.AccessLogSubscription
        {
            GivenName = InputResourceName,
        };

        return accessLogSubscriptionResult;
    }

} // End Of Class

public static class AccessLogSubscriptionFactoryExtensions
{
}
