// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerChannelTimeShiftConfigurationFactory(Action<Humidifier.MediaTailor.ChannelTypes.TimeShiftConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.ChannelTypes.TimeShiftConfiguration>
{

    protected override Humidifier.MediaTailor.ChannelTypes.TimeShiftConfiguration Create()
    {
        var timeShiftConfigurationResult = CreateTimeShiftConfiguration();
        factoryAction?.Invoke(timeShiftConfigurationResult);

        return timeShiftConfigurationResult;
    }

    private Humidifier.MediaTailor.ChannelTypes.TimeShiftConfiguration CreateTimeShiftConfiguration()
    {
        var timeShiftConfigurationResult = new Humidifier.MediaTailor.ChannelTypes.TimeShiftConfiguration();

        return timeShiftConfigurationResult;
    }

} // End Of Class

public static class InnerChannelTimeShiftConfigurationFactoryExtensions
{
}
