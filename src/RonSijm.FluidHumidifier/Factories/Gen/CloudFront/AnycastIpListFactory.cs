// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class AnycastIpListFactory(string resourceName = null, Action<Humidifier.CloudFront.AnycastIpList> factoryAction = null) : ResourceFactory<Humidifier.CloudFront.AnycastIpList>(resourceName)
{

    internal InnerAnycastIpListTagsFactory TagsFactory { get; set; }

    protected override Humidifier.CloudFront.AnycastIpList Create()
    {
        var anycastIpListResult = CreateAnycastIpList();
        factoryAction?.Invoke(anycastIpListResult);

        return anycastIpListResult;
    }

    private Humidifier.CloudFront.AnycastIpList CreateAnycastIpList()
    {
        var anycastIpListResult = new Humidifier.CloudFront.AnycastIpList
        {
            GivenName = InputResourceName,
        };

        return anycastIpListResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.AnycastIpList result)
    {
        base.CreateChildren(result);

        result.Tags ??= TagsFactory?.Build();
    }

} // End Of Class

public static class AnycastIpListFactoryExtensions
{
    public static CombinedResult<AnycastIpListFactory, InnerAnycastIpListTagsFactory> WithTags(this AnycastIpListFactory parentFactory, Action<Humidifier.CloudFront.AnycastIpListTypes.Tags> subFactoryAction = null)
    {
        parentFactory.TagsFactory = new InnerAnycastIpListTagsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TagsFactory);
    }

    public static CombinedResult<AnycastIpListFactory, T1, InnerAnycastIpListTagsFactory> WithTags<T1>(this CombinedResult<AnycastIpListFactory, T1> combinedResult, Action<Humidifier.CloudFront.AnycastIpListTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnycastIpListFactory, InnerAnycastIpListTagsFactory> WithTags<T1>(this CombinedResult<T1, AnycastIpListFactory> combinedResult, Action<Humidifier.CloudFront.AnycastIpListTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AnycastIpListFactory, T1, T2, InnerAnycastIpListTagsFactory> WithTags<T1, T2>(this CombinedResult<AnycastIpListFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.AnycastIpListTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnycastIpListFactory, T2, InnerAnycastIpListTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, AnycastIpListFactory, T2> combinedResult, Action<Humidifier.CloudFront.AnycastIpListTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnycastIpListFactory, InnerAnycastIpListTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, AnycastIpListFactory> combinedResult, Action<Humidifier.CloudFront.AnycastIpListTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AnycastIpListFactory, T1, T2, T3, InnerAnycastIpListTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<AnycastIpListFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.AnycastIpListTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnycastIpListFactory, T2, T3, InnerAnycastIpListTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, AnycastIpListFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.AnycastIpListTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnycastIpListFactory, T3, InnerAnycastIpListTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, AnycastIpListFactory, T3> combinedResult, Action<Humidifier.CloudFront.AnycastIpListTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnycastIpListFactory, InnerAnycastIpListTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, AnycastIpListFactory> combinedResult, Action<Humidifier.CloudFront.AnycastIpListTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AnycastIpListFactory, T1, T2, T3, T4, InnerAnycastIpListTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<AnycastIpListFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.AnycastIpListTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnycastIpListFactory, T2, T3, T4, InnerAnycastIpListTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, AnycastIpListFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.AnycastIpListTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnycastIpListFactory, T3, T4, InnerAnycastIpListTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, AnycastIpListFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.AnycastIpListTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnycastIpListFactory, T4, InnerAnycastIpListTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AnycastIpListFactory, T4> combinedResult, Action<Humidifier.CloudFront.AnycastIpListTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AnycastIpListFactory, InnerAnycastIpListTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AnycastIpListFactory> combinedResult, Action<Humidifier.CloudFront.AnycastIpListTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
}
