// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class StandardFactory(string resourceName = null, Action<Humidifier.SecurityHub.Standard> factoryAction = null) : ResourceFactory<Humidifier.SecurityHub.Standard>(resourceName)
{

    internal List<InnerStandardStandardsControlFactory> DisabledStandardsControlsFactories { get; set; } = [];

    protected override Humidifier.SecurityHub.Standard Create()
    {
        var standardResult = CreateStandard();
        factoryAction?.Invoke(standardResult);

        return standardResult;
    }

    private Humidifier.SecurityHub.Standard CreateStandard()
    {
        var standardResult = new Humidifier.SecurityHub.Standard
        {
            GivenName = InputResourceName,
        };

        return standardResult;
    }
    public override void CreateChildren(Humidifier.SecurityHub.Standard result)
    {
        base.CreateChildren(result);

        result.DisabledStandardsControls = DisabledStandardsControlsFactories.Any() ? DisabledStandardsControlsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class StandardFactoryExtensions
{
    public static CombinedResult<StandardFactory, InnerStandardStandardsControlFactory> WithDisabledStandardsControls(this StandardFactory parentFactory, Action<Humidifier.SecurityHub.StandardTypes.StandardsControl> subFactoryAction = null)
    {
        var factory = new InnerStandardStandardsControlFactory(subFactoryAction);
        parentFactory.DisabledStandardsControlsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<StandardFactory, T1, InnerStandardStandardsControlFactory> WithDisabledStandardsControls<T1>(this CombinedResult<StandardFactory, T1> combinedResult, Action<Humidifier.SecurityHub.StandardTypes.StandardsControl> subFactoryAction = null) => new (combinedResult, combinedResult, WithDisabledStandardsControls(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StandardFactory, InnerStandardStandardsControlFactory> WithDisabledStandardsControls<T1>(this CombinedResult<T1, StandardFactory> combinedResult, Action<Humidifier.SecurityHub.StandardTypes.StandardsControl> subFactoryAction = null) => new (combinedResult, combinedResult, WithDisabledStandardsControls(combinedResult.T2, subFactoryAction));
    public static CombinedResult<StandardFactory, T1, T2, InnerStandardStandardsControlFactory> WithDisabledStandardsControls<T1, T2>(this CombinedResult<StandardFactory, T1, T2> combinedResult, Action<Humidifier.SecurityHub.StandardTypes.StandardsControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDisabledStandardsControls(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StandardFactory, T2, InnerStandardStandardsControlFactory> WithDisabledStandardsControls<T1, T2>(this CombinedResult<T1, StandardFactory, T2> combinedResult, Action<Humidifier.SecurityHub.StandardTypes.StandardsControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDisabledStandardsControls(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StandardFactory, InnerStandardStandardsControlFactory> WithDisabledStandardsControls<T1, T2>(this CombinedResult<T1, T2, StandardFactory> combinedResult, Action<Humidifier.SecurityHub.StandardTypes.StandardsControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDisabledStandardsControls(combinedResult.T3, subFactoryAction));
    public static CombinedResult<StandardFactory, T1, T2, T3, InnerStandardStandardsControlFactory> WithDisabledStandardsControls<T1, T2, T3>(this CombinedResult<StandardFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityHub.StandardTypes.StandardsControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDisabledStandardsControls(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StandardFactory, T2, T3, InnerStandardStandardsControlFactory> WithDisabledStandardsControls<T1, T2, T3>(this CombinedResult<T1, StandardFactory, T2, T3> combinedResult, Action<Humidifier.SecurityHub.StandardTypes.StandardsControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDisabledStandardsControls(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StandardFactory, T3, InnerStandardStandardsControlFactory> WithDisabledStandardsControls<T1, T2, T3>(this CombinedResult<T1, T2, StandardFactory, T3> combinedResult, Action<Humidifier.SecurityHub.StandardTypes.StandardsControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDisabledStandardsControls(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StandardFactory, InnerStandardStandardsControlFactory> WithDisabledStandardsControls<T1, T2, T3>(this CombinedResult<T1, T2, T3, StandardFactory> combinedResult, Action<Humidifier.SecurityHub.StandardTypes.StandardsControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDisabledStandardsControls(combinedResult.T4, subFactoryAction));
    public static CombinedResult<StandardFactory, T1, T2, T3, T4, InnerStandardStandardsControlFactory> WithDisabledStandardsControls<T1, T2, T3, T4>(this CombinedResult<StandardFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.StandardTypes.StandardsControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDisabledStandardsControls(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StandardFactory, T2, T3, T4, InnerStandardStandardsControlFactory> WithDisabledStandardsControls<T1, T2, T3, T4>(this CombinedResult<T1, StandardFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.StandardTypes.StandardsControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDisabledStandardsControls(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StandardFactory, T3, T4, InnerStandardStandardsControlFactory> WithDisabledStandardsControls<T1, T2, T3, T4>(this CombinedResult<T1, T2, StandardFactory, T3, T4> combinedResult, Action<Humidifier.SecurityHub.StandardTypes.StandardsControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDisabledStandardsControls(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StandardFactory, T4, InnerStandardStandardsControlFactory> WithDisabledStandardsControls<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, StandardFactory, T4> combinedResult, Action<Humidifier.SecurityHub.StandardTypes.StandardsControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDisabledStandardsControls(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, StandardFactory, InnerStandardStandardsControlFactory> WithDisabledStandardsControls<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, StandardFactory> combinedResult, Action<Humidifier.SecurityHub.StandardTypes.StandardsControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDisabledStandardsControls(combinedResult.T5, subFactoryAction));
}
