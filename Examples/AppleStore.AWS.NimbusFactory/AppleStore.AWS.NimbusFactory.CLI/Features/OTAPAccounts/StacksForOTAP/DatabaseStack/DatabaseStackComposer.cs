using Humidifier.Backup.BackupPlanTypes;
using RonSijm.FluidHumidifier.Factories.Backup;

namespace AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.DatabaseStack;

public class DatabaseStackComposer : BaseStackComposer<DatabaseStackConfig>
{
    public override StackCreateResult Create(DatabaseStackConfig config)
    {
        var environmentFactory = CreateEnvironmentFactory();

        var stack = environmentFactory.AddStack("PostgreSQL");

        var posgresCluster = stack.WithRDSDBCluster(ResourceConfigSettings.ConceptName, pgConfig =>
        {
            pgConfig.Engine = "aurora-postgresql";
            pgConfig.EngineVersion = "13.13";
            pgConfig.EngineMode = "provisioned";
            pgConfig.EnableIAMDatabaseAuthentication = false;
            pgConfig.DeletionProtection = false;
            pgConfig.EnableHttpEndpoint = false;
            pgConfig.BackupRetentionPeriod = 7;
            pgConfig.AvailabilityZones = Fn.GetAZs(Environment.Region);
            pgConfig.MasterUsername = config.DatabaseMasterUsername;
            pgConfig.MasterUserPassword = config.DatabaseMasterUserPassword;
            pgConfig.Port = 5432;
            pgConfig.StorageEncrypted = true;
            pgConfig.DBClusterParameterGroupName = "default.aurora-postgresql13";
            pgConfig.VpcSecurityGroupIds = config.VpcSecurityGroupIds;
            pgConfig.DBSubnetGroupName = config.DBSubnetGroupName;

            // TODO: Maybe put in config
            pgConfig.PreferredBackupWindow = "03:15-03:45";
            pgConfig.PreferredMaintenanceWindow = "thu:04:18-thu:04:48";
        });

        var roleFactory = stack.WithRole($"{Environment.EnvironmentName}-ECR-Monitoring-Role");

        InnerRolePolicyFactory policies = roleFactory.WithPolicies();
        var document = policies.WithDocument();
        document.WithStatement(["logs:CreateLogGroup", "logs:PutRetentionPolicy"], resource: "arn:aws:logs:*:*:log-group:RDS*", sid: "EnableCreationAndManagementOfRDSCloudwatchLogGroups");
        document.WithStatement(["logs:CreateLogStream", "logs:PutLogEvents", "logs:DescribeLogStreams", "logs:GetLogEvents"], resource: "arn:aws:logs:*:*:log-group:RDS*:log-stream:*", sid: "EnableCreationAndManagementOfRDSCloudwatchLogStreams");
        roleFactory.WithAssumeRolePolicy().WithStatement("sts:AssumeRole", principle: new PolicyPrincipal { Service = "monitoring.rds.amazonaws.com" });

        stack.WithRDSDBInstance($"applestore-{Environment.EnvironmentName}-postgres-instance-1", x =>
        {
            x.DBInstanceIdentifier = $"applestore-{Environment.EnvironmentName}-postgres-instance-1";
            x.DBInstanceClass = "db.t3.medium";
            x.Engine = "aurora-postgresql";
            x.AvailabilityZone = Fn.Sub("${AWS::Region}a");
            x.EngineVersion = "13.13";
            x.AutoMinorVersionUpgrade = true;
            x.LicenseModel = "postgresql-license";
            x.PubliclyAccessible = false;
            x.StorageType = "aurora";
            x.DBClusterIdentifier = posgresCluster.FFnREF();
            x.MonitoringInterval = 60;
            x.PromotionTier = 1;
            x.EnablePerformanceInsights = true;
            //x.PerformanceInsightsKMSKeyId = !Sub "arn:aws:kms:${AWS::Region}:${AWS::AccountId}:key/00000000-0000-0000-0000-000000000003";
            x.PerformanceInsightsRetentionPeriod = 31;
            x.DBSubnetGroupName = config.DBSubnetGroupName;
            x.DBParameterGroupName = "default.aurora-postgresql13";
            x.OptionGroupName = "default:aurora-postgresql-13";
            x.StorageEncrypted = true;
            x.MonitoringRoleArn = roleFactory.FFnGetARN();
            //x.CACertificateIdentifier = "rds-ca-rsa2048-g1";
        });

        var defaultRegion = AWSConfigSettings.DefaultRegionName.ToLowerInvariant();

        var backupVault = stack.WithBackupVault($"PostgreSQL-{defaultRegion}-Backup-Vault", bvConfig =>
        {
            bvConfig.BackupVaultName = $"PostgreSQL-{defaultRegion}-Backup-Vault".ToLower();
            bvConfig.EncryptionKeyArn = Environment.GetKMSKeyArm(AWSConfigSettings.DefaultRegion);
        });

        var backupBackupVaultFactory = UnionValue.Unwrap(config.BackupDestinationVault.Value) as FFnImportValue;
        var backupBackupVault = backupBackupVaultFactory.Result.Result;

        var backupPlan = stack.WithBackupPlan("PostgreSQL-BackupPlan")
            .WithBackupPlan_(x =>
            {
                x.BackupPlanName = "PostgreSQL-BackupPlan";
                x.BackupPlanRule = new BackupRuleResourceType[] {
                    new BackupRuleResourceType()
                    {
                        RuleName = "DailyBackup",
                        TargetBackupVault = backupVault.FFnREF(),
                        ScheduleExpression = "cron(0 12 * * ? *)",
                        StartWindowMinutes = Fn.Literal(60),
                        CompletionWindowMinutes = Fn.Literal(10080),
                        Lifecycle = new LifecycleResourceType()
                        {
                            MoveToColdStorageAfterDays = Fn.Literal(7),
                            DeleteAfterDays = Fn.Literal(100)
                        },
                        RecoveryPointTags = new Dictionary<string, string>
                        {
                            { "App", "PostgreSQL-DB" }
                        },
                        CopyActions = new List<CopyActionResourceType>()
                        {
                            new()
                            {
                                Lifecycle = new LifecycleResourceType()
                                {
                                    DeleteAfterDays = Fn.Literal(100)
                                },
                                DestinationBackupVaultArn = $"arn:aws:backup:{AWSConfigSettings.BackupRegion}:{Environment.AWSAccountId}:backup-vault:{backupBackupVault.GivenName}"
                            }
                        }
                    }
                };
            });

        var backupRole = CreateBackupRole(stack);

        var backupSelection = stack.WithBackupSelection("PostgreSQL-BackupSelection", bsConfig =>
        {
            bsConfig.BackupPlanId = backupPlan.T1.FFnREF();
            bsConfig.DependsOn = posgresCluster.FFNamedList();

        }).WithBackupSelection_(x =>
        {
            x.SelectionName = "PostgreSQL-BackupSelection";
            x.IamRoleArn = backupRole.FFnGetARN();
            x.Resources = new List<Union<string, BaseFunction>>
            {
                // TODO: This is a bit fucked up to do. Maybe invent a better function
                posgresCluster.FFnRawFunc(itemName=> $"{{\"Fn::Sub\": \"arn:aws:rds:${{AWS::Region}}:${{AWS::AccountId}}:cluster:${{{itemName}}}\"}}")
            };
        });


        CreateBackupAlarms(config, stack);

        stack.WithRecordSet(record =>
        {
            record.HostedZoneName = $"{Environment.EnvironmentName}-applestore.example.";
            record.Type = "CNAME";
            record.Name = $"database.{Environment.EnvironmentName}-applestore.example";
            record.TTL = Fn.Literal(300);
            record.ResourceRecords = new List<Union<string, BaseFunction>>() { FFn.FFnGetAtt(posgresCluster, "Endpoint.Address") };
        });

        var stackResult = environmentFactory.Build().First();

        return new StackCreateResult
        {
            Stack = stackResult
        };
    }

