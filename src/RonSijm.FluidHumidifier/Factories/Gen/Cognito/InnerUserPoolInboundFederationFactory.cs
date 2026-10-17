// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolInboundFederationFactory(Action<Humidifier.Cognito.UserPoolTypes.InboundFederation> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolTypes.InboundFederation>
{

    protected override Humidifier.Cognito.UserPoolTypes.InboundFederation Create()
    {
        var inboundFederationResult = CreateInboundFederation();
        factoryAction?.Invoke(inboundFederationResult);

        return inboundFederationResult;
    }

    private Humidifier.Cognito.UserPoolTypes.InboundFederation CreateInboundFederation()
    {
        var inboundFederationResult = new Humidifier.Cognito.UserPoolTypes.InboundFederation();

        return inboundFederationResult;
    }

} // End Of Class

public static class InnerUserPoolInboundFederationFactoryExtensions
{
}
