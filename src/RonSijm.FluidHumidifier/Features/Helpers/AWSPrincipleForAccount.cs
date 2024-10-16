namespace RonSijm.FluidHumidifier.Features.Helpers;

public class AWSPrincipleHelper
{
    public static dynamic CreateRole(string accountId, string role)
    {
        var result = new
        {
            AWS = $"arn:aws:iam::{accountId}:role/{role}"
        };

        return result;
    }

    public static dynamic CreateRoot(string accountId)
    {
        var result = new
        {
            AWS = $"arn:aws:iam::{accountId}:root"
        };

        return result;
    }
}