    private static void CreateBackupAlarms(DatabaseStackConfig config, StackFactory stack)
    {
        stack.WithCloudWatchAlarm("NumberOfBackupJobsCompleted", alarm =>
        {
            alarm.AlarmName = "PostgreSQL-NumberOfBackupJobsCompleted";
            alarm.AlarmDescription = "Alarm for successful backup completion";
            alarm.MetricName = "NumberOfBackupJobsCompleted";
            alarm.Namespace_ = "AWS/Backup";
            alarm.Statistic = "Sum";
            alarm.Period = 30;
            alarm.EvaluationPeriods = 1;
            alarm.Threshold = Fn.Literal(1);
            alarm.ComparisonOperator = "GreaterThanOrEqualToThreshold";
            alarm.ActionsEnabled = true;
            alarm.AlarmActions = config.SlackLoggingTopic;
        });

        stack.WithCloudWatchAlarm("NumberOfBackupJobsFailed", alarm =>
        {
            alarm.AlarmName = "PostgreSQL-NumberOfBackupJobsFailed";
            alarm.AlarmDescription = "Alarm for failed backup completion";
            alarm.MetricName = "NumberOfBackupJobsFailed";
            alarm.Namespace_ = "AWS/Backup";
            alarm.Statistic = "Sum";
            alarm.Period = 30;
            alarm.EvaluationPeriods = 1;
            alarm.Threshold = Fn.Literal(1);
            alarm.ComparisonOperator = "GreaterThanOrEqualToThreshold";
            alarm.ActionsEnabled = true;
            alarm.AlarmActions = config.SlackLoggingTopic;
        });

        stack.WithCloudWatchAlarm("NumberOfRestoreJobsCompleted", alarm =>
        {
            alarm.AlarmName = "PostgreSQL-NumberOfRestoreJobsCompleted";
            alarm.AlarmDescription = "Alarm for successful backup restoration";
            alarm.MetricName = "NumberOfRestoreJobsCompleted";
            alarm.Namespace_ = "AWS/Backup";
            alarm.Statistic = "Sum";
            alarm.Period = 30;
            alarm.EvaluationPeriods = 1;
            alarm.Threshold = Fn.Literal(1);
            alarm.ComparisonOperator = "GreaterThanOrEqualToThreshold";
            alarm.ActionsEnabled = true;
            alarm.AlarmActions = config.SlackLoggingTopic;
        });

        stack.WithCloudWatchAlarm("NumberOfRestoreJobsFailed", alarm =>
        {
            alarm.AlarmName = "PostgreSQL-NumberOfRestoreJobsFailed";
            alarm.AlarmDescription = "Alarm for failed backup restoration";
            alarm.MetricName = "NumberOfRestoreJobsFailed";
            alarm.Namespace_ = "AWS/Backup";
            alarm.Statistic = "Sum";
            alarm.Period = 30;
            alarm.EvaluationPeriods = 1;
            alarm.Threshold = Fn.Literal(1);
            alarm.ComparisonOperator = "GreaterThanOrEqualToThreshold";
            alarm.ActionsEnabled = true;
            alarm.AlarmActions = config.SlackLoggingTopic;
        });
    }

