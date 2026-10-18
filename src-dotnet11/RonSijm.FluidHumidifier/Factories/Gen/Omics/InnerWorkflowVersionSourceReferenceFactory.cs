// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class InnerWorkflowVersionSourceReferenceFactory(Action<Humidifier.Omics.WorkflowVersionTypes.SourceReference> factoryAction = null) : SubResourceFactory<Humidifier.Omics.WorkflowVersionTypes.SourceReference>
{

    protected override Humidifier.Omics.WorkflowVersionTypes.SourceReference Create()
    {
        var sourceReferenceResult = CreateSourceReference();
        factoryAction?.Invoke(sourceReferenceResult);

        return sourceReferenceResult;
    }

    private Humidifier.Omics.WorkflowVersionTypes.SourceReference CreateSourceReference()
    {
        var sourceReferenceResult = new Humidifier.Omics.WorkflowVersionTypes.SourceReference();

        return sourceReferenceResult;
    }

} // End Of Class

public static class InnerWorkflowVersionSourceReferenceFactoryExtensions
{
}
