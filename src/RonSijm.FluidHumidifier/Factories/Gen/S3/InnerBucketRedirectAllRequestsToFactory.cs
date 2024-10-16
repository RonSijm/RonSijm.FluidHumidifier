// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketRedirectAllRequestsToFactory(Action<Humidifier.S3.BucketTypes.RedirectAllRequestsTo> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.RedirectAllRequestsTo>
{

    protected override Humidifier.S3.BucketTypes.RedirectAllRequestsTo Create()
    {
        var redirectAllRequestsToResult = CreateRedirectAllRequestsTo();
        factoryAction?.Invoke(redirectAllRequestsToResult);

        return redirectAllRequestsToResult;
    }

    private Humidifier.S3.BucketTypes.RedirectAllRequestsTo CreateRedirectAllRequestsTo()
    {
        var redirectAllRequestsToResult = new Humidifier.S3.BucketTypes.RedirectAllRequestsTo();

        return redirectAllRequestsToResult;
    }

} // End Of Class

public static class InnerBucketRedirectAllRequestsToFactoryExtensions
{
}
