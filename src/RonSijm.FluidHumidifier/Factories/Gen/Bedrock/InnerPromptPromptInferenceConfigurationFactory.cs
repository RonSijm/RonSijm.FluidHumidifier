// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerPromptPromptInferenceConfigurationFactory(Action<Humidifier.Bedrock.PromptTypes.PromptInferenceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.PromptTypes.PromptInferenceConfiguration>
{

    internal InnerPromptPromptModelInferenceConfigurationFactory TextFactory { get; set; }

    protected override Humidifier.Bedrock.PromptTypes.PromptInferenceConfiguration Create()
    {
        var promptInferenceConfigurationResult = CreatePromptInferenceConfiguration();
        factoryAction?.Invoke(promptInferenceConfigurationResult);

        return promptInferenceConfigurationResult;
    }

    private Humidifier.Bedrock.PromptTypes.PromptInferenceConfiguration CreatePromptInferenceConfiguration()
    {
        var promptInferenceConfigurationResult = new Humidifier.Bedrock.PromptTypes.PromptInferenceConfiguration();

        return promptInferenceConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.PromptTypes.PromptInferenceConfiguration result)
    {
        base.CreateChildren(result);

        result.Text ??= TextFactory?.Build();
    }

} // End Of Class

public static class InnerPromptPromptInferenceConfigurationFactoryExtensions
{
    public static CombinedResult<InnerPromptPromptInferenceConfigurationFactory, InnerPromptPromptModelInferenceConfigurationFactory> WithText(this InnerPromptPromptInferenceConfigurationFactory parentFactory, Action<Humidifier.Bedrock.PromptTypes.PromptModelInferenceConfiguration> subFactoryAction = null)
    {
        parentFactory.TextFactory = new InnerPromptPromptModelInferenceConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TextFactory);
    }

    public static CombinedResult<InnerPromptPromptInferenceConfigurationFactory, T1, InnerPromptPromptModelInferenceConfigurationFactory> WithText<T1>(this CombinedResult<InnerPromptPromptInferenceConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptModelInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithText(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptPromptInferenceConfigurationFactory, InnerPromptPromptModelInferenceConfigurationFactory> WithText<T1>(this CombinedResult<T1, InnerPromptPromptInferenceConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptModelInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithText(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPromptPromptInferenceConfigurationFactory, T1, T2, InnerPromptPromptModelInferenceConfigurationFactory> WithText<T1, T2>(this CombinedResult<InnerPromptPromptInferenceConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptModelInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithText(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptPromptInferenceConfigurationFactory, T2, InnerPromptPromptModelInferenceConfigurationFactory> WithText<T1, T2>(this CombinedResult<T1, InnerPromptPromptInferenceConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptModelInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithText(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPromptPromptInferenceConfigurationFactory, InnerPromptPromptModelInferenceConfigurationFactory> WithText<T1, T2>(this CombinedResult<T1, T2, InnerPromptPromptInferenceConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptModelInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithText(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPromptPromptInferenceConfigurationFactory, T1, T2, T3, InnerPromptPromptModelInferenceConfigurationFactory> WithText<T1, T2, T3>(this CombinedResult<InnerPromptPromptInferenceConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptModelInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptPromptInferenceConfigurationFactory, T2, T3, InnerPromptPromptModelInferenceConfigurationFactory> WithText<T1, T2, T3>(this CombinedResult<T1, InnerPromptPromptInferenceConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptModelInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPromptPromptInferenceConfigurationFactory, T3, InnerPromptPromptModelInferenceConfigurationFactory> WithText<T1, T2, T3>(this CombinedResult<T1, T2, InnerPromptPromptInferenceConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptModelInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPromptPromptInferenceConfigurationFactory, InnerPromptPromptModelInferenceConfigurationFactory> WithText<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPromptPromptInferenceConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptModelInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPromptPromptInferenceConfigurationFactory, T1, T2, T3, T4, InnerPromptPromptModelInferenceConfigurationFactory> WithText<T1, T2, T3, T4>(this CombinedResult<InnerPromptPromptInferenceConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptModelInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptPromptInferenceConfigurationFactory, T2, T3, T4, InnerPromptPromptModelInferenceConfigurationFactory> WithText<T1, T2, T3, T4>(this CombinedResult<T1, InnerPromptPromptInferenceConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptModelInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPromptPromptInferenceConfigurationFactory, T3, T4, InnerPromptPromptModelInferenceConfigurationFactory> WithText<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPromptPromptInferenceConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptModelInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPromptPromptInferenceConfigurationFactory, T4, InnerPromptPromptModelInferenceConfigurationFactory> WithText<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPromptPromptInferenceConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptModelInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPromptPromptInferenceConfigurationFactory, InnerPromptPromptModelInferenceConfigurationFactory> WithText<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPromptPromptInferenceConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptModelInferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T5, subFactoryAction));
}
