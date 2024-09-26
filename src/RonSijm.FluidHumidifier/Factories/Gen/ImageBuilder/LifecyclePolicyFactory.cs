// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class LifecyclePolicyFactory(string resourceName = null, Action<Humidifier.ImageBuilder.LifecyclePolicy> factoryAction = null) : ResourceFactory<Humidifier.ImageBuilder.LifecyclePolicy>(resourceName)
{

    internal List<InnerLifecyclePolicyPolicyDetailFactory> PolicyDetailsFactories { get; set; } = [];

    internal InnerLifecyclePolicyResourceSelectionFactory ResourceSelectionFactory { get; set; }

    protected override Humidifier.ImageBuilder.LifecyclePolicy Create()
    {
        var lifecyclePolicyResult = CreateLifecyclePolicy();
        factoryAction?.Invoke(lifecyclePolicyResult);

        return lifecyclePolicyResult;
    }

    private Humidifier.ImageBuilder.LifecyclePolicy CreateLifecyclePolicy()
    {
        var lifecyclePolicyResult = new Humidifier.ImageBuilder.LifecyclePolicy
        {
            GivenName = InputResourceName,
        };

        return lifecyclePolicyResult;
    }
    public override void CreateChildren(Humidifier.ImageBuilder.LifecyclePolicy result)
    {
        base.CreateChildren(result);

        result.PolicyDetails = PolicyDetailsFactories.Any() ? PolicyDetailsFactories.Select(x => x.Build()).ToList() : null;
        result.ResourceSelection ??= ResourceSelectionFactory?.Build();
    }

} // End Of Class

public static class LifecyclePolicyFactoryExtensions
{
    public static CombinedResult<LifecyclePolicyFactory, InnerLifecyclePolicyPolicyDetailFactory> WithPolicyDetails(this LifecyclePolicyFactory parentFactory, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.PolicyDetail> subFactoryAction = null)
    {
        var factory = new InnerLifecyclePolicyPolicyDetailFactory(subFactoryAction);
        parentFactory.PolicyDetailsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<LifecyclePolicyFactory, InnerLifecyclePolicyResourceSelectionFactory> WithResourceSelection(this LifecyclePolicyFactory parentFactory, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.ResourceSelection> subFactoryAction = null)
    {
        parentFactory.ResourceSelectionFactory = new InnerLifecyclePolicyResourceSelectionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResourceSelectionFactory);
    }

