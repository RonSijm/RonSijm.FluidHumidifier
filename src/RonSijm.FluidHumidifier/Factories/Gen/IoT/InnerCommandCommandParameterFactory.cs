// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerCommandCommandParameterFactory(Action<Humidifier.IoT.CommandTypes.CommandParameter> factoryAction = null) : SubResourceFactory<Humidifier.IoT.CommandTypes.CommandParameter>
{

    internal InnerCommandCommandParameterValueFactory DefaultValueFactory { get; set; }

    internal InnerCommandCommandParameterValueFactory ValueFactory { get; set; }

    protected override Humidifier.IoT.CommandTypes.CommandParameter Create()
    {
        var commandParameterResult = CreateCommandParameter();
        factoryAction?.Invoke(commandParameterResult);

        return commandParameterResult;
    }

    private Humidifier.IoT.CommandTypes.CommandParameter CreateCommandParameter()
    {
        var commandParameterResult = new Humidifier.IoT.CommandTypes.CommandParameter();

        return commandParameterResult;
    }
    public override void CreateChildren(Humidifier.IoT.CommandTypes.CommandParameter result)
    {
        base.CreateChildren(result);

        result.DefaultValue ??= DefaultValueFactory?.Build();
        result.Value ??= ValueFactory?.Build();
    }

} // End Of Class

public static class InnerCommandCommandParameterFactoryExtensions
{
    public static CombinedResult<InnerCommandCommandParameterFactory, InnerCommandCommandParameterValueFactory> WithDefaultValue(this InnerCommandCommandParameterFactory parentFactory, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null)
    {
        parentFactory.DefaultValueFactory = new InnerCommandCommandParameterValueFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultValueFactory);
    }

    public static CombinedResult<InnerCommandCommandParameterFactory, InnerCommandCommandParameterValueFactory> WithValue(this InnerCommandCommandParameterFactory parentFactory, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null)
    {
        parentFactory.ValueFactory = new InnerCommandCommandParameterValueFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ValueFactory);
    }

    public static CombinedResult<InnerCommandCommandParameterFactory, T1, InnerCommandCommandParameterValueFactory> WithDefaultValue<T1>(this CombinedResult<InnerCommandCommandParameterFactory, T1> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCommandCommandParameterFactory, InnerCommandCommandParameterValueFactory> WithDefaultValue<T1>(this CombinedResult<T1, InnerCommandCommandParameterFactory> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCommandCommandParameterFactory, T1, T2, InnerCommandCommandParameterValueFactory> WithDefaultValue<T1, T2>(this CombinedResult<InnerCommandCommandParameterFactory, T1, T2> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCommandCommandParameterFactory, T2, InnerCommandCommandParameterValueFactory> WithDefaultValue<T1, T2>(this CombinedResult<T1, InnerCommandCommandParameterFactory, T2> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCommandCommandParameterFactory, InnerCommandCommandParameterValueFactory> WithDefaultValue<T1, T2>(this CombinedResult<T1, T2, InnerCommandCommandParameterFactory> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultValue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCommandCommandParameterFactory, T1, T2, T3, InnerCommandCommandParameterValueFactory> WithDefaultValue<T1, T2, T3>(this CombinedResult<InnerCommandCommandParameterFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCommandCommandParameterFactory, T2, T3, InnerCommandCommandParameterValueFactory> WithDefaultValue<T1, T2, T3>(this CombinedResult<T1, InnerCommandCommandParameterFactory, T2, T3> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCommandCommandParameterFactory, T3, InnerCommandCommandParameterValueFactory> WithDefaultValue<T1, T2, T3>(this CombinedResult<T1, T2, InnerCommandCommandParameterFactory, T3> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCommandCommandParameterFactory, InnerCommandCommandParameterValueFactory> WithDefaultValue<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCommandCommandParameterFactory> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValue(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCommandCommandParameterFactory, T1, T2, T3, T4, InnerCommandCommandParameterValueFactory> WithDefaultValue<T1, T2, T3, T4>(this CombinedResult<InnerCommandCommandParameterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCommandCommandParameterFactory, T2, T3, T4, InnerCommandCommandParameterValueFactory> WithDefaultValue<T1, T2, T3, T4>(this CombinedResult<T1, InnerCommandCommandParameterFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCommandCommandParameterFactory, T3, T4, InnerCommandCommandParameterValueFactory> WithDefaultValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCommandCommandParameterFactory, T3, T4> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCommandCommandParameterFactory, T4, InnerCommandCommandParameterValueFactory> WithDefaultValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCommandCommandParameterFactory, T4> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValue(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCommandCommandParameterFactory, InnerCommandCommandParameterValueFactory> WithDefaultValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCommandCommandParameterFactory> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultValue(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerCommandCommandParameterFactory, T1, InnerCommandCommandParameterValueFactory> WithValue<T1>(this CombinedResult<InnerCommandCommandParameterFactory, T1> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCommandCommandParameterFactory, InnerCommandCommandParameterValueFactory> WithValue<T1>(this CombinedResult<T1, InnerCommandCommandParameterFactory> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCommandCommandParameterFactory, T1, T2, InnerCommandCommandParameterValueFactory> WithValue<T1, T2>(this CombinedResult<InnerCommandCommandParameterFactory, T1, T2> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCommandCommandParameterFactory, T2, InnerCommandCommandParameterValueFactory> WithValue<T1, T2>(this CombinedResult<T1, InnerCommandCommandParameterFactory, T2> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCommandCommandParameterFactory, InnerCommandCommandParameterValueFactory> WithValue<T1, T2>(this CombinedResult<T1, T2, InnerCommandCommandParameterFactory> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCommandCommandParameterFactory, T1, T2, T3, InnerCommandCommandParameterValueFactory> WithValue<T1, T2, T3>(this CombinedResult<InnerCommandCommandParameterFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCommandCommandParameterFactory, T2, T3, InnerCommandCommandParameterValueFactory> WithValue<T1, T2, T3>(this CombinedResult<T1, InnerCommandCommandParameterFactory, T2, T3> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCommandCommandParameterFactory, T3, InnerCommandCommandParameterValueFactory> WithValue<T1, T2, T3>(this CombinedResult<T1, T2, InnerCommandCommandParameterFactory, T3> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCommandCommandParameterFactory, InnerCommandCommandParameterValueFactory> WithValue<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCommandCommandParameterFactory> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCommandCommandParameterFactory, T1, T2, T3, T4, InnerCommandCommandParameterValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<InnerCommandCommandParameterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCommandCommandParameterFactory, T2, T3, T4, InnerCommandCommandParameterValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, InnerCommandCommandParameterFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCommandCommandParameterFactory, T3, T4, InnerCommandCommandParameterValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCommandCommandParameterFactory, T3, T4> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCommandCommandParameterFactory, T4, InnerCommandCommandParameterValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCommandCommandParameterFactory, T4> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCommandCommandParameterFactory, InnerCommandCommandParameterValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCommandCommandParameterFactory> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameterValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T5, subFactoryAction));
}
