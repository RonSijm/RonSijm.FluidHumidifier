// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerCapacityProviderPermissionsConfigurationFactory(Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.PermissionsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.CapacityProviderTypes.PermissionsConfiguration>
{

    protected override Humidifier.BedrockAgentCore.CapacityProviderTypes.PermissionsConfiguration Create()
    {
        var permissionsConfigurationResult = CreatePermissionsConfiguration();
        factoryAction?.Invoke(permissionsConfigurationResult);

        return permissionsConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.CapacityProviderTypes.PermissionsConfiguration CreatePermissionsConfiguration()
    {
        var permissionsConfigurationResult = new Humidifier.BedrockAgentCore.CapacityProviderTypes.PermissionsConfiguration();

        return permissionsConfigurationResult;
    }

} // End Of Class

public static class InnerCapacityProviderPermissionsConfigurationFactoryExtensions
{
}
