// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class CommandFactory(string resourceName = null, Action<Humidifier.IoT.Command> factoryAction = null) : ResourceFactory<Humidifier.IoT.Command>(resourceName)
{

    internal List<InnerCommandCommandParameterFactory> MandatoryParametersFactories { get; set; } = [];

    internal InnerCommandCommandPayloadFactory PayloadFactory { get; set; }

    protected override Humidifier.IoT.Command Create()
    {
        var commandResult = CreateCommand();
        factoryAction?.Invoke(commandResult);

        return commandResult;
    }

    private Humidifier.IoT.Command CreateCommand()
    {
        var commandResult = new Humidifier.IoT.Command
        {
            GivenName = InputResourceName,
        };

        return commandResult;
    }
    public override void CreateChildren(Humidifier.IoT.Command result)
    {
        base.CreateChildren(result);

        result.MandatoryParameters = MandatoryParametersFactories.Any() ? MandatoryParametersFactories.Select(x => x.Build()).ToList() : null;
        result.Payload ??= PayloadFactory?.Build();
    }

} // End Of Class

public static class CommandFactoryExtensions
{
    public static CombinedResult<CommandFactory, InnerCommandCommandParameterFactory> WithMandatoryParameters(this CommandFactory parentFactory, Action<Humidifier.IoT.CommandTypes.CommandParameter> subFactoryAction = null)
    {
        var factory = new InnerCommandCommandParameterFactory(subFactoryAction);
        parentFactory.MandatoryParametersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<CommandFactory, InnerCommandCommandPayloadFactory> WithPayload(this CommandFactory parentFactory, Action<Humidifier.IoT.CommandTypes.CommandPayload> subFactoryAction = null)
    {
        parentFactory.PayloadFactory = new InnerCommandCommandPayloadFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PayloadFactory);
    }

    public static CombinedResult<CommandFactory, T1, InnerCommandCommandParameterFactory> WithMandatoryParameters<T1>(this CombinedResult<CommandFactory, T1> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithMandatoryParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CommandFactory, InnerCommandCommandParameterFactory> WithMandatoryParameters<T1>(this CombinedResult<T1, CommandFactory> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithMandatoryParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CommandFactory, T1, T2, InnerCommandCommandParameterFactory> WithMandatoryParameters<T1, T2>(this CombinedResult<CommandFactory, T1, T2> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMandatoryParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CommandFactory, T2, InnerCommandCommandParameterFactory> WithMandatoryParameters<T1, T2>(this CombinedResult<T1, CommandFactory, T2> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMandatoryParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CommandFactory, InnerCommandCommandParameterFactory> WithMandatoryParameters<T1, T2>(this CombinedResult<T1, T2, CommandFactory> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMandatoryParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CommandFactory, T1, T2, T3, InnerCommandCommandParameterFactory> WithMandatoryParameters<T1, T2, T3>(this CombinedResult<CommandFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CommandFactory, T2, T3, InnerCommandCommandParameterFactory> WithMandatoryParameters<T1, T2, T3>(this CombinedResult<T1, CommandFactory, T2, T3> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CommandFactory, T3, InnerCommandCommandParameterFactory> WithMandatoryParameters<T1, T2, T3>(this CombinedResult<T1, T2, CommandFactory, T3> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CommandFactory, InnerCommandCommandParameterFactory> WithMandatoryParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, CommandFactory> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CommandFactory, T1, T2, T3, T4, InnerCommandCommandParameterFactory> WithMandatoryParameters<T1, T2, T3, T4>(this CombinedResult<CommandFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CommandFactory, T2, T3, T4, InnerCommandCommandParameterFactory> WithMandatoryParameters<T1, T2, T3, T4>(this CombinedResult<T1, CommandFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CommandFactory, T3, T4, InnerCommandCommandParameterFactory> WithMandatoryParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, CommandFactory, T3, T4> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CommandFactory, T4, InnerCommandCommandParameterFactory> WithMandatoryParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CommandFactory, T4> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CommandFactory, InnerCommandCommandParameterFactory> WithMandatoryParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CommandFactory> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryParameters(combinedResult.T5, subFactoryAction));
    public static CombinedResult<CommandFactory, T1, InnerCommandCommandPayloadFactory> WithPayload<T1>(this CombinedResult<CommandFactory, T1> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandPayload> subFactoryAction = null) => new (combinedResult, combinedResult, WithPayload(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CommandFactory, InnerCommandCommandPayloadFactory> WithPayload<T1>(this CombinedResult<T1, CommandFactory> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandPayload> subFactoryAction = null) => new (combinedResult, combinedResult, WithPayload(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CommandFactory, T1, T2, InnerCommandCommandPayloadFactory> WithPayload<T1, T2>(this CombinedResult<CommandFactory, T1, T2> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPayload(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CommandFactory, T2, InnerCommandCommandPayloadFactory> WithPayload<T1, T2>(this CombinedResult<T1, CommandFactory, T2> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPayload(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CommandFactory, InnerCommandCommandPayloadFactory> WithPayload<T1, T2>(this CombinedResult<T1, T2, CommandFactory> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPayload(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CommandFactory, T1, T2, T3, InnerCommandCommandPayloadFactory> WithPayload<T1, T2, T3>(this CombinedResult<CommandFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPayload(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CommandFactory, T2, T3, InnerCommandCommandPayloadFactory> WithPayload<T1, T2, T3>(this CombinedResult<T1, CommandFactory, T2, T3> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPayload(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CommandFactory, T3, InnerCommandCommandPayloadFactory> WithPayload<T1, T2, T3>(this CombinedResult<T1, T2, CommandFactory, T3> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPayload(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CommandFactory, InnerCommandCommandPayloadFactory> WithPayload<T1, T2, T3>(this CombinedResult<T1, T2, T3, CommandFactory> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPayload(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CommandFactory, T1, T2, T3, T4, InnerCommandCommandPayloadFactory> WithPayload<T1, T2, T3, T4>(this CombinedResult<CommandFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPayload(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CommandFactory, T2, T3, T4, InnerCommandCommandPayloadFactory> WithPayload<T1, T2, T3, T4>(this CombinedResult<T1, CommandFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPayload(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CommandFactory, T3, T4, InnerCommandCommandPayloadFactory> WithPayload<T1, T2, T3, T4>(this CombinedResult<T1, T2, CommandFactory, T3, T4> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPayload(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CommandFactory, T4, InnerCommandCommandPayloadFactory> WithPayload<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CommandFactory, T4> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPayload(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CommandFactory, InnerCommandCommandPayloadFactory> WithPayload<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CommandFactory> combinedResult, Action<Humidifier.IoT.CommandTypes.CommandPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPayload(combinedResult.T5, subFactoryAction));
}
