// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GreengrassV2;

public class ComponentFactory(string resourceName = null, Action<Humidifier.GreengrassV2.Component> factoryAction = null) : ResourceFactory<Humidifier.GreengrassV2.Component>(resourceName)
{

    internal List<InnerComponentTagsItemsFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.GreengrassV2.Component Create()
    {
        var componentResult = CreateComponent();
        factoryAction?.Invoke(componentResult);

        return componentResult;
    }

    private Humidifier.GreengrassV2.Component CreateComponent()
    {
        var componentResult = new Humidifier.GreengrassV2.Component
        {
            GivenName = InputResourceName,
        };

        return componentResult;
    }
    public override void CreateChildren(Humidifier.GreengrassV2.Component result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ComponentFactoryExtensions
{
    public static CombinedResult<ComponentFactory, InnerComponentTagsItemsFactory> WithTags(this ComponentFactory parentFactory, Action<Humidifier.GreengrassV2.ComponentTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerComponentTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ComponentFactory, T1, InnerComponentTagsItemsFactory> WithTags<T1>(this CombinedResult<ComponentFactory, T1> combinedResult, Action<Humidifier.GreengrassV2.ComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ComponentFactory, InnerComponentTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, ComponentFactory> combinedResult, Action<Humidifier.GreengrassV2.ComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ComponentFactory, T1, T2, InnerComponentTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<ComponentFactory, T1, T2> combinedResult, Action<Humidifier.GreengrassV2.ComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ComponentFactory, T2, InnerComponentTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, ComponentFactory, T2> combinedResult, Action<Humidifier.GreengrassV2.ComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ComponentFactory, InnerComponentTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, ComponentFactory> combinedResult, Action<Humidifier.GreengrassV2.ComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ComponentFactory, T1, T2, T3, InnerComponentTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<ComponentFactory, T1, T2, T3> combinedResult, Action<Humidifier.GreengrassV2.ComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ComponentFactory, T2, T3, InnerComponentTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, ComponentFactory, T2, T3> combinedResult, Action<Humidifier.GreengrassV2.ComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ComponentFactory, T3, InnerComponentTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, ComponentFactory, T3> combinedResult, Action<Humidifier.GreengrassV2.ComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ComponentFactory, InnerComponentTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, ComponentFactory> combinedResult, Action<Humidifier.GreengrassV2.ComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ComponentFactory, T1, T2, T3, T4, InnerComponentTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<ComponentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.ComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ComponentFactory, T2, T3, T4, InnerComponentTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, ComponentFactory, T2, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.ComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ComponentFactory, T3, T4, InnerComponentTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, ComponentFactory, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.ComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ComponentFactory, T4, InnerComponentTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ComponentFactory, T4> combinedResult, Action<Humidifier.GreengrassV2.ComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ComponentFactory, InnerComponentTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ComponentFactory> combinedResult, Action<Humidifier.GreengrassV2.ComponentTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
}
