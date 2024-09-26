// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DLM;

public class InnerLifecyclePolicyExclusionsFactory(Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> factoryAction = null) : SubResourceFactory<Humidifier.DLM.LifecyclePolicyTypes.Exclusions>
{

    internal InnerLifecyclePolicyExcludeTagsFactory ExcludeTagsFactory { get; set; }

    internal InnerLifecyclePolicyExcludeVolumeTypesListFactory ExcludeVolumeTypesFactory { get; set; }

    protected override Humidifier.DLM.LifecyclePolicyTypes.Exclusions Create()
    {
        var exclusionsResult = CreateExclusions();
        factoryAction?.Invoke(exclusionsResult);

        return exclusionsResult;
    }

    private Humidifier.DLM.LifecyclePolicyTypes.Exclusions CreateExclusions()
    {
        var exclusionsResult = new Humidifier.DLM.LifecyclePolicyTypes.Exclusions();

        return exclusionsResult;
    }
    public override void CreateChildren(Humidifier.DLM.LifecyclePolicyTypes.Exclusions result)
    {
        base.CreateChildren(result);

        result.ExcludeTags ??= ExcludeTagsFactory?.Build();
        result.ExcludeVolumeTypes ??= ExcludeVolumeTypesFactory?.Build();
    }

} // End Of Class

