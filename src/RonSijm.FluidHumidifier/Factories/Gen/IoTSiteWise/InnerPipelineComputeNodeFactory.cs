// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerPipelineComputeNodeFactory(Action<Humidifier.IoTSiteWise.PipelineTypes.ComputeNode> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.PipelineTypes.ComputeNode>
{

    protected override Humidifier.IoTSiteWise.PipelineTypes.ComputeNode Create()
    {
        var computeNodeResult = CreateComputeNode();
        factoryAction?.Invoke(computeNodeResult);

        return computeNodeResult;
    }

    private Humidifier.IoTSiteWise.PipelineTypes.ComputeNode CreateComputeNode()
    {
        var computeNodeResult = new Humidifier.IoTSiteWise.PipelineTypes.ComputeNode();

        return computeNodeResult;
    }

} // End Of Class

public static class InnerPipelineComputeNodeFactoryExtensions
{
}
