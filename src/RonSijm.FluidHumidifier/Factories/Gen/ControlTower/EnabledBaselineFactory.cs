// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ControlTower;

public class EnabledBaselineFactory(string resourceName = null, Action<Humidifier.ControlTower.EnabledBaseline> factoryAction = null) : ResourceFactory<Humidifier.ControlTower.EnabledBaseline>(resourceName)
{

    internal List<InnerEnabledBaselineParameterFactory> ParametersFactories { get; set; } = [];

    protected override Humidifier.ControlTower.EnabledBaseline Create()
    {
        var enabledBaselineResult = CreateEnabledBaseline();
        factoryAction?.Invoke(enabledBaselineResult);

        return enabledBaselineResult;
    }

    private Humidifier.ControlTower.EnabledBaseline CreateEnabledBaseline()
    {
        var enabledBaselineResult = new Humidifier.ControlTower.EnabledBaseline
        {
            GivenName = InputResourceName,
        };

        return enabledBaselineResult;
    }
    public override void CreateChildren(Humidifier.ControlTower.EnabledBaseline result)
    {
        base.CreateChildren(result);

        result.Parameters = ParametersFactories.Any() ? ParametersFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class EnabledBaselineFactoryExtensions
{
    public static CombinedResult<EnabledBaselineFactory, InnerEnabledBaselineParameterFactory> WithParameters(this EnabledBaselineFactory parentFactory, Action<Humidifier.ControlTower.EnabledBaselineTypes.Parameter> subFactoryAction = null)
    {
        var factory = new InnerEnabledBaselineParameterFactory(subFactoryAction);
        parentFactory.ParametersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<EnabledBaselineFactory, T1, InnerEnabledBaselineParameterFactory> WithParameters<T1>(this CombinedResult<EnabledBaselineFactory, T1> combinedResult, Action<Humidifier.ControlTower.EnabledBaselineTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnabledBaselineFactory, InnerEnabledBaselineParameterFactory> WithParameters<T1>(this CombinedResult<T1, EnabledBaselineFactory> combinedResult, Action<Humidifier.ControlTower.EnabledBaselineTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EnabledBaselineFactory, T1, T2, InnerEnabledBaselineParameterFactory> WithParameters<T1, T2>(this CombinedResult<EnabledBaselineFactory, T1, T2> combinedResult, Action<Humidifier.ControlTower.EnabledBaselineTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnabledBaselineFactory, T2, InnerEnabledBaselineParameterFactory> WithParameters<T1, T2>(this CombinedResult<T1, EnabledBaselineFactory, T2> combinedResult, Action<Humidifier.ControlTower.EnabledBaselineTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnabledBaselineFactory, InnerEnabledBaselineParameterFactory> WithParameters<T1, T2>(this CombinedResult<T1, T2, EnabledBaselineFactory> combinedResult, Action<Humidifier.ControlTower.EnabledBaselineTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EnabledBaselineFactory, T1, T2, T3, InnerEnabledBaselineParameterFactory> WithParameters<T1, T2, T3>(this CombinedResult<EnabledBaselineFactory, T1, T2, T3> combinedResult, Action<Humidifier.ControlTower.EnabledBaselineTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnabledBaselineFactory, T2, T3, InnerEnabledBaselineParameterFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, EnabledBaselineFactory, T2, T3> combinedResult, Action<Humidifier.ControlTower.EnabledBaselineTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnabledBaselineFactory, T3, InnerEnabledBaselineParameterFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, T2, EnabledBaselineFactory, T3> combinedResult, Action<Humidifier.ControlTower.EnabledBaselineTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnabledBaselineFactory, InnerEnabledBaselineParameterFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, EnabledBaselineFactory> combinedResult, Action<Humidifier.ControlTower.EnabledBaselineTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EnabledBaselineFactory, T1, T2, T3, T4, InnerEnabledBaselineParameterFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<EnabledBaselineFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ControlTower.EnabledBaselineTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnabledBaselineFactory, T2, T3, T4, InnerEnabledBaselineParameterFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, EnabledBaselineFactory, T2, T3, T4> combinedResult, Action<Humidifier.ControlTower.EnabledBaselineTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnabledBaselineFactory, T3, T4, InnerEnabledBaselineParameterFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, EnabledBaselineFactory, T3, T4> combinedResult, Action<Humidifier.ControlTower.EnabledBaselineTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnabledBaselineFactory, T4, InnerEnabledBaselineParameterFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EnabledBaselineFactory, T4> combinedResult, Action<Humidifier.ControlTower.EnabledBaselineTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EnabledBaselineFactory, InnerEnabledBaselineParameterFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EnabledBaselineFactory> combinedResult, Action<Humidifier.ControlTower.EnabledBaselineTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T5, subFactoryAction));
}
