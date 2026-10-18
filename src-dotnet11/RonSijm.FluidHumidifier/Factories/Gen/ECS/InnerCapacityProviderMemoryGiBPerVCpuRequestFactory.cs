// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerCapacityProviderMemoryGiBPerVCpuRequestFactory(Action<Humidifier.ECS.CapacityProviderTypes.MemoryGiBPerVCpuRequest> factoryAction = null) : SubResourceFactory<Humidifier.ECS.CapacityProviderTypes.MemoryGiBPerVCpuRequest>
{

    protected override Humidifier.ECS.CapacityProviderTypes.MemoryGiBPerVCpuRequest Create()
    {
        var memoryGiBPerVCpuRequestResult = CreateMemoryGiBPerVCpuRequest();
        factoryAction?.Invoke(memoryGiBPerVCpuRequestResult);

        return memoryGiBPerVCpuRequestResult;
    }

    private Humidifier.ECS.CapacityProviderTypes.MemoryGiBPerVCpuRequest CreateMemoryGiBPerVCpuRequest()
    {
        var memoryGiBPerVCpuRequestResult = new Humidifier.ECS.CapacityProviderTypes.MemoryGiBPerVCpuRequest();

        return memoryGiBPerVCpuRequestResult;
    }

} // End Of Class

public static class InnerCapacityProviderMemoryGiBPerVCpuRequestFactoryExtensions
{
}
