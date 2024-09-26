// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventSchemas;

public class RegistryFactory(string resourceName = null, Action<Humidifier.EventSchemas.Registry> factoryAction = null) : ResourceFactory<Humidifier.EventSchemas.Registry>(resourceName)
{

    internal List<InnerRegistryTagsEntryFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.EventSchemas.Registry Create()
    {
        var registryResult = CreateRegistry();
        factoryAction?.Invoke(registryResult);

        return registryResult;
    }

    private Humidifier.EventSchemas.Registry CreateRegistry()
    {
        var registryResult = new Humidifier.EventSchemas.Registry
        {
            GivenName = InputResourceName,
        };

        return registryResult;
    }
    public override void CreateChildren(Humidifier.EventSchemas.Registry result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class RegistryFactoryExtensions
{
    public static CombinedResult<RegistryFactory, InnerRegistryTagsEntryFactory> WithTags(this RegistryFactory parentFactory, Action<Humidifier.EventSchemas.RegistryTypes.TagsEntry> subFactoryAction = null)
    {
        var factory = new InnerRegistryTagsEntryFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<RegistryFactory, T1, InnerRegistryTagsEntryFactory> WithTags<T1>(this CombinedResult<RegistryFactory, T1> combinedResult, Action<Humidifier.EventSchemas.RegistryTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RegistryFactory, InnerRegistryTagsEntryFactory> WithTags<T1>(this CombinedResult<T1, RegistryFactory> combinedResult, Action<Humidifier.EventSchemas.RegistryTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RegistryFactory, T1, T2, InnerRegistryTagsEntryFactory> WithTags<T1, T2>(this CombinedResult<RegistryFactory, T1, T2> combinedResult, Action<Humidifier.EventSchemas.RegistryTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RegistryFactory, T2, InnerRegistryTagsEntryFactory> WithTags<T1, T2>(this CombinedResult<T1, RegistryFactory, T2> combinedResult, Action<Humidifier.EventSchemas.RegistryTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RegistryFactory, InnerRegistryTagsEntryFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, RegistryFactory> combinedResult, Action<Humidifier.EventSchemas.RegistryTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RegistryFactory, T1, T2, T3, InnerRegistryTagsEntryFactory> WithTags<T1, T2, T3>(this CombinedResult<RegistryFactory, T1, T2, T3> combinedResult, Action<Humidifier.EventSchemas.RegistryTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RegistryFactory, T2, T3, InnerRegistryTagsEntryFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, RegistryFactory, T2, T3> combinedResult, Action<Humidifier.EventSchemas.RegistryTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RegistryFactory, T3, InnerRegistryTagsEntryFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, RegistryFactory, T3> combinedResult, Action<Humidifier.EventSchemas.RegistryTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RegistryFactory, InnerRegistryTagsEntryFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, RegistryFactory> combinedResult, Action<Humidifier.EventSchemas.RegistryTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RegistryFactory, T1, T2, T3, T4, InnerRegistryTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<RegistryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EventSchemas.RegistryTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RegistryFactory, T2, T3, T4, InnerRegistryTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, RegistryFactory, T2, T3, T4> combinedResult, Action<Humidifier.EventSchemas.RegistryTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RegistryFactory, T3, T4, InnerRegistryTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, RegistryFactory, T3, T4> combinedResult, Action<Humidifier.EventSchemas.RegistryTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RegistryFactory, T4, InnerRegistryTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RegistryFactory, T4> combinedResult, Action<Humidifier.EventSchemas.RegistryTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RegistryFactory, InnerRegistryTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RegistryFactory> combinedResult, Action<Humidifier.EventSchemas.RegistryTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
}