    private static RoleFactory CreateBackupRole(StackFactory stack)
    {
        var backupPolicy = stack.WithManagedPolicy("PostgreSQL-Backup");

        var backupPolicyDocument = backupPolicy.WithDocument();

        backupPolicyDocument.WithStatement([
            "rds:DescribeDBClusters",
            "rds:CreateDBClusterSnapshot",
            "rds:CopyDBClusterSnapshot",
            "rds:ListTagsForResource",
            "rds:AddTagsToResource",
            "rds:RemoveTagsFromResource",
            "rds:CreateDBSnapshot",
            "rds:CopyDBSnapshot",
            "rds:DescribeDBInstances",
            "rds:DescribeDBClusterSnapshots",
            "rds:CopyDBClusterSnapshot"
        ], resource: "*");

        // Creating the backup role
        var backupRole = stack.WithRole("PostgreSQL-BackupRole", roleConfig =>
        {
            roleConfig.MaxSessionDuration = 3600;
            roleConfig.ManagedPolicyArns = new List<Union<string, BaseFunction>> { backupPolicy.FFnREF() };
        });

        backupRole.WithAssumeRolePolicy().WithStatement("sts:AssumeRole", principle: new PolicyPrincipal { Service = "backup.amazonaws.com" });

        return backupRole;
    }
}
