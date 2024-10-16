using System.Text;
using RonSijm.FluidHumidifier.Features.Output;

namespace RonSijm.FluidHumidifier.Batch;

public class BatchActionFactory
{
    public void CreateActions(List<EnvironmentOutputResult> environmentOutputResults, CreateEnvironmentConfig config)
    {
        foreach (var environment in environmentOutputResults)
        {
            CreateEnvironmentAction(environment, config);
        }
    }

    public static void CreateEnvironmentAction(EnvironmentOutputResult environment, CreateEnvironmentConfig config)
    {
        var bob = new StringBuilder();

        bob.AppendLine($"@echo off");
        bob.AppendLine($"setlocal enabledelayedexpansion");
        bob.AppendLine();
        bob.AppendLine($"for /f \"tokens=*\" %%i in ('aws sts get-caller-identity --query Account --profile dev --output text') do set ACCOUNT_ID=%%i");
        bob.AppendLine();
        bob.AppendLine($"set EXPECTED_ACCOUNT_ID={environment.Environment.AWSAccountId}");
        bob.AppendLine();
        bob.AppendLine($"REM Compare the retrieved account ID with the expected account ID");
        bob.AppendLine($"if \"%ACCOUNT_ID%\"==\"%EXPECTED_ACCOUNT_ID%\" (");
        bob.AppendLine($"    echo Correct AWS account: %ACCOUNT_ID%");
        bob.AppendLine($") else (");
        bob.AppendLine($"    echo Incorrect AWS account: %ACCOUNT_ID%");
        bob.AppendLine($"    echo Expected AWS account: %EXPECTED_ACCOUNT_ID%");
        bob.AppendLine($"    pause");
        bob.AppendLine($"    exit");
        bob.AppendLine($")");
        bob.AppendLine();

        foreach (var stack in environment.Stacks)
        {
            if (stack is not StackOutputResult stackOutputResult)
            {
                continue;
            }

            bob.AppendLine($"echo {stackOutputResult.Result.Name}");
            bob.AppendLine();
            bob.AppendLine($"cd {stack.BaseDir}{stack.RelativePath}");
            bob.AppendLine();
            bob.AppendLine($"call aws cloudformation deploy ^");
            bob.AppendLine($"    --profile dev ^");
            bob.AppendLine($"    --stack-name {stack.Name} ^");
            bob.AppendLine($"    --template-file \"./{stack.FileName}\" ^");
            bob.AppendLine($"    --region {environment.Environment.Region} ^");
            bob.AppendLine($"    --capabilities CAPABILITY_NAMED_IAM");
        }


        bob.AppendLine();
        bob.AppendLine("endlocal");

        var result = bob.ToString();
        File.WriteAllText(config.OutputDir + $"\\deploy-cf-{environment.Environment.EnvironmentName}.bat", result);
    }
}