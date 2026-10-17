// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationProjectChannelLabelingConfigurationFactory(Action<Humidifier.Bedrock.DataAutomationProjectTypes.ChannelLabelingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationProjectTypes.ChannelLabelingConfiguration>
{

    protected override Humidifier.Bedrock.DataAutomationProjectTypes.ChannelLabelingConfiguration Create()
    {
        var channelLabelingConfigurationResult = CreateChannelLabelingConfiguration();
        factoryAction?.Invoke(channelLabelingConfigurationResult);

        return channelLabelingConfigurationResult;
    }

    private Humidifier.Bedrock.DataAutomationProjectTypes.ChannelLabelingConfiguration CreateChannelLabelingConfiguration()
    {
        var channelLabelingConfigurationResult = new Humidifier.Bedrock.DataAutomationProjectTypes.ChannelLabelingConfiguration();

        return channelLabelingConfigurationResult;
    }

} // End Of Class

public static class InnerDataAutomationProjectChannelLabelingConfigurationFactoryExtensions
{
}
