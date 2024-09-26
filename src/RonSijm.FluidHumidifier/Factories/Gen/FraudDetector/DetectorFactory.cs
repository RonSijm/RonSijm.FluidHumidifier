// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FraudDetector;

public class DetectorFactory(string resourceName = null, Action<Humidifier.FraudDetector.Detector> factoryAction = null) : ResourceFactory<Humidifier.FraudDetector.Detector>(resourceName)
{

    internal List<InnerDetectorModelFactory> AssociatedModelsFactories { get; set; } = [];

    internal List<InnerDetectorRuleFactory> RulesFactories { get; set; } = [];

    internal InnerDetectorEventTypeFactory EventTypeFactory { get; set; }

    protected override Humidifier.FraudDetector.Detector Create()
    {
        var detectorResult = CreateDetector();
        factoryAction?.Invoke(detectorResult);

        return detectorResult;
    }

    private Humidifier.FraudDetector.Detector CreateDetector()
    {
        var detectorResult = new Humidifier.FraudDetector.Detector
        {
            GivenName = InputResourceName,
        };

        return detectorResult;
    }
    public override void CreateChildren(Humidifier.FraudDetector.Detector result)
    {
        base.CreateChildren(result);

        result.AssociatedModels = AssociatedModelsFactories.Any() ? AssociatedModelsFactories.Select(x => x.Build()).ToList() : null;
        result.Rules = RulesFactories.Any() ? RulesFactories.Select(x => x.Build()).ToList() : null;
        result.EventType ??= EventTypeFactory?.Build();
    }

} // End Of Class

