namespace RonSijm.FluidHumidifier.Features.Helpers;

public class AWSPrincipleHelper
{
    public static PolicyPrincipal CreateRole(string accountId, string role)
    {
        var result = new PolicyPrincipal
        {
            AWS = $"arn:aws:iam::{accountId}:role/{role}"
        };

        return result;
    }

    public static PolicyPrincipal CreateRoot(string accountId)
    {
        var result = new PolicyPrincipal
        {
            AWS = $"arn:aws:iam::{accountId}:root"
        };

        return result;
    }
}