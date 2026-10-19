// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerConsentPortalConsentPortalSourceFactory(Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.ConsentPortalSource> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.ConsentPortalTypes.ConsentPortalSource>
{

    protected override Humidifier.BedrockAgentCore.ConsentPortalTypes.ConsentPortalSource Create()
    {
        var consentPortalSourceResult = CreateConsentPortalSource();
        factoryAction?.Invoke(consentPortalSourceResult);

        return consentPortalSourceResult;
    }

    private Humidifier.BedrockAgentCore.ConsentPortalTypes.ConsentPortalSource CreateConsentPortalSource()
    {
        var consentPortalSourceResult = new Humidifier.BedrockAgentCore.ConsentPortalTypes.ConsentPortalSource();

        return consentPortalSourceResult;
    }

} // End Of Class

public static class InnerConsentPortalConsentPortalSourceFactoryExtensions
{
}
