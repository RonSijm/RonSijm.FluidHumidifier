// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerCapacityProviderCapacityProviderScalingConfigFactory(Action<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderScalingConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderScalingConfig>
{

    protected override Humidifier.Lambda.CapacityProviderTypes.CapacityProviderScalingConfig Create()
    {
        var capacityProviderScalingConfigResult = CreateCapacityProviderScalingConfig();
        factoryAction?.Invoke(capacityProviderScalingConfigResult);

        return capacityProviderScalingConfigResult;
    }

    private Humidifier.Lambda.CapacityProviderTypes.CapacityProviderScalingConfig CreateCapacityProviderScalingConfig()
    {
        var capacityProviderScalingConfigResult = new Humidifier.Lambda.CapacityProviderTypes.CapacityProviderScalingConfig();

        return capacityProviderScalingConfigResult;
    }

} // End Of Class

public static class InnerCapacityProviderCapacityProviderScalingConfigFactoryExtensions
{
}
