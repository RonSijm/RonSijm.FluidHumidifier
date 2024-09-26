// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PinpointEmail;

public class DedicatedIpPoolFactory(string resourceName = null, Action<Humidifier.PinpointEmail.DedicatedIpPool> factoryAction = null) : ResourceFactory<Humidifier.PinpointEmail.DedicatedIpPool>(resourceName)
{

    internal List<InnerDedicatedIpPoolTagsFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.PinpointEmail.DedicatedIpPool Create()
    {
        var dedicatedIpPoolResult = CreateDedicatedIpPool();
        factoryAction?.Invoke(dedicatedIpPoolResult);

        return dedicatedIpPoolResult;
    }

    private Humidifier.PinpointEmail.DedicatedIpPool CreateDedicatedIpPool()
    {
        var dedicatedIpPoolResult = new Humidifier.PinpointEmail.DedicatedIpPool
        {
            GivenName = InputResourceName,
        };

        return dedicatedIpPoolResult;
    }
    public override void CreateChildren(Humidifier.PinpointEmail.DedicatedIpPool result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class DedicatedIpPoolFactoryExtensions
{
    public static CombinedResult<DedicatedIpPoolFactory, InnerDedicatedIpPoolTagsFactory> WithTags(this DedicatedIpPoolFactory parentFactory, Action<Humidifier.PinpointEmail.DedicatedIpPoolTypes.Tags> subFactoryAction = null)
    {
        var factory = new InnerDedicatedIpPoolTagsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DedicatedIpPoolFactory, T1, InnerDedicatedIpPoolTagsFactory> WithTags<T1>(this CombinedResult<DedicatedIpPoolFactory, T1> combinedResult, Action<Humidifier.PinpointEmail.DedicatedIpPoolTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DedicatedIpPoolFactory, InnerDedicatedIpPoolTagsFactory> WithTags<T1>(this CombinedResult<T1, DedicatedIpPoolFactory> combinedResult, Action<Humidifier.PinpointEmail.DedicatedIpPoolTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DedicatedIpPoolFactory, T1, T2, InnerDedicatedIpPoolTagsFactory> WithTags<T1, T2>(this CombinedResult<DedicatedIpPoolFactory, T1, T2> combinedResult, Action<Humidifier.PinpointEmail.DedicatedIpPoolTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DedicatedIpPoolFactory, T2, InnerDedicatedIpPoolTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, DedicatedIpPoolFactory, T2> combinedResult, Action<Humidifier.PinpointEmail.DedicatedIpPoolTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DedicatedIpPoolFactory, InnerDedicatedIpPoolTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, DedicatedIpPoolFactory> combinedResult, Action<Humidifier.PinpointEmail.DedicatedIpPoolTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DedicatedIpPoolFactory, T1, T2, T3, InnerDedicatedIpPoolTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<DedicatedIpPoolFactory, T1, T2, T3> combinedResult, Action<Humidifier.PinpointEmail.DedicatedIpPoolTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DedicatedIpPoolFactory, T2, T3, InnerDedicatedIpPoolTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, DedicatedIpPoolFactory, T2, T3> combinedResult, Action<Humidifier.PinpointEmail.DedicatedIpPoolTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DedicatedIpPoolFactory, T3, InnerDedicatedIpPoolTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, DedicatedIpPoolFactory, T3> combinedResult, Action<Humidifier.PinpointEmail.DedicatedIpPoolTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DedicatedIpPoolFactory, InnerDedicatedIpPoolTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, DedicatedIpPoolFactory> combinedResult, Action<Humidifier.PinpointEmail.DedicatedIpPoolTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DedicatedIpPoolFactory, T1, T2, T3, T4, InnerDedicatedIpPoolTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<DedicatedIpPoolFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PinpointEmail.DedicatedIpPoolTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DedicatedIpPoolFactory, T2, T3, T4, InnerDedicatedIpPoolTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, DedicatedIpPoolFactory, T2, T3, T4> combinedResult, Action<Humidifier.PinpointEmail.DedicatedIpPoolTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DedicatedIpPoolFactory, T3, T4, InnerDedicatedIpPoolTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, DedicatedIpPoolFactory, T3, T4> combinedResult, Action<Humidifier.PinpointEmail.DedicatedIpPoolTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DedicatedIpPoolFactory, T4, InnerDedicatedIpPoolTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DedicatedIpPoolFactory, T4> combinedResult, Action<Humidifier.PinpointEmail.DedicatedIpPoolTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DedicatedIpPoolFactory, InnerDedicatedIpPoolTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DedicatedIpPoolFactory> combinedResult, Action<Humidifier.PinpointEmail.DedicatedIpPoolTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
}
