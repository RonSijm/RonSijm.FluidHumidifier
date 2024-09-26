// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerResponseHeadersPolicyFrameOptionsFactory(Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.FrameOptions> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.ResponseHeadersPolicyTypes.FrameOptions>
{

    protected override Humidifier.CloudFront.ResponseHeadersPolicyTypes.FrameOptions Create()
    {
        var frameOptionsResult = CreateFrameOptions();
        factoryAction?.Invoke(frameOptionsResult);

        return frameOptionsResult;
    }

    private Humidifier.CloudFront.ResponseHeadersPolicyTypes.FrameOptions CreateFrameOptions()
    {
        var frameOptionsResult = new Humidifier.CloudFront.ResponseHeadersPolicyTypes.FrameOptions();

        return frameOptionsResult;
    }

} // End Of Class

public static class InnerResponseHeadersPolicyFrameOptionsFactoryExtensions
{
}
