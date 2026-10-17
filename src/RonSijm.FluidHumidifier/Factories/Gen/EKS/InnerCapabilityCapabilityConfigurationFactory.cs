// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerCapabilityCapabilityConfigurationFactory(Action<Humidifier.EKS.CapabilityTypes.CapabilityConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EKS.CapabilityTypes.CapabilityConfiguration>
{

    internal InnerCapabilityAckFactory AckFactory { get; set; }

    internal InnerCapabilityArgoCdFactory ArgoCdFactory { get; set; }

    protected override Humidifier.EKS.CapabilityTypes.CapabilityConfiguration Create()
    {
        var capabilityConfigurationResult = CreateCapabilityConfiguration();
        factoryAction?.Invoke(capabilityConfigurationResult);

        return capabilityConfigurationResult;
    }

    private Humidifier.EKS.CapabilityTypes.CapabilityConfiguration CreateCapabilityConfiguration()
    {
        var capabilityConfigurationResult = new Humidifier.EKS.CapabilityTypes.CapabilityConfiguration();

        return capabilityConfigurationResult;
    }
    public override void CreateChildren(Humidifier.EKS.CapabilityTypes.CapabilityConfiguration result)
    {
        base.CreateChildren(result);

        result.Ack ??= AckFactory?.Build();
        result.ArgoCd ??= ArgoCdFactory?.Build();
    }

} // End Of Class

