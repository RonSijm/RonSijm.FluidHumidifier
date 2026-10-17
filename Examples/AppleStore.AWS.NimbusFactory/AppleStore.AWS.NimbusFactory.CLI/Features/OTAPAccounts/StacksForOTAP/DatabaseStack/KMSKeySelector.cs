using Humidifier.Helpers;

namespace AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.DatabaseStack;

public static class KMSKeySelector
{
    public static string GetKMSKeyArm(this EnvironmentConfig environment, string region)
    {
        return GetKMSKeyArm(environment.EnvironmentName, region);
    }

    public static string GetKMSKeyArm(string environment, string region)
    {
        if (environment == "dev")
        {
            if (region == "eu-central-1")
            {
                return "arn:aws:kms:eu-central-1:333333333333:key/mrk-00000000000000000000000000000001";
            }
            
            if (region == "eu-west-3")
            {
                return "arn:aws:kms:eu-west-3:333333333333:key/mrk-00000000000000000000000000000001";
            }

            throw new NotImplementedException();
        }

        if (environment == "staging")
        {
            if (region == "eu-central-1")
            {
                return "arn:aws:kms:eu-central-1:444444444444:key/mrk-00000000000000000000000000000002";
            }

            if (region == "eu-west-3")
            {
                return "arn:aws:kms:eu-west-3:444444444444:key/mrk-00000000000000000000000000000002";
            }

            throw new NotImplementedException();
        }

        if (environment == "prod")
        {
            if (region == "eu-central-1")
            {
                return "arn:aws:kms:eu-central-1:666666666666:key/mrk-00000000000000000000000000000003";
            }

            if (region == "eu-west-3")
            {
                return "arn:aws:kms:eu-west-3:666666666666:key/mrk-00000000000000000000000000000003";
            }
        }

        throw new NotImplementedException();
    }
}
