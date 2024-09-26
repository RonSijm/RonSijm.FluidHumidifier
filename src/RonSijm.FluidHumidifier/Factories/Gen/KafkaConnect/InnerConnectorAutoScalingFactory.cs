// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KafkaConnect;

public class InnerConnectorAutoScalingFactory(Action<Humidifier.KafkaConnect.ConnectorTypes.AutoScaling> factoryAction = null) : SubResourceFactory<Humidifier.KafkaConnect.ConnectorTypes.AutoScaling>
{

    internal InnerConnectorScaleOutPolicyFactory ScaleOutPolicyFactory { get; set; }

    internal InnerConnectorScaleInPolicyFactory ScaleInPolicyFactory { get; set; }

    protected override Humidifier.KafkaConnect.ConnectorTypes.AutoScaling Create()
    {
        var autoScalingResult = CreateAutoScaling();
        factoryAction?.Invoke(autoScalingResult);

        return autoScalingResult;
    }

    private Humidifier.KafkaConnect.ConnectorTypes.AutoScaling CreateAutoScaling()
    {
        var autoScalingResult = new Humidifier.KafkaConnect.ConnectorTypes.AutoScaling();

        return autoScalingResult;
    }
    public override void CreateChildren(Humidifier.KafkaConnect.ConnectorTypes.AutoScaling result)
    {
        base.CreateChildren(result);

        result.ScaleOutPolicy ??= ScaleOutPolicyFactory?.Build();
        result.ScaleInPolicy ??= ScaleInPolicyFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorAutoScalingFactoryExtensions
{
    public static CombinedResult<InnerConnectorAutoScalingFactory, InnerConnectorScaleOutPolicyFactory> WithScaleOutPolicy(this InnerConnectorAutoScalingFactory parentFactory, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleOutPolicy> subFactoryAction = null)
    {
        parentFactory.ScaleOutPolicyFactory = new InnerConnectorScaleOutPolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScaleOutPolicyFactory);
    }

    public static CombinedResult<InnerConnectorAutoScalingFactory, InnerConnectorScaleInPolicyFactory> WithScaleInPolicy(this InnerConnectorAutoScalingFactory parentFactory, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleInPolicy> subFactoryAction = null)
    {
        parentFactory.ScaleInPolicyFactory = new InnerConnectorScaleInPolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScaleInPolicyFactory);
    }

