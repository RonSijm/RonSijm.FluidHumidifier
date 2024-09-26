// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerLifecyclePolicyExclusionRulesFactory(Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.ExclusionRules> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.LifecyclePolicyTypes.ExclusionRules>
{

    internal InnerLifecyclePolicyAmiExclusionRulesFactory AmisFactory { get; set; }

    protected override Humidifier.ImageBuilder.LifecyclePolicyTypes.ExclusionRules Create()
    {
        var exclusionRulesResult = CreateExclusionRules();
        factoryAction?.Invoke(exclusionRulesResult);

        return exclusionRulesResult;
    }

    private Humidifier.ImageBuilder.LifecyclePolicyTypes.ExclusionRules CreateExclusionRules()
    {
        var exclusionRulesResult = new Humidifier.ImageBuilder.LifecyclePolicyTypes.ExclusionRules();

        return exclusionRulesResult;
    }
    public override void CreateChildren(Humidifier.ImageBuilder.LifecyclePolicyTypes.ExclusionRules result)
    {
        base.CreateChildren(result);

        result.Amis ??= AmisFactory?.Build();
    }

} // End Of Class

public static class InnerLifecyclePolicyExclusionRulesFactoryExtensions
{
    public static CombinedResult<InnerLifecyclePolicyExclusionRulesFactory, InnerLifecyclePolicyAmiExclusionRulesFactory> WithAmis(this InnerLifecyclePolicyExclusionRulesFactory parentFactory, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.AmiExclusionRules> subFactoryAction = null)
    {
        parentFactory.AmisFactory = new InnerLifecyclePolicyAmiExclusionRulesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AmisFactory);
    }

    public static CombinedResult<InnerLifecyclePolicyExclusionRulesFactory, T1, InnerLifecyclePolicyAmiExclusionRulesFactory> WithAmis<T1>(this CombinedResult<InnerLifecyclePolicyExclusionRulesFactory, T1> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.AmiExclusionRules> subFactoryAction = null) => new (combinedResult, combinedResult, WithAmis(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyExclusionRulesFactory, InnerLifecyclePolicyAmiExclusionRulesFactory> WithAmis<T1>(this CombinedResult<T1, InnerLifecyclePolicyExclusionRulesFactory> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.AmiExclusionRules> subFactoryAction = null) => new (combinedResult, combinedResult, WithAmis(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyExclusionRulesFactory, T1, T2, InnerLifecyclePolicyAmiExclusionRulesFactory> WithAmis<T1, T2>(this CombinedResult<InnerLifecyclePolicyExclusionRulesFactory, T1, T2> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.AmiExclusionRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAmis(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyExclusionRulesFactory, T2, InnerLifecyclePolicyAmiExclusionRulesFactory> WithAmis<T1, T2>(this CombinedResult<T1, InnerLifecyclePolicyExclusionRulesFactory, T2> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.AmiExclusionRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAmis(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyExclusionRulesFactory, InnerLifecyclePolicyAmiExclusionRulesFactory> WithAmis<T1, T2>(this CombinedResult<T1, T2, InnerLifecyclePolicyExclusionRulesFactory> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.AmiExclusionRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAmis(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyExclusionRulesFactory, T1, T2, T3, InnerLifecyclePolicyAmiExclusionRulesFactory> WithAmis<T1, T2, T3>(this CombinedResult<InnerLifecyclePolicyExclusionRulesFactory, T1, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.AmiExclusionRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAmis(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyExclusionRulesFactory, T2, T3, InnerLifecyclePolicyAmiExclusionRulesFactory> WithAmis<T1, T2, T3>(this CombinedResult<T1, InnerLifecyclePolicyExclusionRulesFactory, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.AmiExclusionRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAmis(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyExclusionRulesFactory, T3, InnerLifecyclePolicyAmiExclusionRulesFactory> WithAmis<T1, T2, T3>(this CombinedResult<T1, T2, InnerLifecyclePolicyExclusionRulesFactory, T3> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.AmiExclusionRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAmis(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLifecyclePolicyExclusionRulesFactory, InnerLifecyclePolicyAmiExclusionRulesFactory> WithAmis<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLifecyclePolicyExclusionRulesFactory> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.AmiExclusionRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAmis(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyExclusionRulesFactory, T1, T2, T3, T4, InnerLifecyclePolicyAmiExclusionRulesFactory> WithAmis<T1, T2, T3, T4>(this CombinedResult<InnerLifecyclePolicyExclusionRulesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.AmiExclusionRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAmis(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyExclusionRulesFactory, T2, T3, T4, InnerLifecyclePolicyAmiExclusionRulesFactory> WithAmis<T1, T2, T3, T4>(this CombinedResult<T1, InnerLifecyclePolicyExclusionRulesFactory, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.AmiExclusionRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAmis(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyExclusionRulesFactory, T3, T4, InnerLifecyclePolicyAmiExclusionRulesFactory> WithAmis<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLifecyclePolicyExclusionRulesFactory, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.AmiExclusionRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAmis(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLifecyclePolicyExclusionRulesFactory, T4, InnerLifecyclePolicyAmiExclusionRulesFactory> WithAmis<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLifecyclePolicyExclusionRulesFactory, T4> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.AmiExclusionRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAmis(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLifecyclePolicyExclusionRulesFactory, InnerLifecyclePolicyAmiExclusionRulesFactory> WithAmis<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLifecyclePolicyExclusionRulesFactory> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.AmiExclusionRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAmis(combinedResult.T5, subFactoryAction));
}