public static class DetectorFactoryExtensions
{
    public static CombinedResult<DetectorFactory, InnerDetectorModelFactory> WithAssociatedModels(this DetectorFactory parentFactory, Action<Humidifier.FraudDetector.DetectorTypes.Model> subFactoryAction = null)
    {
        var factory = new InnerDetectorModelFactory(subFactoryAction);
        parentFactory.AssociatedModelsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DetectorFactory, InnerDetectorRuleFactory> WithRules(this DetectorFactory parentFactory, Action<Humidifier.FraudDetector.DetectorTypes.Rule> subFactoryAction = null)
    {
        var factory = new InnerDetectorRuleFactory(subFactoryAction);
        parentFactory.RulesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DetectorFactory, InnerDetectorEventTypeFactory> WithEventType(this DetectorFactory parentFactory, Action<Humidifier.FraudDetector.DetectorTypes.EventType> subFactoryAction = null)
    {
        parentFactory.EventTypeFactory = new InnerDetectorEventTypeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EventTypeFactory);
    }

    public static CombinedResult<DetectorFactory, T1, InnerDetectorModelFactory> WithAssociatedModels<T1>(this CombinedResult<DetectorFactory, T1> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, WithAssociatedModels(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorFactory, InnerDetectorModelFactory> WithAssociatedModels<T1>(this CombinedResult<T1, DetectorFactory> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, WithAssociatedModels(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DetectorFactory, T1, T2, InnerDetectorModelFactory> WithAssociatedModels<T1, T2>(this CombinedResult<DetectorFactory, T1, T2> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssociatedModels(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorFactory, T2, InnerDetectorModelFactory> WithAssociatedModels<T1, T2>(this CombinedResult<T1, DetectorFactory, T2> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssociatedModels(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DetectorFactory, InnerDetectorModelFactory> WithAssociatedModels<T1, T2>(this CombinedResult<T1, T2, DetectorFactory> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssociatedModels(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DetectorFactory, T1, T2, T3, InnerDetectorModelFactory> WithAssociatedModels<T1, T2, T3>(this CombinedResult<DetectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedModels(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorFactory, T2, T3, InnerDetectorModelFactory> WithAssociatedModels<T1, T2, T3>(this CombinedResult<T1, DetectorFactory, T2, T3> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedModels(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DetectorFactory, T3, InnerDetectorModelFactory> WithAssociatedModels<T1, T2, T3>(this CombinedResult<T1, T2, DetectorFactory, T3> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedModels(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DetectorFactory, InnerDetectorModelFactory> WithAssociatedModels<T1, T2, T3>(this CombinedResult<T1, T2, T3, DetectorFactory> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedModels(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DetectorFactory, T1, T2, T3, T4, InnerDetectorModelFactory> WithAssociatedModels<T1, T2, T3, T4>(this CombinedResult<DetectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedModels(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorFactory, T2, T3, T4, InnerDetectorModelFactory> WithAssociatedModels<T1, T2, T3, T4>(this CombinedResult<T1, DetectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedModels(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DetectorFactory, T3, T4, InnerDetectorModelFactory> WithAssociatedModels<T1, T2, T3, T4>(this CombinedResult<T1, T2, DetectorFactory, T3, T4> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedModels(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DetectorFactory, T4, InnerDetectorModelFactory> WithAssociatedModels<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DetectorFactory, T4> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedModels(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DetectorFactory, InnerDetectorModelFactory> WithAssociatedModels<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DetectorFactory> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedModels(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DetectorFactory, T1, InnerDetectorRuleFactory> WithRules<T1>(this CombinedResult<DetectorFactory, T1> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorFactory, InnerDetectorRuleFactory> WithRules<T1>(this CombinedResult<T1, DetectorFactory> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DetectorFactory, T1, T2, InnerDetectorRuleFactory> WithRules<T1, T2>(this CombinedResult<DetectorFactory, T1, T2> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorFactory, T2, InnerDetectorRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, DetectorFactory, T2> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DetectorFactory, InnerDetectorRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, T2, DetectorFactory> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DetectorFactory, T1, T2, T3, InnerDetectorRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<DetectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorFactory, T2, T3, InnerDetectorRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, DetectorFactory, T2, T3> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DetectorFactory, T3, InnerDetectorRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, DetectorFactory, T3> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DetectorFactory, InnerDetectorRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, DetectorFactory> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DetectorFactory, T1, T2, T3, T4, InnerDetectorRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<DetectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorFactory, T2, T3, T4, InnerDetectorRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, DetectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DetectorFactory, T3, T4, InnerDetectorRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, DetectorFactory, T3, T4> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DetectorFactory, T4, InnerDetectorRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DetectorFactory, T4> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DetectorFactory, InnerDetectorRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DetectorFactory> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DetectorFactory, T1, InnerDetectorEventTypeFactory> WithEventType<T1>(this CombinedResult<DetectorFactory, T1> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.EventType> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorFactory, InnerDetectorEventTypeFactory> WithEventType<T1>(this CombinedResult<T1, DetectorFactory> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.EventType> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DetectorFactory, T1, T2, InnerDetectorEventTypeFactory> WithEventType<T1, T2>(this CombinedResult<DetectorFactory, T1, T2> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.EventType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorFactory, T2, InnerDetectorEventTypeFactory> WithEventType<T1, T2>(this CombinedResult<T1, DetectorFactory, T2> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.EventType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DetectorFactory, InnerDetectorEventTypeFactory> WithEventType<T1, T2>(this CombinedResult<T1, T2, DetectorFactory> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.EventType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventType(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DetectorFactory, T1, T2, T3, InnerDetectorEventTypeFactory> WithEventType<T1, T2, T3>(this CombinedResult<DetectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.EventType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorFactory, T2, T3, InnerDetectorEventTypeFactory> WithEventType<T1, T2, T3>(this CombinedResult<T1, DetectorFactory, T2, T3> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.EventType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DetectorFactory, T3, InnerDetectorEventTypeFactory> WithEventType<T1, T2, T3>(this CombinedResult<T1, T2, DetectorFactory, T3> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.EventType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventType(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DetectorFactory, InnerDetectorEventTypeFactory> WithEventType<T1, T2, T3>(this CombinedResult<T1, T2, T3, DetectorFactory> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.EventType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventType(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DetectorFactory, T1, T2, T3, T4, InnerDetectorEventTypeFactory> WithEventType<T1, T2, T3, T4>(this CombinedResult<DetectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.EventType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorFactory, T2, T3, T4, InnerDetectorEventTypeFactory> WithEventType<T1, T2, T3, T4>(this CombinedResult<T1, DetectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.EventType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DetectorFactory, T3, T4, InnerDetectorEventTypeFactory> WithEventType<T1, T2, T3, T4>(this CombinedResult<T1, T2, DetectorFactory, T3, T4> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.EventType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventType(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DetectorFactory, T4, InnerDetectorEventTypeFactory> WithEventType<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DetectorFactory, T4> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.EventType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventType(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DetectorFactory, InnerDetectorEventTypeFactory> WithEventType<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DetectorFactory> combinedResult, Action<Humidifier.FraudDetector.DetectorTypes.EventType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventType(combinedResult.T5, subFactoryAction));
}
