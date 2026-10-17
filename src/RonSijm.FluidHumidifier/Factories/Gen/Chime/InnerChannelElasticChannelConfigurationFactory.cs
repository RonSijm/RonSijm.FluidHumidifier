// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerChannelElasticChannelConfigurationFactory(Action<Humidifier.Chime.ChannelTypes.ElasticChannelConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.ChannelTypes.ElasticChannelConfiguration>
{

    protected override Humidifier.Chime.ChannelTypes.ElasticChannelConfiguration Create()
    {
        var elasticChannelConfigurationResult = CreateElasticChannelConfiguration();
        factoryAction?.Invoke(elasticChannelConfigurationResult);

        return elasticChannelConfigurationResult;
    }

    private Humidifier.Chime.ChannelTypes.ElasticChannelConfiguration CreateElasticChannelConfiguration()
    {
        var elasticChannelConfigurationResult = new Humidifier.Chime.ChannelTypes.ElasticChannelConfiguration();

        return elasticChannelConfigurationResult;
    }

} // End Of Class

public static class InnerChannelElasticChannelConfigurationFactoryExtensions
{
}
