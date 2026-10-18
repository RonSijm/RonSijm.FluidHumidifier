// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCS;

public class InnerComputeNodeGroupNodeLifecycleStagesFactory(Action<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleStages> factoryAction = null) : SubResourceFactory<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleStages>
{

    protected override Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleStages Create()
    {
        var nodeLifecycleStagesResult = CreateNodeLifecycleStages();
        factoryAction?.Invoke(nodeLifecycleStagesResult);

        return nodeLifecycleStagesResult;
    }

    private Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleStages CreateNodeLifecycleStages()
    {
        var nodeLifecycleStagesResult = new Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleStages();

        return nodeLifecycleStagesResult;
    }

} // End Of Class

public static class InnerComputeNodeGroupNodeLifecycleStagesFactoryExtensions
{
}
