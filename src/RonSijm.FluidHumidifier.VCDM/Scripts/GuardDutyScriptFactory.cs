using RonSijm.FluidHumidifier.Features.Consumer;
using System.Text;
using RonSijm.FluidHumidifier.VCDM.Config;

namespace RonSijm.FluidHumidifier.VCDM.Scripts
{
    public class GuardDutyScriptFactory : BaseStackComposer
    {
        public string Create(GuardDutyScriptFactoryConfig config)
        {
            var bob = new StringBuilder();

            bob.AppendLine($"@echo off");
            bob.AppendLine($"");
            bob.AppendLine($"setlocal enabledelayedexpansion");
            bob.AppendLine($"");
            bob.AppendLine($"for /f \"tokens=*\" %%i in ('aws sts get-caller-identity --query Account --profile {Environment.EnvironmentName} --output text') do set ACCOUNT_ID=%%i");
            bob.AppendLine($"");
            bob.AppendLine($"set EXPECTED_ACCOUNT_ID={Environment.AWSAccountId}");
            bob.AppendLine($"set \"PROFILE={Environment.EnvironmentName}\"");
            bob.AppendLine($"set \"BUCKET_NAME=aws-{config.ConceptName}-{Environment.EnvironmentName}-logging\"");
            bob.AppendLine($"set \"KMS_KEY_ID=KMS-{Environment.EnvironmentName}-CMK\"");
            bob.AppendLine($"set \"PREFIX={LoggingPrefixConfig.GuardDutyPrefix}\"");
            bob.AppendLine($"");
            bob.AppendLine($"REM Compare the retrieved account ID with the expected account ID");
            bob.AppendLine($"if \"%ACCOUNT_ID%\"==\"%EXPECTED_ACCOUNT_ID%\" (");
            bob.AppendLine($"    echo Correct AWS account: %ACCOUNT_ID%");
            bob.AppendLine($") else (");
            bob.AppendLine($"    echo Incorrect AWS account: %ACCOUNT_ID%");
            bob.AppendLine($"    echo Expected AWS account: %EXPECTED_ACCOUNT_ID%");
            bob.AppendLine($"    pause");
            bob.AppendLine($"    exit");
            bob.AppendLine($")");
            bob.AppendLine($"");

            foreach (var region in config.Regions)
            {
                bob.AppendLine($"REM Check if a GuardDuty detector exists in the {region} region");
                bob.AppendLine($"for /f \"delims=\" %%i in ('aws guardduty list-detectors --profile \"%PROFILE%\" --region {region} --query \"DetectorIds[0]\" --output text') do set \"DETECTOR_ID=%%i\"");
                bob.AppendLine($"");
                bob.AppendLine($"if \"%DETECTOR_ID%\"==\"None\" (");
                bob.AppendLine($"    REM Create a new GuardDuty detector if one doesn't exist in the {region} region");
                bob.AppendLine($"    echo No GuardDuty detector found. Creating a new one...");
                bob.AppendLine($"    for /f \"delims=\" %%i in ('aws guardduty create-detector --profile \"%PROFILE%\" --enable --finding-publishing-frequency FIFTEEN_MINUTES --region {region} --query \"DetectorId\" --output text') do set \"DETECTOR_ID=%%i\"");
                bob.AppendLine($"    echo Created new GuardDuty detector with ID: %DETECTOR_ID% in the {region} region");
                bob.AppendLine($") else (");
                bob.AppendLine($"    echo Existing GuardDuty detector found with ID: %DETECTOR_ID% in the {region} region");
                bob.AppendLine($")");
                bob.AppendLine($"");
                bob.AppendLine($"REM Create publishing destination in the {region} region");
                bob.AppendLine($"aws guardduty create-publishing-destination --profile \"%PROFILE%\" ^");
                bob.AppendLine($"    --detector-id %DETECTOR_ID% ^");
                bob.AppendLine($"    --destination-type S3 ^");
                bob.AppendLine($"    --destination-properties DestinationArn=arn:aws:s3:::%BUCKET_NAME%/%PREFIX%,KmsKeyArn=arn:aws:kms:{config.KMSKeyRegion}:%ACCOUNT_ID%:alias/%KMS_KEY_ID% ^");
                bob.AppendLine($"    --region {region}");
                bob.AppendLine($"");
                bob.AppendLine($"if %errorlevel% neq 0 (");
                bob.AppendLine($"    echo Failed to create publishing destination.");
                bob.AppendLine($"    pause");
                bob.AppendLine($"    exit /b 1");
                bob.AppendLine($")");
                bob.AppendLine($"");
                bob.AppendLine($"echo GuardDuty findings in the {region} region will be published to S3 bucket '%BUCKET_NAME%' with prefix '%PREFIX%'");
            }

            bob.AppendLine($"");
            bob.AppendLine($"pause");
            bob.AppendLine($"");
            bob.AppendLine($"endlocal");

            var result = bob.ToString();

            return result;
        }
    }
}
