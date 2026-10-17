// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class SipMediaApplicationFactory(string resourceName = null, Action<Humidifier.Chime.SipMediaApplication> factoryAction = null) : ResourceFactory<Humidifier.Chime.SipMediaApplication>(resourceName)
{

    internal List<InnerSipMediaApplicationSipMediaApplicationEndpointFactory> EndpointsFactories { get; set; } = [];

    protected override Humidifier.Chime.SipMediaApplication Create()
    {
        var sipMediaApplicationResult = CreateSipMediaApplication();
        factoryAction?.Invoke(sipMediaApplicationResult);

        return sipMediaApplicationResult;
    }

    private Humidifier.Chime.SipMediaApplication CreateSipMediaApplication()
    {
        var sipMediaApplicationResult = new Humidifier.Chime.SipMediaApplication
        {
            GivenName = InputResourceName,
        };

        return sipMediaApplicationResult;
    }
    public override void CreateChildren(Humidifier.Chime.SipMediaApplication result)
    {
        base.CreateChildren(result);

        result.Endpoints = EndpointsFactories.Any() ? EndpointsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class SipMediaApplicationFactoryExtensions
{
    public static CombinedResult<SipMediaApplicationFactory, InnerSipMediaApplicationSipMediaApplicationEndpointFactory> WithEndpoints(this SipMediaApplicationFactory parentFactory, Action<Humidifier.Chime.SipMediaApplicationTypes.SipMediaApplicationEndpoint> subFactoryAction = null)
    {
        var factory = new InnerSipMediaApplicationSipMediaApplicationEndpointFactory(subFactoryAction);
        parentFactory.EndpointsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<SipMediaApplicationFactory, T1, InnerSipMediaApplicationSipMediaApplicationEndpointFactory> WithEndpoints<T1>(this CombinedResult<SipMediaApplicationFactory, T1> combinedResult, Action<Humidifier.Chime.SipMediaApplicationTypes.SipMediaApplicationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndpoints(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SipMediaApplicationFactory, InnerSipMediaApplicationSipMediaApplicationEndpointFactory> WithEndpoints<T1>(this CombinedResult<T1, SipMediaApplicationFactory> combinedResult, Action<Humidifier.Chime.SipMediaApplicationTypes.SipMediaApplicationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndpoints(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SipMediaApplicationFactory, T1, T2, InnerSipMediaApplicationSipMediaApplicationEndpointFactory> WithEndpoints<T1, T2>(this CombinedResult<SipMediaApplicationFactory, T1, T2> combinedResult, Action<Humidifier.Chime.SipMediaApplicationTypes.SipMediaApplicationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SipMediaApplicationFactory, T2, InnerSipMediaApplicationSipMediaApplicationEndpointFactory> WithEndpoints<T1, T2>(this CombinedResult<T1, SipMediaApplicationFactory, T2> combinedResult, Action<Humidifier.Chime.SipMediaApplicationTypes.SipMediaApplicationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SipMediaApplicationFactory, InnerSipMediaApplicationSipMediaApplicationEndpointFactory> WithEndpoints<T1, T2>(this CombinedResult<T1, T2, SipMediaApplicationFactory> combinedResult, Action<Humidifier.Chime.SipMediaApplicationTypes.SipMediaApplicationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SipMediaApplicationFactory, T1, T2, T3, InnerSipMediaApplicationSipMediaApplicationEndpointFactory> WithEndpoints<T1, T2, T3>(this CombinedResult<SipMediaApplicationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chime.SipMediaApplicationTypes.SipMediaApplicationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SipMediaApplicationFactory, T2, T3, InnerSipMediaApplicationSipMediaApplicationEndpointFactory> WithEndpoints<T1, T2, T3>(this CombinedResult<T1, SipMediaApplicationFactory, T2, T3> combinedResult, Action<Humidifier.Chime.SipMediaApplicationTypes.SipMediaApplicationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SipMediaApplicationFactory, T3, InnerSipMediaApplicationSipMediaApplicationEndpointFactory> WithEndpoints<T1, T2, T3>(this CombinedResult<T1, T2, SipMediaApplicationFactory, T3> combinedResult, Action<Humidifier.Chime.SipMediaApplicationTypes.SipMediaApplicationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SipMediaApplicationFactory, InnerSipMediaApplicationSipMediaApplicationEndpointFactory> WithEndpoints<T1, T2, T3>(this CombinedResult<T1, T2, T3, SipMediaApplicationFactory> combinedResult, Action<Humidifier.Chime.SipMediaApplicationTypes.SipMediaApplicationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SipMediaApplicationFactory, T1, T2, T3, T4, InnerSipMediaApplicationSipMediaApplicationEndpointFactory> WithEndpoints<T1, T2, T3, T4>(this CombinedResult<SipMediaApplicationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chime.SipMediaApplicationTypes.SipMediaApplicationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SipMediaApplicationFactory, T2, T3, T4, InnerSipMediaApplicationSipMediaApplicationEndpointFactory> WithEndpoints<T1, T2, T3, T4>(this CombinedResult<T1, SipMediaApplicationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chime.SipMediaApplicationTypes.SipMediaApplicationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SipMediaApplicationFactory, T3, T4, InnerSipMediaApplicationSipMediaApplicationEndpointFactory> WithEndpoints<T1, T2, T3, T4>(this CombinedResult<T1, T2, SipMediaApplicationFactory, T3, T4> combinedResult, Action<Humidifier.Chime.SipMediaApplicationTypes.SipMediaApplicationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SipMediaApplicationFactory, T4, InnerSipMediaApplicationSipMediaApplicationEndpointFactory> WithEndpoints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SipMediaApplicationFactory, T4> combinedResult, Action<Humidifier.Chime.SipMediaApplicationTypes.SipMediaApplicationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SipMediaApplicationFactory, InnerSipMediaApplicationSipMediaApplicationEndpointFactory> WithEndpoints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SipMediaApplicationFactory> combinedResult, Action<Humidifier.Chime.SipMediaApplicationTypes.SipMediaApplicationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T5, subFactoryAction).T2);
}
