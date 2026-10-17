using Humidifier.Helpers;

namespace AppleStore.AWS.NimbusFactory.CLI.Features.AllAccounts.StacksForAllAccounts.CircleCIUserStack;

public class CircleCIUserStackConfig
{
    public CircleCIUserStackConfig()
    {
        OIDCSafetyPolicyArn = new WithFallback<dynamic>(() => Import.Single(x => x.Result.AWSTypeName == Humidifier.AWS.IAM.ManagedPolicy).ImportValue());
    }

    public ImportModel Import { get; set; }

    public WithFallback<dynamic> OIDCSafetyPolicyArn { get; set; }
    public string CircleCIOrgId { get; set; } = "00000000-0000-0000-0000-000000000001";
    public string CircleCIProjectId { get; set; } = "00000000-0000-0000-0000-000000000002";
    public string Thumbprint { get; set; } = "9e99a48a9960b14926bb7f3b02e22da2b0ab7280";

    public bool UseFineTunedPolicy { get; set; }
}