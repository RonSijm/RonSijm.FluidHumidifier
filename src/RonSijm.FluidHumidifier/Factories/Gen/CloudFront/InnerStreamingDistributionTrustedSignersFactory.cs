// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerStreamingDistributionTrustedSignersFactory(Action<Humidifier.CloudFront.StreamingDistributionTypes.TrustedSigners> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.StreamingDistributionTypes.TrustedSigners>
{

    protected override Humidifier.CloudFront.StreamingDistributionTypes.TrustedSigners Create()
    {
        var trustedSignersResult = CreateTrustedSigners();
        factoryAction?.Invoke(trustedSignersResult);

        return trustedSignersResult;
    }

    private Humidifier.CloudFront.StreamingDistributionTypes.TrustedSigners CreateTrustedSigners()
    {
        var trustedSignersResult = new Humidifier.CloudFront.StreamingDistributionTypes.TrustedSigners();

        return trustedSignersResult;
    }

} // End Of Class

public static class InnerStreamingDistributionTrustedSignersFactoryExtensions
{
}
