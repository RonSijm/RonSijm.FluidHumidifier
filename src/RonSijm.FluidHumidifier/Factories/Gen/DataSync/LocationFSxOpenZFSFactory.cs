// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class LocationFSxOpenZFSFactory(string resourceName = null, Action<Humidifier.DataSync.LocationFSxOpenZFS> factoryAction = null) : ResourceFactory<Humidifier.DataSync.LocationFSxOpenZFS>(resourceName)
{

    internal InnerLocationFSxOpenZFSProtocolFactory ProtocolFactory { get; set; }

    protected override Humidifier.DataSync.LocationFSxOpenZFS Create()
    {
        var locationFSxOpenZFSResult = CreateLocationFSxOpenZFS();
        factoryAction?.Invoke(locationFSxOpenZFSResult);

        return locationFSxOpenZFSResult;
    }

    private Humidifier.DataSync.LocationFSxOpenZFS CreateLocationFSxOpenZFS()
    {
        var locationFSxOpenZFSResult = new Humidifier.DataSync.LocationFSxOpenZFS
        {
            GivenName = InputResourceName,
        };

        return locationFSxOpenZFSResult;
    }
    public override void CreateChildren(Humidifier.DataSync.LocationFSxOpenZFS result)
    {
        base.CreateChildren(result);

        result.Protocol ??= ProtocolFactory?.Build();
    }

} // End Of Class

public static class LocationFSxOpenZFSFactoryExtensions
{
    public static CombinedResult<LocationFSxOpenZFSFactory, InnerLocationFSxOpenZFSProtocolFactory> WithProtocol(this LocationFSxOpenZFSFactory parentFactory, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.Protocol> subFactoryAction = null)
    {
        parentFactory.ProtocolFactory = new InnerLocationFSxOpenZFSProtocolFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProtocolFactory);
    }

    public static CombinedResult<LocationFSxOpenZFSFactory, T1, InnerLocationFSxOpenZFSProtocolFactory> WithProtocol<T1>(this CombinedResult<LocationFSxOpenZFSFactory, T1> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, WithProtocol(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationFSxOpenZFSFactory, InnerLocationFSxOpenZFSProtocolFactory> WithProtocol<T1>(this CombinedResult<T1, LocationFSxOpenZFSFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, WithProtocol(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LocationFSxOpenZFSFactory, T1, T2, InnerLocationFSxOpenZFSProtocolFactory> WithProtocol<T1, T2>(this CombinedResult<LocationFSxOpenZFSFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProtocol(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationFSxOpenZFSFactory, T2, InnerLocationFSxOpenZFSProtocolFactory> WithProtocol<T1, T2>(this CombinedResult<T1, LocationFSxOpenZFSFactory, T2> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProtocol(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationFSxOpenZFSFactory, InnerLocationFSxOpenZFSProtocolFactory> WithProtocol<T1, T2>(this CombinedResult<T1, T2, LocationFSxOpenZFSFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProtocol(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LocationFSxOpenZFSFactory, T1, T2, T3, InnerLocationFSxOpenZFSProtocolFactory> WithProtocol<T1, T2, T3>(this CombinedResult<LocationFSxOpenZFSFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProtocol(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationFSxOpenZFSFactory, T2, T3, InnerLocationFSxOpenZFSProtocolFactory> WithProtocol<T1, T2, T3>(this CombinedResult<T1, LocationFSxOpenZFSFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProtocol(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationFSxOpenZFSFactory, T3, InnerLocationFSxOpenZFSProtocolFactory> WithProtocol<T1, T2, T3>(this CombinedResult<T1, T2, LocationFSxOpenZFSFactory, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProtocol(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LocationFSxOpenZFSFactory, InnerLocationFSxOpenZFSProtocolFactory> WithProtocol<T1, T2, T3>(this CombinedResult<T1, T2, T3, LocationFSxOpenZFSFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProtocol(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LocationFSxOpenZFSFactory, T1, T2, T3, T4, InnerLocationFSxOpenZFSProtocolFactory> WithProtocol<T1, T2, T3, T4>(this CombinedResult<LocationFSxOpenZFSFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtocol(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationFSxOpenZFSFactory, T2, T3, T4, InnerLocationFSxOpenZFSProtocolFactory> WithProtocol<T1, T2, T3, T4>(this CombinedResult<T1, LocationFSxOpenZFSFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtocol(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationFSxOpenZFSFactory, T3, T4, InnerLocationFSxOpenZFSProtocolFactory> WithProtocol<T1, T2, T3, T4>(this CombinedResult<T1, T2, LocationFSxOpenZFSFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtocol(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LocationFSxOpenZFSFactory, T4, InnerLocationFSxOpenZFSProtocolFactory> WithProtocol<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LocationFSxOpenZFSFactory, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtocol(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LocationFSxOpenZFSFactory, InnerLocationFSxOpenZFSProtocolFactory> WithProtocol<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LocationFSxOpenZFSFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtocol(combinedResult.T5, subFactoryAction));
}
