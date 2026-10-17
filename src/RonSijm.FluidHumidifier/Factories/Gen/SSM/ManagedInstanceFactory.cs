// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class ManagedInstanceFactory(string resourceName = null, Action<Humidifier.SSM.ManagedInstance> factoryAction = null) : ResourceFactory<Humidifier.SSM.ManagedInstance>(resourceName)
{

    internal List<InnerManagedInstanceTagsItemsFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.SSM.ManagedInstance Create()
    {
        var managedInstanceResult = CreateManagedInstance();
        factoryAction?.Invoke(managedInstanceResult);

        return managedInstanceResult;
    }

    private Humidifier.SSM.ManagedInstance CreateManagedInstance()
    {
        var managedInstanceResult = new Humidifier.SSM.ManagedInstance
        {
            GivenName = InputResourceName,
        };

        return managedInstanceResult;
    }
    public override void CreateChildren(Humidifier.SSM.ManagedInstance result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ManagedInstanceFactoryExtensions
{
    public static CombinedResult<ManagedInstanceFactory, InnerManagedInstanceTagsItemsFactory> WithTags(this ManagedInstanceFactory parentFactory, Action<Humidifier.SSM.ManagedInstanceTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerManagedInstanceTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ManagedInstanceFactory, T1, InnerManagedInstanceTagsItemsFactory> WithTags<T1>(this CombinedResult<ManagedInstanceFactory, T1> combinedResult, Action<Humidifier.SSM.ManagedInstanceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ManagedInstanceFactory, InnerManagedInstanceTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, ManagedInstanceFactory> combinedResult, Action<Humidifier.SSM.ManagedInstanceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ManagedInstanceFactory, T1, T2, InnerManagedInstanceTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<ManagedInstanceFactory, T1, T2> combinedResult, Action<Humidifier.SSM.ManagedInstanceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ManagedInstanceFactory, T2, InnerManagedInstanceTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, ManagedInstanceFactory, T2> combinedResult, Action<Humidifier.SSM.ManagedInstanceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ManagedInstanceFactory, InnerManagedInstanceTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, ManagedInstanceFactory> combinedResult, Action<Humidifier.SSM.ManagedInstanceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ManagedInstanceFactory, T1, T2, T3, InnerManagedInstanceTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<ManagedInstanceFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSM.ManagedInstanceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ManagedInstanceFactory, T2, T3, InnerManagedInstanceTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, ManagedInstanceFactory, T2, T3> combinedResult, Action<Humidifier.SSM.ManagedInstanceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ManagedInstanceFactory, T3, InnerManagedInstanceTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, ManagedInstanceFactory, T3> combinedResult, Action<Humidifier.SSM.ManagedInstanceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ManagedInstanceFactory, InnerManagedInstanceTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, ManagedInstanceFactory> combinedResult, Action<Humidifier.SSM.ManagedInstanceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ManagedInstanceFactory, T1, T2, T3, T4, InnerManagedInstanceTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<ManagedInstanceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSM.ManagedInstanceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ManagedInstanceFactory, T2, T3, T4, InnerManagedInstanceTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, ManagedInstanceFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSM.ManagedInstanceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ManagedInstanceFactory, T3, T4, InnerManagedInstanceTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, ManagedInstanceFactory, T3, T4> combinedResult, Action<Humidifier.SSM.ManagedInstanceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ManagedInstanceFactory, T4, InnerManagedInstanceTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ManagedInstanceFactory, T4> combinedResult, Action<Humidifier.SSM.ManagedInstanceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ManagedInstanceFactory, InnerManagedInstanceTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ManagedInstanceFactory> combinedResult, Action<Humidifier.SSM.ManagedInstanceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
}
