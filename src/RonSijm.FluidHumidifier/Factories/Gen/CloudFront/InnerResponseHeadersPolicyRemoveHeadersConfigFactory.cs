// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerResponseHeadersPolicyRemoveHeadersConfigFactory(Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.RemoveHeadersConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.ResponseHeadersPolicyTypes.RemoveHeadersConfig>
{

    protected override Humidifier.CloudFront.ResponseHeadersPolicyTypes.RemoveHeadersConfig Create()
    {
        var removeHeadersConfigResult = CreateRemoveHeadersConfig();
        factoryAction?.Invoke(removeHeadersConfigResult);

        return removeHeadersConfigResult;
    }

    private Humidifier.CloudFront.ResponseHeadersPolicyTypes.RemoveHeadersConfig CreateRemoveHeadersConfig()
    {
        var removeHeadersConfigResult = new Humidifier.CloudFront.ResponseHeadersPolicyTypes.RemoveHeadersConfig();

        return removeHeadersConfigResult;
    }

} // End Of Class

public static class InnerResponseHeadersPolicyRemoveHeadersConfigFactoryExtensions
{
}
