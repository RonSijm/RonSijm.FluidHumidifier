// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerPipelineChannelFactory(Action<Humidifier.IoTAnalytics.PipelineTypes.Channel> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.PipelineTypes.Channel>
{

    protected override Humidifier.IoTAnalytics.PipelineTypes.Channel Create()
    {
        var channelResult = CreateChannel();
        factoryAction?.Invoke(channelResult);

        return channelResult;
    }

    private Humidifier.IoTAnalytics.PipelineTypes.Channel CreateChannel()
    {
        var channelResult = new Humidifier.IoTAnalytics.PipelineTypes.Channel();

        return channelResult;
    }

} // End Of Class

public static class InnerPipelineChannelFactoryExtensions
{
}
