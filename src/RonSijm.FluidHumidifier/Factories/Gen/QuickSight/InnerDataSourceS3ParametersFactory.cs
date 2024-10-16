// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceS3ParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.S3Parameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.S3Parameters>
{

    internal InnerDataSourceManifestFileLocationFactory ManifestFileLocationFactory { get; set; }

    protected override Humidifier.QuickSight.DataSourceTypes.S3Parameters Create()
    {
        var s3ParametersResult = CreateS3Parameters();
        factoryAction?.Invoke(s3ParametersResult);

        return s3ParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.S3Parameters CreateS3Parameters()
    {
        var s3ParametersResult = new Humidifier.QuickSight.DataSourceTypes.S3Parameters();

        return s3ParametersResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DataSourceTypes.S3Parameters result)
    {
        base.CreateChildren(result);

        result.ManifestFileLocation ??= ManifestFileLocationFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceS3ParametersFactoryExtensions
{
    public static CombinedResult<InnerDataSourceS3ParametersFactory, InnerDataSourceManifestFileLocationFactory> WithManifestFileLocation(this InnerDataSourceS3ParametersFactory parentFactory, Action<Humidifier.QuickSight.DataSourceTypes.ManifestFileLocation> subFactoryAction = null)
    {
        parentFactory.ManifestFileLocationFactory = new InnerDataSourceManifestFileLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ManifestFileLocationFactory);
    }

    public static CombinedResult<InnerDataSourceS3ParametersFactory, T1, InnerDataSourceManifestFileLocationFactory> WithManifestFileLocation<T1>(this CombinedResult<InnerDataSourceS3ParametersFactory, T1> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.ManifestFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithManifestFileLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceS3ParametersFactory, InnerDataSourceManifestFileLocationFactory> WithManifestFileLocation<T1>(this CombinedResult<T1, InnerDataSourceS3ParametersFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.ManifestFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithManifestFileLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceS3ParametersFactory, T1, T2, InnerDataSourceManifestFileLocationFactory> WithManifestFileLocation<T1, T2>(this CombinedResult<InnerDataSourceS3ParametersFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.ManifestFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManifestFileLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceS3ParametersFactory, T2, InnerDataSourceManifestFileLocationFactory> WithManifestFileLocation<T1, T2>(this CombinedResult<T1, InnerDataSourceS3ParametersFactory, T2> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.ManifestFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManifestFileLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceS3ParametersFactory, InnerDataSourceManifestFileLocationFactory> WithManifestFileLocation<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceS3ParametersFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.ManifestFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManifestFileLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceS3ParametersFactory, T1, T2, T3, InnerDataSourceManifestFileLocationFactory> WithManifestFileLocation<T1, T2, T3>(this CombinedResult<InnerDataSourceS3ParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.ManifestFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifestFileLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceS3ParametersFactory, T2, T3, InnerDataSourceManifestFileLocationFactory> WithManifestFileLocation<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceS3ParametersFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.ManifestFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifestFileLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceS3ParametersFactory, T3, InnerDataSourceManifestFileLocationFactory> WithManifestFileLocation<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceS3ParametersFactory, T3> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.ManifestFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifestFileLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceS3ParametersFactory, InnerDataSourceManifestFileLocationFactory> WithManifestFileLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceS3ParametersFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.ManifestFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifestFileLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceS3ParametersFactory, T1, T2, T3, T4, InnerDataSourceManifestFileLocationFactory> WithManifestFileLocation<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceS3ParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.ManifestFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestFileLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceS3ParametersFactory, T2, T3, T4, InnerDataSourceManifestFileLocationFactory> WithManifestFileLocation<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceS3ParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.ManifestFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestFileLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceS3ParametersFactory, T3, T4, InnerDataSourceManifestFileLocationFactory> WithManifestFileLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceS3ParametersFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.ManifestFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestFileLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceS3ParametersFactory, T4, InnerDataSourceManifestFileLocationFactory> WithManifestFileLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceS3ParametersFactory, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.ManifestFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestFileLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceS3ParametersFactory, InnerDataSourceManifestFileLocationFactory> WithManifestFileLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceS3ParametersFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.ManifestFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestFileLocation(combinedResult.T5, subFactoryAction));
}
