// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerConsentPortalIdpConfigFactory(Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.IdpConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.ConsentPortalTypes.IdpConfig>
{

    protected override Humidifier.BedrockAgentCore.ConsentPortalTypes.IdpConfig Create()
    {
        var idpConfigResult = CreateIdpConfig();
        factoryAction?.Invoke(idpConfigResult);

        return idpConfigResult;
    }

    private Humidifier.BedrockAgentCore.ConsentPortalTypes.IdpConfig CreateIdpConfig()
    {
        var idpConfigResult = new Humidifier.BedrockAgentCore.ConsentPortalTypes.IdpConfig();

        return idpConfigResult;
    }

} // End Of Class

public static class InnerConsentPortalIdpConfigFactoryExtensions
{
}
