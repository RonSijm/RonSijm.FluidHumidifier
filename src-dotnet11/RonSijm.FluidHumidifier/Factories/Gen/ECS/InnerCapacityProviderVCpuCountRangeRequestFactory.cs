// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerCapacityProviderVCpuCountRangeRequestFactory(Action<Humidifier.ECS.CapacityProviderTypes.VCpuCountRangeRequest> factoryAction = null) : SubResourceFactory<Humidifier.ECS.CapacityProviderTypes.VCpuCountRangeRequest>
{

    protected override Humidifier.ECS.CapacityProviderTypes.VCpuCountRangeRequest Create()
    {
        var vCpuCountRangeRequestResult = CreateVCpuCountRangeRequest();
        factoryAction?.Invoke(vCpuCountRangeRequestResult);

        return vCpuCountRangeRequestResult;
    }

    private Humidifier.ECS.CapacityProviderTypes.VCpuCountRangeRequest CreateVCpuCountRangeRequest()
    {
        var vCpuCountRangeRequestResult = new Humidifier.ECS.CapacityProviderTypes.VCpuCountRangeRequest();

        return vCpuCountRangeRequestResult;
    }

} // End Of Class

public static class InnerCapacityProviderVCpuCountRangeRequestFactoryExtensions
{
}
