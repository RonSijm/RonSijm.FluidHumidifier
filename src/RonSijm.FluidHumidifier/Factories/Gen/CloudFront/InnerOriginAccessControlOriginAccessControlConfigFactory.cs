// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerOriginAccessControlOriginAccessControlConfigFactory(Action<Humidifier.CloudFront.OriginAccessControlTypes.OriginAccessControlConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.OriginAccessControlTypes.OriginAccessControlConfig>
{

    protected override Humidifier.CloudFront.OriginAccessControlTypes.OriginAccessControlConfig Create()
    {
        var originAccessControlConfigResult = CreateOriginAccessControlConfig();
        factoryAction?.Invoke(originAccessControlConfigResult);

        return originAccessControlConfigResult;
    }

    private Humidifier.CloudFront.OriginAccessControlTypes.OriginAccessControlConfig CreateOriginAccessControlConfig()
    {
        var originAccessControlConfigResult = new Humidifier.CloudFront.OriginAccessControlTypes.OriginAccessControlConfig();

        return originAccessControlConfigResult;
    }

} // End Of Class

public static class InnerOriginAccessControlOriginAccessControlConfigFactoryExtensions
{
}
