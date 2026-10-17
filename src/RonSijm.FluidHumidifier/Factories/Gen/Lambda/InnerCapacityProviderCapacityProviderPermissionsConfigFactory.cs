// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerCapacityProviderCapacityProviderPermissionsConfigFactory(Action<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderPermissionsConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderPermissionsConfig>
{

    protected override Humidifier.Lambda.CapacityProviderTypes.CapacityProviderPermissionsConfig Create()
    {
        var capacityProviderPermissionsConfigResult = CreateCapacityProviderPermissionsConfig();
        factoryAction?.Invoke(capacityProviderPermissionsConfigResult);

        return capacityProviderPermissionsConfigResult;
    }

    private Humidifier.Lambda.CapacityProviderTypes.CapacityProviderPermissionsConfig CreateCapacityProviderPermissionsConfig()
    {
        var capacityProviderPermissionsConfigResult = new Humidifier.Lambda.CapacityProviderTypes.CapacityProviderPermissionsConfig();

        return capacityProviderPermissionsConfigResult;
    }

} // End Of Class

public static class InnerCapacityProviderCapacityProviderPermissionsConfigFactoryExtensions
{
}
