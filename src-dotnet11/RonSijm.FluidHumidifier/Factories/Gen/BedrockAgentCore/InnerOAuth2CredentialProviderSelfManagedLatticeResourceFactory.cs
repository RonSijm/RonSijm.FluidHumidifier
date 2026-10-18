// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerOAuth2CredentialProviderSelfManagedLatticeResourceFactory(Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SelfManagedLatticeResource> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SelfManagedLatticeResource>
{

    protected override Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SelfManagedLatticeResource Create()
    {
        var selfManagedLatticeResourceResult = CreateSelfManagedLatticeResource();
        factoryAction?.Invoke(selfManagedLatticeResourceResult);

        return selfManagedLatticeResourceResult;
    }

    private Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SelfManagedLatticeResource CreateSelfManagedLatticeResource()
    {
        var selfManagedLatticeResourceResult = new Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SelfManagedLatticeResource();

        return selfManagedLatticeResourceResult;
    }

} // End Of Class

public static class InnerOAuth2CredentialProviderSelfManagedLatticeResourceFactoryExtensions
{
}
