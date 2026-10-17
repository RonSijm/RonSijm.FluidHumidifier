// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerCapacityProviderMemoryMiBRequestFactory(Action<Humidifier.ECS.CapacityProviderTypes.MemoryMiBRequest> factoryAction = null) : SubResourceFactory<Humidifier.ECS.CapacityProviderTypes.MemoryMiBRequest>
{

    protected override Humidifier.ECS.CapacityProviderTypes.MemoryMiBRequest Create()
    {
        var memoryMiBRequestResult = CreateMemoryMiBRequest();
        factoryAction?.Invoke(memoryMiBRequestResult);

        return memoryMiBRequestResult;
    }

    private Humidifier.ECS.CapacityProviderTypes.MemoryMiBRequest CreateMemoryMiBRequest()
    {
        var memoryMiBRequestResult = new Humidifier.ECS.CapacityProviderTypes.MemoryMiBRequest();

        return memoryMiBRequestResult;
    }

} // End Of Class

public static class InnerCapacityProviderMemoryMiBRequestFactoryExtensions
{
}
