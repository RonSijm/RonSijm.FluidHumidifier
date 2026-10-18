// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BillingConductor;

public class InnerBillingGroupComputationPreferenceFactory(Action<Humidifier.BillingConductor.BillingGroupTypes.ComputationPreference> factoryAction = null) : SubResourceFactory<Humidifier.BillingConductor.BillingGroupTypes.ComputationPreference>
{

    protected override Humidifier.BillingConductor.BillingGroupTypes.ComputationPreference Create()
    {
        var computationPreferenceResult = CreateComputationPreference();
        factoryAction?.Invoke(computationPreferenceResult);

        return computationPreferenceResult;
    }

    private Humidifier.BillingConductor.BillingGroupTypes.ComputationPreference CreateComputationPreference()
    {
        var computationPreferenceResult = new Humidifier.BillingConductor.BillingGroupTypes.ComputationPreference();

        return computationPreferenceResult;
    }

} // End Of Class

public static class InnerBillingGroupComputationPreferenceFactoryExtensions
{
}
