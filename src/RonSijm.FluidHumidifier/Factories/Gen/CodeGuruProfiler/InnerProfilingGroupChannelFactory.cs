// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeGuruProfiler;

public class InnerProfilingGroupChannelFactory(Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.Channel> factoryAction = null) : SubResourceFactory<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.Channel>
{

    protected override Humidifier.CodeGuruProfiler.ProfilingGroupTypes.Channel Create()
    {
        var channelResult = CreateChannel();
        factoryAction?.Invoke(channelResult);

        return channelResult;
    }

    private Humidifier.CodeGuruProfiler.ProfilingGroupTypes.Channel CreateChannel()
    {
        var channelResult = new Humidifier.CodeGuruProfiler.ProfilingGroupTypes.Channel();

        return channelResult;
    }

} // End Of Class

public static class InnerProfilingGroupChannelFactoryExtensions
{
}