public static class InnerLifecyclePolicyExclusionsFactoryExtensions
{
    public static CombinedResult<InnerLifecyclePolicyExclusionsFactory, InnerLifecyclePolicyExcludeTagsFactory> WithExcludeTags(this InnerLifecyclePolicyExclusionsFactory parentFactory, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeTags> subFactoryAction = null)
    {
        parentFactory.ExcludeTagsFactory = new InnerLifecyclePolicyExcludeTagsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExcludeTagsFactory);
    }

    public static CombinedResult<InnerLifecyclePolicyExclusionsFactory, InnerLifecyclePolicyExcludeVolumeTypesListFactory> WithExcludeVolumeTypes(this InnerLifecyclePolicyExclusionsFactory parentFactory, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeVolumeTypesList> subFactoryAction = null)
    {
        parentFactory.ExcludeVolumeTypesFactory = new InnerLifecyclePolicyExcludeVolumeTypesListFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExcludeVolumeTypesFactory);
    }

    public static CombinedResult<InnerLifecyclePolicyExclusionsFactory, T1, InnerLifecyclePolicyExcludeTagsFactory> WithExcludeTags<T1>(this CombinedResult<InnerLifecyclePolicyExclusionsFactory, T1> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeTags> subFactoryAction = null) => new (combinedResult, combinedResult, WithExcludeTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyExclusionsFactory, InnerLifecyclePolicyExcludeTagsFactory> WithExcludeTags<T1>(this CombinedResult<T1, InnerLifecyclePolicyExclusionsFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeTags> subFactoryAction = null) => new (combinedResult, combinedResult, WithExcludeTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyExclusionsFactory, T1, T2, InnerLifecyclePolicyExcludeTagsFactory> WithExcludeTags<T1, T2>(this CombinedResult<InnerLifecyclePolicyExclusionsFactory, T1, T2> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeTags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExcludeTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyExclusionsFactory, T2, InnerLifecyclePolicyExcludeTagsFactory> WithExcludeTags<T1, T2>(this CombinedResult<T1, InnerLifecyclePolicyExclusionsFactory, T2> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeTags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExcludeTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyExclusionsFactory, InnerLifecyclePolicyExcludeTagsFactory> WithExcludeTags<T1, T2>(this CombinedResult<T1, T2, InnerLifecyclePolicyExclusionsFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeTags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExcludeTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyExclusionsFactory, T1, T2, T3, InnerLifecyclePolicyExcludeTagsFactory> WithExcludeTags<T1, T2, T3>(this CombinedResult<InnerLifecyclePolicyExclusionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeTags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyExclusionsFactory, T2, T3, InnerLifecyclePolicyExcludeTagsFactory> WithExcludeTags<T1, T2, T3>(this CombinedResult<T1, InnerLifecyclePolicyExclusionsFactory, T2, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeTags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyExclusionsFactory, T3, InnerLifecyclePolicyExcludeTagsFactory> WithExcludeTags<T1, T2, T3>(this CombinedResult<T1, T2, InnerLifecyclePolicyExclusionsFactory, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeTags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLifecyclePolicyExclusionsFactory, InnerLifecyclePolicyExcludeTagsFactory> WithExcludeTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLifecyclePolicyExclusionsFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeTags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyExclusionsFactory, T1, T2, T3, T4, InnerLifecyclePolicyExcludeTagsFactory> WithExcludeTags<T1, T2, T3, T4>(this CombinedResult<InnerLifecyclePolicyExclusionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeTags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyExclusionsFactory, T2, T3, T4, InnerLifecyclePolicyExcludeTagsFactory> WithExcludeTags<T1, T2, T3, T4>(this CombinedResult<T1, InnerLifecyclePolicyExclusionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeTags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyExclusionsFactory, T3, T4, InnerLifecyclePolicyExcludeTagsFactory> WithExcludeTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLifecyclePolicyExclusionsFactory, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeTags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLifecyclePolicyExclusionsFactory, T4, InnerLifecyclePolicyExcludeTagsFactory> WithExcludeTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLifecyclePolicyExclusionsFactory, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeTags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLifecyclePolicyExclusionsFactory, InnerLifecyclePolicyExcludeTagsFactory> WithExcludeTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLifecyclePolicyExclusionsFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeTags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeTags(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyExclusionsFactory, T1, InnerLifecyclePolicyExcludeVolumeTypesListFactory> WithExcludeVolumeTypes<T1>(this CombinedResult<InnerLifecyclePolicyExclusionsFactory, T1> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeVolumeTypesList> subFactoryAction = null) => new (combinedResult, combinedResult, WithExcludeVolumeTypes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyExclusionsFactory, InnerLifecyclePolicyExcludeVolumeTypesListFactory> WithExcludeVolumeTypes<T1>(this CombinedResult<T1, InnerLifecyclePolicyExclusionsFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeVolumeTypesList> subFactoryAction = null) => new (combinedResult, combinedResult, WithExcludeVolumeTypes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyExclusionsFactory, T1, T2, InnerLifecyclePolicyExcludeVolumeTypesListFactory> WithExcludeVolumeTypes<T1, T2>(this CombinedResult<InnerLifecyclePolicyExclusionsFactory, T1, T2> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeVolumeTypesList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExcludeVolumeTypes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyExclusionsFactory, T2, InnerLifecyclePolicyExcludeVolumeTypesListFactory> WithExcludeVolumeTypes<T1, T2>(this CombinedResult<T1, InnerLifecyclePolicyExclusionsFactory, T2> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeVolumeTypesList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExcludeVolumeTypes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyExclusionsFactory, InnerLifecyclePolicyExcludeVolumeTypesListFactory> WithExcludeVolumeTypes<T1, T2>(this CombinedResult<T1, T2, InnerLifecyclePolicyExclusionsFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeVolumeTypesList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExcludeVolumeTypes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyExclusionsFactory, T1, T2, T3, InnerLifecyclePolicyExcludeVolumeTypesListFactory> WithExcludeVolumeTypes<T1, T2, T3>(this CombinedResult<InnerLifecyclePolicyExclusionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeVolumeTypesList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeVolumeTypes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyExclusionsFactory, T2, T3, InnerLifecyclePolicyExcludeVolumeTypesListFactory> WithExcludeVolumeTypes<T1, T2, T3>(this CombinedResult<T1, InnerLifecyclePolicyExclusionsFactory, T2, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeVolumeTypesList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeVolumeTypes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyExclusionsFactory, T3, InnerLifecyclePolicyExcludeVolumeTypesListFactory> WithExcludeVolumeTypes<T1, T2, T3>(this CombinedResult<T1, T2, InnerLifecyclePolicyExclusionsFactory, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeVolumeTypesList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeVolumeTypes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLifecyclePolicyExclusionsFactory, InnerLifecyclePolicyExcludeVolumeTypesListFactory> WithExcludeVolumeTypes<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLifecyclePolicyExclusionsFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeVolumeTypesList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeVolumeTypes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyExclusionsFactory, T1, T2, T3, T4, InnerLifecyclePolicyExcludeVolumeTypesListFactory> WithExcludeVolumeTypes<T1, T2, T3, T4>(this CombinedResult<InnerLifecyclePolicyExclusionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeVolumeTypesList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeVolumeTypes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyExclusionsFactory, T2, T3, T4, InnerLifecyclePolicyExcludeVolumeTypesListFactory> WithExcludeVolumeTypes<T1, T2, T3, T4>(this CombinedResult<T1, InnerLifecyclePolicyExclusionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeVolumeTypesList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeVolumeTypes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyExclusionsFactory, T3, T4, InnerLifecyclePolicyExcludeVolumeTypesListFactory> WithExcludeVolumeTypes<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLifecyclePolicyExclusionsFactory, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeVolumeTypesList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeVolumeTypes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLifecyclePolicyExclusionsFactory, T4, InnerLifecyclePolicyExcludeVolumeTypesListFactory> WithExcludeVolumeTypes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLifecyclePolicyExclusionsFactory, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeVolumeTypesList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeVolumeTypes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLifecyclePolicyExclusionsFactory, InnerLifecyclePolicyExcludeVolumeTypesListFactory> WithExcludeVolumeTypes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLifecyclePolicyExclusionsFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeVolumeTypesList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeVolumeTypes(combinedResult.T5, subFactoryAction));
}
