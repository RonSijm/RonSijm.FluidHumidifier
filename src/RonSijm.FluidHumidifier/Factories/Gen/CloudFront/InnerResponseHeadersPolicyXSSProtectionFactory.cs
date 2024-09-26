// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerResponseHeadersPolicyXSSProtectionFactory(Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.XSSProtection> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.ResponseHeadersPolicyTypes.XSSProtection>
{

    protected override Humidifier.CloudFront.ResponseHeadersPolicyTypes.XSSProtection Create()
    {
        var xSSProtectionResult = CreateXSSProtection();
        factoryAction?.Invoke(xSSProtectionResult);

        return xSSProtectionResult;
    }

    private Humidifier.CloudFront.ResponseHeadersPolicyTypes.XSSProtection CreateXSSProtection()
    {
        var xSSProtectionResult = new Humidifier.CloudFront.ResponseHeadersPolicyTypes.XSSProtection();

        return xSSProtectionResult;
    }

} // End Of Class

public static class InnerResponseHeadersPolicyXSSProtectionFactoryExtensions
{
}
