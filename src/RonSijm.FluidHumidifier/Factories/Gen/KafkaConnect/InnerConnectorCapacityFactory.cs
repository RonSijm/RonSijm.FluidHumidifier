// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KafkaConnect;

public class InnerConnectorCapacityFactory(Action<Humidifier.KafkaConnect.ConnectorTypes.Capacity> factoryAction = null) : SubResourceFactory<Humidifier.KafkaConnect.ConnectorTypes.Capacity>
{

    internal InnerConnectorProvisionedCapacityFactory ProvisionedCapacityFactory { get; set; }

    internal InnerConnectorAutoScalingFactory AutoScalingFactory { get; set; }

    protected override Humidifier.KafkaConnect.ConnectorTypes.Capacity Create()
    {
        var capacityResult = CreateCapacity();
        factoryAction?.Invoke(capacityResult);

        return capacityResult;
    }

    private Humidifier.KafkaConnect.ConnectorTypes.Capacity CreateCapacity()
    {
        var capacityResult = new Humidifier.KafkaConnect.ConnectorTypes.Capacity();

        return capacityResult;
    }
    public override void CreateChildren(Humidifier.KafkaConnect.ConnectorTypes.Capacity result)
    {
        base.CreateChildren(result);

        result.ProvisionedCapacity ??= ProvisionedCapacityFactory?.Build();
        result.AutoScaling ??= AutoScalingFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorCapacityFactoryExtensions
{
    public static CombinedResult<InnerConnectorCapacityFactory, InnerConnectorProvisionedCapacityFactory> WithProvisionedCapacity(this InnerConnectorCapacityFactory parentFactory, Action<Humidifier.KafkaConnect.ConnectorTypes.ProvisionedCapacity> subFactoryAction = null)
    {
        parentFactory.ProvisionedCapacityFactory = new InnerConnectorProvisionedCapacityFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProvisionedCapacityFactory);
    }

    public static CombinedResult<InnerConnectorCapacityFactory, InnerConnectorAutoScalingFactory> WithAutoScaling(this InnerConnectorCapacityFactory parentFactory, Action<Humidifier.KafkaConnect.ConnectorTypes.AutoScaling> subFactoryAction = null)
    {
        parentFactory.AutoScalingFactory = new InnerConnectorAutoScalingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AutoScalingFactory);
    }

