// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerAIPromptAIPromptTemplateConfigurationFactory(Action<Humidifier.Wisdom.AIPromptTypes.AIPromptTemplateConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.AIPromptTypes.AIPromptTemplateConfiguration>
{

    internal InnerAIPromptTextFullAIPromptEditTemplateConfigurationFactory TextFullAIPromptEditTemplateConfigurationFactory { get; set; }

    protected override Humidifier.Wisdom.AIPromptTypes.AIPromptTemplateConfiguration Create()
    {
        var aIPromptTemplateConfigurationResult = CreateAIPromptTemplateConfiguration();
        factoryAction?.Invoke(aIPromptTemplateConfigurationResult);

        return aIPromptTemplateConfigurationResult;
    }

    private Humidifier.Wisdom.AIPromptTypes.AIPromptTemplateConfiguration CreateAIPromptTemplateConfiguration()
    {
        var aIPromptTemplateConfigurationResult = new Humidifier.Wisdom.AIPromptTypes.AIPromptTemplateConfiguration();

        return aIPromptTemplateConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Wisdom.AIPromptTypes.AIPromptTemplateConfiguration result)
    {
        base.CreateChildren(result);

        result.TextFullAIPromptEditTemplateConfiguration ??= TextFullAIPromptEditTemplateConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerAIPromptAIPromptTemplateConfigurationFactoryExtensions
{
    public static CombinedResult<InnerAIPromptAIPromptTemplateConfigurationFactory, InnerAIPromptTextFullAIPromptEditTemplateConfigurationFactory> WithTextFullAIPromptEditTemplateConfiguration(this InnerAIPromptAIPromptTemplateConfigurationFactory parentFactory, Action<Humidifier.Wisdom.AIPromptTypes.TextFullAIPromptEditTemplateConfiguration> subFactoryAction = null)
    {
        parentFactory.TextFullAIPromptEditTemplateConfigurationFactory = new InnerAIPromptTextFullAIPromptEditTemplateConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TextFullAIPromptEditTemplateConfigurationFactory);
    }

    public static CombinedResult<InnerAIPromptAIPromptTemplateConfigurationFactory, T1, InnerAIPromptTextFullAIPromptEditTemplateConfigurationFactory> WithTextFullAIPromptEditTemplateConfiguration<T1>(this CombinedResult<InnerAIPromptAIPromptTemplateConfigurationFactory, T1> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.TextFullAIPromptEditTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTextFullAIPromptEditTemplateConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAIPromptAIPromptTemplateConfigurationFactory, InnerAIPromptTextFullAIPromptEditTemplateConfigurationFactory> WithTextFullAIPromptEditTemplateConfiguration<T1>(this CombinedResult<T1, InnerAIPromptAIPromptTemplateConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.TextFullAIPromptEditTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTextFullAIPromptEditTemplateConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAIPromptAIPromptTemplateConfigurationFactory, T1, T2, InnerAIPromptTextFullAIPromptEditTemplateConfigurationFactory> WithTextFullAIPromptEditTemplateConfiguration<T1, T2>(this CombinedResult<InnerAIPromptAIPromptTemplateConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.TextFullAIPromptEditTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTextFullAIPromptEditTemplateConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAIPromptAIPromptTemplateConfigurationFactory, T2, InnerAIPromptTextFullAIPromptEditTemplateConfigurationFactory> WithTextFullAIPromptEditTemplateConfiguration<T1, T2>(this CombinedResult<T1, InnerAIPromptAIPromptTemplateConfigurationFactory, T2> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.TextFullAIPromptEditTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTextFullAIPromptEditTemplateConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAIPromptAIPromptTemplateConfigurationFactory, InnerAIPromptTextFullAIPromptEditTemplateConfigurationFactory> WithTextFullAIPromptEditTemplateConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerAIPromptAIPromptTemplateConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.TextFullAIPromptEditTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTextFullAIPromptEditTemplateConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAIPromptAIPromptTemplateConfigurationFactory, T1, T2, T3, InnerAIPromptTextFullAIPromptEditTemplateConfigurationFactory> WithTextFullAIPromptEditTemplateConfiguration<T1, T2, T3>(this CombinedResult<InnerAIPromptAIPromptTemplateConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.TextFullAIPromptEditTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTextFullAIPromptEditTemplateConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAIPromptAIPromptTemplateConfigurationFactory, T2, T3, InnerAIPromptTextFullAIPromptEditTemplateConfigurationFactory> WithTextFullAIPromptEditTemplateConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerAIPromptAIPromptTemplateConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.TextFullAIPromptEditTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTextFullAIPromptEditTemplateConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAIPromptAIPromptTemplateConfigurationFactory, T3, InnerAIPromptTextFullAIPromptEditTemplateConfigurationFactory> WithTextFullAIPromptEditTemplateConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerAIPromptAIPromptTemplateConfigurationFactory, T3> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.TextFullAIPromptEditTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTextFullAIPromptEditTemplateConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAIPromptAIPromptTemplateConfigurationFactory, InnerAIPromptTextFullAIPromptEditTemplateConfigurationFactory> WithTextFullAIPromptEditTemplateConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAIPromptAIPromptTemplateConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.TextFullAIPromptEditTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTextFullAIPromptEditTemplateConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAIPromptAIPromptTemplateConfigurationFactory, T1, T2, T3, T4, InnerAIPromptTextFullAIPromptEditTemplateConfigurationFactory> WithTextFullAIPromptEditTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerAIPromptAIPromptTemplateConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.TextFullAIPromptEditTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTextFullAIPromptEditTemplateConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAIPromptAIPromptTemplateConfigurationFactory, T2, T3, T4, InnerAIPromptTextFullAIPromptEditTemplateConfigurationFactory> WithTextFullAIPromptEditTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerAIPromptAIPromptTemplateConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.TextFullAIPromptEditTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTextFullAIPromptEditTemplateConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAIPromptAIPromptTemplateConfigurationFactory, T3, T4, InnerAIPromptTextFullAIPromptEditTemplateConfigurationFactory> WithTextFullAIPromptEditTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAIPromptAIPromptTemplateConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.TextFullAIPromptEditTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTextFullAIPromptEditTemplateConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAIPromptAIPromptTemplateConfigurationFactory, T4, InnerAIPromptTextFullAIPromptEditTemplateConfigurationFactory> WithTextFullAIPromptEditTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAIPromptAIPromptTemplateConfigurationFactory, T4> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.TextFullAIPromptEditTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTextFullAIPromptEditTemplateConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAIPromptAIPromptTemplateConfigurationFactory, InnerAIPromptTextFullAIPromptEditTemplateConfigurationFactory> WithTextFullAIPromptEditTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAIPromptAIPromptTemplateConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.AIPromptTypes.TextFullAIPromptEditTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTextFullAIPromptEditTemplateConfiguration(combinedResult.T5, subFactoryAction));
}
