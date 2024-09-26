// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerTaskSourceFactory(Action<Humidifier.DataSync.TaskTypes.Source> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.TaskTypes.Source>
{

    internal InnerTaskManifestConfigSourceS3Factory S3Factory { get; set; }

    protected override Humidifier.DataSync.TaskTypes.Source Create()
    {
        var sourceResult = CreateSource();
        factoryAction?.Invoke(sourceResult);

        return sourceResult;
    }

    private Humidifier.DataSync.TaskTypes.Source CreateSource()
    {
        var sourceResult = new Humidifier.DataSync.TaskTypes.Source();

        return sourceResult;
    }
    public override void CreateChildren(Humidifier.DataSync.TaskTypes.Source result)
    {
        base.CreateChildren(result);

        result.S3 ??= S3Factory?.Build();
    }

} // End Of Class

public static class InnerTaskSourceFactoryExtensions
{
    public static CombinedResult<InnerTaskSourceFactory, InnerTaskManifestConfigSourceS3Factory> WithS3(this InnerTaskSourceFactory parentFactory, Action<Humidifier.DataSync.TaskTypes.ManifestConfigSourceS3> subFactoryAction = null)
    {
        parentFactory.S3Factory = new InnerTaskManifestConfigSourceS3Factory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3Factory);
    }

    public static CombinedResult<InnerTaskSourceFactory, T1, InnerTaskManifestConfigSourceS3Factory> WithS3<T1>(this CombinedResult<InnerTaskSourceFactory, T1> combinedResult, Action<Humidifier.DataSync.TaskTypes.ManifestConfigSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskSourceFactory, InnerTaskManifestConfigSourceS3Factory> WithS3<T1>(this CombinedResult<T1, InnerTaskSourceFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.ManifestConfigSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTaskSourceFactory, T1, T2, InnerTaskManifestConfigSourceS3Factory> WithS3<T1, T2>(this CombinedResult<InnerTaskSourceFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.TaskTypes.ManifestConfigSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskSourceFactory, T2, InnerTaskManifestConfigSourceS3Factory> WithS3<T1, T2>(this CombinedResult<T1, InnerTaskSourceFactory, T2> combinedResult, Action<Humidifier.DataSync.TaskTypes.ManifestConfigSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskSourceFactory, InnerTaskManifestConfigSourceS3Factory> WithS3<T1, T2>(this CombinedResult<T1, T2, InnerTaskSourceFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.ManifestConfigSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTaskSourceFactory, T1, T2, T3, InnerTaskManifestConfigSourceS3Factory> WithS3<T1, T2, T3>(this CombinedResult<InnerTaskSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.ManifestConfigSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskSourceFactory, T2, T3, InnerTaskManifestConfigSourceS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, InnerTaskSourceFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.ManifestConfigSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskSourceFactory, T3, InnerTaskManifestConfigSourceS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, InnerTaskSourceFactory, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.ManifestConfigSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskSourceFactory, InnerTaskManifestConfigSourceS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTaskSourceFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.ManifestConfigSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTaskSourceFactory, T1, T2, T3, T4, InnerTaskManifestConfigSourceS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<InnerTaskSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.ManifestConfigSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskSourceFactory, T2, T3, T4, InnerTaskManifestConfigSourceS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, InnerTaskSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.ManifestConfigSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskSourceFactory, T3, T4, InnerTaskManifestConfigSourceS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTaskSourceFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.ManifestConfigSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskSourceFactory, T4, InnerTaskManifestConfigSourceS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTaskSourceFactory, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.ManifestConfigSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTaskSourceFactory, InnerTaskManifestConfigSourceS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTaskSourceFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.ManifestConfigSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T5, subFactoryAction));
}