    public static CombinedResult<LifecyclePolicyFactory, T1, InnerLifecyclePolicyPolicyDetailFactory> WithPolicyDetails<T1>(this CombinedResult<LifecyclePolicyFactory, T1> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.PolicyDetail> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicyDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LifecyclePolicyFactory, InnerLifecyclePolicyPolicyDetailFactory> WithPolicyDetails<T1>(this CombinedResult<T1, LifecyclePolicyFactory> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.PolicyDetail> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicyDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LifecyclePolicyFactory, T1, T2, InnerLifecyclePolicyPolicyDetailFactory> WithPolicyDetails<T1, T2>(this CombinedResult<LifecyclePolicyFactory, T1, T2> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.PolicyDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicyDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LifecyclePolicyFactory, T2, InnerLifecyclePolicyPolicyDetailFactory> WithPolicyDetails<T1, T2>(this CombinedResult<T1, LifecyclePolicyFactory, T2> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.PolicyDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicyDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LifecyclePolicyFactory, InnerLifecyclePolicyPolicyDetailFactory> WithPolicyDetails<T1, T2>(this CombinedResult<T1, T2, LifecyclePolicyFactory> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.PolicyDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicyDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LifecyclePolicyFactory, T1, T2, T3, InnerLifecyclePolicyPolicyDetailFactory> WithPolicyDetails<T1, T2, T3>(this CombinedResult<LifecyclePolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.PolicyDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LifecyclePolicyFactory, T2, T3, InnerLifecyclePolicyPolicyDetailFactory> WithPolicyDetails<T1, T2, T3>(this CombinedResult<T1, LifecyclePolicyFactory, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.PolicyDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LifecyclePolicyFactory, T3, InnerLifecyclePolicyPolicyDetailFactory> WithPolicyDetails<T1, T2, T3>(this CombinedResult<T1, T2, LifecyclePolicyFactory, T3> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.PolicyDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LifecyclePolicyFactory, InnerLifecyclePolicyPolicyDetailFactory> WithPolicyDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, LifecyclePolicyFactory> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.PolicyDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LifecyclePolicyFactory, T1, T2, T3, T4, InnerLifecyclePolicyPolicyDetailFactory> WithPolicyDetails<T1, T2, T3, T4>(this CombinedResult<LifecyclePolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.PolicyDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LifecyclePolicyFactory, T2, T3, T4, InnerLifecyclePolicyPolicyDetailFactory> WithPolicyDetails<T1, T2, T3, T4>(this CombinedResult<T1, LifecyclePolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.PolicyDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LifecyclePolicyFactory, T3, T4, InnerLifecyclePolicyPolicyDetailFactory> WithPolicyDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, LifecyclePolicyFactory, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.PolicyDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LifecyclePolicyFactory, T4, InnerLifecyclePolicyPolicyDetailFactory> WithPolicyDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LifecyclePolicyFactory, T4> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.PolicyDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LifecyclePolicyFactory, InnerLifecyclePolicyPolicyDetailFactory> WithPolicyDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LifecyclePolicyFactory> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.PolicyDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDetails(combinedResult.T5, subFactoryAction));
    public static CombinedResult<LifecyclePolicyFactory, T1, InnerLifecyclePolicyResourceSelectionFactory> WithResourceSelection<T1>(this CombinedResult<LifecyclePolicyFactory, T1> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceSelection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LifecyclePolicyFactory, InnerLifecyclePolicyResourceSelectionFactory> WithResourceSelection<T1>(this CombinedResult<T1, LifecyclePolicyFactory> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceSelection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LifecyclePolicyFactory, T1, T2, InnerLifecyclePolicyResourceSelectionFactory> WithResourceSelection<T1, T2>(this CombinedResult<LifecyclePolicyFactory, T1, T2> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceSelection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LifecyclePolicyFactory, T2, InnerLifecyclePolicyResourceSelectionFactory> WithResourceSelection<T1, T2>(this CombinedResult<T1, LifecyclePolicyFactory, T2> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceSelection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LifecyclePolicyFactory, InnerLifecyclePolicyResourceSelectionFactory> WithResourceSelection<T1, T2>(this CombinedResult<T1, T2, LifecyclePolicyFactory> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceSelection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LifecyclePolicyFactory, T1, T2, T3, InnerLifecyclePolicyResourceSelectionFactory> WithResourceSelection<T1, T2, T3>(this CombinedResult<LifecyclePolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSelection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LifecyclePolicyFactory, T2, T3, InnerLifecyclePolicyResourceSelectionFactory> WithResourceSelection<T1, T2, T3>(this CombinedResult<T1, LifecyclePolicyFactory, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSelection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LifecyclePolicyFactory, T3, InnerLifecyclePolicyResourceSelectionFactory> WithResourceSelection<T1, T2, T3>(this CombinedResult<T1, T2, LifecyclePolicyFactory, T3> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSelection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LifecyclePolicyFactory, InnerLifecyclePolicyResourceSelectionFactory> WithResourceSelection<T1, T2, T3>(this CombinedResult<T1, T2, T3, LifecyclePolicyFactory> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSelection(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LifecyclePolicyFactory, T1, T2, T3, T4, InnerLifecyclePolicyResourceSelectionFactory> WithResourceSelection<T1, T2, T3, T4>(this CombinedResult<LifecyclePolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSelection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LifecyclePolicyFactory, T2, T3, T4, InnerLifecyclePolicyResourceSelectionFactory> WithResourceSelection<T1, T2, T3, T4>(this CombinedResult<T1, LifecyclePolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSelection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LifecyclePolicyFactory, T3, T4, InnerLifecyclePolicyResourceSelectionFactory> WithResourceSelection<T1, T2, T3, T4>(this CombinedResult<T1, T2, LifecyclePolicyFactory, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSelection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LifecyclePolicyFactory, T4, InnerLifecyclePolicyResourceSelectionFactory> WithResourceSelection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LifecyclePolicyFactory, T4> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSelection(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LifecyclePolicyFactory, InnerLifecyclePolicyResourceSelectionFactory> WithResourceSelection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LifecyclePolicyFactory> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.ResourceSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSelection(combinedResult.T5, subFactoryAction));
}
