// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Redshift;

public class InnerScheduledActionResizeClusterMessageFactory(Action<Humidifier.Redshift.ScheduledActionTypes.ResizeClusterMessage> factoryAction = null) : SubResourceFactory<Humidifier.Redshift.ScheduledActionTypes.ResizeClusterMessage>
{

    protected override Humidifier.Redshift.ScheduledActionTypes.ResizeClusterMessage Create()
    {
        var resizeClusterMessageResult = CreateResizeClusterMessage();
        factoryAction?.Invoke(resizeClusterMessageResult);

        return resizeClusterMessageResult;
    }

    private Humidifier.Redshift.ScheduledActionTypes.ResizeClusterMessage CreateResizeClusterMessage()
    {
        var resizeClusterMessageResult = new Humidifier.Redshift.ScheduledActionTypes.ResizeClusterMessage();

        return resizeClusterMessageResult;
    }

} // End Of Class

public static class InnerScheduledActionResizeClusterMessageFactoryExtensions
{
}
