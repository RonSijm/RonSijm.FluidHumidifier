// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTEvents;

public class InputFactory(string resourceName = null, Action<Humidifier.IoTEvents.Input> factoryAction = null) : ResourceFactory<Humidifier.IoTEvents.Input>(resourceName)
{

    internal InnerInputInputDefinitionFactory InputDefinitionFactory { get; set; }

    protected override Humidifier.IoTEvents.Input Create()
    {
        var inputResult = CreateInput();
        factoryAction?.Invoke(inputResult);

        return inputResult;
    }

    private Humidifier.IoTEvents.Input CreateInput()
    {
        var inputResult = new Humidifier.IoTEvents.Input
        {
            GivenName = InputResourceName,
        };

        return inputResult;
    }
    public override void CreateChildren(Humidifier.IoTEvents.Input result)
    {
        base.CreateChildren(result);

        result.InputDefinition ??= InputDefinitionFactory?.Build();
    }

} // End Of Class

public static class InputFactoryExtensions
{
    public static CombinedResult<InputFactory, InnerInputInputDefinitionFactory> WithInputDefinition(this InputFactory parentFactory, Action<Humidifier.IoTEvents.InputTypes.InputDefinition> subFactoryAction = null)
    {
        parentFactory.InputDefinitionFactory = new InnerInputInputDefinitionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InputDefinitionFactory);
    }

    public static CombinedResult<InputFactory, T1, InnerInputInputDefinitionFactory> WithInputDefinition<T1>(this CombinedResult<InputFactory, T1> combinedResult, Action<Humidifier.IoTEvents.InputTypes.InputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InputFactory, InnerInputInputDefinitionFactory> WithInputDefinition<T1>(this CombinedResult<T1, InputFactory> combinedResult, Action<Humidifier.IoTEvents.InputTypes.InputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InputFactory, T1, T2, InnerInputInputDefinitionFactory> WithInputDefinition<T1, T2>(this CombinedResult<InputFactory, T1, T2> combinedResult, Action<Humidifier.IoTEvents.InputTypes.InputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InputFactory, T2, InnerInputInputDefinitionFactory> WithInputDefinition<T1, T2>(this CombinedResult<T1, InputFactory, T2> combinedResult, Action<Humidifier.IoTEvents.InputTypes.InputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InputFactory, InnerInputInputDefinitionFactory> WithInputDefinition<T1, T2>(this CombinedResult<T1, T2, InputFactory> combinedResult, Action<Humidifier.IoTEvents.InputTypes.InputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InputFactory, T1, T2, T3, InnerInputInputDefinitionFactory> WithInputDefinition<T1, T2, T3>(this CombinedResult<InputFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTEvents.InputTypes.InputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InputFactory, T2, T3, InnerInputInputDefinitionFactory> WithInputDefinition<T1, T2, T3>(this CombinedResult<T1, InputFactory, T2, T3> combinedResult, Action<Humidifier.IoTEvents.InputTypes.InputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InputFactory, T3, InnerInputInputDefinitionFactory> WithInputDefinition<T1, T2, T3>(this CombinedResult<T1, T2, InputFactory, T3> combinedResult, Action<Humidifier.IoTEvents.InputTypes.InputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InputFactory, InnerInputInputDefinitionFactory> WithInputDefinition<T1, T2, T3>(this CombinedResult<T1, T2, T3, InputFactory> combinedResult, Action<Humidifier.IoTEvents.InputTypes.InputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InputFactory, T1, T2, T3, T4, InnerInputInputDefinitionFactory> WithInputDefinition<T1, T2, T3, T4>(this CombinedResult<InputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTEvents.InputTypes.InputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InputFactory, T2, T3, T4, InnerInputInputDefinitionFactory> WithInputDefinition<T1, T2, T3, T4>(this CombinedResult<T1, InputFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTEvents.InputTypes.InputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InputFactory, T3, T4, InnerInputInputDefinitionFactory> WithInputDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, InputFactory, T3, T4> combinedResult, Action<Humidifier.IoTEvents.InputTypes.InputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InputFactory, T4, InnerInputInputDefinitionFactory> WithInputDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InputFactory, T4> combinedResult, Action<Humidifier.IoTEvents.InputTypes.InputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InputFactory, InnerInputInputDefinitionFactory> WithInputDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InputFactory> combinedResult, Action<Humidifier.IoTEvents.InputTypes.InputDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputDefinition(combinedResult.T5, subFactoryAction));
}
