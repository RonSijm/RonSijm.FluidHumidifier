using FruitVendor.AWS.NimbusFactory.CLI.Core.Config;
using Humidifier.Backup.BackupPlanTypes;
using RonSijm.FluidHumidifier.Factories.Backup;

namespace FruitVendor.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.DatabaseStack;

public class DatabaseStackComposer : BaseStackComposer<DatabaseStackConfig>
{
    public override StackCreateResult Create(DatabaseStackConfig config)
    {
        var environmentFactory = CreateEnvironmentFactory();

        var stack = environmentFactory.AddStack("MySQL");

        var parameterGroup = stack.WithRDSDBClusterParameterGroup("mysql-custom-parameter-group",group =>
        {
            group.Family = "aurora-mysql8.0";
            group.Description = "Parameter group for fruitvendor.example";
            group.Parameters = new Dictionary<string, object>
            {
                { "lower_case_table_names", "1" },
                { "character_set_server", "utf8mb4" },
                { "collation_server", "utf8mb4_unicode_ci" },
            };
        });

        var mysqlCluster = stack.WithRDSDBCluster(ResourceConfigSettings.ConceptName, mysqlConfig =>
        {
            mysqlConfig.Engine = "aurora-mysql";
            mysqlConfig.EngineVersion = "8.0.mysql_aurora.3.04.0";
            mysqlConfig.EngineMode = "provisioned";
            mysqlConfig.EnableIAMDatabaseAuthentication = false;
            mysqlConfig.DeletionProtection = false;
            mysqlConfig.EnableHttpEndpoint = false;
            mysqlConfig.BackupRetentionPeriod = 7;
            mysqlConfig.AvailabilityZones = Fn.GetAZs(Environment.Region);
            mysqlConfig.MasterUsername = config.DatabaseMasterUsername;
            mysqlConfig.MasterUserPassword = config.DatabaseMasterUserPassword;
            mysqlConfig.Port = 3306;
            mysqlConfig.StorageEncrypted = true;
            mysqlConfig.DBClusterParameterGroupName = FFn.FFnREF(parameterGroup);
            mysqlConfig.VpcSecurityGroupIds = config.VpcSecurityGroupIds;
            mysqlConfig.DBSubnetGroupName = config.DBSubnetGroupName;
            mysqlConfig.PreferredBackupWindow = "03:15-03:45";
            mysqlConfig.PreferredMaintenanceWindow = "thu:04:18-thu:04:48";

        });

        var roleFactory = stack.WithRole($"{Environment.EnvironmentName}-ECR-Monitoring-Role");

        InnerRolePolicyFactory policies = roleFactory.WithPolicies();
        var document = policies.WithDocument();
        document.WithStatement(["logs:CreateLogGroup", "logs:PutRetentionPolicy"], resource: "arn:aws:logs:*:*:log-group:RDS*", sid: "EnableCreationAndManagementOfRDSCloudwatchLogGroups");
        document.WithStatement(["logs:CreateLogStream", "logs:PutLogEvents", "logs:DescribeLogStreams", "logs:GetLogEvents"], resource: "arn:aws:logs:*:*:log-group:RDS*:log-stream:*", sid: "EnableCreationAndManagementOfRDSCloudwatchLogStreams");
        roleFactory.WithAssumeRolePolicy().WithStatement("sts:AssumeRole", principle: new PolicyPrincipal { Service = "monitoring.rds.amazonaws.com" });

        stack.WithRDSDBInstance($"fruitvendor-{Environment.EnvironmentName}-mysql-instance", x =>
        {
            x.DBInstanceIdentifier = $"fruitvendor-{Environment.EnvironmentName}-mysql-instance";
            x.DBInstanceClass = "db.t3.medium";
            x.Engine = "aurora-mysql";
            x.AvailabilityZone = Fn.Sub("${AWS::Region}a");
            x.EngineVersion = "8.0.mysql_aurora.3.04.0";
            x.AutoMinorVersionUpgrade = true;
            x.LicenseModel = "general-public-license";
            x.PubliclyAccessible = false;
            x.StorageType = "aurora";
            x.DBClusterIdentifier = mysqlCluster.FFnREF();
            x.MonitoringInterval = 60;
            x.PromotionTier = 1;
            x.DBSubnetGroupName = config.DBSubnetGroupName;
            x.DBParameterGroupName = "default.aurora-mysql8.0";
            x.OptionGroupName = "default:aurora-mysql-8-0";
            x.StorageEncrypted = true;
            x.MonitoringRoleArn = roleFactory.FFnGetARN();
        });

        var backupVault = stack.WithBackupVault("MyDBInstanceSnapshotCopyToRegion", bvConfig =>
        {
            bvConfig.BackupVaultName = "cross-region-backup-vault";
            bvConfig.EncryptionKeyArn = Environment.GetKMSKeyArm();
        });

        var backupPlan = stack.WithBackupPlan("MySQL-BackupPlan")
            .WithBackupPlan_(x =>
            {
                x.BackupPlanName = "MySQL-BackupPlan";
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
                            { "App", "MySQL-DB" }
                        }
                    }
                };
            });

        var backupRole = CreateBackupRole(stack);

        var backupSelection = stack.WithBackupSelection("MySQL-BackupSelection", bsConfig =>
        {
            bsConfig.BackupPlanId = backupPlan.T1.FFnREF();
            bsConfig.DependsOn = mysqlCluster.FFNamedList();

        }).WithBackupSelection_(x =>
        {
            x.SelectionName = "MySQL-BackupSelection";
            x.IamRoleArn = backupRole.FFnGetARN();
            x.Resources = new List<Union<string, BaseFunction>>
            {
                // TODO: This is a bit fucked up to do. Maybe invent a better function
                mysqlCluster.FFnRawFunc(itemName=> $"{{\"Fn::Sub\": \"arn:aws:rds:${{AWS::Region}}:${{AWS::AccountId}}:cluster:${{{itemName}}}\"}}")
            };
        });


        CreateBackupAlarms(config, stack);

        stack.WithRecordSet(record =>
        {
            record.HostedZoneName = $"fruitvendor.example.";
            record.Type = "CNAME";
            record.Name = $"database.fruitvendor.example";
            record.TTL = Fn.Literal(300);
            record.ResourceRecords = new List<Union<string, BaseFunction>>() { FFn.FFnGetAtt(mysqlCluster, "Endpoint.Address") };
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
            alarm.AlarmName = "MySQL-NumberOfBackupJobsCompleted";
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
            alarm.AlarmName = "MySQL-NumberOfBackupJobsFailed";
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
            alarm.AlarmName = "MySQL-NumberOfRestoreJobsCompleted";
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
            alarm.AlarmName = "MySQL-NumberOfRestoreJobsFailed";
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
        var backupPolicy = stack.WithManagedPolicy("MySQL-Backup");

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
        var backupRole = stack.WithRole("MySQL-BackupRole", roleConfig =>
        {
            roleConfig.MaxSessionDuration = 3600;
            roleConfig.ManagedPolicyArns = new List<Union<string, BaseFunction>> { backupPolicy.FFnREF() };
        });

        backupRole.WithAssumeRolePolicy().WithStatement("sts:AssumeRole", principle: new PolicyPrincipal { Service = "backup.amazonaws.com" });
       
        return backupRole;
    }
}
