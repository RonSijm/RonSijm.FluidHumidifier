// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class CodeSigningConfigFactory(string resourceName = null, Action<Humidifier.Lambda.CodeSigningConfig> factoryAction = null) : ResourceFactory<Humidifier.Lambda.CodeSigningConfig>(resourceName)
{

    internal InnerCodeSigningConfigAllowedPublishersFactory AllowedPublishersFactory { get; set; }

    internal InnerCodeSigningConfigCodeSigningPoliciesFactory CodeSigningPoliciesFactory { get; set; }

    protected override Humidifier.Lambda.CodeSigningConfig Create()
    {
        var codeSigningConfigResult = CreateCodeSigningConfig();
        factoryAction?.Invoke(codeSigningConfigResult);

        return codeSigningConfigResult;
    }

    private Humidifier.Lambda.CodeSigningConfig CreateCodeSigningConfig()
    {
        var codeSigningConfigResult = new Humidifier.Lambda.CodeSigningConfig
        {
            GivenName = InputResourceName,
        };

        return codeSigningConfigResult;
    }
    public override void CreateChildren(Humidifier.Lambda.CodeSigningConfig result)
    {
        base.CreateChildren(result);

        result.AllowedPublishers ??= AllowedPublishersFactory?.Build();
        result.CodeSigningPolicies ??= CodeSigningPoliciesFactory?.Build();
    }

} // End Of Class

