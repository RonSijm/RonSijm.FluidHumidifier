// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerJobDefinitionResourceRetentionPolicyFactory(Action<Humidifier.Batch.JobDefinitionTypes.ResourceRetentionPolicy> factoryAction = null) : SubResourceFactory<Humidifier.Batch.JobDefinitionTypes.ResourceRetentionPolicy>
{

    protected override Humidifier.Batch.JobDefinitionTypes.ResourceRetentionPolicy Create()
    {
        var resourceRetentionPolicyResult = CreateResourceRetentionPolicy();
        factoryAction?.Invoke(resourceRetentionPolicyResult);

        return resourceRetentionPolicyResult;
    }

    private Humidifier.Batch.JobDefinitionTypes.ResourceRetentionPolicy CreateResourceRetentionPolicy()
    {
        var resourceRetentionPolicyResult = new Humidifier.Batch.JobDefinitionTypes.ResourceRetentionPolicy();

        return resourceRetentionPolicyResult;
    }

} // End Of Class

public static class InnerJobDefinitionResourceRetentionPolicyFactoryExtensions
{
}
