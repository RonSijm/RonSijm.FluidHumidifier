// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.HealthLake;

public class DataTransformationProfileFactory(string resourceName = null, Action<Humidifier.HealthLake.DataTransformationProfile> factoryAction = null) : ResourceFactory<Humidifier.HealthLake.DataTransformationProfile>(resourceName)
{

    internal InnerDataTransformationProfileSourceFactory SourceFactory { get; set; }

    protected override Humidifier.HealthLake.DataTransformationProfile Create()
    {
        var dataTransformationProfileResult = CreateDataTransformationProfile();
        factoryAction?.Invoke(dataTransformationProfileResult);

        return dataTransformationProfileResult;
    }

    private Humidifier.HealthLake.DataTransformationProfile CreateDataTransformationProfile()
    {
        var dataTransformationProfileResult = new Humidifier.HealthLake.DataTransformationProfile
        {
            GivenName = InputResourceName,
        };

        return dataTransformationProfileResult;
    }
    public override void CreateChildren(Humidifier.HealthLake.DataTransformationProfile result)
    {
        base.CreateChildren(result);

        result.Source ??= SourceFactory?.Build();
    }

} // End Of Class

public static class DataTransformationProfileFactoryExtensions
{
    public static CombinedResult<DataTransformationProfileFactory, InnerDataTransformationProfileSourceFactory> WithSource(this DataTransformationProfileFactory parentFactory, Action<Humidifier.HealthLake.DataTransformationProfileTypes.Source> subFactoryAction = null)
    {
        parentFactory.SourceFactory = new InnerDataTransformationProfileSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceFactory);
    }

    public static CombinedResult<DataTransformationProfileFactory, T1, InnerDataTransformationProfileSourceFactory> WithSource<T1>(this CombinedResult<DataTransformationProfileFactory, T1> combinedResult, Action<Humidifier.HealthLake.DataTransformationProfileTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataTransformationProfileFactory, InnerDataTransformationProfileSourceFactory> WithSource<T1>(this CombinedResult<T1, DataTransformationProfileFactory> combinedResult, Action<Humidifier.HealthLake.DataTransformationProfileTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DataTransformationProfileFactory, T1, T2, InnerDataTransformationProfileSourceFactory> WithSource<T1, T2>(this CombinedResult<DataTransformationProfileFactory, T1, T2> combinedResult, Action<Humidifier.HealthLake.DataTransformationProfileTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataTransformationProfileFactory, T2, InnerDataTransformationProfileSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, DataTransformationProfileFactory, T2> combinedResult, Action<Humidifier.HealthLake.DataTransformationProfileTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DataTransformationProfileFactory, InnerDataTransformationProfileSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, T2, DataTransformationProfileFactory> combinedResult, Action<Humidifier.HealthLake.DataTransformationProfileTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DataTransformationProfileFactory, T1, T2, T3, InnerDataTransformationProfileSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<DataTransformationProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.HealthLake.DataTransformationProfileTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataTransformationProfileFactory, T2, T3, InnerDataTransformationProfileSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, DataTransformationProfileFactory, T2, T3> combinedResult, Action<Humidifier.HealthLake.DataTransformationProfileTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DataTransformationProfileFactory, T3, InnerDataTransformationProfileSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, DataTransformationProfileFactory, T3> combinedResult, Action<Humidifier.HealthLake.DataTransformationProfileTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DataTransformationProfileFactory, InnerDataTransformationProfileSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataTransformationProfileFactory> combinedResult, Action<Humidifier.HealthLake.DataTransformationProfileTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DataTransformationProfileFactory, T1, T2, T3, T4, InnerDataTransformationProfileSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<DataTransformationProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.HealthLake.DataTransformationProfileTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataTransformationProfileFactory, T2, T3, T4, InnerDataTransformationProfileSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, DataTransformationProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.HealthLake.DataTransformationProfileTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DataTransformationProfileFactory, T3, T4, InnerDataTransformationProfileSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataTransformationProfileFactory, T3, T4> combinedResult, Action<Humidifier.HealthLake.DataTransformationProfileTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DataTransformationProfileFactory, T4, InnerDataTransformationProfileSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataTransformationProfileFactory, T4> combinedResult, Action<Humidifier.HealthLake.DataTransformationProfileTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DataTransformationProfileFactory, InnerDataTransformationProfileSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataTransformationProfileFactory> combinedResult, Action<Humidifier.HealthLake.DataTransformationProfileTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T5, subFactoryAction).T2);
}
