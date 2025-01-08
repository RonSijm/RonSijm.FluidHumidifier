// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerPromptChatPromptTemplateConfigurationFactory(Action<Humidifier.Bedrock.PromptTypes.ChatPromptTemplateConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.PromptTypes.ChatPromptTemplateConfiguration>
{

    internal InnerPromptToolConfigurationFactory ToolConfigurationFactory { get; set; }

    protected override Humidifier.Bedrock.PromptTypes.ChatPromptTemplateConfiguration Create()
    {
        var chatPromptTemplateConfigurationResult = CreateChatPromptTemplateConfiguration();
        factoryAction?.Invoke(chatPromptTemplateConfigurationResult);

        return chatPromptTemplateConfigurationResult;
    }

    private Humidifier.Bedrock.PromptTypes.ChatPromptTemplateConfiguration CreateChatPromptTemplateConfiguration()
    {
        var chatPromptTemplateConfigurationResult = new Humidifier.Bedrock.PromptTypes.ChatPromptTemplateConfiguration();

        return chatPromptTemplateConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.PromptTypes.ChatPromptTemplateConfiguration result)
    {
        base.CreateChildren(result);

        result.ToolConfiguration ??= ToolConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerPromptChatPromptTemplateConfigurationFactoryExtensions
{
    public static CombinedResult<InnerPromptChatPromptTemplateConfigurationFactory, InnerPromptToolConfigurationFactory> WithToolConfiguration(this InnerPromptChatPromptTemplateConfigurationFactory parentFactory, Action<Humidifier.Bedrock.PromptTypes.ToolConfiguration> subFactoryAction = null)
    {
        parentFactory.ToolConfigurationFactory = new InnerPromptToolConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ToolConfigurationFactory);
    }

    public static CombinedResult<InnerPromptChatPromptTemplateConfigurationFactory, T1, InnerPromptToolConfigurationFactory> WithToolConfiguration<T1>(this CombinedResult<InnerPromptChatPromptTemplateConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithToolConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptChatPromptTemplateConfigurationFactory, InnerPromptToolConfigurationFactory> WithToolConfiguration<T1>(this CombinedResult<T1, InnerPromptChatPromptTemplateConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithToolConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPromptChatPromptTemplateConfigurationFactory, T1, T2, InnerPromptToolConfigurationFactory> WithToolConfiguration<T1, T2>(this CombinedResult<InnerPromptChatPromptTemplateConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithToolConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptChatPromptTemplateConfigurationFactory, T2, InnerPromptToolConfigurationFactory> WithToolConfiguration<T1, T2>(this CombinedResult<T1, InnerPromptChatPromptTemplateConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithToolConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPromptChatPromptTemplateConfigurationFactory, InnerPromptToolConfigurationFactory> WithToolConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerPromptChatPromptTemplateConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithToolConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPromptChatPromptTemplateConfigurationFactory, T1, T2, T3, InnerPromptToolConfigurationFactory> WithToolConfiguration<T1, T2, T3>(this CombinedResult<InnerPromptChatPromptTemplateConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithToolConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptChatPromptTemplateConfigurationFactory, T2, T3, InnerPromptToolConfigurationFactory> WithToolConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerPromptChatPromptTemplateConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithToolConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPromptChatPromptTemplateConfigurationFactory, T3, InnerPromptToolConfigurationFactory> WithToolConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerPromptChatPromptTemplateConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithToolConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPromptChatPromptTemplateConfigurationFactory, InnerPromptToolConfigurationFactory> WithToolConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPromptChatPromptTemplateConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithToolConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPromptChatPromptTemplateConfigurationFactory, T1, T2, T3, T4, InnerPromptToolConfigurationFactory> WithToolConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerPromptChatPromptTemplateConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithToolConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptChatPromptTemplateConfigurationFactory, T2, T3, T4, InnerPromptToolConfigurationFactory> WithToolConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerPromptChatPromptTemplateConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithToolConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPromptChatPromptTemplateConfigurationFactory, T3, T4, InnerPromptToolConfigurationFactory> WithToolConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPromptChatPromptTemplateConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithToolConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPromptChatPromptTemplateConfigurationFactory, T4, InnerPromptToolConfigurationFactory> WithToolConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPromptChatPromptTemplateConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithToolConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPromptChatPromptTemplateConfigurationFactory, InnerPromptToolConfigurationFactory> WithToolConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPromptChatPromptTemplateConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithToolConfiguration(combinedResult.T5, subFactoryAction));
}
