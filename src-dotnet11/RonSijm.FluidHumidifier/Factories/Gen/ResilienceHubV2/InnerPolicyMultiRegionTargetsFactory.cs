// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHubV2;

public class InnerPolicyMultiRegionTargetsFactory(Action<Humidifier.ResilienceHubV2.PolicyTypes.MultiRegionTargets> factoryAction = null) : SubResourceFactory<Humidifier.ResilienceHubV2.PolicyTypes.MultiRegionTargets>
{

    protected override Humidifier.ResilienceHubV2.PolicyTypes.MultiRegionTargets Create()
    {
        var multiRegionTargetsResult = CreateMultiRegionTargets();
        factoryAction?.Invoke(multiRegionTargetsResult);

        return multiRegionTargetsResult;
    }

    private Humidifier.ResilienceHubV2.PolicyTypes.MultiRegionTargets CreateMultiRegionTargets()
    {
        var multiRegionTargetsResult = new Humidifier.ResilienceHubV2.PolicyTypes.MultiRegionTargets();

        return multiRegionTargetsResult;
    }

} // End Of Class

public static class InnerPolicyMultiRegionTargetsFactoryExtensions
{
}
