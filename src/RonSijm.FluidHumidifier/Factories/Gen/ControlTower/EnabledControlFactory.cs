// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ControlTower;

public class EnabledControlFactory(string resourceName = null, Action<Humidifier.ControlTower.EnabledControl> factoryAction = null) : ResourceFactory<Humidifier.ControlTower.EnabledControl>(resourceName)
{

    internal List<InnerEnabledControlEnabledControlParameterFactory> ParametersFactories { get; set; } = [];

    protected override Humidifier.ControlTower.EnabledControl Create()
    {
        var enabledControlResult = CreateEnabledControl();
        factoryAction?.Invoke(enabledControlResult);

        return enabledControlResult;
    }

    private Humidifier.ControlTower.EnabledControl CreateEnabledControl()
    {
        var enabledControlResult = new Humidifier.ControlTower.EnabledControl
        {
            GivenName = InputResourceName,
        };

        return enabledControlResult;
    }
    public override void CreateChildren(Humidifier.ControlTower.EnabledControl result)
    {
        base.CreateChildren(result);

        result.Parameters = ParametersFactories.Any() ? ParametersFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class EnabledControlFactoryExtensions
{
    public static CombinedResult<EnabledControlFactory, InnerEnabledControlEnabledControlParameterFactory> WithParameters(this EnabledControlFactory parentFactory, Action<Humidifier.ControlTower.EnabledControlTypes.EnabledControlParameter> subFactoryAction = null)
    {
        var factory = new InnerEnabledControlEnabledControlParameterFactory(subFactoryAction);
        parentFactory.ParametersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<EnabledControlFactory, T1, InnerEnabledControlEnabledControlParameterFactory> WithParameters<T1>(this CombinedResult<EnabledControlFactory, T1> combinedResult, Action<Humidifier.ControlTower.EnabledControlTypes.EnabledControlParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnabledControlFactory, InnerEnabledControlEnabledControlParameterFactory> WithParameters<T1>(this CombinedResult<T1, EnabledControlFactory> combinedResult, Action<Humidifier.ControlTower.EnabledControlTypes.EnabledControlParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EnabledControlFactory, T1, T2, InnerEnabledControlEnabledControlParameterFactory> WithParameters<T1, T2>(this CombinedResult<EnabledControlFactory, T1, T2> combinedResult, Action<Humidifier.ControlTower.EnabledControlTypes.EnabledControlParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnabledControlFactory, T2, InnerEnabledControlEnabledControlParameterFactory> WithParameters<T1, T2>(this CombinedResult<T1, EnabledControlFactory, T2> combinedResult, Action<Humidifier.ControlTower.EnabledControlTypes.EnabledControlParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnabledControlFactory, InnerEnabledControlEnabledControlParameterFactory> WithParameters<T1, T2>(this CombinedResult<T1, T2, EnabledControlFactory> combinedResult, Action<Humidifier.ControlTower.EnabledControlTypes.EnabledControlParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EnabledControlFactory, T1, T2, T3, InnerEnabledControlEnabledControlParameterFactory> WithParameters<T1, T2, T3>(this CombinedResult<EnabledControlFactory, T1, T2, T3> combinedResult, Action<Humidifier.ControlTower.EnabledControlTypes.EnabledControlParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnabledControlFactory, T2, T3, InnerEnabledControlEnabledControlParameterFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, EnabledControlFactory, T2, T3> combinedResult, Action<Humidifier.ControlTower.EnabledControlTypes.EnabledControlParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnabledControlFactory, T3, InnerEnabledControlEnabledControlParameterFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, T2, EnabledControlFactory, T3> combinedResult, Action<Humidifier.ControlTower.EnabledControlTypes.EnabledControlParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnabledControlFactory, InnerEnabledControlEnabledControlParameterFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, EnabledControlFactory> combinedResult, Action<Humidifier.ControlTower.EnabledControlTypes.EnabledControlParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EnabledControlFactory, T1, T2, T3, T4, InnerEnabledControlEnabledControlParameterFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<EnabledControlFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ControlTower.EnabledControlTypes.EnabledControlParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnabledControlFactory, T2, T3, T4, InnerEnabledControlEnabledControlParameterFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, EnabledControlFactory, T2, T3, T4> combinedResult, Action<Humidifier.ControlTower.EnabledControlTypes.EnabledControlParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnabledControlFactory, T3, T4, InnerEnabledControlEnabledControlParameterFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, EnabledControlFactory, T3, T4> combinedResult, Action<Humidifier.ControlTower.EnabledControlTypes.EnabledControlParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnabledControlFactory, T4, InnerEnabledControlEnabledControlParameterFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EnabledControlFactory, T4> combinedResult, Action<Humidifier.ControlTower.EnabledControlTypes.EnabledControlParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EnabledControlFactory, InnerEnabledControlEnabledControlParameterFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EnabledControlFactory> combinedResult, Action<Humidifier.ControlTower.EnabledControlTypes.EnabledControlParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T5, subFactoryAction));
}
