// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transcribe;

public class InnerCallAnalyticsJobChannelDefinitionFactory(Action<Humidifier.Transcribe.CallAnalyticsJobTypes.ChannelDefinition> factoryAction = null) : SubResourceFactory<Humidifier.Transcribe.CallAnalyticsJobTypes.ChannelDefinition>
{

    protected override Humidifier.Transcribe.CallAnalyticsJobTypes.ChannelDefinition Create()
    {
        var channelDefinitionResult = CreateChannelDefinition();
        factoryAction?.Invoke(channelDefinitionResult);

        return channelDefinitionResult;
    }

    private Humidifier.Transcribe.CallAnalyticsJobTypes.ChannelDefinition CreateChannelDefinition()
    {
        var channelDefinitionResult = new Humidifier.Transcribe.CallAnalyticsJobTypes.ChannelDefinition();

        return channelDefinitionResult;
    }

} // End Of Class

public static class InnerCallAnalyticsJobChannelDefinitionFactoryExtensions
{
}