public static class CodeSigningConfigFactoryExtensions
{
    public static CombinedResult<CodeSigningConfigFactory, InnerCodeSigningConfigAllowedPublishersFactory> WithAllowedPublishers(this CodeSigningConfigFactory parentFactory, Action<Humidifier.Lambda.CodeSigningConfigTypes.AllowedPublishers> subFactoryAction = null)
    {
        parentFactory.AllowedPublishersFactory = new InnerCodeSigningConfigAllowedPublishersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AllowedPublishersFactory);
    }

    public static CombinedResult<CodeSigningConfigFactory, InnerCodeSigningConfigCodeSigningPoliciesFactory> WithCodeSigningPolicies(this CodeSigningConfigFactory parentFactory, Action<Humidifier.Lambda.CodeSigningConfigTypes.CodeSigningPolicies> subFactoryAction = null)
    {
        parentFactory.CodeSigningPoliciesFactory = new InnerCodeSigningConfigCodeSigningPoliciesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CodeSigningPoliciesFactory);
    }

    public static CombinedResult<CodeSigningConfigFactory, T1, InnerCodeSigningConfigAllowedPublishersFactory> WithAllowedPublishers<T1>(this CombinedResult<CodeSigningConfigFactory, T1> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.AllowedPublishers> subFactoryAction = null) => new (combinedResult, combinedResult, WithAllowedPublishers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CodeSigningConfigFactory, InnerCodeSigningConfigAllowedPublishersFactory> WithAllowedPublishers<T1>(this CombinedResult<T1, CodeSigningConfigFactory> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.AllowedPublishers> subFactoryAction = null) => new (combinedResult, combinedResult, WithAllowedPublishers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CodeSigningConfigFactory, T1, T2, InnerCodeSigningConfigAllowedPublishersFactory> WithAllowedPublishers<T1, T2>(this CombinedResult<CodeSigningConfigFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.AllowedPublishers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAllowedPublishers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CodeSigningConfigFactory, T2, InnerCodeSigningConfigAllowedPublishersFactory> WithAllowedPublishers<T1, T2>(this CombinedResult<T1, CodeSigningConfigFactory, T2> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.AllowedPublishers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAllowedPublishers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CodeSigningConfigFactory, InnerCodeSigningConfigAllowedPublishersFactory> WithAllowedPublishers<T1, T2>(this CombinedResult<T1, T2, CodeSigningConfigFactory> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.AllowedPublishers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAllowedPublishers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CodeSigningConfigFactory, T1, T2, T3, InnerCodeSigningConfigAllowedPublishersFactory> WithAllowedPublishers<T1, T2, T3>(this CombinedResult<CodeSigningConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.AllowedPublishers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAllowedPublishers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CodeSigningConfigFactory, T2, T3, InnerCodeSigningConfigAllowedPublishersFactory> WithAllowedPublishers<T1, T2, T3>(this CombinedResult<T1, CodeSigningConfigFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.AllowedPublishers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAllowedPublishers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CodeSigningConfigFactory, T3, InnerCodeSigningConfigAllowedPublishersFactory> WithAllowedPublishers<T1, T2, T3>(this CombinedResult<T1, T2, CodeSigningConfigFactory, T3> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.AllowedPublishers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAllowedPublishers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CodeSigningConfigFactory, InnerCodeSigningConfigAllowedPublishersFactory> WithAllowedPublishers<T1, T2, T3>(this CombinedResult<T1, T2, T3, CodeSigningConfigFactory> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.AllowedPublishers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAllowedPublishers(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CodeSigningConfigFactory, T1, T2, T3, T4, InnerCodeSigningConfigAllowedPublishersFactory> WithAllowedPublishers<T1, T2, T3, T4>(this CombinedResult<CodeSigningConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.AllowedPublishers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAllowedPublishers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CodeSigningConfigFactory, T2, T3, T4, InnerCodeSigningConfigAllowedPublishersFactory> WithAllowedPublishers<T1, T2, T3, T4>(this CombinedResult<T1, CodeSigningConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.AllowedPublishers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAllowedPublishers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CodeSigningConfigFactory, T3, T4, InnerCodeSigningConfigAllowedPublishersFactory> WithAllowedPublishers<T1, T2, T3, T4>(this CombinedResult<T1, T2, CodeSigningConfigFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.AllowedPublishers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAllowedPublishers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CodeSigningConfigFactory, T4, InnerCodeSigningConfigAllowedPublishersFactory> WithAllowedPublishers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CodeSigningConfigFactory, T4> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.AllowedPublishers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAllowedPublishers(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CodeSigningConfigFactory, InnerCodeSigningConfigAllowedPublishersFactory> WithAllowedPublishers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CodeSigningConfigFactory> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.AllowedPublishers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAllowedPublishers(combinedResult.T5, subFactoryAction));
    public static CombinedResult<CodeSigningConfigFactory, T1, InnerCodeSigningConfigCodeSigningPoliciesFactory> WithCodeSigningPolicies<T1>(this CombinedResult<CodeSigningConfigFactory, T1> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.CodeSigningPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, WithCodeSigningPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CodeSigningConfigFactory, InnerCodeSigningConfigCodeSigningPoliciesFactory> WithCodeSigningPolicies<T1>(this CombinedResult<T1, CodeSigningConfigFactory> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.CodeSigningPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, WithCodeSigningPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CodeSigningConfigFactory, T1, T2, InnerCodeSigningConfigCodeSigningPoliciesFactory> WithCodeSigningPolicies<T1, T2>(this CombinedResult<CodeSigningConfigFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.CodeSigningPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeSigningPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CodeSigningConfigFactory, T2, InnerCodeSigningConfigCodeSigningPoliciesFactory> WithCodeSigningPolicies<T1, T2>(this CombinedResult<T1, CodeSigningConfigFactory, T2> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.CodeSigningPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeSigningPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CodeSigningConfigFactory, InnerCodeSigningConfigCodeSigningPoliciesFactory> WithCodeSigningPolicies<T1, T2>(this CombinedResult<T1, T2, CodeSigningConfigFactory> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.CodeSigningPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeSigningPolicies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CodeSigningConfigFactory, T1, T2, T3, InnerCodeSigningConfigCodeSigningPoliciesFactory> WithCodeSigningPolicies<T1, T2, T3>(this CombinedResult<CodeSigningConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.CodeSigningPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeSigningPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CodeSigningConfigFactory, T2, T3, InnerCodeSigningConfigCodeSigningPoliciesFactory> WithCodeSigningPolicies<T1, T2, T3>(this CombinedResult<T1, CodeSigningConfigFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.CodeSigningPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeSigningPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CodeSigningConfigFactory, T3, InnerCodeSigningConfigCodeSigningPoliciesFactory> WithCodeSigningPolicies<T1, T2, T3>(this CombinedResult<T1, T2, CodeSigningConfigFactory, T3> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.CodeSigningPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeSigningPolicies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CodeSigningConfigFactory, InnerCodeSigningConfigCodeSigningPoliciesFactory> WithCodeSigningPolicies<T1, T2, T3>(this CombinedResult<T1, T2, T3, CodeSigningConfigFactory> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.CodeSigningPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeSigningPolicies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CodeSigningConfigFactory, T1, T2, T3, T4, InnerCodeSigningConfigCodeSigningPoliciesFactory> WithCodeSigningPolicies<T1, T2, T3, T4>(this CombinedResult<CodeSigningConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.CodeSigningPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeSigningPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CodeSigningConfigFactory, T2, T3, T4, InnerCodeSigningConfigCodeSigningPoliciesFactory> WithCodeSigningPolicies<T1, T2, T3, T4>(this CombinedResult<T1, CodeSigningConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.CodeSigningPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeSigningPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CodeSigningConfigFactory, T3, T4, InnerCodeSigningConfigCodeSigningPoliciesFactory> WithCodeSigningPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, CodeSigningConfigFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.CodeSigningPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeSigningPolicies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CodeSigningConfigFactory, T4, InnerCodeSigningConfigCodeSigningPoliciesFactory> WithCodeSigningPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CodeSigningConfigFactory, T4> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.CodeSigningPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeSigningPolicies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CodeSigningConfigFactory, InnerCodeSigningConfigCodeSigningPoliciesFactory> WithCodeSigningPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CodeSigningConfigFactory> combinedResult, Action<Humidifier.Lambda.CodeSigningConfigTypes.CodeSigningPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeSigningPolicies(combinedResult.T5, subFactoryAction));
}
