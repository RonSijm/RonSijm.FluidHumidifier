// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerConnectionConnectivityParametersFactory(Action<Humidifier.Events.ConnectionTypes.ConnectivityParameters> factoryAction = null) : SubResourceFactory<Humidifier.Events.ConnectionTypes.ConnectivityParameters>
{

    internal InnerConnectionResourceParametersFactory ResourceParametersFactory { get; set; }

    protected override Humidifier.Events.ConnectionTypes.ConnectivityParameters Create()
    {
        var connectivityParametersResult = CreateConnectivityParameters();
        factoryAction?.Invoke(connectivityParametersResult);

        return connectivityParametersResult;
    }

    private Humidifier.Events.ConnectionTypes.ConnectivityParameters CreateConnectivityParameters()
    {
        var connectivityParametersResult = new Humidifier.Events.ConnectionTypes.ConnectivityParameters();

        return connectivityParametersResult;
    }
    public override void CreateChildren(Humidifier.Events.ConnectionTypes.ConnectivityParameters result)
    {
        base.CreateChildren(result);

        result.ResourceParameters ??= ResourceParametersFactory?.Build();
    }

} // End Of Class

public static class InnerConnectionConnectivityParametersFactoryExtensions
{
    public static CombinedResult<InnerConnectionConnectivityParametersFactory, InnerConnectionResourceParametersFactory> WithResourceParameters(this InnerConnectionConnectivityParametersFactory parentFactory, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null)
    {
        parentFactory.ResourceParametersFactory = new InnerConnectionResourceParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResourceParametersFactory);
    }

    public static CombinedResult<InnerConnectionConnectivityParametersFactory, T1, InnerConnectionResourceParametersFactory> WithResourceParameters<T1>(this CombinedResult<InnerConnectionConnectivityParametersFactory, T1> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectionConnectivityParametersFactory, InnerConnectionResourceParametersFactory> WithResourceParameters<T1>(this CombinedResult<T1, InnerConnectionConnectivityParametersFactory> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectionConnectivityParametersFactory, T1, T2, InnerConnectionResourceParametersFactory> WithResourceParameters<T1, T2>(this CombinedResult<InnerConnectionConnectivityParametersFactory, T1, T2> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectionConnectivityParametersFactory, T2, InnerConnectionResourceParametersFactory> WithResourceParameters<T1, T2>(this CombinedResult<T1, InnerConnectionConnectivityParametersFactory, T2> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectionConnectivityParametersFactory, InnerConnectionResourceParametersFactory> WithResourceParameters<T1, T2>(this CombinedResult<T1, T2, InnerConnectionConnectivityParametersFactory> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectionConnectivityParametersFactory, T1, T2, T3, InnerConnectionResourceParametersFactory> WithResourceParameters<T1, T2, T3>(this CombinedResult<InnerConnectionConnectivityParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectionConnectivityParametersFactory, T2, T3, InnerConnectionResourceParametersFactory> WithResourceParameters<T1, T2, T3>(this CombinedResult<T1, InnerConnectionConnectivityParametersFactory, T2, T3> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectionConnectivityParametersFactory, T3, InnerConnectionResourceParametersFactory> WithResourceParameters<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectionConnectivityParametersFactory, T3> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectionConnectivityParametersFactory, InnerConnectionResourceParametersFactory> WithResourceParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectionConnectivityParametersFactory> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectionConnectivityParametersFactory, T1, T2, T3, T4, InnerConnectionResourceParametersFactory> WithResourceParameters<T1, T2, T3, T4>(this CombinedResult<InnerConnectionConnectivityParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectionConnectivityParametersFactory, T2, T3, T4, InnerConnectionResourceParametersFactory> WithResourceParameters<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectionConnectivityParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectionConnectivityParametersFactory, T3, T4, InnerConnectionResourceParametersFactory> WithResourceParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectionConnectivityParametersFactory, T3, T4> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectionConnectivityParametersFactory, T4, InnerConnectionResourceParametersFactory> WithResourceParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectionConnectivityParametersFactory, T4> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectionConnectivityParametersFactory, InnerConnectionResourceParametersFactory> WithResourceParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectionConnectivityParametersFactory> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceParameters(combinedResult.T5, subFactoryAction));
}
