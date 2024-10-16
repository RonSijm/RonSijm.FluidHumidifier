// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelFeatureActivationsFactory(Action<Humidifier.MediaLive.ChannelTypes.FeatureActivations> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.FeatureActivations>
{

    protected override Humidifier.MediaLive.ChannelTypes.FeatureActivations Create()
    {
        var featureActivationsResult = CreateFeatureActivations();
        factoryAction?.Invoke(featureActivationsResult);

        return featureActivationsResult;
    }

    private Humidifier.MediaLive.ChannelTypes.FeatureActivations CreateFeatureActivations()
    {
        var featureActivationsResult = new Humidifier.MediaLive.ChannelTypes.FeatureActivations();

        return featureActivationsResult;
    }

} // End Of Class

public static class InnerChannelFeatureActivationsFactoryExtensions
{
}
