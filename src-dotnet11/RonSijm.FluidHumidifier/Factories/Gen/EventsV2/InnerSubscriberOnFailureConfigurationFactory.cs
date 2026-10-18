// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class InnerSubscriberOnFailureConfigurationFactory(Action<Humidifier.EventsV2.SubscriberTypes.OnFailureConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EventsV2.SubscriberTypes.OnFailureConfiguration>
{

    protected override Humidifier.EventsV2.SubscriberTypes.OnFailureConfiguration Create()
    {
        var onFailureConfigurationResult = CreateOnFailureConfiguration();
        factoryAction?.Invoke(onFailureConfigurationResult);

        return onFailureConfigurationResult;
    }

    private Humidifier.EventsV2.SubscriberTypes.OnFailureConfiguration CreateOnFailureConfiguration()
    {
        var onFailureConfigurationResult = new Humidifier.EventsV2.SubscriberTypes.OnFailureConfiguration();

        return onFailureConfigurationResult;
    }

} // End Of Class

public static class InnerSubscriberOnFailureConfigurationFactoryExtensions
{
}
