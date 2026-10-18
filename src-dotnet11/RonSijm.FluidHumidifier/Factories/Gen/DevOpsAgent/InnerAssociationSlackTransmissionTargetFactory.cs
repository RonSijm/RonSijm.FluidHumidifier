// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerAssociationSlackTransmissionTargetFactory(Action<Humidifier.DevOpsAgent.AssociationTypes.SlackTransmissionTarget> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.AssociationTypes.SlackTransmissionTarget>
{

    internal InnerAssociationSlackChannelFactory IncidentResponseTargetFactory { get; set; }

    protected override Humidifier.DevOpsAgent.AssociationTypes.SlackTransmissionTarget Create()
    {
        var slackTransmissionTargetResult = CreateSlackTransmissionTarget();
        factoryAction?.Invoke(slackTransmissionTargetResult);

        return slackTransmissionTargetResult;
    }

    private Humidifier.DevOpsAgent.AssociationTypes.SlackTransmissionTarget CreateSlackTransmissionTarget()
    {
        var slackTransmissionTargetResult = new Humidifier.DevOpsAgent.AssociationTypes.SlackTransmissionTarget();

        return slackTransmissionTargetResult;
    }
    public override void CreateChildren(Humidifier.DevOpsAgent.AssociationTypes.SlackTransmissionTarget result)
    {
        base.CreateChildren(result);

        result.IncidentResponseTarget ??= IncidentResponseTargetFactory?.Build();
    }

} // End Of Class

public static class InnerAssociationSlackTransmissionTargetFactoryExtensions
{
    public static CombinedResult<InnerAssociationSlackTransmissionTargetFactory, InnerAssociationSlackChannelFactory> WithIncidentResponseTarget(this InnerAssociationSlackTransmissionTargetFactory parentFactory, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackChannel> subFactoryAction = null)
    {
        parentFactory.IncidentResponseTargetFactory = new InnerAssociationSlackChannelFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IncidentResponseTargetFactory);
    }

    public static CombinedResult<InnerAssociationSlackTransmissionTargetFactory, T1, InnerAssociationSlackChannelFactory> WithIncidentResponseTarget<T1>(this CombinedResult<InnerAssociationSlackTransmissionTargetFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackChannel> subFactoryAction = null) => new (combinedResult, combinedResult, WithIncidentResponseTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAssociationSlackTransmissionTargetFactory, InnerAssociationSlackChannelFactory> WithIncidentResponseTarget<T1>(this CombinedResult<T1, InnerAssociationSlackTransmissionTargetFactory> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackChannel> subFactoryAction = null) => new (combinedResult, combinedResult, WithIncidentResponseTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAssociationSlackTransmissionTargetFactory, T1, T2, InnerAssociationSlackChannelFactory> WithIncidentResponseTarget<T1, T2>(this CombinedResult<InnerAssociationSlackTransmissionTargetFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIncidentResponseTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAssociationSlackTransmissionTargetFactory, T2, InnerAssociationSlackChannelFactory> WithIncidentResponseTarget<T1, T2>(this CombinedResult<T1, InnerAssociationSlackTransmissionTargetFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIncidentResponseTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAssociationSlackTransmissionTargetFactory, InnerAssociationSlackChannelFactory> WithIncidentResponseTarget<T1, T2>(this CombinedResult<T1, T2, InnerAssociationSlackTransmissionTargetFactory> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIncidentResponseTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAssociationSlackTransmissionTargetFactory, T1, T2, T3, InnerAssociationSlackChannelFactory> WithIncidentResponseTarget<T1, T2, T3>(this CombinedResult<InnerAssociationSlackTransmissionTargetFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncidentResponseTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAssociationSlackTransmissionTargetFactory, T2, T3, InnerAssociationSlackChannelFactory> WithIncidentResponseTarget<T1, T2, T3>(this CombinedResult<T1, InnerAssociationSlackTransmissionTargetFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncidentResponseTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAssociationSlackTransmissionTargetFactory, T3, InnerAssociationSlackChannelFactory> WithIncidentResponseTarget<T1, T2, T3>(this CombinedResult<T1, T2, InnerAssociationSlackTransmissionTargetFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncidentResponseTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAssociationSlackTransmissionTargetFactory, InnerAssociationSlackChannelFactory> WithIncidentResponseTarget<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAssociationSlackTransmissionTargetFactory> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncidentResponseTarget(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAssociationSlackTransmissionTargetFactory, T1, T2, T3, T4, InnerAssociationSlackChannelFactory> WithIncidentResponseTarget<T1, T2, T3, T4>(this CombinedResult<InnerAssociationSlackTransmissionTargetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncidentResponseTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAssociationSlackTransmissionTargetFactory, T2, T3, T4, InnerAssociationSlackChannelFactory> WithIncidentResponseTarget<T1, T2, T3, T4>(this CombinedResult<T1, InnerAssociationSlackTransmissionTargetFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncidentResponseTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAssociationSlackTransmissionTargetFactory, T3, T4, InnerAssociationSlackChannelFactory> WithIncidentResponseTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAssociationSlackTransmissionTargetFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncidentResponseTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAssociationSlackTransmissionTargetFactory, T4, InnerAssociationSlackChannelFactory> WithIncidentResponseTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAssociationSlackTransmissionTargetFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncidentResponseTarget(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAssociationSlackTransmissionTargetFactory, InnerAssociationSlackChannelFactory> WithIncidentResponseTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAssociationSlackTransmissionTargetFactory> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncidentResponseTarget(combinedResult.T5, subFactoryAction).T2);
}
