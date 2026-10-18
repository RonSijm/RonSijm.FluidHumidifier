// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerGuardrailContentPolicyConfigFactory(Action<Humidifier.Bedrock.GuardrailTypes.ContentPolicyConfig> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.GuardrailTypes.ContentPolicyConfig>
{

    internal InnerGuardrailContentFiltersTierConfigFactory ContentFiltersTierConfigFactory { get; set; }

    protected override Humidifier.Bedrock.GuardrailTypes.ContentPolicyConfig Create()
    {
        var contentPolicyConfigResult = CreateContentPolicyConfig();
        factoryAction?.Invoke(contentPolicyConfigResult);

        return contentPolicyConfigResult;
    }

    private Humidifier.Bedrock.GuardrailTypes.ContentPolicyConfig CreateContentPolicyConfig()
    {
        var contentPolicyConfigResult = new Humidifier.Bedrock.GuardrailTypes.ContentPolicyConfig();

        return contentPolicyConfigResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.GuardrailTypes.ContentPolicyConfig result)
    {
        base.CreateChildren(result);

        result.ContentFiltersTierConfig ??= ContentFiltersTierConfigFactory?.Build();
    }

} // End Of Class

public static class InnerGuardrailContentPolicyConfigFactoryExtensions
{
    public static CombinedResult<InnerGuardrailContentPolicyConfigFactory, InnerGuardrailContentFiltersTierConfigFactory> WithContentFiltersTierConfig(this InnerGuardrailContentPolicyConfigFactory parentFactory, Action<Humidifier.Bedrock.GuardrailTypes.ContentFiltersTierConfig> subFactoryAction = null)
    {
        parentFactory.ContentFiltersTierConfigFactory = new InnerGuardrailContentFiltersTierConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContentFiltersTierConfigFactory);
    }

    public static CombinedResult<InnerGuardrailContentPolicyConfigFactory, T1, InnerGuardrailContentFiltersTierConfigFactory> WithContentFiltersTierConfig<T1>(this CombinedResult<InnerGuardrailContentPolicyConfigFactory, T1> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.ContentFiltersTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithContentFiltersTierConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGuardrailContentPolicyConfigFactory, InnerGuardrailContentFiltersTierConfigFactory> WithContentFiltersTierConfig<T1>(this CombinedResult<T1, InnerGuardrailContentPolicyConfigFactory> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.ContentFiltersTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithContentFiltersTierConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGuardrailContentPolicyConfigFactory, T1, T2, InnerGuardrailContentFiltersTierConfigFactory> WithContentFiltersTierConfig<T1, T2>(this CombinedResult<InnerGuardrailContentPolicyConfigFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.ContentFiltersTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContentFiltersTierConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGuardrailContentPolicyConfigFactory, T2, InnerGuardrailContentFiltersTierConfigFactory> WithContentFiltersTierConfig<T1, T2>(this CombinedResult<T1, InnerGuardrailContentPolicyConfigFactory, T2> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.ContentFiltersTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContentFiltersTierConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGuardrailContentPolicyConfigFactory, InnerGuardrailContentFiltersTierConfigFactory> WithContentFiltersTierConfig<T1, T2>(this CombinedResult<T1, T2, InnerGuardrailContentPolicyConfigFactory> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.ContentFiltersTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContentFiltersTierConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGuardrailContentPolicyConfigFactory, T1, T2, T3, InnerGuardrailContentFiltersTierConfigFactory> WithContentFiltersTierConfig<T1, T2, T3>(this CombinedResult<InnerGuardrailContentPolicyConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.ContentFiltersTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContentFiltersTierConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGuardrailContentPolicyConfigFactory, T2, T3, InnerGuardrailContentFiltersTierConfigFactory> WithContentFiltersTierConfig<T1, T2, T3>(this CombinedResult<T1, InnerGuardrailContentPolicyConfigFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.ContentFiltersTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContentFiltersTierConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGuardrailContentPolicyConfigFactory, T3, InnerGuardrailContentFiltersTierConfigFactory> WithContentFiltersTierConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerGuardrailContentPolicyConfigFactory, T3> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.ContentFiltersTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContentFiltersTierConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGuardrailContentPolicyConfigFactory, InnerGuardrailContentFiltersTierConfigFactory> WithContentFiltersTierConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGuardrailContentPolicyConfigFactory> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.ContentFiltersTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContentFiltersTierConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGuardrailContentPolicyConfigFactory, T1, T2, T3, T4, InnerGuardrailContentFiltersTierConfigFactory> WithContentFiltersTierConfig<T1, T2, T3, T4>(this CombinedResult<InnerGuardrailContentPolicyConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.ContentFiltersTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContentFiltersTierConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGuardrailContentPolicyConfigFactory, T2, T3, T4, InnerGuardrailContentFiltersTierConfigFactory> WithContentFiltersTierConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerGuardrailContentPolicyConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.ContentFiltersTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContentFiltersTierConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGuardrailContentPolicyConfigFactory, T3, T4, InnerGuardrailContentFiltersTierConfigFactory> WithContentFiltersTierConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGuardrailContentPolicyConfigFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.ContentFiltersTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContentFiltersTierConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGuardrailContentPolicyConfigFactory, T4, InnerGuardrailContentFiltersTierConfigFactory> WithContentFiltersTierConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGuardrailContentPolicyConfigFactory, T4> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.ContentFiltersTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContentFiltersTierConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGuardrailContentPolicyConfigFactory, InnerGuardrailContentFiltersTierConfigFactory> WithContentFiltersTierConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGuardrailContentPolicyConfigFactory> combinedResult, Action<Humidifier.Bedrock.GuardrailTypes.ContentFiltersTierConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContentFiltersTierConfig(combinedResult.T5, subFactoryAction).T2);
}
