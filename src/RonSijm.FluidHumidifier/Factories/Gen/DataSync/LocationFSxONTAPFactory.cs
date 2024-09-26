// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class LocationFSxONTAPFactory(string resourceName = null, Action<Humidifier.DataSync.LocationFSxONTAP> factoryAction = null) : ResourceFactory<Humidifier.DataSync.LocationFSxONTAP>(resourceName)
{

    internal InnerLocationFSxONTAPProtocolFactory ProtocolFactory { get; set; }

    protected override Humidifier.DataSync.LocationFSxONTAP Create()
    {
        var locationFSxONTAPResult = CreateLocationFSxONTAP();
        factoryAction?.Invoke(locationFSxONTAPResult);

        return locationFSxONTAPResult;
    }

    private Humidifier.DataSync.LocationFSxONTAP CreateLocationFSxONTAP()
    {
        var locationFSxONTAPResult = new Humidifier.DataSync.LocationFSxONTAP
        {
            GivenName = InputResourceName,
        };

        return locationFSxONTAPResult;
    }
    public override void CreateChildren(Humidifier.DataSync.LocationFSxONTAP result)
    {
        base.CreateChildren(result);

        result.Protocol ??= ProtocolFactory?.Build();
    }

} // End Of Class

public static class LocationFSxONTAPFactoryExtensions
{
    public static CombinedResult<LocationFSxONTAPFactory, InnerLocationFSxONTAPProtocolFactory> WithProtocol(this LocationFSxONTAPFactory parentFactory, Action<Humidifier.DataSync.LocationFSxONTAPTypes.Protocol> subFactoryAction = null)
    {
        parentFactory.ProtocolFactory = new InnerLocationFSxONTAPProtocolFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProtocolFactory);
    }

    public static CombinedResult<LocationFSxONTAPFactory, T1, InnerLocationFSxONTAPProtocolFactory> WithProtocol<T1>(this CombinedResult<LocationFSxONTAPFactory, T1> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, WithProtocol(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationFSxONTAPFactory, InnerLocationFSxONTAPProtocolFactory> WithProtocol<T1>(this CombinedResult<T1, LocationFSxONTAPFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, WithProtocol(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LocationFSxONTAPFactory, T1, T2, InnerLocationFSxONTAPProtocolFactory> WithProtocol<T1, T2>(this CombinedResult<LocationFSxONTAPFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProtocol(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationFSxONTAPFactory, T2, InnerLocationFSxONTAPProtocolFactory> WithProtocol<T1, T2>(this CombinedResult<T1, LocationFSxONTAPFactory, T2> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProtocol(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationFSxONTAPFactory, InnerLocationFSxONTAPProtocolFactory> WithProtocol<T1, T2>(this CombinedResult<T1, T2, LocationFSxONTAPFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProtocol(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LocationFSxONTAPFactory, T1, T2, T3, InnerLocationFSxONTAPProtocolFactory> WithProtocol<T1, T2, T3>(this CombinedResult<LocationFSxONTAPFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProtocol(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationFSxONTAPFactory, T2, T3, InnerLocationFSxONTAPProtocolFactory> WithProtocol<T1, T2, T3>(this CombinedResult<T1, LocationFSxONTAPFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProtocol(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationFSxONTAPFactory, T3, InnerLocationFSxONTAPProtocolFactory> WithProtocol<T1, T2, T3>(this CombinedResult<T1, T2, LocationFSxONTAPFactory, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProtocol(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LocationFSxONTAPFactory, InnerLocationFSxONTAPProtocolFactory> WithProtocol<T1, T2, T3>(this CombinedResult<T1, T2, T3, LocationFSxONTAPFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProtocol(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LocationFSxONTAPFactory, T1, T2, T3, T4, InnerLocationFSxONTAPProtocolFactory> WithProtocol<T1, T2, T3, T4>(this CombinedResult<LocationFSxONTAPFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtocol(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationFSxONTAPFactory, T2, T3, T4, InnerLocationFSxONTAPProtocolFactory> WithProtocol<T1, T2, T3, T4>(this CombinedResult<T1, LocationFSxONTAPFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtocol(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationFSxONTAPFactory, T3, T4, InnerLocationFSxONTAPProtocolFactory> WithProtocol<T1, T2, T3, T4>(this CombinedResult<T1, T2, LocationFSxONTAPFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtocol(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LocationFSxONTAPFactory, T4, InnerLocationFSxONTAPProtocolFactory> WithProtocol<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LocationFSxONTAPFactory, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtocol(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LocationFSxONTAPFactory, InnerLocationFSxONTAPProtocolFactory> WithProtocol<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LocationFSxONTAPFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxONTAPTypes.Protocol> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtocol(combinedResult.T5, subFactoryAction));
}
