// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityLake;

public class InnerSubscriberSubscriberIdentityFactory(Action<Humidifier.SecurityLake.SubscriberTypes.SubscriberIdentity> factoryAction = null) : SubResourceFactory<Humidifier.SecurityLake.SubscriberTypes.SubscriberIdentity>
{

    protected override Humidifier.SecurityLake.SubscriberTypes.SubscriberIdentity Create()
    {
        var subscriberIdentityResult = CreateSubscriberIdentity();
        factoryAction?.Invoke(subscriberIdentityResult);

        return subscriberIdentityResult;
    }

    private Humidifier.SecurityLake.SubscriberTypes.SubscriberIdentity CreateSubscriberIdentity()
    {
        var subscriberIdentityResult = new Humidifier.SecurityLake.SubscriberTypes.SubscriberIdentity();

        return subscriberIdentityResult;
    }

} // End Of Class

public static class InnerSubscriberSubscriberIdentityFactoryExtensions
{
}
