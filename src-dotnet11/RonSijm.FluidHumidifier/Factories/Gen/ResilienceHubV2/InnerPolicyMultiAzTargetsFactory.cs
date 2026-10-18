// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHubV2;

public class InnerPolicyMultiAzTargetsFactory(Action<Humidifier.ResilienceHubV2.PolicyTypes.MultiAzTargets> factoryAction = null) : SubResourceFactory<Humidifier.ResilienceHubV2.PolicyTypes.MultiAzTargets>
{

    protected override Humidifier.ResilienceHubV2.PolicyTypes.MultiAzTargets Create()
    {
        var multiAzTargetsResult = CreateMultiAzTargets();
        factoryAction?.Invoke(multiAzTargetsResult);

        return multiAzTargetsResult;
    }

    private Humidifier.ResilienceHubV2.PolicyTypes.MultiAzTargets CreateMultiAzTargets()
    {
        var multiAzTargetsResult = new Humidifier.ResilienceHubV2.PolicyTypes.MultiAzTargets();

        return multiAzTargetsResult;
    }

} // End Of Class

public static class InnerPolicyMultiAzTargetsFactoryExtensions
{
}
