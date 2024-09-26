// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTEvents;

public class DetectorModelFactory(string resourceName = null, Action<Humidifier.IoTEvents.DetectorModel> factoryAction = null) : ResourceFactory<Humidifier.IoTEvents.DetectorModel>(resourceName)
{

    internal InnerDetectorModelDetectorModelDefinitionFactory DetectorModelDefinitionFactory { get; set; }

    protected override Humidifier.IoTEvents.DetectorModel Create()
    {
        var detectorModelResult = CreateDetectorModel();
        factoryAction?.Invoke(detectorModelResult);

        return detectorModelResult;
    }

    private Humidifier.IoTEvents.DetectorModel CreateDetectorModel()
    {
        var detectorModelResult = new Humidifier.IoTEvents.DetectorModel
        {
            GivenName = InputResourceName,
        };

        return detectorModelResult;
    }
    public override void CreateChildren(Humidifier.IoTEvents.DetectorModel result)
    {
        base.CreateChildren(result);

        result.DetectorModelDefinition ??= DetectorModelDefinitionFactory?.Build();
    }

} // End Of Class

public static class DetectorModelFactoryExtensions
{
    public static CombinedResult<DetectorModelFactory, InnerDetectorModelDetectorModelDefinitionFactory> WithDetectorModelDefinition(this DetectorModelFactory parentFactory, Action<Humidifier.IoTEvents.DetectorModelTypes.DetectorModelDefinition> subFactoryAction = null)
    {
        parentFactory.DetectorModelDefinitionFactory = new InnerDetectorModelDetectorModelDefinitionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DetectorModelDefinitionFactory);
    }

    public static CombinedResult<DetectorModelFactory, T1, InnerDetectorModelDetectorModelDefinitionFactory> WithDetectorModelDefinition<T1>(this CombinedResult<DetectorModelFactory, T1> combinedResult, Action<Humidifier.IoTEvents.DetectorModelTypes.DetectorModelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithDetectorModelDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorModelFactory, InnerDetectorModelDetectorModelDefinitionFactory> WithDetectorModelDefinition<T1>(this CombinedResult<T1, DetectorModelFactory> combinedResult, Action<Humidifier.IoTEvents.DetectorModelTypes.DetectorModelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithDetectorModelDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DetectorModelFactory, T1, T2, InnerDetectorModelDetectorModelDefinitionFactory> WithDetectorModelDefinition<T1, T2>(this CombinedResult<DetectorModelFactory, T1, T2> combinedResult, Action<Humidifier.IoTEvents.DetectorModelTypes.DetectorModelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDetectorModelDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorModelFactory, T2, InnerDetectorModelDetectorModelDefinitionFactory> WithDetectorModelDefinition<T1, T2>(this CombinedResult<T1, DetectorModelFactory, T2> combinedResult, Action<Humidifier.IoTEvents.DetectorModelTypes.DetectorModelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDetectorModelDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DetectorModelFactory, InnerDetectorModelDetectorModelDefinitionFactory> WithDetectorModelDefinition<T1, T2>(this CombinedResult<T1, T2, DetectorModelFactory> combinedResult, Action<Humidifier.IoTEvents.DetectorModelTypes.DetectorModelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDetectorModelDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DetectorModelFactory, T1, T2, T3, InnerDetectorModelDetectorModelDefinitionFactory> WithDetectorModelDefinition<T1, T2, T3>(this CombinedResult<DetectorModelFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTEvents.DetectorModelTypes.DetectorModelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDetectorModelDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorModelFactory, T2, T3, InnerDetectorModelDetectorModelDefinitionFactory> WithDetectorModelDefinition<T1, T2, T3>(this CombinedResult<T1, DetectorModelFactory, T2, T3> combinedResult, Action<Humidifier.IoTEvents.DetectorModelTypes.DetectorModelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDetectorModelDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DetectorModelFactory, T3, InnerDetectorModelDetectorModelDefinitionFactory> WithDetectorModelDefinition<T1, T2, T3>(this CombinedResult<T1, T2, DetectorModelFactory, T3> combinedResult, Action<Humidifier.IoTEvents.DetectorModelTypes.DetectorModelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDetectorModelDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DetectorModelFactory, InnerDetectorModelDetectorModelDefinitionFactory> WithDetectorModelDefinition<T1, T2, T3>(this CombinedResult<T1, T2, T3, DetectorModelFactory> combinedResult, Action<Humidifier.IoTEvents.DetectorModelTypes.DetectorModelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDetectorModelDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DetectorModelFactory, T1, T2, T3, T4, InnerDetectorModelDetectorModelDefinitionFactory> WithDetectorModelDefinition<T1, T2, T3, T4>(this CombinedResult<DetectorModelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTEvents.DetectorModelTypes.DetectorModelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDetectorModelDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DetectorModelFactory, T2, T3, T4, InnerDetectorModelDetectorModelDefinitionFactory> WithDetectorModelDefinition<T1, T2, T3, T4>(this CombinedResult<T1, DetectorModelFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTEvents.DetectorModelTypes.DetectorModelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDetectorModelDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DetectorModelFactory, T3, T4, InnerDetectorModelDetectorModelDefinitionFactory> WithDetectorModelDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, DetectorModelFactory, T3, T4> combinedResult, Action<Humidifier.IoTEvents.DetectorModelTypes.DetectorModelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDetectorModelDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DetectorModelFactory, T4, InnerDetectorModelDetectorModelDefinitionFactory> WithDetectorModelDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DetectorModelFactory, T4> combinedResult, Action<Humidifier.IoTEvents.DetectorModelTypes.DetectorModelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDetectorModelDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DetectorModelFactory, InnerDetectorModelDetectorModelDefinitionFactory> WithDetectorModelDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DetectorModelFactory> combinedResult, Action<Humidifier.IoTEvents.DetectorModelTypes.DetectorModelDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDetectorModelDefinition(combinedResult.T5, subFactoryAction));
}
