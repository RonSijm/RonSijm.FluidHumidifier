// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Redshift;

public class InnerScheduledActionPauseClusterMessageFactory(Action<Humidifier.Redshift.ScheduledActionTypes.PauseClusterMessage> factoryAction = null) : SubResourceFactory<Humidifier.Redshift.ScheduledActionTypes.PauseClusterMessage>
{

    protected override Humidifier.Redshift.ScheduledActionTypes.PauseClusterMessage Create()
    {
        var pauseClusterMessageResult = CreatePauseClusterMessage();
        factoryAction?.Invoke(pauseClusterMessageResult);

        return pauseClusterMessageResult;
    }

    private Humidifier.Redshift.ScheduledActionTypes.PauseClusterMessage CreatePauseClusterMessage()
    {
        var pauseClusterMessageResult = new Humidifier.Redshift.ScheduledActionTypes.PauseClusterMessage();

        return pauseClusterMessageResult;
    }

} // End Of Class

public static class InnerScheduledActionPauseClusterMessageFactoryExtensions
{
}
