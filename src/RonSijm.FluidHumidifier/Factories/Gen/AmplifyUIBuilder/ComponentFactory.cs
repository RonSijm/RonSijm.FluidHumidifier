// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmplifyUIBuilder;

public class ComponentFactory(string resourceName = null, Action<Humidifier.AmplifyUIBuilder.Component> factoryAction = null) : ResourceFactory<Humidifier.AmplifyUIBuilder.Component>(resourceName)
{

    internal List<InnerComponentComponentVariantFactory> VariantsFactories { get; set; } = [];

    internal List<InnerComponentComponentChildFactory> ChildrenFactories { get; set; } = [];

    protected override Humidifier.AmplifyUIBuilder.Component Create()
    {
        var componentResult = CreateComponent();
        factoryAction?.Invoke(componentResult);

        return componentResult;
    }

    private Humidifier.AmplifyUIBuilder.Component CreateComponent()
    {
        var componentResult = new Humidifier.AmplifyUIBuilder.Component
        {
            GivenName = InputResourceName,
        };

        return componentResult;
    }
    public override void CreateChildren(Humidifier.AmplifyUIBuilder.Component result)
    {
        base.CreateChildren(result);

        result.Variants = VariantsFactories.Any() ? VariantsFactories.Select(x => x.Build()).ToList() : null;
        result.Children = ChildrenFactories.Any() ? ChildrenFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ComponentFactoryExtensions
{
    public static CombinedResult<ComponentFactory, InnerComponentComponentVariantFactory> WithVariants(this ComponentFactory parentFactory, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentVariant> subFactoryAction = null)
    {
        var factory = new InnerComponentComponentVariantFactory(subFactoryAction);
        parentFactory.VariantsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ComponentFactory, InnerComponentComponentChildFactory> WithChildren(this ComponentFactory parentFactory, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild> subFactoryAction = null)
    {
        var factory = new InnerComponentComponentChildFactory(subFactoryAction);
        parentFactory.ChildrenFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ComponentFactory, T1, InnerComponentComponentVariantFactory> WithVariants<T1>(this CombinedResult<ComponentFactory, T1> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentVariant> subFactoryAction = null) => new (combinedResult, combinedResult, WithVariants(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ComponentFactory, InnerComponentComponentVariantFactory> WithVariants<T1>(this CombinedResult<T1, ComponentFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentVariant> subFactoryAction = null) => new (combinedResult, combinedResult, WithVariants(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ComponentFactory, T1, T2, InnerComponentComponentVariantFactory> WithVariants<T1, T2>(this CombinedResult<ComponentFactory, T1, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentVariant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVariants(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ComponentFactory, T2, InnerComponentComponentVariantFactory> WithVariants<T1, T2>(this CombinedResult<T1, ComponentFactory, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentVariant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVariants(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ComponentFactory, InnerComponentComponentVariantFactory> WithVariants<T1, T2>(this CombinedResult<T1, T2, ComponentFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentVariant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVariants(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ComponentFactory, T1, T2, T3, InnerComponentComponentVariantFactory> WithVariants<T1, T2, T3>(this CombinedResult<ComponentFactory, T1, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentVariant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVariants(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ComponentFactory, T2, T3, InnerComponentComponentVariantFactory> WithVariants<T1, T2, T3>(this CombinedResult<T1, ComponentFactory, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentVariant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVariants(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ComponentFactory, T3, InnerComponentComponentVariantFactory> WithVariants<T1, T2, T3>(this CombinedResult<T1, T2, ComponentFactory, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentVariant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVariants(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ComponentFactory, InnerComponentComponentVariantFactory> WithVariants<T1, T2, T3>(this CombinedResult<T1, T2, T3, ComponentFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentVariant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVariants(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ComponentFactory, T1, T2, T3, T4, InnerComponentComponentVariantFactory> WithVariants<T1, T2, T3, T4>(this CombinedResult<ComponentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentVariant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVariants(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ComponentFactory, T2, T3, T4, InnerComponentComponentVariantFactory> WithVariants<T1, T2, T3, T4>(this CombinedResult<T1, ComponentFactory, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentVariant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVariants(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ComponentFactory, T3, T4, InnerComponentComponentVariantFactory> WithVariants<T1, T2, T3, T4>(this CombinedResult<T1, T2, ComponentFactory, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentVariant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVariants(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ComponentFactory, T4, InnerComponentComponentVariantFactory> WithVariants<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ComponentFactory, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentVariant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVariants(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ComponentFactory, InnerComponentComponentVariantFactory> WithVariants<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ComponentFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentVariant> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVariants(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ComponentFactory, T1, InnerComponentComponentChildFactory> WithChildren<T1>(this CombinedResult<ComponentFactory, T1> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild> subFactoryAction = null) => new (combinedResult, combinedResult, WithChildren(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ComponentFactory, InnerComponentComponentChildFactory> WithChildren<T1>(this CombinedResult<T1, ComponentFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild> subFactoryAction = null) => new (combinedResult, combinedResult, WithChildren(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ComponentFactory, T1, T2, InnerComponentComponentChildFactory> WithChildren<T1, T2>(this CombinedResult<ComponentFactory, T1, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithChildren(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ComponentFactory, T2, InnerComponentComponentChildFactory> WithChildren<T1, T2>(this CombinedResult<T1, ComponentFactory, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithChildren(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ComponentFactory, InnerComponentComponentChildFactory> WithChildren<T1, T2>(this CombinedResult<T1, T2, ComponentFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithChildren(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ComponentFactory, T1, T2, T3, InnerComponentComponentChildFactory> WithChildren<T1, T2, T3>(this CombinedResult<ComponentFactory, T1, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithChildren(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ComponentFactory, T2, T3, InnerComponentComponentChildFactory> WithChildren<T1, T2, T3>(this CombinedResult<T1, ComponentFactory, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithChildren(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ComponentFactory, T3, InnerComponentComponentChildFactory> WithChildren<T1, T2, T3>(this CombinedResult<T1, T2, ComponentFactory, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithChildren(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ComponentFactory, InnerComponentComponentChildFactory> WithChildren<T1, T2, T3>(this CombinedResult<T1, T2, T3, ComponentFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithChildren(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ComponentFactory, T1, T2, T3, T4, InnerComponentComponentChildFactory> WithChildren<T1, T2, T3, T4>(this CombinedResult<ComponentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChildren(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ComponentFactory, T2, T3, T4, InnerComponentComponentChildFactory> WithChildren<T1, T2, T3, T4>(this CombinedResult<T1, ComponentFactory, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChildren(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ComponentFactory, T3, T4, InnerComponentComponentChildFactory> WithChildren<T1, T2, T3, T4>(this CombinedResult<T1, T2, ComponentFactory, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChildren(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ComponentFactory, T4, InnerComponentComponentChildFactory> WithChildren<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ComponentFactory, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChildren(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ComponentFactory, InnerComponentComponentChildFactory> WithChildren<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ComponentFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChildren(combinedResult.T5, subFactoryAction));
}
