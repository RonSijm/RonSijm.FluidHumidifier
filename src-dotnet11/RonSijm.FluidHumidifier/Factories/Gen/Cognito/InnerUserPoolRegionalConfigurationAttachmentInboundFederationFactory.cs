// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolRegionalConfigurationAttachmentInboundFederationFactory(Action<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.InboundFederation> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.InboundFederation>
{

    protected override Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.InboundFederation Create()
    {
        var inboundFederationResult = CreateInboundFederation();
        factoryAction?.Invoke(inboundFederationResult);

        return inboundFederationResult;
    }

    private Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.InboundFederation CreateInboundFederation()
    {
        var inboundFederationResult = new Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.InboundFederation();

        return inboundFederationResult;
    }

} // End Of Class

public static class InnerUserPoolRegionalConfigurationAttachmentInboundFederationFactoryExtensions
{
}
