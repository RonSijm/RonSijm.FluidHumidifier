// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class TokenVaultFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.TokenVault> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.TokenVault>(resourceName)
{

    protected override Humidifier.BedrockAgentCore.TokenVault Create()
    {
        var tokenVaultResult = CreateTokenVault();
        factoryAction?.Invoke(tokenVaultResult);

        return tokenVaultResult;
    }

    private Humidifier.BedrockAgentCore.TokenVault CreateTokenVault()
    {
        var tokenVaultResult = new Humidifier.BedrockAgentCore.TokenVault
        {
            GivenName = InputResourceName,
        };

        return tokenVaultResult;
    }

} // End Of Class

public static class TokenVaultFactoryExtensions
{
}
