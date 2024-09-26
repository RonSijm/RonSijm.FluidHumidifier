// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmazonMQ;

public class InnerConfigurationAssociationConfigurationIdFactory(Action<Humidifier.AmazonMQ.ConfigurationAssociationTypes.ConfigurationId> factoryAction = null) : SubResourceFactory<Humidifier.AmazonMQ.ConfigurationAssociationTypes.ConfigurationId>
{

    protected override Humidifier.AmazonMQ.ConfigurationAssociationTypes.ConfigurationId Create()
    {
        var configurationIdResult = CreateConfigurationId();
        factoryAction?.Invoke(configurationIdResult);

        return configurationIdResult;
    }

    private Humidifier.AmazonMQ.ConfigurationAssociationTypes.ConfigurationId CreateConfigurationId()
    {
        var configurationIdResult = new Humidifier.AmazonMQ.ConfigurationAssociationTypes.ConfigurationId();

        return configurationIdResult;
    }

} // End Of Class

public static class InnerConfigurationAssociationConfigurationIdFactoryExtensions
{
}
