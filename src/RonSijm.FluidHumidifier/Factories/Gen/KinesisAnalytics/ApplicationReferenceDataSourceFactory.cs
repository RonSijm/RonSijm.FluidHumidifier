// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalytics;

public class ApplicationReferenceDataSourceFactory(string resourceName = null, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSource> factoryAction = null) : ResourceFactory<Humidifier.KinesisAnalytics.ApplicationReferenceDataSource>(resourceName)
{

    internal InnerApplicationReferenceDataSourceReferenceDataSourceFactory ReferenceDataSourceFactory { get; set; }

    protected override Humidifier.KinesisAnalytics.ApplicationReferenceDataSource Create()
    {
        var applicationReferenceDataSourceResult = CreateApplicationReferenceDataSource();
        factoryAction?.Invoke(applicationReferenceDataSourceResult);

        return applicationReferenceDataSourceResult;
    }

    private Humidifier.KinesisAnalytics.ApplicationReferenceDataSource CreateApplicationReferenceDataSource()
    {
        var applicationReferenceDataSourceResult = new Humidifier.KinesisAnalytics.ApplicationReferenceDataSource
        {
            GivenName = InputResourceName,
        };

        return applicationReferenceDataSourceResult;
    }
    public override void CreateChildren(Humidifier.KinesisAnalytics.ApplicationReferenceDataSource result)
    {
        base.CreateChildren(result);

        result.ReferenceDataSource ??= ReferenceDataSourceFactory?.Build();
    }

} // End Of Class

public static class ApplicationReferenceDataSourceFactoryExtensions
{
    public static CombinedResult<ApplicationReferenceDataSourceFactory, InnerApplicationReferenceDataSourceReferenceDataSourceFactory> WithReferenceDataSource(this ApplicationReferenceDataSourceFactory parentFactory, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.ReferenceDataSource> subFactoryAction = null)
    {
        parentFactory.ReferenceDataSourceFactory = new InnerApplicationReferenceDataSourceReferenceDataSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReferenceDataSourceFactory);
    }

    public static CombinedResult<ApplicationReferenceDataSourceFactory, T1, InnerApplicationReferenceDataSourceReferenceDataSourceFactory> WithReferenceDataSource<T1>(this CombinedResult<ApplicationReferenceDataSourceFactory, T1> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.ReferenceDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithReferenceDataSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationReferenceDataSourceFactory, InnerApplicationReferenceDataSourceReferenceDataSourceFactory> WithReferenceDataSource<T1>(this CombinedResult<T1, ApplicationReferenceDataSourceFactory> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.ReferenceDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithReferenceDataSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApplicationReferenceDataSourceFactory, T1, T2, InnerApplicationReferenceDataSourceReferenceDataSourceFactory> WithReferenceDataSource<T1, T2>(this CombinedResult<ApplicationReferenceDataSourceFactory, T1, T2> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.ReferenceDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReferenceDataSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationReferenceDataSourceFactory, T2, InnerApplicationReferenceDataSourceReferenceDataSourceFactory> WithReferenceDataSource<T1, T2>(this CombinedResult<T1, ApplicationReferenceDataSourceFactory, T2> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.ReferenceDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReferenceDataSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationReferenceDataSourceFactory, InnerApplicationReferenceDataSourceReferenceDataSourceFactory> WithReferenceDataSource<T1, T2>(this CombinedResult<T1, T2, ApplicationReferenceDataSourceFactory> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.ReferenceDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReferenceDataSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApplicationReferenceDataSourceFactory, T1, T2, T3, InnerApplicationReferenceDataSourceReferenceDataSourceFactory> WithReferenceDataSource<T1, T2, T3>(this CombinedResult<ApplicationReferenceDataSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.ReferenceDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReferenceDataSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationReferenceDataSourceFactory, T2, T3, InnerApplicationReferenceDataSourceReferenceDataSourceFactory> WithReferenceDataSource<T1, T2, T3>(this CombinedResult<T1, ApplicationReferenceDataSourceFactory, T2, T3> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.ReferenceDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReferenceDataSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationReferenceDataSourceFactory, T3, InnerApplicationReferenceDataSourceReferenceDataSourceFactory> WithReferenceDataSource<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationReferenceDataSourceFactory, T3> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.ReferenceDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReferenceDataSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationReferenceDataSourceFactory, InnerApplicationReferenceDataSourceReferenceDataSourceFactory> WithReferenceDataSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationReferenceDataSourceFactory> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.ReferenceDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReferenceDataSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApplicationReferenceDataSourceFactory, T1, T2, T3, T4, InnerApplicationReferenceDataSourceReferenceDataSourceFactory> WithReferenceDataSource<T1, T2, T3, T4>(this CombinedResult<ApplicationReferenceDataSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.ReferenceDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReferenceDataSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationReferenceDataSourceFactory, T2, T3, T4, InnerApplicationReferenceDataSourceReferenceDataSourceFactory> WithReferenceDataSource<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationReferenceDataSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.ReferenceDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReferenceDataSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationReferenceDataSourceFactory, T3, T4, InnerApplicationReferenceDataSourceReferenceDataSourceFactory> WithReferenceDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationReferenceDataSourceFactory, T3, T4> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.ReferenceDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReferenceDataSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationReferenceDataSourceFactory, T4, InnerApplicationReferenceDataSourceReferenceDataSourceFactory> WithReferenceDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationReferenceDataSourceFactory, T4> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.ReferenceDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReferenceDataSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApplicationReferenceDataSourceFactory, InnerApplicationReferenceDataSourceReferenceDataSourceFactory> WithReferenceDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationReferenceDataSourceFactory> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.ReferenceDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReferenceDataSource(combinedResult.T5, subFactoryAction));
}
