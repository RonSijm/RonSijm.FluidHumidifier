// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerWorkflowCopyStepDetailsFactory(Action<Humidifier.Transfer.WorkflowTypes.CopyStepDetails> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.WorkflowTypes.CopyStepDetails>
{

    internal InnerWorkflowS3FileLocationFactory DestinationFileLocationFactory { get; set; }

    protected override Humidifier.Transfer.WorkflowTypes.CopyStepDetails Create()
    {
        var copyStepDetailsResult = CreateCopyStepDetails();
        factoryAction?.Invoke(copyStepDetailsResult);

        return copyStepDetailsResult;
    }

    private Humidifier.Transfer.WorkflowTypes.CopyStepDetails CreateCopyStepDetails()
    {
        var copyStepDetailsResult = new Humidifier.Transfer.WorkflowTypes.CopyStepDetails();

        return copyStepDetailsResult;
    }
    public override void CreateChildren(Humidifier.Transfer.WorkflowTypes.CopyStepDetails result)
    {
        base.CreateChildren(result);

        result.DestinationFileLocation ??= DestinationFileLocationFactory?.Build();
    }

} // End Of Class

public static class InnerWorkflowCopyStepDetailsFactoryExtensions
{
    public static CombinedResult<InnerWorkflowCopyStepDetailsFactory, InnerWorkflowS3FileLocationFactory> WithDestinationFileLocation(this InnerWorkflowCopyStepDetailsFactory parentFactory, Action<Humidifier.Transfer.WorkflowTypes.S3FileLocation> subFactoryAction = null)
    {
        parentFactory.DestinationFileLocationFactory = new InnerWorkflowS3FileLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationFileLocationFactory);
    }

    public static CombinedResult<InnerWorkflowCopyStepDetailsFactory, T1, InnerWorkflowS3FileLocationFactory> WithDestinationFileLocation<T1>(this CombinedResult<InnerWorkflowCopyStepDetailsFactory, T1> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkflowCopyStepDetailsFactory, InnerWorkflowS3FileLocationFactory> WithDestinationFileLocation<T1>(this CombinedResult<T1, InnerWorkflowCopyStepDetailsFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWorkflowCopyStepDetailsFactory, T1, T2, InnerWorkflowS3FileLocationFactory> WithDestinationFileLocation<T1, T2>(this CombinedResult<InnerWorkflowCopyStepDetailsFactory, T1, T2> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkflowCopyStepDetailsFactory, T2, InnerWorkflowS3FileLocationFactory> WithDestinationFileLocation<T1, T2>(this CombinedResult<T1, InnerWorkflowCopyStepDetailsFactory, T2> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkflowCopyStepDetailsFactory, InnerWorkflowS3FileLocationFactory> WithDestinationFileLocation<T1, T2>(this CombinedResult<T1, T2, InnerWorkflowCopyStepDetailsFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWorkflowCopyStepDetailsFactory, T1, T2, T3, InnerWorkflowS3FileLocationFactory> WithDestinationFileLocation<T1, T2, T3>(this CombinedResult<InnerWorkflowCopyStepDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkflowCopyStepDetailsFactory, T2, T3, InnerWorkflowS3FileLocationFactory> WithDestinationFileLocation<T1, T2, T3>(this CombinedResult<T1, InnerWorkflowCopyStepDetailsFactory, T2, T3> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkflowCopyStepDetailsFactory, T3, InnerWorkflowS3FileLocationFactory> WithDestinationFileLocation<T1, T2, T3>(this CombinedResult<T1, T2, InnerWorkflowCopyStepDetailsFactory, T3> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWorkflowCopyStepDetailsFactory, InnerWorkflowS3FileLocationFactory> WithDestinationFileLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWorkflowCopyStepDetailsFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWorkflowCopyStepDetailsFactory, T1, T2, T3, T4, InnerWorkflowS3FileLocationFactory> WithDestinationFileLocation<T1, T2, T3, T4>(this CombinedResult<InnerWorkflowCopyStepDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkflowCopyStepDetailsFactory, T2, T3, T4, InnerWorkflowS3FileLocationFactory> WithDestinationFileLocation<T1, T2, T3, T4>(this CombinedResult<T1, InnerWorkflowCopyStepDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkflowCopyStepDetailsFactory, T3, T4, InnerWorkflowS3FileLocationFactory> WithDestinationFileLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWorkflowCopyStepDetailsFactory, T3, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWorkflowCopyStepDetailsFactory, T4, InnerWorkflowS3FileLocationFactory> WithDestinationFileLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWorkflowCopyStepDetailsFactory, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWorkflowCopyStepDetailsFactory, InnerWorkflowS3FileLocationFactory> WithDestinationFileLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWorkflowCopyStepDetailsFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3FileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T5, subFactoryAction));
}
