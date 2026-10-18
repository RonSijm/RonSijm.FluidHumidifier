// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmazonMQ;

public class InnerBrokerEncryptionOptionsFactory(Action<Humidifier.AmazonMQ.BrokerTypes.EncryptionOptions> factoryAction = null) : SubResourceFactory<Humidifier.AmazonMQ.BrokerTypes.EncryptionOptions>
{

    protected override Humidifier.AmazonMQ.BrokerTypes.EncryptionOptions Create()
    {
        var encryptionOptionsResult = CreateEncryptionOptions();
        factoryAction?.Invoke(encryptionOptionsResult);

        return encryptionOptionsResult;
    }

    private Humidifier.AmazonMQ.BrokerTypes.EncryptionOptions CreateEncryptionOptions()
    {
        var encryptionOptionsResult = new Humidifier.AmazonMQ.BrokerTypes.EncryptionOptions();

        return encryptionOptionsResult;
    }

} // End Of Class

public static class InnerBrokerEncryptionOptionsFactoryExtensions
{
}
