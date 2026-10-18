// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Redshift;

public class InnerScheduledActionResumeClusterMessageFactory(Action<Humidifier.Redshift.ScheduledActionTypes.ResumeClusterMessage> factoryAction = null) : SubResourceFactory<Humidifier.Redshift.ScheduledActionTypes.ResumeClusterMessage>
{

    protected override Humidifier.Redshift.ScheduledActionTypes.ResumeClusterMessage Create()
    {
        var resumeClusterMessageResult = CreateResumeClusterMessage();
        factoryAction?.Invoke(resumeClusterMessageResult);

        return resumeClusterMessageResult;
    }

    private Humidifier.Redshift.ScheduledActionTypes.ResumeClusterMessage CreateResumeClusterMessage()
    {
        var resumeClusterMessageResult = new Humidifier.Redshift.ScheduledActionTypes.ResumeClusterMessage();

        return resumeClusterMessageResult;
    }

} // End Of Class

public static class InnerScheduledActionResumeClusterMessageFactoryExtensions
{
}
