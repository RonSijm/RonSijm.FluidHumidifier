// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerCapacityProviderBaselineEbsBandwidthMbpsRequestFactory(Action<Humidifier.ECS.CapacityProviderTypes.BaselineEbsBandwidthMbpsRequest> factoryAction = null) : SubResourceFactory<Humidifier.ECS.CapacityProviderTypes.BaselineEbsBandwidthMbpsRequest>
{

    protected override Humidifier.ECS.CapacityProviderTypes.BaselineEbsBandwidthMbpsRequest Create()
    {
        var baselineEbsBandwidthMbpsRequestResult = CreateBaselineEbsBandwidthMbpsRequest();
        factoryAction?.Invoke(baselineEbsBandwidthMbpsRequestResult);

        return baselineEbsBandwidthMbpsRequestResult;
    }

    private Humidifier.ECS.CapacityProviderTypes.BaselineEbsBandwidthMbpsRequest CreateBaselineEbsBandwidthMbpsRequest()
    {
        var baselineEbsBandwidthMbpsRequestResult = new Humidifier.ECS.CapacityProviderTypes.BaselineEbsBandwidthMbpsRequest();

        return baselineEbsBandwidthMbpsRequestResult;
    }

} // End Of Class

public static class InnerCapacityProviderBaselineEbsBandwidthMbpsRequestFactoryExtensions
{
}
