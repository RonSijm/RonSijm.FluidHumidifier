// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FraudDetector;

public class EventTypeFactory(string resourceName = null, Action<Humidifier.FraudDetector.EventType> factoryAction = null) : ResourceFactory<Humidifier.FraudDetector.EventType>(resourceName)
{

    internal List<InnerEventTypeEntityTypeFactory> EntityTypesFactories { get; set; } = [];

    internal List<InnerEventTypeLabelFactory> LabelsFactories { get; set; } = [];

    internal List<InnerEventTypeEventVariableFactory> EventVariablesFactories { get; set; } = [];

    protected override Humidifier.FraudDetector.EventType Create()
    {
        var eventTypeResult = CreateEventType();
        factoryAction?.Invoke(eventTypeResult);

        return eventTypeResult;
    }

    private Humidifier.FraudDetector.EventType CreateEventType()
    {
        var eventTypeResult = new Humidifier.FraudDetector.EventType
        {
            GivenName = InputResourceName,
        };

        return eventTypeResult;
    }
    public override void CreateChildren(Humidifier.FraudDetector.EventType result)
    {
        base.CreateChildren(result);

        result.EntityTypes = EntityTypesFactories.Any() ? EntityTypesFactories.Select(x => x.Build()).ToList() : null;
        result.Labels = LabelsFactories.Any() ? LabelsFactories.Select(x => x.Build()).ToList() : null;
        result.EventVariables = EventVariablesFactories.Any() ? EventVariablesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class EventTypeFactoryExtensions
{
    public static CombinedResult<EventTypeFactory, InnerEventTypeEntityTypeFactory> WithEntityTypes(this EventTypeFactory parentFactory, Action<Humidifier.FraudDetector.EventTypeTypes.EntityType> subFactoryAction = null)
    {
        var factory = new InnerEventTypeEntityTypeFactory(subFactoryAction);
        parentFactory.EntityTypesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<EventTypeFactory, InnerEventTypeLabelFactory> WithLabels(this EventTypeFactory parentFactory, Action<Humidifier.FraudDetector.EventTypeTypes.Label> subFactoryAction = null)
    {
        var factory = new InnerEventTypeLabelFactory(subFactoryAction);
        parentFactory.LabelsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<EventTypeFactory, InnerEventTypeEventVariableFactory> WithEventVariables(this EventTypeFactory parentFactory, Action<Humidifier.FraudDetector.EventTypeTypes.EventVariable> subFactoryAction = null)
    {
        var factory = new InnerEventTypeEventVariableFactory(subFactoryAction);
        parentFactory.EventVariablesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<EventTypeFactory, T1, InnerEventTypeEntityTypeFactory> WithEntityTypes<T1>(this CombinedResult<EventTypeFactory, T1> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EntityType> subFactoryAction = null) => new (combinedResult, combinedResult, WithEntityTypes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventTypeFactory, InnerEventTypeEntityTypeFactory> WithEntityTypes<T1>(this CombinedResult<T1, EventTypeFactory> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EntityType> subFactoryAction = null) => new (combinedResult, combinedResult, WithEntityTypes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EventTypeFactory, T1, T2, InnerEventTypeEntityTypeFactory> WithEntityTypes<T1, T2>(this CombinedResult<EventTypeFactory, T1, T2> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EntityType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntityTypes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventTypeFactory, T2, InnerEventTypeEntityTypeFactory> WithEntityTypes<T1, T2>(this CombinedResult<T1, EventTypeFactory, T2> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EntityType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntityTypes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventTypeFactory, InnerEventTypeEntityTypeFactory> WithEntityTypes<T1, T2>(this CombinedResult<T1, T2, EventTypeFactory> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EntityType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntityTypes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EventTypeFactory, T1, T2, T3, InnerEventTypeEntityTypeFactory> WithEntityTypes<T1, T2, T3>(this CombinedResult<EventTypeFactory, T1, T2, T3> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EntityType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntityTypes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventTypeFactory, T2, T3, InnerEventTypeEntityTypeFactory> WithEntityTypes<T1, T2, T3>(this CombinedResult<T1, EventTypeFactory, T2, T3> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EntityType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntityTypes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventTypeFactory, T3, InnerEventTypeEntityTypeFactory> WithEntityTypes<T1, T2, T3>(this CombinedResult<T1, T2, EventTypeFactory, T3> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EntityType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntityTypes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EventTypeFactory, InnerEventTypeEntityTypeFactory> WithEntityTypes<T1, T2, T3>(this CombinedResult<T1, T2, T3, EventTypeFactory> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EntityType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntityTypes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EventTypeFactory, T1, T2, T3, T4, InnerEventTypeEntityTypeFactory> WithEntityTypes<T1, T2, T3, T4>(this CombinedResult<EventTypeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EntityType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntityTypes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventTypeFactory, T2, T3, T4, InnerEventTypeEntityTypeFactory> WithEntityTypes<T1, T2, T3, T4>(this CombinedResult<T1, EventTypeFactory, T2, T3, T4> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EntityType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntityTypes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventTypeFactory, T3, T4, InnerEventTypeEntityTypeFactory> WithEntityTypes<T1, T2, T3, T4>(this CombinedResult<T1, T2, EventTypeFactory, T3, T4> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EntityType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntityTypes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EventTypeFactory, T4, InnerEventTypeEntityTypeFactory> WithEntityTypes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EventTypeFactory, T4> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EntityType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntityTypes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EventTypeFactory, InnerEventTypeEntityTypeFactory> WithEntityTypes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EventTypeFactory> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EntityType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntityTypes(combinedResult.T5, subFactoryAction));
    public static CombinedResult<EventTypeFactory, T1, InnerEventTypeLabelFactory> WithLabels<T1>(this CombinedResult<EventTypeFactory, T1> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, WithLabels(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventTypeFactory, InnerEventTypeLabelFactory> WithLabels<T1>(this CombinedResult<T1, EventTypeFactory> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, WithLabels(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EventTypeFactory, T1, T2, InnerEventTypeLabelFactory> WithLabels<T1, T2>(this CombinedResult<EventTypeFactory, T1, T2> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLabels(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventTypeFactory, T2, InnerEventTypeLabelFactory> WithLabels<T1, T2>(this CombinedResult<T1, EventTypeFactory, T2> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLabels(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventTypeFactory, InnerEventTypeLabelFactory> WithLabels<T1, T2>(this CombinedResult<T1, T2, EventTypeFactory> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLabels(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EventTypeFactory, T1, T2, T3, InnerEventTypeLabelFactory> WithLabels<T1, T2, T3>(this CombinedResult<EventTypeFactory, T1, T2, T3> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLabels(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventTypeFactory, T2, T3, InnerEventTypeLabelFactory> WithLabels<T1, T2, T3>(this CombinedResult<T1, EventTypeFactory, T2, T3> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLabels(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventTypeFactory, T3, InnerEventTypeLabelFactory> WithLabels<T1, T2, T3>(this CombinedResult<T1, T2, EventTypeFactory, T3> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLabels(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EventTypeFactory, InnerEventTypeLabelFactory> WithLabels<T1, T2, T3>(this CombinedResult<T1, T2, T3, EventTypeFactory> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLabels(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EventTypeFactory, T1, T2, T3, T4, InnerEventTypeLabelFactory> WithLabels<T1, T2, T3, T4>(this CombinedResult<EventTypeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLabels(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventTypeFactory, T2, T3, T4, InnerEventTypeLabelFactory> WithLabels<T1, T2, T3, T4>(this CombinedResult<T1, EventTypeFactory, T2, T3, T4> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLabels(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventTypeFactory, T3, T4, InnerEventTypeLabelFactory> WithLabels<T1, T2, T3, T4>(this CombinedResult<T1, T2, EventTypeFactory, T3, T4> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLabels(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EventTypeFactory, T4, InnerEventTypeLabelFactory> WithLabels<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EventTypeFactory, T4> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLabels(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EventTypeFactory, InnerEventTypeLabelFactory> WithLabels<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EventTypeFactory> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.Label> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLabels(combinedResult.T5, subFactoryAction));
    public static CombinedResult<EventTypeFactory, T1, InnerEventTypeEventVariableFactory> WithEventVariables<T1>(this CombinedResult<EventTypeFactory, T1> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EventVariable> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventVariables(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventTypeFactory, InnerEventTypeEventVariableFactory> WithEventVariables<T1>(this CombinedResult<T1, EventTypeFactory> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EventVariable> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventVariables(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EventTypeFactory, T1, T2, InnerEventTypeEventVariableFactory> WithEventVariables<T1, T2>(this CombinedResult<EventTypeFactory, T1, T2> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EventVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventVariables(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventTypeFactory, T2, InnerEventTypeEventVariableFactory> WithEventVariables<T1, T2>(this CombinedResult<T1, EventTypeFactory, T2> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EventVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventVariables(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventTypeFactory, InnerEventTypeEventVariableFactory> WithEventVariables<T1, T2>(this CombinedResult<T1, T2, EventTypeFactory> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EventVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventVariables(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EventTypeFactory, T1, T2, T3, InnerEventTypeEventVariableFactory> WithEventVariables<T1, T2, T3>(this CombinedResult<EventTypeFactory, T1, T2, T3> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EventVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventVariables(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventTypeFactory, T2, T3, InnerEventTypeEventVariableFactory> WithEventVariables<T1, T2, T3>(this CombinedResult<T1, EventTypeFactory, T2, T3> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EventVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventVariables(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventTypeFactory, T3, InnerEventTypeEventVariableFactory> WithEventVariables<T1, T2, T3>(this CombinedResult<T1, T2, EventTypeFactory, T3> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EventVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventVariables(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EventTypeFactory, InnerEventTypeEventVariableFactory> WithEventVariables<T1, T2, T3>(this CombinedResult<T1, T2, T3, EventTypeFactory> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EventVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventVariables(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EventTypeFactory, T1, T2, T3, T4, InnerEventTypeEventVariableFactory> WithEventVariables<T1, T2, T3, T4>(this CombinedResult<EventTypeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EventVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventVariables(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventTypeFactory, T2, T3, T4, InnerEventTypeEventVariableFactory> WithEventVariables<T1, T2, T3, T4>(this CombinedResult<T1, EventTypeFactory, T2, T3, T4> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EventVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventVariables(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventTypeFactory, T3, T4, InnerEventTypeEventVariableFactory> WithEventVariables<T1, T2, T3, T4>(this CombinedResult<T1, T2, EventTypeFactory, T3, T4> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EventVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventVariables(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EventTypeFactory, T4, InnerEventTypeEventVariableFactory> WithEventVariables<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EventTypeFactory, T4> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EventVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventVariables(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EventTypeFactory, InnerEventTypeEventVariableFactory> WithEventVariables<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EventTypeFactory> combinedResult, Action<Humidifier.FraudDetector.EventTypeTypes.EventVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventVariables(combinedResult.T5, subFactoryAction));
}
