// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class InnerWorkflowSourceReferenceFactory(Action<Humidifier.Omics.WorkflowTypes.SourceReference> factoryAction = null) : SubResourceFactory<Humidifier.Omics.WorkflowTypes.SourceReference>
{

    protected override Humidifier.Omics.WorkflowTypes.SourceReference Create()
    {
        var sourceReferenceResult = CreateSourceReference();
        factoryAction?.Invoke(sourceReferenceResult);

        return sourceReferenceResult;
    }

    private Humidifier.Omics.WorkflowTypes.SourceReference CreateSourceReference()
    {
        var sourceReferenceResult = new Humidifier.Omics.WorkflowTypes.SourceReference();

        return sourceReferenceResult;
    }

} // End Of Class

public static class InnerWorkflowSourceReferenceFactoryExtensions
{
}
