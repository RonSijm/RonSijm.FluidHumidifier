// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FMS;

public class PolicyFactory(string resourceName = null, Action<Humidifier.FMS.Policy> factoryAction = null) : ResourceFactory<Humidifier.FMS.Policy>(resourceName)
{

    internal List<InnerPolicyResourceTagFactory> ResourceTagsFactories { get; set; } = [];

    internal List<InnerPolicyPolicyTagFactory> TagsFactories { get; set; } = [];

    internal InnerPolicySecurityServicePolicyDataFactory SecurityServicePolicyDataFactory { get; set; }

    internal InnerPolicyIEMapFactory ExcludeMapFactory { get; set; }

    internal InnerPolicyIEMapFactory IncludeMapFactory { get; set; }

    protected override Humidifier.FMS.Policy Create()
    {
        var policyResult = CreatePolicy();
        factoryAction?.Invoke(policyResult);

        return policyResult;
    }

    private Humidifier.FMS.Policy CreatePolicy()
    {
        var policyResult = new Humidifier.FMS.Policy
        {
            GivenName = InputResourceName,
        };

        return policyResult;
    }
    public override void CreateChildren(Humidifier.FMS.Policy result)
    {
        base.CreateChildren(result);

        result.ResourceTags = ResourceTagsFactories.Any() ? ResourceTagsFactories.Select(x => x.Build()).ToList() : null;
        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.SecurityServicePolicyData ??= SecurityServicePolicyDataFactory?.Build();
        result.ExcludeMap ??= ExcludeMapFactory?.Build();
        result.IncludeMap ??= IncludeMapFactory?.Build();
    }

} // End Of Class

public static class PolicyFactoryExtensions
{
    public static CombinedResult<PolicyFactory, InnerPolicyResourceTagFactory> WithResourceTags(this PolicyFactory parentFactory, Action<Humidifier.FMS.PolicyTypes.ResourceTag> subFactoryAction = null)
    {
        var factory = new InnerPolicyResourceTagFactory(subFactoryAction);
        parentFactory.ResourceTagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<PolicyFactory, InnerPolicyPolicyTagFactory> WithTags(this PolicyFactory parentFactory, Action<Humidifier.FMS.PolicyTypes.PolicyTag> subFactoryAction = null)
    {
        var factory = new InnerPolicyPolicyTagFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<PolicyFactory, InnerPolicySecurityServicePolicyDataFactory> WithSecurityServicePolicyData(this PolicyFactory parentFactory, Action<Humidifier.FMS.PolicyTypes.SecurityServicePolicyData> subFactoryAction = null)
    {
        parentFactory.SecurityServicePolicyDataFactory = new InnerPolicySecurityServicePolicyDataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SecurityServicePolicyDataFactory);
    }

    public static CombinedResult<PolicyFactory, InnerPolicyIEMapFactory> WithExcludeMap(this PolicyFactory parentFactory, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null)
    {
        parentFactory.ExcludeMapFactory = new InnerPolicyIEMapFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExcludeMapFactory);
    }

