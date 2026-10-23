// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class ExportImageTaskFactory(string resourceName = null, Action<Humidifier.EC2.ExportImageTask> factoryAction = null) : ResourceFactory<Humidifier.EC2.ExportImageTask>(resourceName)
{

    internal InnerExportImageTaskS3ExportLocationFactory S3ExportLocationFactory { get; set; }

    protected override Humidifier.EC2.ExportImageTask Create()
    {
        var exportImageTaskResult = CreateExportImageTask();
        factoryAction?.Invoke(exportImageTaskResult);

        return exportImageTaskResult;
    }

    private Humidifier.EC2.ExportImageTask CreateExportImageTask()
    {
        var exportImageTaskResult = new Humidifier.EC2.ExportImageTask
        {
            GivenName = InputResourceName,
        };

        return exportImageTaskResult;
    }
    public override void CreateChildren(Humidifier.EC2.ExportImageTask result)
    {
        base.CreateChildren(result);

        result.S3ExportLocation ??= S3ExportLocationFactory?.Build();
    }

} // End Of Class

public static class ExportImageTaskFactoryExtensions
{
    public static CombinedResult<ExportImageTaskFactory, InnerExportImageTaskS3ExportLocationFactory> WithS3ExportLocation(this ExportImageTaskFactory parentFactory, Action<Humidifier.EC2.ExportImageTaskTypes.S3ExportLocation> subFactoryAction = null)
    {
        parentFactory.S3ExportLocationFactory = new InnerExportImageTaskS3ExportLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3ExportLocationFactory);
    }

    public static CombinedResult<ExportImageTaskFactory, T1, InnerExportImageTaskS3ExportLocationFactory> WithS3ExportLocation<T1>(this CombinedResult<ExportImageTaskFactory, T1> combinedResult, Action<Humidifier.EC2.ExportImageTaskTypes.S3ExportLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3ExportLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExportImageTaskFactory, InnerExportImageTaskS3ExportLocationFactory> WithS3ExportLocation<T1>(this CombinedResult<T1, ExportImageTaskFactory> combinedResult, Action<Humidifier.EC2.ExportImageTaskTypes.S3ExportLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3ExportLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ExportImageTaskFactory, T1, T2, InnerExportImageTaskS3ExportLocationFactory> WithS3ExportLocation<T1, T2>(this CombinedResult<ExportImageTaskFactory, T1, T2> combinedResult, Action<Humidifier.EC2.ExportImageTaskTypes.S3ExportLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3ExportLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExportImageTaskFactory, T2, InnerExportImageTaskS3ExportLocationFactory> WithS3ExportLocation<T1, T2>(this CombinedResult<T1, ExportImageTaskFactory, T2> combinedResult, Action<Humidifier.EC2.ExportImageTaskTypes.S3ExportLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3ExportLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ExportImageTaskFactory, InnerExportImageTaskS3ExportLocationFactory> WithS3ExportLocation<T1, T2>(this CombinedResult<T1, T2, ExportImageTaskFactory> combinedResult, Action<Humidifier.EC2.ExportImageTaskTypes.S3ExportLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3ExportLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ExportImageTaskFactory, T1, T2, T3, InnerExportImageTaskS3ExportLocationFactory> WithS3ExportLocation<T1, T2, T3>(this CombinedResult<ExportImageTaskFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.ExportImageTaskTypes.S3ExportLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3ExportLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExportImageTaskFactory, T2, T3, InnerExportImageTaskS3ExportLocationFactory> WithS3ExportLocation<T1, T2, T3>(this CombinedResult<T1, ExportImageTaskFactory, T2, T3> combinedResult, Action<Humidifier.EC2.ExportImageTaskTypes.S3ExportLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3ExportLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ExportImageTaskFactory, T3, InnerExportImageTaskS3ExportLocationFactory> WithS3ExportLocation<T1, T2, T3>(this CombinedResult<T1, T2, ExportImageTaskFactory, T3> combinedResult, Action<Humidifier.EC2.ExportImageTaskTypes.S3ExportLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3ExportLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ExportImageTaskFactory, InnerExportImageTaskS3ExportLocationFactory> WithS3ExportLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, ExportImageTaskFactory> combinedResult, Action<Humidifier.EC2.ExportImageTaskTypes.S3ExportLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3ExportLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ExportImageTaskFactory, T1, T2, T3, T4, InnerExportImageTaskS3ExportLocationFactory> WithS3ExportLocation<T1, T2, T3, T4>(this CombinedResult<ExportImageTaskFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.ExportImageTaskTypes.S3ExportLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3ExportLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExportImageTaskFactory, T2, T3, T4, InnerExportImageTaskS3ExportLocationFactory> WithS3ExportLocation<T1, T2, T3, T4>(this CombinedResult<T1, ExportImageTaskFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.ExportImageTaskTypes.S3ExportLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3ExportLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ExportImageTaskFactory, T3, T4, InnerExportImageTaskS3ExportLocationFactory> WithS3ExportLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, ExportImageTaskFactory, T3, T4> combinedResult, Action<Humidifier.EC2.ExportImageTaskTypes.S3ExportLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3ExportLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ExportImageTaskFactory, T4, InnerExportImageTaskS3ExportLocationFactory> WithS3ExportLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ExportImageTaskFactory, T4> combinedResult, Action<Humidifier.EC2.ExportImageTaskTypes.S3ExportLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3ExportLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ExportImageTaskFactory, InnerExportImageTaskS3ExportLocationFactory> WithS3ExportLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ExportImageTaskFactory> combinedResult, Action<Humidifier.EC2.ExportImageTaskTypes.S3ExportLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3ExportLocation(combinedResult.T5, subFactoryAction).T2);
}
