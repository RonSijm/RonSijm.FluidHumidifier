using System.Text;
using RonSijm.FluidHumidifier.Features.Output;

namespace RonSijm.FluidHumidifier.Github;

public class GithubActionFactory
{
    public void CreateActions(List<EnvironmentOutputResult> environmentOutputResults, CreateGithubActionConfig config)
    {
        foreach (var environment in environmentOutputResults)
        {
            CreateEnvironmentAction(environment, config);
        }
    }

    public static void CreateEnvironmentAction(EnvironmentOutputResult environment, CreateGithubActionConfig config)
    {
        var bob = new StringBuilder();
        var envNameToUpper = environment.Environment.EnvironmentName.ToUpper();

        bob.AppendLine($"name: 'Auto Deploy {environment.Environment.EnvironmentName} CloudFormation'");
        bob.AppendLine("");
        bob.AppendLine("on:");
        bob.AppendLine("  push:");
        bob.AppendLine("    branches:");

        var branches = config.BranchName(environment.Environment.EnvironmentName);

        bob.AppendLine($"      - {branches}");
        bob.AppendLine("    paths:");

        foreach (var stack in environment.Stacks.Where(stack => stack is StackOutputResult))
        {
            bob.AppendLine($"      - \"{stack.LinuxRelativePath}/{stack.FileName}\"");
        }

        if (config.AddManualDispatch)
        {
            bob.AppendLine("  workflow_dispatch:");
        }

        bob.AppendLine("     ");
        bob.AppendLine("jobs:");
        bob.AppendLine("  cluster:");
        bob.AppendLine($"    name: Deploy {environment.Environment.EnvironmentName} Stack to AWS");
        bob.AppendLine("    runs-on: ubuntu-latest");

        if (!config.UseIAM)
        {
            bob.AppendLine("    permissions:");
            bob.AppendLine("      id-token: write");
            bob.AppendLine("      contents: read");
        }

        bob.AppendLine("    steps:");
        bob.AppendLine("    - name: Checkout");
        bob.AppendLine("      uses: actions/checkout@v2");
        bob.AppendLine();

        bob.AppendLine("    - name: Configure AWS credentials");
        if (config.UseIAM)
        {
            bob.AppendLine("      id: creds");
            bob.AppendLine("      uses: aws-actions/configure-aws-credentials@v1");
            bob.AppendLine("      with:");
            bob.AppendLine($"        aws-access-key-id: ${{{{ secrets.AWS_{envNameToUpper}_ACCESS_KEY_ID }}}}");
            bob.AppendLine($"        aws-secret-access-key: ${{{{ secrets.AWS_{envNameToUpper}_SECRET_ACCESS_KEY }}}}");
            bob.AppendLine($"        aws-region: {environment.RegionName}");
            bob.AppendLine();
        }
        else
        {
            bob.AppendLine("      uses: aws-actions/configure-aws-credentials@v3");
            bob.AppendLine("      with:");
            bob.AppendLine($"        role-to-assume: arn:aws:iam::{environment.Environment.AWSAccountId}:role/GitHub_Actions_Role");
            bob.AppendLine("        aws-region: eu-central-1");
            bob.AppendLine("    - name: Fetch the caller identity");
            bob.AppendLine("      run: |");
            bob.AppendLine("        aws sts get-caller-identity");
        }

        for (var index = 1; index <= environment.Stacks.Count; index++)
        {
            var stack = environment.Stacks[index - 1];

            if (stack is not StackOutputResult)
            {
                continue;
            }

            bob.AppendLine($"    - name: {stack.Description}");
            bob.AppendLine($"      id: {stack.Name}");
            bob.AppendLine("      uses: aws-actions/aws-cloudformation-github-deploy@master");
            bob.AppendLine("      with:");
            bob.AppendLine($"        name: {stack.Name}");
            bob.AppendLine($"        template: \"{stack.LinuxRelativePath}/{stack.FileName}\"");

            if (config.NoFailOnEmptyChangeset)
            {
                bob.AppendLine("        no-fail-on-empty-changeset: \"1\"");
            }

            if (config.DisableRoleBack)
            {
                bob.AppendLine("        disable-rollback: \"1\"");
            }

            bob.AppendLine($"        capabilities: {config.Capabilities}");

            if (config.WithNotifications != null)
            {
                if (index > config.StartNotificationsAtStack)
                {
                    var notificationArn = config.WithNotifications(environment.Environment);
                    bob.AppendLine($"        notification-arns: \"{notificationArn}\"");
                }
            }

            bob.AppendLine();
        }

        var result = bob.ToString();

        if (!Directory.Exists(config.OutputDir))
        {
            Directory.CreateDirectory(config.OutputDir);
        }

        File.WriteAllText(config.OutputDir + $"auto-deploy-cf-{environment.Environment.EnvironmentName}.yml", result);
    }
}