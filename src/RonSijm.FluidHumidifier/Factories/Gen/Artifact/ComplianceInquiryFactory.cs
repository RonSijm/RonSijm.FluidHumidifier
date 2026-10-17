// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Artifact;

public class ComplianceInquiryFactory(string resourceName = null, Action<Humidifier.Artifact.ComplianceInquiry> factoryAction = null) : ResourceFactory<Humidifier.Artifact.ComplianceInquiry>(resourceName)
{

    protected override Humidifier.Artifact.ComplianceInquiry Create()
    {
        var complianceInquiryResult = CreateComplianceInquiry();
        factoryAction?.Invoke(complianceInquiryResult);

        return complianceInquiryResult;
    }

    private Humidifier.Artifact.ComplianceInquiry CreateComplianceInquiry()
    {
        var complianceInquiryResult = new Humidifier.Artifact.ComplianceInquiry
        {
            GivenName = InputResourceName,
        };

        return complianceInquiryResult;
    }

} // End Of Class

public static class ComplianceInquiryFactoryExtensions
{
}
