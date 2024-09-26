// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerWorkflowInputFileLocationFactory(Action<Humidifier.Transfer.WorkflowTypes.InputFileLocation> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.WorkflowTypes.InputFileLocation>
{

    internal InnerWorkflowEfsInputFileLocationFactory EfsFileLocationFactory { get; set; }

    internal InnerWorkflowS3InputFileLocationFactory S3FileLocationFactory { get; set; }

    protected override Humidifier.Transfer.WorkflowTypes.InputFileLocation Create()
    {
        var inputFileLocationResult = CreateInputFileLocation();
        factoryAction?.Invoke(inputFileLocationResult);

        return inputFileLocationResult;
    }

    private Humidifier.Transfer.WorkflowTypes.InputFileLocation CreateInputFileLocation()
    {
        var inputFileLocationResult = new Humidifier.Transfer.WorkflowTypes.InputFileLocation();

        return inputFileLocationResult;
    }
    public override void CreateChildren(Humidifier.Transfer.WorkflowTypes.InputFileLocation result)
    {
        base.CreateChildren(result);

        result.EfsFileLocation ??= EfsFileLocationFactory?.Build();
        result.S3FileLocation ??= S3FileLocationFactory?.Build();
    }

} // End Of Class

public static class InnerWorkflowInputFileLocationFactoryExtensions
{
    public static CombinedResult<InnerWorkflowInputFileLocationFactory, InnerWorkflowEfsInputFileLocationFactory> WithEfsFileLocation(this InnerWorkflowInputFileLocationFactory parentFactory, Action<Humidifier.Transfer.WorkflowTypes.EfsInputFileLocation> subFactoryAction = null)
    {
        parentFactory.EfsFileLocationFactory = new InnerWorkflowEfsInputFileLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EfsFileLocationFactory);
    }

    public static CombinedResult<InnerWorkflowInputFileLocationFactory, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation(this InnerWorkflowInputFileLocationFactory parentFactory, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null)
    {
        parentFactory.S3FileLocationFactory = new InnerWorkflowS3InputFileLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3FileLocationFactory);
    }

    public static CombinedResult<InnerWorkflowInputFileLocationFactory, T1, InnerWorkflowEfsInputFileLocationFactory> WithEfsFileLocation<T1>(this CombinedResult<InnerWorkflowInputFileLocationFactory, T1> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.EfsInputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithEfsFileLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkflowInputFileLocationFactory, InnerWorkflowEfsInputFileLocationFactory> WithEfsFileLocation<T1>(this CombinedResult<T1, InnerWorkflowInputFileLocationFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.EfsInputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithEfsFileLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWorkflowInputFileLocationFactory, T1, T2, InnerWorkflowEfsInputFileLocationFactory> WithEfsFileLocation<T1, T2>(this CombinedResult<InnerWorkflowInputFileLocationFactory, T1, T2> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.EfsInputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEfsFileLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkflowInputFileLocationFactory, T2, InnerWorkflowEfsInputFileLocationFactory> WithEfsFileLocation<T1, T2>(this CombinedResult<T1, InnerWorkflowInputFileLocationFactory, T2> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.EfsInputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEfsFileLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkflowInputFileLocationFactory, InnerWorkflowEfsInputFileLocationFactory> WithEfsFileLocation<T1, T2>(this CombinedResult<T1, T2, InnerWorkflowInputFileLocationFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.EfsInputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEfsFileLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWorkflowInputFileLocationFactory, T1, T2, T3, InnerWorkflowEfsInputFileLocationFactory> WithEfsFileLocation<T1, T2, T3>(this CombinedResult<InnerWorkflowInputFileLocationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.EfsInputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEfsFileLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkflowInputFileLocationFactory, T2, T3, InnerWorkflowEfsInputFileLocationFactory> WithEfsFileLocation<T1, T2, T3>(this CombinedResult<T1, InnerWorkflowInputFileLocationFactory, T2, T3> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.EfsInputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEfsFileLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkflowInputFileLocationFactory, T3, InnerWorkflowEfsInputFileLocationFactory> WithEfsFileLocation<T1, T2, T3>(this CombinedResult<T1, T2, InnerWorkflowInputFileLocationFactory, T3> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.EfsInputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEfsFileLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWorkflowInputFileLocationFactory, InnerWorkflowEfsInputFileLocationFactory> WithEfsFileLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWorkflowInputFileLocationFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.EfsInputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEfsFileLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWorkflowInputFileLocationFactory, T1, T2, T3, T4, InnerWorkflowEfsInputFileLocationFactory> WithEfsFileLocation<T1, T2, T3, T4>(this CombinedResult<InnerWorkflowInputFileLocationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.EfsInputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEfsFileLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkflowInputFileLocationFactory, T2, T3, T4, InnerWorkflowEfsInputFileLocationFactory> WithEfsFileLocation<T1, T2, T3, T4>(this CombinedResult<T1, InnerWorkflowInputFileLocationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.EfsInputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEfsFileLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkflowInputFileLocationFactory, T3, T4, InnerWorkflowEfsInputFileLocationFactory> WithEfsFileLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWorkflowInputFileLocationFactory, T3, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.EfsInputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEfsFileLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWorkflowInputFileLocationFactory, T4, InnerWorkflowEfsInputFileLocationFactory> WithEfsFileLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWorkflowInputFileLocationFactory, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.EfsInputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEfsFileLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWorkflowInputFileLocationFactory, InnerWorkflowEfsInputFileLocationFactory> WithEfsFileLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWorkflowInputFileLocationFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.EfsInputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEfsFileLocation(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerWorkflowInputFileLocationFactory, T1, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation<T1>(this CombinedResult<InnerWorkflowInputFileLocationFactory, T1> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3FileLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkflowInputFileLocationFactory, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation<T1>(this CombinedResult<T1, InnerWorkflowInputFileLocationFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3FileLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWorkflowInputFileLocationFactory, T1, T2, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation<T1, T2>(this CombinedResult<InnerWorkflowInputFileLocationFactory, T1, T2> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3FileLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkflowInputFileLocationFactory, T2, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation<T1, T2>(this CombinedResult<T1, InnerWorkflowInputFileLocationFactory, T2> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3FileLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkflowInputFileLocationFactory, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation<T1, T2>(this CombinedResult<T1, T2, InnerWorkflowInputFileLocationFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3FileLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWorkflowInputFileLocationFactory, T1, T2, T3, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation<T1, T2, T3>(this CombinedResult<InnerWorkflowInputFileLocationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3FileLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkflowInputFileLocationFactory, T2, T3, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation<T1, T2, T3>(this CombinedResult<T1, InnerWorkflowInputFileLocationFactory, T2, T3> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3FileLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkflowInputFileLocationFactory, T3, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation<T1, T2, T3>(this CombinedResult<T1, T2, InnerWorkflowInputFileLocationFactory, T3> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3FileLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWorkflowInputFileLocationFactory, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWorkflowInputFileLocationFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3FileLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWorkflowInputFileLocationFactory, T1, T2, T3, T4, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation<T1, T2, T3, T4>(this CombinedResult<InnerWorkflowInputFileLocationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3FileLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkflowInputFileLocationFactory, T2, T3, T4, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation<T1, T2, T3, T4>(this CombinedResult<T1, InnerWorkflowInputFileLocationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3FileLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkflowInputFileLocationFactory, T3, T4, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWorkflowInputFileLocationFactory, T3, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3FileLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWorkflowInputFileLocationFactory, T4, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWorkflowInputFileLocationFactory, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3FileLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWorkflowInputFileLocationFactory, InnerWorkflowS3InputFileLocationFactory> WithS3FileLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWorkflowInputFileLocationFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.S3InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3FileLocation(combinedResult.T5, subFactoryAction));
}
