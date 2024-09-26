// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class LocationEFSFactory(string resourceName = null, Action<Humidifier.DataSync.LocationEFS> factoryAction = null) : ResourceFactory<Humidifier.DataSync.LocationEFS>(resourceName)
{

    internal InnerLocationEFSEc2ConfigFactory Ec2ConfigFactory { get; set; }

    protected override Humidifier.DataSync.LocationEFS Create()
    {
        var locationEFSResult = CreateLocationEFS();
        factoryAction?.Invoke(locationEFSResult);

        return locationEFSResult;
    }

    private Humidifier.DataSync.LocationEFS CreateLocationEFS()
    {
        var locationEFSResult = new Humidifier.DataSync.LocationEFS
        {
            GivenName = InputResourceName,
        };

        return locationEFSResult;
    }
    public override void CreateChildren(Humidifier.DataSync.LocationEFS result)
    {
        base.CreateChildren(result);

        result.Ec2Config ??= Ec2ConfigFactory?.Build();
    }

} // End Of Class

public static class LocationEFSFactoryExtensions
{
    public static CombinedResult<LocationEFSFactory, InnerLocationEFSEc2ConfigFactory> WithEc2Config(this LocationEFSFactory parentFactory, Action<Humidifier.DataSync.LocationEFSTypes.Ec2Config> subFactoryAction = null)
    {
        parentFactory.Ec2ConfigFactory = new InnerLocationEFSEc2ConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.Ec2ConfigFactory);
    }

    public static CombinedResult<LocationEFSFactory, T1, InnerLocationEFSEc2ConfigFactory> WithEc2Config<T1>(this CombinedResult<LocationEFSFactory, T1> combinedResult, Action<Humidifier.DataSync.LocationEFSTypes.Ec2Config> subFactoryAction = null) => new (combinedResult, combinedResult, WithEc2Config(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationEFSFactory, InnerLocationEFSEc2ConfigFactory> WithEc2Config<T1>(this CombinedResult<T1, LocationEFSFactory> combinedResult, Action<Humidifier.DataSync.LocationEFSTypes.Ec2Config> subFactoryAction = null) => new (combinedResult, combinedResult, WithEc2Config(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LocationEFSFactory, T1, T2, InnerLocationEFSEc2ConfigFactory> WithEc2Config<T1, T2>(this CombinedResult<LocationEFSFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.LocationEFSTypes.Ec2Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEc2Config(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationEFSFactory, T2, InnerLocationEFSEc2ConfigFactory> WithEc2Config<T1, T2>(this CombinedResult<T1, LocationEFSFactory, T2> combinedResult, Action<Humidifier.DataSync.LocationEFSTypes.Ec2Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEc2Config(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationEFSFactory, InnerLocationEFSEc2ConfigFactory> WithEc2Config<T1, T2>(this CombinedResult<T1, T2, LocationEFSFactory> combinedResult, Action<Humidifier.DataSync.LocationEFSTypes.Ec2Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEc2Config(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LocationEFSFactory, T1, T2, T3, InnerLocationEFSEc2ConfigFactory> WithEc2Config<T1, T2, T3>(this CombinedResult<LocationEFSFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationEFSTypes.Ec2Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEc2Config(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationEFSFactory, T2, T3, InnerLocationEFSEc2ConfigFactory> WithEc2Config<T1, T2, T3>(this CombinedResult<T1, LocationEFSFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationEFSTypes.Ec2Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEc2Config(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationEFSFactory, T3, InnerLocationEFSEc2ConfigFactory> WithEc2Config<T1, T2, T3>(this CombinedResult<T1, T2, LocationEFSFactory, T3> combinedResult, Action<Humidifier.DataSync.LocationEFSTypes.Ec2Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEc2Config(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LocationEFSFactory, InnerLocationEFSEc2ConfigFactory> WithEc2Config<T1, T2, T3>(this CombinedResult<T1, T2, T3, LocationEFSFactory> combinedResult, Action<Humidifier.DataSync.LocationEFSTypes.Ec2Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEc2Config(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LocationEFSFactory, T1, T2, T3, T4, InnerLocationEFSEc2ConfigFactory> WithEc2Config<T1, T2, T3, T4>(this CombinedResult<LocationEFSFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationEFSTypes.Ec2Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEc2Config(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationEFSFactory, T2, T3, T4, InnerLocationEFSEc2ConfigFactory> WithEc2Config<T1, T2, T3, T4>(this CombinedResult<T1, LocationEFSFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationEFSTypes.Ec2Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEc2Config(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationEFSFactory, T3, T4, InnerLocationEFSEc2ConfigFactory> WithEc2Config<T1, T2, T3, T4>(this CombinedResult<T1, T2, LocationEFSFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationEFSTypes.Ec2Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEc2Config(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LocationEFSFactory, T4, InnerLocationEFSEc2ConfigFactory> WithEc2Config<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LocationEFSFactory, T4> combinedResult, Action<Humidifier.DataSync.LocationEFSTypes.Ec2Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEc2Config(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LocationEFSFactory, InnerLocationEFSEc2ConfigFactory> WithEc2Config<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LocationEFSFactory> combinedResult, Action<Humidifier.DataSync.LocationEFSTypes.Ec2Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEc2Config(combinedResult.T5, subFactoryAction));
}
