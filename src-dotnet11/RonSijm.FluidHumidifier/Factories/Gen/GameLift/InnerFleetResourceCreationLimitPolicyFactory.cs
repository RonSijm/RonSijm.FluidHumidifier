// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerFleetResourceCreationLimitPolicyFactory(Action<Humidifier.GameLift.FleetTypes.ResourceCreationLimitPolicy> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.FleetTypes.ResourceCreationLimitPolicy>
{

    protected override Humidifier.GameLift.FleetTypes.ResourceCreationLimitPolicy Create()
    {
        var resourceCreationLimitPolicyResult = CreateResourceCreationLimitPolicy();
        factoryAction?.Invoke(resourceCreationLimitPolicyResult);

        return resourceCreationLimitPolicyResult;
    }

    private Humidifier.GameLift.FleetTypes.ResourceCreationLimitPolicy CreateResourceCreationLimitPolicy()
    {
        var resourceCreationLimitPolicyResult = new Humidifier.GameLift.FleetTypes.ResourceCreationLimitPolicy();

        return resourceCreationLimitPolicyResult;
    }

} // End Of Class

public static class InnerFleetResourceCreationLimitPolicyFactoryExtensions
{
}
