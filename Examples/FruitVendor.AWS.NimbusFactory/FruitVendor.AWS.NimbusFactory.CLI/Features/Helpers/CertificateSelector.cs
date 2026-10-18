namespace FruitVendor.AWS.NimbusFactory.CLI.Features.Helpers;

public static class CertificateSelector
{
    public static string GetCertificateArnFromRegion(string environmentName)
    {
        throw new NotImplementedException();
    }

    public static string GetCertificateArnFromGlobal(string environmentName)
    {
        if (environmentName == "fruitvendor-prod")
        {
            return "arn:aws:acm:us-east-1:666666666666:certificate/00000000-0000-0000-0000-000000000011";
        }

        throw new NotImplementedException();
    }
}