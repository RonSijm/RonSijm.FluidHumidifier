using AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.DatabaseStack;

namespace AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.DatabaseCrossRegionBackupStack;

public class CrossRegionBackupStackComposer : BaseStackComposer<CrossRegionBackupStackConfig>
{
    public override StackCreateResult Create(CrossRegionBackupStackConfig config)
    {
        var environmentFactory = CreateEnvironmentFactory();

        var backupRegionName = AWSConfigSettings.BackupRegionName.ToLower();

        var stack = environmentFactory.AddStack($"PostgreSQL-{backupRegionName}-Backup");

        var backupVault = stack.WithBackupVault($"PostgreSQL-{backupRegionName}-Backup-Vault", bvConfig =>
        {
            bvConfig.BackupVaultName = $"PostgreSQL-{backupRegionName}-Backup-Vault".ToLower();
            bvConfig.EncryptionKeyArn = Environment.GetKMSKeyArm(AWSConfigSettings.BackupRegion);
        });

        var export = new ExportModel { backupVault };

        var stackResult = environmentFactory.Build().First();

        return new StackCreateResult
        {
            Stack = stackResult,
            Region = AWSConfigSettings.BackupRegion,
            Export = export
        };
    }
}

