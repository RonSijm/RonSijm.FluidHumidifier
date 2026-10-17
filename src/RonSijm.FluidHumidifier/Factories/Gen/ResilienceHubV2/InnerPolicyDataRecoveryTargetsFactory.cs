// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHubV2;

public class InnerPolicyDataRecoveryTargetsFactory(Action<Humidifier.ResilienceHubV2.PolicyTypes.DataRecoveryTargets> factoryAction = null) : SubResourceFactory<Humidifier.ResilienceHubV2.PolicyTypes.DataRecoveryTargets>
{

    protected override Humidifier.ResilienceHubV2.PolicyTypes.DataRecoveryTargets Create()
    {
        var dataRecoveryTargetsResult = CreateDataRecoveryTargets();
        factoryAction?.Invoke(dataRecoveryTargetsResult);

        return dataRecoveryTargetsResult;
    }

    private Humidifier.ResilienceHubV2.PolicyTypes.DataRecoveryTargets CreateDataRecoveryTargets()
    {
        var dataRecoveryTargetsResult = new Humidifier.ResilienceHubV2.PolicyTypes.DataRecoveryTargets();

        return dataRecoveryTargetsResult;
    }

} // End Of Class

public static class InnerPolicyDataRecoveryTargetsFactoryExtensions
{
}