    public static CombinedResult<PolicyFactory, InnerPolicyIEMapFactory> WithIncludeMap(this PolicyFactory parentFactory, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null)
    {
        parentFactory.IncludeMapFactory = new InnerPolicyIEMapFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IncludeMapFactory);
    }

    public static CombinedResult<PolicyFactory, T1, InnerPolicyResourceTagFactory> WithResourceTags<T1>(this CombinedResult<PolicyFactory, T1> combinedResult, Action<Humidifier.FMS.PolicyTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyFactory, InnerPolicyResourceTagFactory> WithResourceTags<T1>(this CombinedResult<T1, PolicyFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PolicyFactory, T1, T2, InnerPolicyResourceTagFactory> WithResourceTags<T1, T2>(this CombinedResult<PolicyFactory, T1, T2> combinedResult, Action<Humidifier.FMS.PolicyTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyFactory, T2, InnerPolicyResourceTagFactory> WithResourceTags<T1, T2>(this CombinedResult<T1, PolicyFactory, T2> combinedResult, Action<Humidifier.FMS.PolicyTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PolicyFactory, InnerPolicyResourceTagFactory> WithResourceTags<T1, T2>(this CombinedResult<T1, T2, PolicyFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PolicyFactory, T1, T2, T3, InnerPolicyResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<PolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.FMS.PolicyTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyFactory, T2, T3, InnerPolicyResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<T1, PolicyFactory, T2, T3> combinedResult, Action<Humidifier.FMS.PolicyTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PolicyFactory, T3, InnerPolicyResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<T1, T2, PolicyFactory, T3> combinedResult, Action<Humidifier.FMS.PolicyTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PolicyFactory, InnerPolicyResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, PolicyFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PolicyFactory, T1, T2, T3, T4, InnerPolicyResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<PolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyFactory, T2, T3, T4, InnerPolicyResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, PolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PolicyFactory, T3, T4, InnerPolicyResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, PolicyFactory, T3, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PolicyFactory, T4, InnerPolicyResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PolicyFactory, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PolicyFactory, InnerPolicyResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PolicyFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T5, subFactoryAction));
    public static CombinedResult<PolicyFactory, T1, InnerPolicyPolicyTagFactory> WithTags<T1>(this CombinedResult<PolicyFactory, T1> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyFactory, InnerPolicyPolicyTagFactory> WithTags<T1>(this CombinedResult<T1, PolicyFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PolicyFactory, T1, T2, InnerPolicyPolicyTagFactory> WithTags<T1, T2>(this CombinedResult<PolicyFactory, T1, T2> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyFactory, T2, InnerPolicyPolicyTagFactory> WithTags<T1, T2>(this CombinedResult<T1, PolicyFactory, T2> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PolicyFactory, InnerPolicyPolicyTagFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, PolicyFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PolicyFactory, T1, T2, T3, InnerPolicyPolicyTagFactory> WithTags<T1, T2, T3>(this CombinedResult<PolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyFactory, T2, T3, InnerPolicyPolicyTagFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, PolicyFactory, T2, T3> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PolicyFactory, T3, InnerPolicyPolicyTagFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, PolicyFactory, T3> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PolicyFactory, InnerPolicyPolicyTagFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, PolicyFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PolicyFactory, T1, T2, T3, T4, InnerPolicyPolicyTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<PolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyFactory, T2, T3, T4, InnerPolicyPolicyTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, PolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PolicyFactory, T3, T4, InnerPolicyPolicyTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, PolicyFactory, T3, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PolicyFactory, T4, InnerPolicyPolicyTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PolicyFactory, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PolicyFactory, InnerPolicyPolicyTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PolicyFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
    public static CombinedResult<PolicyFactory, T1, InnerPolicySecurityServicePolicyDataFactory> WithSecurityServicePolicyData<T1>(this CombinedResult<PolicyFactory, T1> combinedResult, Action<Humidifier.FMS.PolicyTypes.SecurityServicePolicyData> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecurityServicePolicyData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyFactory, InnerPolicySecurityServicePolicyDataFactory> WithSecurityServicePolicyData<T1>(this CombinedResult<T1, PolicyFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.SecurityServicePolicyData> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecurityServicePolicyData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PolicyFactory, T1, T2, InnerPolicySecurityServicePolicyDataFactory> WithSecurityServicePolicyData<T1, T2>(this CombinedResult<PolicyFactory, T1, T2> combinedResult, Action<Humidifier.FMS.PolicyTypes.SecurityServicePolicyData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityServicePolicyData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyFactory, T2, InnerPolicySecurityServicePolicyDataFactory> WithSecurityServicePolicyData<T1, T2>(this CombinedResult<T1, PolicyFactory, T2> combinedResult, Action<Humidifier.FMS.PolicyTypes.SecurityServicePolicyData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityServicePolicyData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PolicyFactory, InnerPolicySecurityServicePolicyDataFactory> WithSecurityServicePolicyData<T1, T2>(this CombinedResult<T1, T2, PolicyFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.SecurityServicePolicyData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityServicePolicyData(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PolicyFactory, T1, T2, T3, InnerPolicySecurityServicePolicyDataFactory> WithSecurityServicePolicyData<T1, T2, T3>(this CombinedResult<PolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.FMS.PolicyTypes.SecurityServicePolicyData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityServicePolicyData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyFactory, T2, T3, InnerPolicySecurityServicePolicyDataFactory> WithSecurityServicePolicyData<T1, T2, T3>(this CombinedResult<T1, PolicyFactory, T2, T3> combinedResult, Action<Humidifier.FMS.PolicyTypes.SecurityServicePolicyData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityServicePolicyData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PolicyFactory, T3, InnerPolicySecurityServicePolicyDataFactory> WithSecurityServicePolicyData<T1, T2, T3>(this CombinedResult<T1, T2, PolicyFactory, T3> combinedResult, Action<Humidifier.FMS.PolicyTypes.SecurityServicePolicyData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityServicePolicyData(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PolicyFactory, InnerPolicySecurityServicePolicyDataFactory> WithSecurityServicePolicyData<T1, T2, T3>(this CombinedResult<T1, T2, T3, PolicyFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.SecurityServicePolicyData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityServicePolicyData(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PolicyFactory, T1, T2, T3, T4, InnerPolicySecurityServicePolicyDataFactory> WithSecurityServicePolicyData<T1, T2, T3, T4>(this CombinedResult<PolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.SecurityServicePolicyData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityServicePolicyData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyFactory, T2, T3, T4, InnerPolicySecurityServicePolicyDataFactory> WithSecurityServicePolicyData<T1, T2, T3, T4>(this CombinedResult<T1, PolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.SecurityServicePolicyData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityServicePolicyData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PolicyFactory, T3, T4, InnerPolicySecurityServicePolicyDataFactory> WithSecurityServicePolicyData<T1, T2, T3, T4>(this CombinedResult<T1, T2, PolicyFactory, T3, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.SecurityServicePolicyData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityServicePolicyData(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PolicyFactory, T4, InnerPolicySecurityServicePolicyDataFactory> WithSecurityServicePolicyData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PolicyFactory, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.SecurityServicePolicyData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityServicePolicyData(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PolicyFactory, InnerPolicySecurityServicePolicyDataFactory> WithSecurityServicePolicyData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PolicyFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.SecurityServicePolicyData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityServicePolicyData(combinedResult.T5, subFactoryAction));
    public static CombinedResult<PolicyFactory, T1, InnerPolicyIEMapFactory> WithExcludeMap<T1>(this CombinedResult<PolicyFactory, T1> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, WithExcludeMap(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyFactory, InnerPolicyIEMapFactory> WithExcludeMap<T1>(this CombinedResult<T1, PolicyFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, WithExcludeMap(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PolicyFactory, T1, T2, InnerPolicyIEMapFactory> WithExcludeMap<T1, T2>(this CombinedResult<PolicyFactory, T1, T2> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExcludeMap(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyFactory, T2, InnerPolicyIEMapFactory> WithExcludeMap<T1, T2>(this CombinedResult<T1, PolicyFactory, T2> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExcludeMap(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PolicyFactory, InnerPolicyIEMapFactory> WithExcludeMap<T1, T2>(this CombinedResult<T1, T2, PolicyFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExcludeMap(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PolicyFactory, T1, T2, T3, InnerPolicyIEMapFactory> WithExcludeMap<T1, T2, T3>(this CombinedResult<PolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeMap(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyFactory, T2, T3, InnerPolicyIEMapFactory> WithExcludeMap<T1, T2, T3>(this CombinedResult<T1, PolicyFactory, T2, T3> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeMap(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PolicyFactory, T3, InnerPolicyIEMapFactory> WithExcludeMap<T1, T2, T3>(this CombinedResult<T1, T2, PolicyFactory, T3> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeMap(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PolicyFactory, InnerPolicyIEMapFactory> WithExcludeMap<T1, T2, T3>(this CombinedResult<T1, T2, T3, PolicyFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeMap(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PolicyFactory, T1, T2, T3, T4, InnerPolicyIEMapFactory> WithExcludeMap<T1, T2, T3, T4>(this CombinedResult<PolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeMap(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyFactory, T2, T3, T4, InnerPolicyIEMapFactory> WithExcludeMap<T1, T2, T3, T4>(this CombinedResult<T1, PolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeMap(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PolicyFactory, T3, T4, InnerPolicyIEMapFactory> WithExcludeMap<T1, T2, T3, T4>(this CombinedResult<T1, T2, PolicyFactory, T3, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeMap(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PolicyFactory, T4, InnerPolicyIEMapFactory> WithExcludeMap<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PolicyFactory, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeMap(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PolicyFactory, InnerPolicyIEMapFactory> WithExcludeMap<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PolicyFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeMap(combinedResult.T5, subFactoryAction));
    public static CombinedResult<PolicyFactory, T1, InnerPolicyIEMapFactory> WithIncludeMap<T1>(this CombinedResult<PolicyFactory, T1> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, WithIncludeMap(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyFactory, InnerPolicyIEMapFactory> WithIncludeMap<T1>(this CombinedResult<T1, PolicyFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, WithIncludeMap(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PolicyFactory, T1, T2, InnerPolicyIEMapFactory> WithIncludeMap<T1, T2>(this CombinedResult<PolicyFactory, T1, T2> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIncludeMap(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyFactory, T2, InnerPolicyIEMapFactory> WithIncludeMap<T1, T2>(this CombinedResult<T1, PolicyFactory, T2> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIncludeMap(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PolicyFactory, InnerPolicyIEMapFactory> WithIncludeMap<T1, T2>(this CombinedResult<T1, T2, PolicyFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIncludeMap(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PolicyFactory, T1, T2, T3, InnerPolicyIEMapFactory> WithIncludeMap<T1, T2, T3>(this CombinedResult<PolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeMap(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyFactory, T2, T3, InnerPolicyIEMapFactory> WithIncludeMap<T1, T2, T3>(this CombinedResult<T1, PolicyFactory, T2, T3> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeMap(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PolicyFactory, T3, InnerPolicyIEMapFactory> WithIncludeMap<T1, T2, T3>(this CombinedResult<T1, T2, PolicyFactory, T3> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeMap(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PolicyFactory, InnerPolicyIEMapFactory> WithIncludeMap<T1, T2, T3>(this CombinedResult<T1, T2, T3, PolicyFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeMap(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PolicyFactory, T1, T2, T3, T4, InnerPolicyIEMapFactory> WithIncludeMap<T1, T2, T3, T4>(this CombinedResult<PolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeMap(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyFactory, T2, T3, T4, InnerPolicyIEMapFactory> WithIncludeMap<T1, T2, T3, T4>(this CombinedResult<T1, PolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeMap(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PolicyFactory, T3, T4, InnerPolicyIEMapFactory> WithIncludeMap<T1, T2, T3, T4>(this CombinedResult<T1, T2, PolicyFactory, T3, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeMap(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PolicyFactory, T4, InnerPolicyIEMapFactory> WithIncludeMap<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PolicyFactory, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeMap(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PolicyFactory, InnerPolicyIEMapFactory> WithIncludeMap<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PolicyFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.IEMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeMap(combinedResult.T5, subFactoryAction));
}
