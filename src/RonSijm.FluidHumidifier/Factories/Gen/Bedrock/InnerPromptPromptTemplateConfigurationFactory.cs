// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerPromptPromptTemplateConfigurationFactory(Action<Humidifier.Bedrock.PromptTypes.PromptTemplateConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.PromptTypes.PromptTemplateConfiguration>
{

    internal InnerPromptTextPromptTemplateConfigurationFactory TextFactory { get; set; }

    protected override Humidifier.Bedrock.PromptTypes.PromptTemplateConfiguration Create()
    {
        var promptTemplateConfigurationResult = CreatePromptTemplateConfiguration();
        factoryAction?.Invoke(promptTemplateConfigurationResult);

        return promptTemplateConfigurationResult;
    }

    private Humidifier.Bedrock.PromptTypes.PromptTemplateConfiguration CreatePromptTemplateConfiguration()
    {
        var promptTemplateConfigurationResult = new Humidifier.Bedrock.PromptTypes.PromptTemplateConfiguration();

        return promptTemplateConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.PromptTypes.PromptTemplateConfiguration result)
    {
        base.CreateChildren(result);

        result.Text ??= TextFactory?.Build();
    }

} // End Of Class

public static class InnerPromptPromptTemplateConfigurationFactoryExtensions
{
    public static CombinedResult<InnerPromptPromptTemplateConfigurationFactory, InnerPromptTextPromptTemplateConfigurationFactory> WithText(this InnerPromptPromptTemplateConfigurationFactory parentFactory, Action<Humidifier.Bedrock.PromptTypes.TextPromptTemplateConfiguration> subFactoryAction = null)
    {
        parentFactory.TextFactory = new InnerPromptTextPromptTemplateConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TextFactory);
    }

    public static CombinedResult<InnerPromptPromptTemplateConfigurationFactory, T1, InnerPromptTextPromptTemplateConfigurationFactory> WithText<T1>(this CombinedResult<InnerPromptPromptTemplateConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithText(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptPromptTemplateConfigurationFactory, InnerPromptTextPromptTemplateConfigurationFactory> WithText<T1>(this CombinedResult<T1, InnerPromptPromptTemplateConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithText(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPromptPromptTemplateConfigurationFactory, T1, T2, InnerPromptTextPromptTemplateConfigurationFactory> WithText<T1, T2>(this CombinedResult<InnerPromptPromptTemplateConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithText(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptPromptTemplateConfigurationFactory, T2, InnerPromptTextPromptTemplateConfigurationFactory> WithText<T1, T2>(this CombinedResult<T1, InnerPromptPromptTemplateConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithText(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPromptPromptTemplateConfigurationFactory, InnerPromptTextPromptTemplateConfigurationFactory> WithText<T1, T2>(this CombinedResult<T1, T2, InnerPromptPromptTemplateConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithText(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPromptPromptTemplateConfigurationFactory, T1, T2, T3, InnerPromptTextPromptTemplateConfigurationFactory> WithText<T1, T2, T3>(this CombinedResult<InnerPromptPromptTemplateConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptPromptTemplateConfigurationFactory, T2, T3, InnerPromptTextPromptTemplateConfigurationFactory> WithText<T1, T2, T3>(this CombinedResult<T1, InnerPromptPromptTemplateConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPromptPromptTemplateConfigurationFactory, T3, InnerPromptTextPromptTemplateConfigurationFactory> WithText<T1, T2, T3>(this CombinedResult<T1, T2, InnerPromptPromptTemplateConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPromptPromptTemplateConfigurationFactory, InnerPromptTextPromptTemplateConfigurationFactory> WithText<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPromptPromptTemplateConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPromptPromptTemplateConfigurationFactory, T1, T2, T3, T4, InnerPromptTextPromptTemplateConfigurationFactory> WithText<T1, T2, T3, T4>(this CombinedResult<InnerPromptPromptTemplateConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptPromptTemplateConfigurationFactory, T2, T3, T4, InnerPromptTextPromptTemplateConfigurationFactory> WithText<T1, T2, T3, T4>(this CombinedResult<T1, InnerPromptPromptTemplateConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPromptPromptTemplateConfigurationFactory, T3, T4, InnerPromptTextPromptTemplateConfigurationFactory> WithText<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPromptPromptTemplateConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPromptPromptTemplateConfigurationFactory, T4, InnerPromptTextPromptTemplateConfigurationFactory> WithText<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPromptPromptTemplateConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPromptPromptTemplateConfigurationFactory, InnerPromptTextPromptTemplateConfigurationFactory> WithText<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPromptPromptTemplateConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithText(combinedResult.T5, subFactoryAction));
}
