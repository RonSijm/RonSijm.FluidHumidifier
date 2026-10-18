// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerCapacityProviderAcceleratorTotalMemoryMiBRequestFactory(Action<Humidifier.ECS.CapacityProviderTypes.AcceleratorTotalMemoryMiBRequest> factoryAction = null) : SubResourceFactory<Humidifier.ECS.CapacityProviderTypes.AcceleratorTotalMemoryMiBRequest>
{

    protected override Humidifier.ECS.CapacityProviderTypes.AcceleratorTotalMemoryMiBRequest Create()
    {
        var acceleratorTotalMemoryMiBRequestResult = CreateAcceleratorTotalMemoryMiBRequest();
        factoryAction?.Invoke(acceleratorTotalMemoryMiBRequestResult);

        return acceleratorTotalMemoryMiBRequestResult;
    }

    private Humidifier.ECS.CapacityProviderTypes.AcceleratorTotalMemoryMiBRequest CreateAcceleratorTotalMemoryMiBRequest()
    {
        var acceleratorTotalMemoryMiBRequestResult = new Humidifier.ECS.CapacityProviderTypes.AcceleratorTotalMemoryMiBRequest();

        return acceleratorTotalMemoryMiBRequestResult;
    }

} // End Of Class

public static class InnerCapacityProviderAcceleratorTotalMemoryMiBRequestFactoryExtensions
{
}
