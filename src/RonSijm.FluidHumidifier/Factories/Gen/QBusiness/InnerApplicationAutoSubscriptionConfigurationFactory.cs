// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerApplicationAutoSubscriptionConfigurationFactory(Action<Humidifier.QBusiness.ApplicationTypes.AutoSubscriptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.ApplicationTypes.AutoSubscriptionConfiguration>
{

    protected override Humidifier.QBusiness.ApplicationTypes.AutoSubscriptionConfiguration Create()
    {
        var autoSubscriptionConfigurationResult = CreateAutoSubscriptionConfiguration();
        factoryAction?.Invoke(autoSubscriptionConfigurationResult);

        return autoSubscriptionConfigurationResult;
    }

    private Humidifier.QBusiness.ApplicationTypes.AutoSubscriptionConfiguration CreateAutoSubscriptionConfiguration()
    {
        var autoSubscriptionConfigurationResult = new Humidifier.QBusiness.ApplicationTypes.AutoSubscriptionConfiguration();

        return autoSubscriptionConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationAutoSubscriptionConfigurationFactoryExtensions
{
}
