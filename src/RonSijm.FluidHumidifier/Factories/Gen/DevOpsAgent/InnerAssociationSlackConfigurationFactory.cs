// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerAssociationSlackConfigurationFactory(Action<Humidifier.DevOpsAgent.AssociationTypes.SlackConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.AssociationTypes.SlackConfiguration>
{

    internal InnerAssociationSlackTransmissionTargetFactory TransmissionTargetFactory { get; set; }

    protected override Humidifier.DevOpsAgent.AssociationTypes.SlackConfiguration Create()
    {
        var slackConfigurationResult = CreateSlackConfiguration();
        factoryAction?.Invoke(slackConfigurationResult);

        return slackConfigurationResult;
    }

    private Humidifier.DevOpsAgent.AssociationTypes.SlackConfiguration CreateSlackConfiguration()
    {
        var slackConfigurationResult = new Humidifier.DevOpsAgent.AssociationTypes.SlackConfiguration();

        return slackConfigurationResult;
    }
    public override void CreateChildren(Humidifier.DevOpsAgent.AssociationTypes.SlackConfiguration result)
    {
        base.CreateChildren(result);

        result.TransmissionTarget ??= TransmissionTargetFactory?.Build();
    }

} // End Of Class

public static class InnerAssociationSlackConfigurationFactoryExtensions
{
    public static CombinedResult<InnerAssociationSlackConfigurationFactory, InnerAssociationSlackTransmissionTargetFactory> WithTransmissionTarget(this InnerAssociationSlackConfigurationFactory parentFactory, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackTransmissionTarget> subFactoryAction = null)
    {
        parentFactory.TransmissionTargetFactory = new InnerAssociationSlackTransmissionTargetFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TransmissionTargetFactory);
    }

    public static CombinedResult<InnerAssociationSlackConfigurationFactory, T1, InnerAssociationSlackTransmissionTargetFactory> WithTransmissionTarget<T1>(this CombinedResult<InnerAssociationSlackConfigurationFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackTransmissionTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithTransmissionTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAssociationSlackConfigurationFactory, InnerAssociationSlackTransmissionTargetFactory> WithTransmissionTarget<T1>(this CombinedResult<T1, InnerAssociationSlackConfigurationFactory> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackTransmissionTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithTransmissionTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAssociationSlackConfigurationFactory, T1, T2, InnerAssociationSlackTransmissionTargetFactory> WithTransmissionTarget<T1, T2>(this CombinedResult<InnerAssociationSlackConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackTransmissionTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTransmissionTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAssociationSlackConfigurationFactory, T2, InnerAssociationSlackTransmissionTargetFactory> WithTransmissionTarget<T1, T2>(this CombinedResult<T1, InnerAssociationSlackConfigurationFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackTransmissionTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTransmissionTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAssociationSlackConfigurationFactory, InnerAssociationSlackTransmissionTargetFactory> WithTransmissionTarget<T1, T2>(this CombinedResult<T1, T2, InnerAssociationSlackConfigurationFactory> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackTransmissionTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTransmissionTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAssociationSlackConfigurationFactory, T1, T2, T3, InnerAssociationSlackTransmissionTargetFactory> WithTransmissionTarget<T1, T2, T3>(this CombinedResult<InnerAssociationSlackConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackTransmissionTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransmissionTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAssociationSlackConfigurationFactory, T2, T3, InnerAssociationSlackTransmissionTargetFactory> WithTransmissionTarget<T1, T2, T3>(this CombinedResult<T1, InnerAssociationSlackConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackTransmissionTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransmissionTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAssociationSlackConfigurationFactory, T3, InnerAssociationSlackTransmissionTargetFactory> WithTransmissionTarget<T1, T2, T3>(this CombinedResult<T1, T2, InnerAssociationSlackConfigurationFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackTransmissionTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransmissionTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAssociationSlackConfigurationFactory, InnerAssociationSlackTransmissionTargetFactory> WithTransmissionTarget<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAssociationSlackConfigurationFactory> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackTransmissionTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransmissionTarget(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAssociationSlackConfigurationFactory, T1, T2, T3, T4, InnerAssociationSlackTransmissionTargetFactory> WithTransmissionTarget<T1, T2, T3, T4>(this CombinedResult<InnerAssociationSlackConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackTransmissionTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransmissionTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAssociationSlackConfigurationFactory, T2, T3, T4, InnerAssociationSlackTransmissionTargetFactory> WithTransmissionTarget<T1, T2, T3, T4>(this CombinedResult<T1, InnerAssociationSlackConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackTransmissionTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransmissionTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAssociationSlackConfigurationFactory, T3, T4, InnerAssociationSlackTransmissionTargetFactory> WithTransmissionTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAssociationSlackConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackTransmissionTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransmissionTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAssociationSlackConfigurationFactory, T4, InnerAssociationSlackTransmissionTargetFactory> WithTransmissionTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAssociationSlackConfigurationFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackTransmissionTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransmissionTarget(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAssociationSlackConfigurationFactory, InnerAssociationSlackTransmissionTargetFactory> WithTransmissionTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAssociationSlackConfigurationFactory> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.SlackTransmissionTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransmissionTarget(combinedResult.T5, subFactoryAction).T2);
}
