// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmazonMQ;

public class InnerBrokerConfigurationIdFactory(Action<Humidifier.AmazonMQ.BrokerTypes.ConfigurationId> factoryAction = null) : SubResourceFactory<Humidifier.AmazonMQ.BrokerTypes.ConfigurationId>
{

    protected override Humidifier.AmazonMQ.BrokerTypes.ConfigurationId Create()
    {
        var configurationIdResult = CreateConfigurationId();
        factoryAction?.Invoke(configurationIdResult);

        return configurationIdResult;
    }

    private Humidifier.AmazonMQ.BrokerTypes.ConfigurationId CreateConfigurationId()
    {
        var configurationIdResult = new Humidifier.AmazonMQ.BrokerTypes.ConfigurationId();

        return configurationIdResult;
    }

} // End Of Class

public static class InnerBrokerConfigurationIdFactoryExtensions
{
}
