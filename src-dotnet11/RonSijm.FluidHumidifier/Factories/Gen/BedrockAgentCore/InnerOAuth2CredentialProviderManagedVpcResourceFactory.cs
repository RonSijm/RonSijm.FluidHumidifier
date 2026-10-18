// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerOAuth2CredentialProviderManagedVpcResourceFactory(Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.ManagedVpcResource> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.ManagedVpcResource>
{

    protected override Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.ManagedVpcResource Create()
    {
        var managedVpcResourceResult = CreateManagedVpcResource();
        factoryAction?.Invoke(managedVpcResourceResult);

        return managedVpcResourceResult;
    }

    private Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.ManagedVpcResource CreateManagedVpcResource()
    {
        var managedVpcResourceResult = new Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.ManagedVpcResource();

        return managedVpcResourceResult;
    }

} // End Of Class

public static class InnerOAuth2CredentialProviderManagedVpcResourceFactoryExtensions
{
}