public static class InnerCapabilityCapabilityConfigurationFactoryExtensions
{
    public static CombinedResult<InnerCapabilityCapabilityConfigurationFactory, InnerCapabilityAckFactory> WithAck(this InnerCapabilityCapabilityConfigurationFactory parentFactory, Action<Humidifier.EKS.CapabilityTypes.Ack> subFactoryAction = null)
    {
        parentFactory.AckFactory = new InnerCapabilityAckFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AckFactory);
    }

    public static CombinedResult<InnerCapabilityCapabilityConfigurationFactory, InnerCapabilityArgoCdFactory> WithArgoCd(this InnerCapabilityCapabilityConfigurationFactory parentFactory, Action<Humidifier.EKS.CapabilityTypes.ArgoCd> subFactoryAction = null)
    {
        parentFactory.ArgoCdFactory = new InnerCapabilityArgoCdFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ArgoCdFactory);
    }

    public static CombinedResult<InnerCapabilityCapabilityConfigurationFactory, T1, InnerCapabilityAckFactory> WithAck<T1>(this CombinedResult<InnerCapabilityCapabilityConfigurationFactory, T1> combinedResult, Action<Humidifier.EKS.CapabilityTypes.Ack> subFactoryAction = null) => new (combinedResult, combinedResult, WithAck(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapabilityCapabilityConfigurationFactory, InnerCapabilityAckFactory> WithAck<T1>(this CombinedResult<T1, InnerCapabilityCapabilityConfigurationFactory> combinedResult, Action<Humidifier.EKS.CapabilityTypes.Ack> subFactoryAction = null) => new (combinedResult, combinedResult, WithAck(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCapabilityCapabilityConfigurationFactory, T1, T2, InnerCapabilityAckFactory> WithAck<T1, T2>(this CombinedResult<InnerCapabilityCapabilityConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.EKS.CapabilityTypes.Ack> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAck(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapabilityCapabilityConfigurationFactory, T2, InnerCapabilityAckFactory> WithAck<T1, T2>(this CombinedResult<T1, InnerCapabilityCapabilityConfigurationFactory, T2> combinedResult, Action<Humidifier.EKS.CapabilityTypes.Ack> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAck(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCapabilityCapabilityConfigurationFactory, InnerCapabilityAckFactory> WithAck<T1, T2>(this CombinedResult<T1, T2, InnerCapabilityCapabilityConfigurationFactory> combinedResult, Action<Humidifier.EKS.CapabilityTypes.Ack> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAck(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCapabilityCapabilityConfigurationFactory, T1, T2, T3, InnerCapabilityAckFactory> WithAck<T1, T2, T3>(this CombinedResult<InnerCapabilityCapabilityConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.EKS.CapabilityTypes.Ack> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAck(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapabilityCapabilityConfigurationFactory, T2, T3, InnerCapabilityAckFactory> WithAck<T1, T2, T3>(this CombinedResult<T1, InnerCapabilityCapabilityConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.EKS.CapabilityTypes.Ack> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAck(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCapabilityCapabilityConfigurationFactory, T3, InnerCapabilityAckFactory> WithAck<T1, T2, T3>(this CombinedResult<T1, T2, InnerCapabilityCapabilityConfigurationFactory, T3> combinedResult, Action<Humidifier.EKS.CapabilityTypes.Ack> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAck(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCapabilityCapabilityConfigurationFactory, InnerCapabilityAckFactory> WithAck<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCapabilityCapabilityConfigurationFactory> combinedResult, Action<Humidifier.EKS.CapabilityTypes.Ack> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAck(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCapabilityCapabilityConfigurationFactory, T1, T2, T3, T4, InnerCapabilityAckFactory> WithAck<T1, T2, T3, T4>(this CombinedResult<InnerCapabilityCapabilityConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EKS.CapabilityTypes.Ack> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAck(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapabilityCapabilityConfigurationFactory, T2, T3, T4, InnerCapabilityAckFactory> WithAck<T1, T2, T3, T4>(this CombinedResult<T1, InnerCapabilityCapabilityConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.EKS.CapabilityTypes.Ack> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAck(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCapabilityCapabilityConfigurationFactory, T3, T4, InnerCapabilityAckFactory> WithAck<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCapabilityCapabilityConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.EKS.CapabilityTypes.Ack> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAck(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCapabilityCapabilityConfigurationFactory, T4, InnerCapabilityAckFactory> WithAck<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCapabilityCapabilityConfigurationFactory, T4> combinedResult, Action<Humidifier.EKS.CapabilityTypes.Ack> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAck(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCapabilityCapabilityConfigurationFactory, InnerCapabilityAckFactory> WithAck<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCapabilityCapabilityConfigurationFactory> combinedResult, Action<Humidifier.EKS.CapabilityTypes.Ack> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAck(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerCapabilityCapabilityConfigurationFactory, T1, InnerCapabilityArgoCdFactory> WithArgoCd<T1>(this CombinedResult<InnerCapabilityCapabilityConfigurationFactory, T1> combinedResult, Action<Humidifier.EKS.CapabilityTypes.ArgoCd> subFactoryAction = null) => new (combinedResult, combinedResult, WithArgoCd(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapabilityCapabilityConfigurationFactory, InnerCapabilityArgoCdFactory> WithArgoCd<T1>(this CombinedResult<T1, InnerCapabilityCapabilityConfigurationFactory> combinedResult, Action<Humidifier.EKS.CapabilityTypes.ArgoCd> subFactoryAction = null) => new (combinedResult, combinedResult, WithArgoCd(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCapabilityCapabilityConfigurationFactory, T1, T2, InnerCapabilityArgoCdFactory> WithArgoCd<T1, T2>(this CombinedResult<InnerCapabilityCapabilityConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.EKS.CapabilityTypes.ArgoCd> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithArgoCd(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapabilityCapabilityConfigurationFactory, T2, InnerCapabilityArgoCdFactory> WithArgoCd<T1, T2>(this CombinedResult<T1, InnerCapabilityCapabilityConfigurationFactory, T2> combinedResult, Action<Humidifier.EKS.CapabilityTypes.ArgoCd> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithArgoCd(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCapabilityCapabilityConfigurationFactory, InnerCapabilityArgoCdFactory> WithArgoCd<T1, T2>(this CombinedResult<T1, T2, InnerCapabilityCapabilityConfigurationFactory> combinedResult, Action<Humidifier.EKS.CapabilityTypes.ArgoCd> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithArgoCd(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCapabilityCapabilityConfigurationFactory, T1, T2, T3, InnerCapabilityArgoCdFactory> WithArgoCd<T1, T2, T3>(this CombinedResult<InnerCapabilityCapabilityConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.EKS.CapabilityTypes.ArgoCd> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArgoCd(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapabilityCapabilityConfigurationFactory, T2, T3, InnerCapabilityArgoCdFactory> WithArgoCd<T1, T2, T3>(this CombinedResult<T1, InnerCapabilityCapabilityConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.EKS.CapabilityTypes.ArgoCd> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArgoCd(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCapabilityCapabilityConfigurationFactory, T3, InnerCapabilityArgoCdFactory> WithArgoCd<T1, T2, T3>(this CombinedResult<T1, T2, InnerCapabilityCapabilityConfigurationFactory, T3> combinedResult, Action<Humidifier.EKS.CapabilityTypes.ArgoCd> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArgoCd(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCapabilityCapabilityConfigurationFactory, InnerCapabilityArgoCdFactory> WithArgoCd<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCapabilityCapabilityConfigurationFactory> combinedResult, Action<Humidifier.EKS.CapabilityTypes.ArgoCd> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArgoCd(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCapabilityCapabilityConfigurationFactory, T1, T2, T3, T4, InnerCapabilityArgoCdFactory> WithArgoCd<T1, T2, T3, T4>(this CombinedResult<InnerCapabilityCapabilityConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EKS.CapabilityTypes.ArgoCd> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArgoCd(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapabilityCapabilityConfigurationFactory, T2, T3, T4, InnerCapabilityArgoCdFactory> WithArgoCd<T1, T2, T3, T4>(this CombinedResult<T1, InnerCapabilityCapabilityConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.EKS.CapabilityTypes.ArgoCd> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArgoCd(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCapabilityCapabilityConfigurationFactory, T3, T4, InnerCapabilityArgoCdFactory> WithArgoCd<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCapabilityCapabilityConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.EKS.CapabilityTypes.ArgoCd> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArgoCd(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCapabilityCapabilityConfigurationFactory, T4, InnerCapabilityArgoCdFactory> WithArgoCd<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCapabilityCapabilityConfigurationFactory, T4> combinedResult, Action<Humidifier.EKS.CapabilityTypes.ArgoCd> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArgoCd(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCapabilityCapabilityConfigurationFactory, InnerCapabilityArgoCdFactory> WithArgoCd<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCapabilityCapabilityConfigurationFactory> combinedResult, Action<Humidifier.EKS.CapabilityTypes.ArgoCd> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArgoCd(combinedResult.T5, subFactoryAction).T2);
}