    public static CombinedResult<InnerConnectorAutoScalingFactory, T1, InnerConnectorScaleOutPolicyFactory> WithScaleOutPolicy<T1>(this CombinedResult<InnerConnectorAutoScalingFactory, T1> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleOutPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithScaleOutPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorAutoScalingFactory, InnerConnectorScaleOutPolicyFactory> WithScaleOutPolicy<T1>(this CombinedResult<T1, InnerConnectorAutoScalingFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleOutPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithScaleOutPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectorAutoScalingFactory, T1, T2, InnerConnectorScaleOutPolicyFactory> WithScaleOutPolicy<T1, T2>(this CombinedResult<InnerConnectorAutoScalingFactory, T1, T2> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleOutPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScaleOutPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorAutoScalingFactory, T2, InnerConnectorScaleOutPolicyFactory> WithScaleOutPolicy<T1, T2>(this CombinedResult<T1, InnerConnectorAutoScalingFactory, T2> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleOutPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScaleOutPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorAutoScalingFactory, InnerConnectorScaleOutPolicyFactory> WithScaleOutPolicy<T1, T2>(this CombinedResult<T1, T2, InnerConnectorAutoScalingFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleOutPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScaleOutPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectorAutoScalingFactory, T1, T2, T3, InnerConnectorScaleOutPolicyFactory> WithScaleOutPolicy<T1, T2, T3>(this CombinedResult<InnerConnectorAutoScalingFactory, T1, T2, T3> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleOutPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScaleOutPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorAutoScalingFactory, T2, T3, InnerConnectorScaleOutPolicyFactory> WithScaleOutPolicy<T1, T2, T3>(this CombinedResult<T1, InnerConnectorAutoScalingFactory, T2, T3> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleOutPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScaleOutPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorAutoScalingFactory, T3, InnerConnectorScaleOutPolicyFactory> WithScaleOutPolicy<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorAutoScalingFactory, T3> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleOutPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScaleOutPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorAutoScalingFactory, InnerConnectorScaleOutPolicyFactory> WithScaleOutPolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorAutoScalingFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleOutPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScaleOutPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectorAutoScalingFactory, T1, T2, T3, T4, InnerConnectorScaleOutPolicyFactory> WithScaleOutPolicy<T1, T2, T3, T4>(this CombinedResult<InnerConnectorAutoScalingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleOutPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScaleOutPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorAutoScalingFactory, T2, T3, T4, InnerConnectorScaleOutPolicyFactory> WithScaleOutPolicy<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorAutoScalingFactory, T2, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleOutPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScaleOutPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorAutoScalingFactory, T3, T4, InnerConnectorScaleOutPolicyFactory> WithScaleOutPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorAutoScalingFactory, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleOutPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScaleOutPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorAutoScalingFactory, T4, InnerConnectorScaleOutPolicyFactory> WithScaleOutPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorAutoScalingFactory, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleOutPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScaleOutPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorAutoScalingFactory, InnerConnectorScaleOutPolicyFactory> WithScaleOutPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorAutoScalingFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleOutPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScaleOutPolicy(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerConnectorAutoScalingFactory, T1, InnerConnectorScaleInPolicyFactory> WithScaleInPolicy<T1>(this CombinedResult<InnerConnectorAutoScalingFactory, T1> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorAutoScalingFactory, InnerConnectorScaleInPolicyFactory> WithScaleInPolicy<T1>(this CombinedResult<T1, InnerConnectorAutoScalingFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectorAutoScalingFactory, T1, T2, InnerConnectorScaleInPolicyFactory> WithScaleInPolicy<T1, T2>(this CombinedResult<InnerConnectorAutoScalingFactory, T1, T2> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorAutoScalingFactory, T2, InnerConnectorScaleInPolicyFactory> WithScaleInPolicy<T1, T2>(this CombinedResult<T1, InnerConnectorAutoScalingFactory, T2> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorAutoScalingFactory, InnerConnectorScaleInPolicyFactory> WithScaleInPolicy<T1, T2>(this CombinedResult<T1, T2, InnerConnectorAutoScalingFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectorAutoScalingFactory, T1, T2, T3, InnerConnectorScaleInPolicyFactory> WithScaleInPolicy<T1, T2, T3>(this CombinedResult<InnerConnectorAutoScalingFactory, T1, T2, T3> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorAutoScalingFactory, T2, T3, InnerConnectorScaleInPolicyFactory> WithScaleInPolicy<T1, T2, T3>(this CombinedResult<T1, InnerConnectorAutoScalingFactory, T2, T3> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorAutoScalingFactory, T3, InnerConnectorScaleInPolicyFactory> WithScaleInPolicy<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorAutoScalingFactory, T3> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorAutoScalingFactory, InnerConnectorScaleInPolicyFactory> WithScaleInPolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorAutoScalingFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectorAutoScalingFactory, T1, T2, T3, T4, InnerConnectorScaleInPolicyFactory> WithScaleInPolicy<T1, T2, T3, T4>(this CombinedResult<InnerConnectorAutoScalingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorAutoScalingFactory, T2, T3, T4, InnerConnectorScaleInPolicyFactory> WithScaleInPolicy<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorAutoScalingFactory, T2, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorAutoScalingFactory, T3, T4, InnerConnectorScaleInPolicyFactory> WithScaleInPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorAutoScalingFactory, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorAutoScalingFactory, T4, InnerConnectorScaleInPolicyFactory> WithScaleInPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorAutoScalingFactory, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorAutoScalingFactory, InnerConnectorScaleInPolicyFactory> WithScaleInPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorAutoScalingFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScaleInPolicy(combinedResult.T5, subFactoryAction));
}
