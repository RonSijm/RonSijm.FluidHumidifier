// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerSubscriptionTargetSubscriptionTargetFormFactory(Action<Humidifier.DataZone.SubscriptionTargetTypes.SubscriptionTargetForm> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.SubscriptionTargetTypes.SubscriptionTargetForm>
{

    protected override Humidifier.DataZone.SubscriptionTargetTypes.SubscriptionTargetForm Create()
    {
        var subscriptionTargetFormResult = CreateSubscriptionTargetForm();
        factoryAction?.Invoke(subscriptionTargetFormResult);

        return subscriptionTargetFormResult;
    }

    private Humidifier.DataZone.SubscriptionTargetTypes.SubscriptionTargetForm CreateSubscriptionTargetForm()
    {
        var subscriptionTargetFormResult = new Humidifier.DataZone.SubscriptionTargetTypes.SubscriptionTargetForm();

        return subscriptionTargetFormResult;
    }

} // End Of Class

public static class InnerSubscriptionTargetSubscriptionTargetFormFactoryExtensions
{
}
