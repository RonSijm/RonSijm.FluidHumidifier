// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class AIPromptFactory(string resourceName = null, Action<Humidifier.Wisdom.AIPrompt> factoryAction = null) : ResourceFactory<Humidifier.Wisdom.AIPrompt>(resourceName)
{

    internal InnerAIPromptAIPromptTemplateConfigurationFactory TemplateConfigurationFactory { get; set; }

    protected override Humidifier.Wisdom.AIPrompt Create()
    {
        var aIPromptResult = CreateAIPrompt();
        factoryAction?.Invoke(aIPromptResult);

        return aIPromptResult;
    }

    private Humidifier.Wisdom.AIPrompt CreateAIPrompt()
    {
        var aIPromptResult = new Humidifier.Wisdom.AIPrompt
        {
            GivenName = InputResourceName,
        };

        return aIPromptResult;
    }
    public override void CreateChildren(Humidifier.Wisdom.AIPrompt result)
    {
        base.CreateChildren(result);

        result.TemplateConfiguration ??= TemplateConfigurationFactory?.Build();
    }

} // End Of Class

public static class AIPromptFactoryExtensions
{
    public static CombinedResult<AIPromptFactory, InnerAIPromptAIPromptTemplateConfigurationFactory> WithTemplateConfiguration(this AIPromptFactory parentFactory, Action<Humidifier.Wisdom.AIPromptTypes.AIPromptTemplateConfiguration> subFactoryAction = null)
    {
        parentFactory.TemplateConfigurationFactory = new InnerAIPromptAIPromptTemplateConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TemplateConfigurationFactory);
    }

    public static CombinedResult<AIPromptFactory, T1, InnerAIPromptAIPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1>(this CombinedResult<AIPromptFactory, T1> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.AIPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AIPromptFactory, InnerAIPromptAIPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1>(this CombinedResult<T1, AIPromptFactory> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.AIPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AIPromptFactory, T1, T2, InnerAIPromptAIPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2>(this CombinedResult<AIPromptFactory, T1, T2> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.AIPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AIPromptFactory, T2, InnerAIPromptAIPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2>(this CombinedResult<T1, AIPromptFactory, T2> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.AIPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AIPromptFactory, InnerAIPromptAIPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2>(this CombinedResult<T1, T2, AIPromptFactory> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.AIPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AIPromptFactory, T1, T2, T3, InnerAIPromptAIPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3>(this CombinedResult<AIPromptFactory, T1, T2, T3> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.AIPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AIPromptFactory, T2, T3, InnerAIPromptAIPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3>(this CombinedResult<T1, AIPromptFactory, T2, T3> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.AIPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AIPromptFactory, T3, InnerAIPromptAIPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, AIPromptFactory, T3> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.AIPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AIPromptFactory, InnerAIPromptAIPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, AIPromptFactory> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.AIPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AIPromptFactory, T1, T2, T3, T4, InnerAIPromptAIPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<AIPromptFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.AIPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AIPromptFactory, T2, T3, T4, InnerAIPromptAIPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, AIPromptFactory, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.AIPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AIPromptFactory, T3, T4, InnerAIPromptAIPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, AIPromptFactory, T3, T4> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.AIPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AIPromptFactory, T4, InnerAIPromptAIPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AIPromptFactory, T4> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.AIPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AIPromptFactory, InnerAIPromptAIPromptTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AIPromptFactory> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.AIPromptTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T5, subFactoryAction));
}
