// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DLM;

public class InnerLifecyclePolicyCrossRegionCopyTargetFactory(Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTarget> factoryAction = null) : SubResourceFactory<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTarget>
{

    protected override Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTarget Create()
    {
        var crossRegionCopyTargetResult = CreateCrossRegionCopyTarget();
        factoryAction?.Invoke(crossRegionCopyTargetResult);

        return crossRegionCopyTargetResult;
    }

    private Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTarget CreateCrossRegionCopyTarget()
    {
        var crossRegionCopyTargetResult = new Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTarget();

        return crossRegionCopyTargetResult;
    }

} // End Of Class

public static class InnerLifecyclePolicyCrossRegionCopyTargetFactoryExtensions
{
}
