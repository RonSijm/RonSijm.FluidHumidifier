// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerWorkflowS3FileLocationFactory(Action<Humidifier.Transfer.WorkflowTypes.S3FileLocation> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.WorkflowTypes.S3FileLocation>
{

    internal InnerWorkflowS3InputFileLocationFactory S3FileLocation_Factory { get; set; }

    protected override Humidifier.Transfer.WorkflowTypes.S3FileLocation Create()
    {
        var s3FileLocationResult = CreateS3FileLocation();
        factoryAction?.Invoke(s3FileLocationResult);

        return s3FileLocationResult;
    }

    private Humidifier.Transfer.WorkflowTypes.S3FileLocation CreateS3FileLocation()
    {
        var s3FileLocationResult = new Humidifier.Transfer.WorkflowTypes.S3FileLocation();

        return s3FileLocationResult;
    }
    public override void CreateChildren(Humidifier.Transfer.WorkflowTypes.S3FileLocation result)
    {
        base.CreateChildren(result);

        result.S3FileLocation_ ??= S3FileLocation_Factory?.Build();
    }

} // End Of Class

public static class InnerWorkflowS3FileLocationFactoryExtensions
{
    public static CombinedResult<InnerWorkflowS3FileLocationFactory, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation_(this InnerWorkflowS3FileLocationFactory parentFactory, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null)
    {
        parentFactory.S3FileLocation_Factory = new InnerWorkflowS3InputFileLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3FileLocation_Factory);
    }

    public static CombinedResult<InnerWorkflowS3FileLocationFactory, T1, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation_<T1>(this CombinedResult<InnerWorkflowS3FileLocationFactory, T1> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3FileLocation_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkflowS3FileLocationFactory, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation_<T1>(this CombinedResult<T1, InnerWorkflowS3FileLocationFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3FileLocation_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWorkflowS3FileLocationFactory, T1, T2, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation_<T1, T2>(this CombinedResult<InnerWorkflowS3FileLocationFactory, T1, T2> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3FileLocation_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkflowS3FileLocationFactory, T2, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation_<T1, T2>(this CombinedResult<T1, InnerWorkflowS3FileLocationFactory, T2> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3FileLocation_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkflowS3FileLocationFactory, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation_<T1, T2>(this CombinedResult<T1, T2, InnerWorkflowS3FileLocationFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3FileLocation_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWorkflowS3FileLocationFactory, T1, T2, T3, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation_<T1, T2, T3>(this CombinedResult<InnerWorkflowS3FileLocationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3FileLocation_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkflowS3FileLocationFactory, T2, T3, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation_<T1, T2, T3>(this CombinedResult<T1, InnerWorkflowS3FileLocationFactory, T2, T3> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3FileLocation_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkflowS3FileLocationFactory, T3, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation_<T1, T2, T3>(this CombinedResult<T1, T2, InnerWorkflowS3FileLocationFactory, T3> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3FileLocation_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWorkflowS3FileLocationFactory, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation_<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWorkflowS3FileLocationFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3FileLocation_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWorkflowS3FileLocationFactory, T1, T2, T3, T4, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation_<T1, T2, T3, T4>(this CombinedResult<InnerWorkflowS3FileLocationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3FileLocation_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkflowS3FileLocationFactory, T2, T3, T4, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation_<T1, T2, T3, T4>(this CombinedResult<T1, InnerWorkflowS3FileLocationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3FileLocation_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkflowS3FileLocationFactory, T3, T4, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation_<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWorkflowS3FileLocationFactory, T3, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3FileLocation_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWorkflowS3FileLocationFactory, T4, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWorkflowS3FileLocationFactory, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3FileLocation_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWorkflowS3FileLocationFactory, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWorkflowS3FileLocationFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3FileLocation_(combinedResult.T5, subFactoryAction));
}
