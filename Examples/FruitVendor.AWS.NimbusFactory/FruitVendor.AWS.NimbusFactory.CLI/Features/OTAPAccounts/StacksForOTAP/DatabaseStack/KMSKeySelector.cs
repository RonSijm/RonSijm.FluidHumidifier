namespace FruitVendor.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.DatabaseStack;

public static class KMSKeySelector
{
    public static string GetKMSKeyArm(this EnvironmentConfig environment)
    {
        return GetKMSKeyArm(environment.EnvironmentName);
    }

    public static string GetKMSKeyArm(string environment)
    {
        if (environment == "dev")
        {
            return "arn:aws:kms:eu-central-1:333333333333:key/mrk-00000000000000000000000000000001";
        }

        if (environment == "staging")
        {
            return "arn:aws:kms:eu-central-1:444444444444:key/mrk-00000000000000000000000000000002";
        }

        if (environment == "prod")
        {
            return "arn:aws:kms:eu-central-1:666666666666:key/mrk-00000000000000000000000000000003";
        }

        if (environment == "fruitvendor-prod")
        {
            return "arn:aws:kms:eu-central-1:666666666666:key/mrk-00000000000000000000000000000004";
        }

        throw new NotImplementedException();
    }
}