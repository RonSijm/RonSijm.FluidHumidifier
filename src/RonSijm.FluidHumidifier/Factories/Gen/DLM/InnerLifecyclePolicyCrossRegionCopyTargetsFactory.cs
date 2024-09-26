// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DLM;

public class InnerLifecyclePolicyCrossRegionCopyTargetsFactory(Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> factoryAction = null) : SubResourceFactory<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets>
{

    protected override Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets Create()
    {
        var crossRegionCopyTargetsResult = CreateCrossRegionCopyTargets();
        factoryAction?.Invoke(crossRegionCopyTargetsResult);

        return crossRegionCopyTargetsResult;
    }

    private Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets CreateCrossRegionCopyTargets()
    {
        var crossRegionCopyTargetsResult = new Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets();

        return crossRegionCopyTargetsResult;
    }

} // End Of Class

public static class InnerLifecyclePolicyCrossRegionCopyTargetsFactoryExtensions
{
}
