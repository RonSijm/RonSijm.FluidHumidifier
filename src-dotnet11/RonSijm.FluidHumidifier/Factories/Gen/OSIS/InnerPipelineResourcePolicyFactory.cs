// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OSIS;

public class InnerPipelineResourcePolicyFactory(Action<Humidifier.OSIS.PipelineTypes.ResourcePolicy> factoryAction = null) : SubResourceFactory<Humidifier.OSIS.PipelineTypes.ResourcePolicy>
{

    protected override Humidifier.OSIS.PipelineTypes.ResourcePolicy Create()
    {
        var resourcePolicyResult = CreateResourcePolicy();
        factoryAction?.Invoke(resourcePolicyResult);

        return resourcePolicyResult;
    }

    private Humidifier.OSIS.PipelineTypes.ResourcePolicy CreateResourcePolicy()
    {
        var resourcePolicyResult = new Humidifier.OSIS.PipelineTypes.ResourcePolicy();

        return resourcePolicyResult;
    }

} // End Of Class

public static class InnerPipelineResourcePolicyFactoryExtensions
{
}
