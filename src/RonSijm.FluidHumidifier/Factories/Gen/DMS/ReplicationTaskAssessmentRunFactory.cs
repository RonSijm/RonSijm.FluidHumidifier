// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class ReplicationTaskAssessmentRunFactory(string resourceName = null, Action<Humidifier.DMS.ReplicationTaskAssessmentRun> factoryAction = null) : ResourceFactory<Humidifier.DMS.ReplicationTaskAssessmentRun>(resourceName)
{

    protected override Humidifier.DMS.ReplicationTaskAssessmentRun Create()
    {
        var replicationTaskAssessmentRunResult = CreateReplicationTaskAssessmentRun();
        factoryAction?.Invoke(replicationTaskAssessmentRunResult);

        return replicationTaskAssessmentRunResult;
    }

    private Humidifier.DMS.ReplicationTaskAssessmentRun CreateReplicationTaskAssessmentRun()
    {
        var replicationTaskAssessmentRunResult = new Humidifier.DMS.ReplicationTaskAssessmentRun
        {
            GivenName = InputResourceName,
        };

        return replicationTaskAssessmentRunResult;
    }

} // End Of Class

public static class ReplicationTaskAssessmentRunFactoryExtensions
{
}
