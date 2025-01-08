// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerConnectionInvocationConnectivityParametersFactory(Action<Humidifier.Events.ConnectionTypes.InvocationConnectivityParameters> factoryAction = null) : SubResourceFactory<Humidifier.Events.ConnectionTypes.InvocationConnectivityParameters>
{

    internal InnerConnectionResourceParametersFactory ResourceParametersFactory { get; set; }

    protected override Humidifier.Events.ConnectionTypes.InvocationConnectivityParameters Create()
    {
        var invocationConnectivityParametersResult = CreateInvocationConnectivityParameters();
        factoryAction?.Invoke(invocationConnectivityParametersResult);

        return invocationConnectivityParametersResult;
    }

    private Humidifier.Events.ConnectionTypes.InvocationConnectivityParameters CreateInvocationConnectivityParameters()
    {
        var invocationConnectivityParametersResult = new Humidifier.Events.ConnectionTypes.InvocationConnectivityParameters();

        return invocationConnectivityParametersResult;
    }
    public override void CreateChildren(Humidifier.Events.ConnectionTypes.InvocationConnectivityParameters result)
    {
        base.CreateChildren(result);

        result.ResourceParameters ??= ResourceParametersFactory?.Build();
    }

} // End Of Class

public static class InnerConnectionInvocationConnectivityParametersFactoryExtensions
{
    public static CombinedResult<InnerConnectionInvocationConnectivityParametersFactory, InnerConnectionResourceParametersFactory> WithResourceParameters(this InnerConnectionInvocationConnectivityParametersFactory parentFactory, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null)
    {
        parentFactory.ResourceParametersFactory = new InnerConnectionResourceParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResourceParametersFactory);
    }

    public static CombinedResult<InnerConnectionInvocationConnectivityParametersFactory, T1, InnerConnectionResourceParametersFactory> WithResourceParameters<T1>(this CombinedResult<InnerConnectionInvocationConnectivityParametersFactory, T1> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectionInvocationConnectivityParametersFactory, InnerConnectionResourceParametersFactory> WithResourceParameters<T1>(this CombinedResult<T1, InnerConnectionInvocationConnectivityParametersFactory> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectionInvocationConnectivityParametersFactory, T1, T2, InnerConnectionResourceParametersFactory> WithResourceParameters<T1, T2>(this CombinedResult<InnerConnectionInvocationConnectivityParametersFactory, T1, T2> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectionInvocationConnectivityParametersFactory, T2, InnerConnectionResourceParametersFactory> WithResourceParameters<T1, T2>(this CombinedResult<T1, InnerConnectionInvocationConnectivityParametersFactory, T2> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectionInvocationConnectivityParametersFactory, InnerConnectionResourceParametersFactory> WithResourceParameters<T1, T2>(this CombinedResult<T1, T2, InnerConnectionInvocationConnectivityParametersFactory> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectionInvocationConnectivityParametersFactory, T1, T2, T3, InnerConnectionResourceParametersFactory> WithResourceParameters<T1, T2, T3>(this CombinedResult<InnerConnectionInvocationConnectivityParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectionInvocationConnectivityParametersFactory, T2, T3, InnerConnectionResourceParametersFactory> WithResourceParameters<T1, T2, T3>(this CombinedResult<T1, InnerConnectionInvocationConnectivityParametersFactory, T2, T3> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectionInvocationConnectivityParametersFactory, T3, InnerConnectionResourceParametersFactory> WithResourceParameters<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectionInvocationConnectivityParametersFactory, T3> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectionInvocationConnectivityParametersFactory, InnerConnectionResourceParametersFactory> WithResourceParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectionInvocationConnectivityParametersFactory> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectionInvocationConnectivityParametersFactory, T1, T2, T3, T4, InnerConnectionResourceParametersFactory> WithResourceParameters<T1, T2, T3, T4>(this CombinedResult<InnerConnectionInvocationConnectivityParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectionInvocationConnectivityParametersFactory, T2, T3, T4, InnerConnectionResourceParametersFactory> WithResourceParameters<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectionInvocationConnectivityParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectionInvocationConnectivityParametersFactory, T3, T4, InnerConnectionResourceParametersFactory> WithResourceParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectionInvocationConnectivityParametersFactory, T3, T4> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectionInvocationConnectivityParametersFactory, T4, InnerConnectionResourceParametersFactory> WithResourceParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectionInvocationConnectivityParametersFactory, T4> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectionInvocationConnectivityParametersFactory, InnerConnectionResourceParametersFactory> WithResourceParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectionInvocationConnectivityParametersFactory> combinedResult, Action<Humidifier.Events.ConnectionTypes.ResourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceParameters(combinedResult.T5, subFactoryAction));
}
