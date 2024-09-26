// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class LocationS3Factory(string resourceName = null, Action<Humidifier.DataSync.LocationS3> factoryAction = null) : ResourceFactory<Humidifier.DataSync.LocationS3>(resourceName)
{

    internal InnerLocationS3S3ConfigFactory S3ConfigFactory { get; set; }

    protected override Humidifier.DataSync.LocationS3 Create()
    {
        var locationS3Result = CreateLocationS3();
        factoryAction?.Invoke(locationS3Result);

        return locationS3Result;
    }

    private Humidifier.DataSync.LocationS3 CreateLocationS3()
    {
        var locationS3Result = new Humidifier.DataSync.LocationS3
        {
            GivenName = InputResourceName,
        };

        return locationS3Result;
    }
    public override void CreateChildren(Humidifier.DataSync.LocationS3 result)
    {
        base.CreateChildren(result);

        result.S3Config ??= S3ConfigFactory?.Build();
    }

} // End Of Class

public static class LocationS3FactoryExtensions
{
    public static CombinedResult<LocationS3Factory, InnerLocationS3S3ConfigFactory> WithS3Config(this LocationS3Factory parentFactory, Action<Humidifier.DataSync.LocationS3Types.S3Config> subFactoryAction = null)
    {
        parentFactory.S3ConfigFactory = new InnerLocationS3S3ConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3ConfigFactory);
    }

    public static CombinedResult<LocationS3Factory, T1, InnerLocationS3S3ConfigFactory> WithS3Config<T1>(this CombinedResult<LocationS3Factory, T1> combinedResult, Action<Humidifier.DataSync.LocationS3Types.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Config(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationS3Factory, InnerLocationS3S3ConfigFactory> WithS3Config<T1>(this CombinedResult<T1, LocationS3Factory> combinedResult, Action<Humidifier.DataSync.LocationS3Types.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Config(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LocationS3Factory, T1, T2, InnerLocationS3S3ConfigFactory> WithS3Config<T1, T2>(this CombinedResult<LocationS3Factory, T1, T2> combinedResult, Action<Humidifier.DataSync.LocationS3Types.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Config(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationS3Factory, T2, InnerLocationS3S3ConfigFactory> WithS3Config<T1, T2>(this CombinedResult<T1, LocationS3Factory, T2> combinedResult, Action<Humidifier.DataSync.LocationS3Types.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Config(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationS3Factory, InnerLocationS3S3ConfigFactory> WithS3Config<T1, T2>(this CombinedResult<T1, T2, LocationS3Factory> combinedResult, Action<Humidifier.DataSync.LocationS3Types.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Config(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LocationS3Factory, T1, T2, T3, InnerLocationS3S3ConfigFactory> WithS3Config<T1, T2, T3>(this CombinedResult<LocationS3Factory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationS3Types.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Config(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationS3Factory, T2, T3, InnerLocationS3S3ConfigFactory> WithS3Config<T1, T2, T3>(this CombinedResult<T1, LocationS3Factory, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationS3Types.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Config(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationS3Factory, T3, InnerLocationS3S3ConfigFactory> WithS3Config<T1, T2, T3>(this CombinedResult<T1, T2, LocationS3Factory, T3> combinedResult, Action<Humidifier.DataSync.LocationS3Types.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Config(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LocationS3Factory, InnerLocationS3S3ConfigFactory> WithS3Config<T1, T2, T3>(this CombinedResult<T1, T2, T3, LocationS3Factory> combinedResult, Action<Humidifier.DataSync.LocationS3Types.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Config(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LocationS3Factory, T1, T2, T3, T4, InnerLocationS3S3ConfigFactory> WithS3Config<T1, T2, T3, T4>(this CombinedResult<LocationS3Factory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationS3Types.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Config(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationS3Factory, T2, T3, T4, InnerLocationS3S3ConfigFactory> WithS3Config<T1, T2, T3, T4>(this CombinedResult<T1, LocationS3Factory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationS3Types.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Config(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationS3Factory, T3, T4, InnerLocationS3S3ConfigFactory> WithS3Config<T1, T2, T3, T4>(this CombinedResult<T1, T2, LocationS3Factory, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationS3Types.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Config(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LocationS3Factory, T4, InnerLocationS3S3ConfigFactory> WithS3Config<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LocationS3Factory, T4> combinedResult, Action<Humidifier.DataSync.LocationS3Types.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Config(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LocationS3Factory, InnerLocationS3S3ConfigFactory> WithS3Config<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LocationS3Factory> combinedResult, Action<Humidifier.DataSync.LocationS3Types.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Config(combinedResult.T5, subFactoryAction));
}
