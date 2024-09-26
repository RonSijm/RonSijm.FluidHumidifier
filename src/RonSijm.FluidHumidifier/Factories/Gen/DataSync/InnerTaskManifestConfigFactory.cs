// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerTaskManifestConfigFactory(Action<Humidifier.DataSync.TaskTypes.ManifestConfig> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.TaskTypes.ManifestConfig>
{

    internal InnerTaskSourceFactory SourceFactory { get; set; }

    protected override Humidifier.DataSync.TaskTypes.ManifestConfig Create()
    {
        var manifestConfigResult = CreateManifestConfig();
        factoryAction?.Invoke(manifestConfigResult);

        return manifestConfigResult;
    }

    private Humidifier.DataSync.TaskTypes.ManifestConfig CreateManifestConfig()
    {
        var manifestConfigResult = new Humidifier.DataSync.TaskTypes.ManifestConfig();

        return manifestConfigResult;
    }
    public override void CreateChildren(Humidifier.DataSync.TaskTypes.ManifestConfig result)
    {
        base.CreateChildren(result);

        result.Source ??= SourceFactory?.Build();
    }

} // End Of Class

public static class InnerTaskManifestConfigFactoryExtensions
{
    public static CombinedResult<InnerTaskManifestConfigFactory, InnerTaskSourceFactory> WithSource(this InnerTaskManifestConfigFactory parentFactory, Action<Humidifier.DataSync.TaskTypes.Source> subFactoryAction = null)
    {
        parentFactory.SourceFactory = new InnerTaskSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceFactory);
    }

    public static CombinedResult<InnerTaskManifestConfigFactory, T1, InnerTaskSourceFactory> WithSource<T1>(this CombinedResult<InnerTaskManifestConfigFactory, T1> combinedResult, Action<Humidifier.DataSync.TaskTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskManifestConfigFactory, InnerTaskSourceFactory> WithSource<T1>(this CombinedResult<T1, InnerTaskManifestConfigFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTaskManifestConfigFactory, T1, T2, InnerTaskSourceFactory> WithSource<T1, T2>(this CombinedResult<InnerTaskManifestConfigFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.TaskTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskManifestConfigFactory, T2, InnerTaskSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, InnerTaskManifestConfigFactory, T2> combinedResult, Action<Humidifier.DataSync.TaskTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskManifestConfigFactory, InnerTaskSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, T2, InnerTaskManifestConfigFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTaskManifestConfigFactory, T1, T2, T3, InnerTaskSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<InnerTaskManifestConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskManifestConfigFactory, T2, T3, InnerTaskSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, InnerTaskManifestConfigFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskManifestConfigFactory, T3, InnerTaskSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerTaskManifestConfigFactory, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskManifestConfigFactory, InnerTaskSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTaskManifestConfigFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTaskManifestConfigFactory, T1, T2, T3, T4, InnerTaskSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<InnerTaskManifestConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskManifestConfigFactory, T2, T3, T4, InnerTaskSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerTaskManifestConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskManifestConfigFactory, T3, T4, InnerTaskSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTaskManifestConfigFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskManifestConfigFactory, T4, InnerTaskSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTaskManifestConfigFactory, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTaskManifestConfigFactory, InnerTaskSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTaskManifestConfigFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T5, subFactoryAction));
}
