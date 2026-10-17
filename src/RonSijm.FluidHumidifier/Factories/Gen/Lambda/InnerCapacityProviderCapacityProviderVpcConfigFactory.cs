// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerCapacityProviderCapacityProviderVpcConfigFactory(Action<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderVpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderVpcConfig>
{

    protected override Humidifier.Lambda.CapacityProviderTypes.CapacityProviderVpcConfig Create()
    {
        var capacityProviderVpcConfigResult = CreateCapacityProviderVpcConfig();
        factoryAction?.Invoke(capacityProviderVpcConfigResult);

        return capacityProviderVpcConfigResult;
    }

    private Humidifier.Lambda.CapacityProviderTypes.CapacityProviderVpcConfig CreateCapacityProviderVpcConfig()
    {
        var capacityProviderVpcConfigResult = new Humidifier.Lambda.CapacityProviderTypes.CapacityProviderVpcConfig();

        return capacityProviderVpcConfigResult;
    }

} // End Of Class

public static class InnerCapacityProviderCapacityProviderVpcConfigFactoryExtensions
{
}