    public static CombinedResult<InnerConnectorCapacityFactory, T1, InnerConnectorProvisionedCapacityFactory> WithProvisionedCapacity<T1>(this CombinedResult<InnerConnectorCapacityFactory, T1> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ProvisionedCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, WithProvisionedCapacity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorCapacityFactory, InnerConnectorProvisionedCapacityFactory> WithProvisionedCapacity<T1>(this CombinedResult<T1, InnerConnectorCapacityFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ProvisionedCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, WithProvisionedCapacity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectorCapacityFactory, T1, T2, InnerConnectorProvisionedCapacityFactory> WithProvisionedCapacity<T1, T2>(this CombinedResult<InnerConnectorCapacityFactory, T1, T2> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ProvisionedCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvisionedCapacity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorCapacityFactory, T2, InnerConnectorProvisionedCapacityFactory> WithProvisionedCapacity<T1, T2>(this CombinedResult<T1, InnerConnectorCapacityFactory, T2> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ProvisionedCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvisionedCapacity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorCapacityFactory, InnerConnectorProvisionedCapacityFactory> WithProvisionedCapacity<T1, T2>(this CombinedResult<T1, T2, InnerConnectorCapacityFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ProvisionedCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvisionedCapacity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectorCapacityFactory, T1, T2, T3, InnerConnectorProvisionedCapacityFactory> WithProvisionedCapacity<T1, T2, T3>(this CombinedResult<InnerConnectorCapacityFactory, T1, T2, T3> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ProvisionedCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedCapacity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorCapacityFactory, T2, T3, InnerConnectorProvisionedCapacityFactory> WithProvisionedCapacity<T1, T2, T3>(this CombinedResult<T1, InnerConnectorCapacityFactory, T2, T3> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ProvisionedCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedCapacity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorCapacityFactory, T3, InnerConnectorProvisionedCapacityFactory> WithProvisionedCapacity<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorCapacityFactory, T3> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ProvisionedCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedCapacity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorCapacityFactory, InnerConnectorProvisionedCapacityFactory> WithProvisionedCapacity<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorCapacityFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ProvisionedCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedCapacity(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectorCapacityFactory, T1, T2, T3, T4, InnerConnectorProvisionedCapacityFactory> WithProvisionedCapacity<T1, T2, T3, T4>(this CombinedResult<InnerConnectorCapacityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ProvisionedCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedCapacity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorCapacityFactory, T2, T3, T4, InnerConnectorProvisionedCapacityFactory> WithProvisionedCapacity<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorCapacityFactory, T2, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ProvisionedCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedCapacity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorCapacityFactory, T3, T4, InnerConnectorProvisionedCapacityFactory> WithProvisionedCapacity<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorCapacityFactory, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ProvisionedCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedCapacity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorCapacityFactory, T4, InnerConnectorProvisionedCapacityFactory> WithProvisionedCapacity<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorCapacityFactory, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ProvisionedCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedCapacity(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorCapacityFactory, InnerConnectorProvisionedCapacityFactory> WithProvisionedCapacity<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorCapacityFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ProvisionedCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedCapacity(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerConnectorCapacityFactory, T1, InnerConnectorAutoScalingFactory> WithAutoScaling<T1>(this CombinedResult<InnerConnectorCapacityFactory, T1> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.AutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, WithAutoScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorCapacityFactory, InnerConnectorAutoScalingFactory> WithAutoScaling<T1>(this CombinedResult<T1, InnerConnectorCapacityFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.AutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, WithAutoScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectorCapacityFactory, T1, T2, InnerConnectorAutoScalingFactory> WithAutoScaling<T1, T2>(this CombinedResult<InnerConnectorCapacityFactory, T1, T2> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.AutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorCapacityFactory, T2, InnerConnectorAutoScalingFactory> WithAutoScaling<T1, T2>(this CombinedResult<T1, InnerConnectorCapacityFactory, T2> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.AutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorCapacityFactory, InnerConnectorAutoScalingFactory> WithAutoScaling<T1, T2>(this CombinedResult<T1, T2, InnerConnectorCapacityFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.AutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoScaling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectorCapacityFactory, T1, T2, T3, InnerConnectorAutoScalingFactory> WithAutoScaling<T1, T2, T3>(this CombinedResult<InnerConnectorCapacityFactory, T1, T2, T3> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.AutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorCapacityFactory, T2, T3, InnerConnectorAutoScalingFactory> WithAutoScaling<T1, T2, T3>(this CombinedResult<T1, InnerConnectorCapacityFactory, T2, T3> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.AutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorCapacityFactory, T3, InnerConnectorAutoScalingFactory> WithAutoScaling<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorCapacityFactory, T3> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.AutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScaling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorCapacityFactory, InnerConnectorAutoScalingFactory> WithAutoScaling<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorCapacityFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.AutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScaling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectorCapacityFactory, T1, T2, T3, T4, InnerConnectorAutoScalingFactory> WithAutoScaling<T1, T2, T3, T4>(this CombinedResult<InnerConnectorCapacityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.AutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorCapacityFactory, T2, T3, T4, InnerConnectorAutoScalingFactory> WithAutoScaling<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorCapacityFactory, T2, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.AutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorCapacityFactory, T3, T4, InnerConnectorAutoScalingFactory> WithAutoScaling<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorCapacityFactory, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.AutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScaling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorCapacityFactory, T4, InnerConnectorAutoScalingFactory> WithAutoScaling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorCapacityFactory, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.AutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScaling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorCapacityFactory, InnerConnectorAutoScalingFactory> WithAutoScaling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorCapacityFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.AutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScaling(combinedResult.T5, subFactoryAction));
}
