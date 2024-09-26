// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class PolicyPrincipalAttachmentFactory(string resourceName = null, Action<Humidifier.IoT.PolicyPrincipalAttachment> factoryAction = null) : ResourceFactory<Humidifier.IoT.PolicyPrincipalAttachment>(resourceName)
{

    protected override Humidifier.IoT.PolicyPrincipalAttachment Create()
    {
        var policyPrincipalAttachmentResult = CreatePolicyPrincipalAttachment();
        factoryAction?.Invoke(policyPrincipalAttachmentResult);

        return policyPrincipalAttachmentResult;
    }

    private Humidifier.IoT.PolicyPrincipalAttachment CreatePolicyPrincipalAttachment()
    {
        var policyPrincipalAttachmentResult = new Humidifier.IoT.PolicyPrincipalAttachment
        {
            GivenName = InputResourceName,
        };

        return policyPrincipalAttachmentResult;
    }

} // End Of Class

public static class PolicyPrincipalAttachmentFactoryExtensions
{
}
