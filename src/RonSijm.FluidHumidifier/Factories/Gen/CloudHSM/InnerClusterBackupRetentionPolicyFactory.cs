// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudHSM;

public class InnerClusterBackupRetentionPolicyFactory(Action<Humidifier.CloudHSM.ClusterTypes.BackupRetentionPolicy> factoryAction = null) : SubResourceFactory<Humidifier.CloudHSM.ClusterTypes.BackupRetentionPolicy>
{

    protected override Humidifier.CloudHSM.ClusterTypes.BackupRetentionPolicy Create()
    {
        var backupRetentionPolicyResult = CreateBackupRetentionPolicy();
        factoryAction?.Invoke(backupRetentionPolicyResult);

        return backupRetentionPolicyResult;
    }

    private Humidifier.CloudHSM.ClusterTypes.BackupRetentionPolicy CreateBackupRetentionPolicy()
    {
        var backupRetentionPolicyResult = new Humidifier.CloudHSM.ClusterTypes.BackupRetentionPolicy();

        return backupRetentionPolicyResult;
    }

} // End Of Class

public static class InnerClusterBackupRetentionPolicyFactoryExtensions
{
}
