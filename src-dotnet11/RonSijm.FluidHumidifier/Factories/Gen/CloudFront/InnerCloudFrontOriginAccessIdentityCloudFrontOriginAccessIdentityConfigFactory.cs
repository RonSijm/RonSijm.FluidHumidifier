// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerCloudFrontOriginAccessIdentityCloudFrontOriginAccessIdentityConfigFactory(Action<Humidifier.CloudFront.CloudFrontOriginAccessIdentityTypes.CloudFrontOriginAccessIdentityConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.CloudFrontOriginAccessIdentityTypes.CloudFrontOriginAccessIdentityConfig>
{

    protected override Humidifier.CloudFront.CloudFrontOriginAccessIdentityTypes.CloudFrontOriginAccessIdentityConfig Create()
    {
        var cloudFrontOriginAccessIdentityConfigResult = CreateCloudFrontOriginAccessIdentityConfig();
        factoryAction?.Invoke(cloudFrontOriginAccessIdentityConfigResult);

        return cloudFrontOriginAccessIdentityConfigResult;
    }

    private Humidifier.CloudFront.CloudFrontOriginAccessIdentityTypes.CloudFrontOriginAccessIdentityConfig CreateCloudFrontOriginAccessIdentityConfig()
    {
        var cloudFrontOriginAccessIdentityConfigResult = new Humidifier.CloudFront.CloudFrontOriginAccessIdentityTypes.CloudFrontOriginAccessIdentityConfig();

        return cloudFrontOriginAccessIdentityConfigResult;
    }

} // End Of Class

public static class InnerCloudFrontOriginAccessIdentityCloudFrontOriginAccessIdentityConfigFactoryExtensions
{
}
