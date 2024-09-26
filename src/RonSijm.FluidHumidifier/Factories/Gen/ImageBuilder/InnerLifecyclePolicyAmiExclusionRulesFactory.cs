// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerLifecyclePolicyAmiExclusionRulesFactory(Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.AmiExclusionRules> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.LifecyclePolicyTypes.AmiExclusionRules>
{

    internal InnerLifecyclePolicyLastLaunchedFactory LastLaunchedFactory { get; set; }

    protected override Humidifier.ImageBuilder.LifecyclePolicyTypes.AmiExclusionRules Create()
    {
        var amiExclusionRulesResult = CreateAmiExclusionRules();
        factoryAction?.Invoke(amiExclusionRulesResult);

        return amiExclusionRulesResult;
    }

    private Humidifier.ImageBuilder.LifecyclePolicyTypes.AmiExclusionRules CreateAmiExclusionRules()
    {
        var amiExclusionRulesResult = new Humidifier.ImageBuilder.LifecyclePolicyTypes.AmiExclusionRules();

        return amiExclusionRulesResult;
    }
    public override void CreateChildren(Humidifier.ImageBuilder.LifecyclePolicyTypes.AmiExclusionRules result)
    {
        base.CreateChildren(result);

        result.LastLaunched ??= LastLaunchedFactory?.Build();
    }

} // End Of Class

public static class InnerLifecyclePolicyAmiExclusionRulesFactoryExtensions
{
    public static CombinedResult<InnerLifecyclePolicyAmiExclusionRulesFactory, InnerLifecyclePolicyLastLaunchedFactory> WithLastLaunched(this InnerLifecyclePolicyAmiExclusionRulesFactory parentFactory, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.LastLaunched> subFactoryAction = null)
    {
        parentFactory.LastLaunchedFactory = new InnerLifecyclePolicyLastLaunchedFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LastLaunchedFactory);
    }

    public static CombinedResult<InnerLifecyclePolicyAmiExclusionRulesFactory, T1, InnerLifecyclePolicyLastLaunchedFactory> WithLastLaunched<T1>(this CombinedResult<InnerLifecyclePolicyAmiExclusionRulesFactory, T1> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.LastLaunched> subFactoryAction = null) => new (combinedResult, combinedResult, WithLastLaunched(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyAmiExclusionRulesFactory, InnerLifecyclePolicyLastLaunchedFactory> WithLastLaunched<T1>(this CombinedResult<T1, InnerLifecyclePolicyAmiExclusionRulesFactory> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.LastLaunched> subFactoryAction = null) => new (combinedResult, combinedResult, WithLastLaunched(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyAmiExclusionRulesFactory, T1, T2, InnerLifecyclePolicyLastLaunchedFactory> WithLastLaunched<T1, T2>(this CombinedResult<InnerLifecyclePolicyAmiExclusionRulesFactory, T1, T2> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.LastLaunched> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLastLaunched(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyAmiExclusionRulesFactory, T2, InnerLifecyclePolicyLastLaunchedFactory> WithLastLaunched<T1, T2>(this CombinedResult<T1, InnerLifecyclePolicyAmiExclusionRulesFactory, T2> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.LastLaunched> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLastLaunched(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyAmiExclusionRulesFactory, InnerLifecyclePolicyLastLaunchedFactory> WithLastLaunched<T1, T2>(this CombinedResult<T1, T2, InnerLifecyclePolicyAmiExclusionRulesFactory> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.LastLaunched> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLastLaunched(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyAmiExclusionRulesFactory, T1, T2, T3, InnerLifecyclePolicyLastLaunchedFactory> WithLastLaunched<T1, T2, T3>(this CombinedResult<InnerLifecyclePolicyAmiExclusionRulesFactory, T1, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.LastLaunched> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLastLaunched(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyAmiExclusionRulesFactory, T2, T3, InnerLifecyclePolicyLastLaunchedFactory> WithLastLaunched<T1, T2, T3>(this CombinedResult<T1, InnerLifecyclePolicyAmiExclusionRulesFactory, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.LastLaunched> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLastLaunched(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyAmiExclusionRulesFactory, T3, InnerLifecyclePolicyLastLaunchedFactory> WithLastLaunched<T1, T2, T3>(this CombinedResult<T1, T2, InnerLifecyclePolicyAmiExclusionRulesFactory, T3> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.LastLaunched> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLastLaunched(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLifecyclePolicyAmiExclusionRulesFactory, InnerLifecyclePolicyLastLaunchedFactory> WithLastLaunched<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLifecyclePolicyAmiExclusionRulesFactory> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.LastLaunched> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLastLaunched(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyAmiExclusionRulesFactory, T1, T2, T3, T4, InnerLifecyclePolicyLastLaunchedFactory> WithLastLaunched<T1, T2, T3, T4>(this CombinedResult<InnerLifecyclePolicyAmiExclusionRulesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.LastLaunched> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLastLaunched(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyAmiExclusionRulesFactory, T2, T3, T4, InnerLifecyclePolicyLastLaunchedFactory> WithLastLaunched<T1, T2, T3, T4>(this CombinedResult<T1, InnerLifecyclePolicyAmiExclusionRulesFactory, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.LastLaunched> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLastLaunched(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyAmiExclusionRulesFactory, T3, T4, InnerLifecyclePolicyLastLaunchedFactory> WithLastLaunched<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLifecyclePolicyAmiExclusionRulesFactory, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.LastLaunched> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLastLaunched(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLifecyclePolicyAmiExclusionRulesFactory, T4, InnerLifecyclePolicyLastLaunchedFactory> WithLastLaunched<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLifecyclePolicyAmiExclusionRulesFactory, T4> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.LastLaunched> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLastLaunched(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLifecyclePolicyAmiExclusionRulesFactory, InnerLifecyclePolicyLastLaunchedFactory> WithLastLaunched<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLifecyclePolicyAmiExclusionRulesFactory> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.LastLaunched> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLastLaunched(combinedResult.T5, subFactoryAction));
}
