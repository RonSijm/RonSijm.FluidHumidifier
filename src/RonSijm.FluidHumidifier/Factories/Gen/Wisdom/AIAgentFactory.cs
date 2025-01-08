// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class AIAgentFactory(string resourceName = null, Action<Humidifier.Wisdom.AIAgent> factoryAction = null) : ResourceFactory<Humidifier.Wisdom.AIAgent>(resourceName)
{

    internal InnerAIAgentAIAgentConfigurationFactory ConfigurationFactory { get; set; }

    protected override Humidifier.Wisdom.AIAgent Create()
    {
        var aIAgentResult = CreateAIAgent();
        factoryAction?.Invoke(aIAgentResult);

        return aIAgentResult;
    }

    private Humidifier.Wisdom.AIAgent CreateAIAgent()
    {
        var aIAgentResult = new Humidifier.Wisdom.AIAgent
        {
            GivenName = InputResourceName,
        };

        return aIAgentResult;
    }
    public override void CreateChildren(Humidifier.Wisdom.AIAgent result)
    {
        base.CreateChildren(result);

        result.Configuration ??= ConfigurationFactory?.Build();
    }

} // End Of Class

public static class AIAgentFactoryExtensions
{
    public static CombinedResult<AIAgentFactory, InnerAIAgentAIAgentConfigurationFactory> WithConfiguration(this AIAgentFactory parentFactory, Action<Humidifier.Wisdom.AIAgentTypes.AIAgentConfiguration> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerAIAgentAIAgentConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<AIAgentFactory, T1, InnerAIAgentAIAgentConfigurationFactory> WithConfiguration<T1>(this CombinedResult<AIAgentFactory, T1> combinedResult, Action<Humidifier.Wisdom.AIAgentTypes.AIAgentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AIAgentFactory, InnerAIAgentAIAgentConfigurationFactory> WithConfiguration<T1>(this CombinedResult<T1, AIAgentFactory> combinedResult, Action<Humidifier.Wisdom.AIAgentTypes.AIAgentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AIAgentFactory, T1, T2, InnerAIAgentAIAgentConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<AIAgentFactory, T1, T2> combinedResult, Action<Humidifier.Wisdom.AIAgentTypes.AIAgentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AIAgentFactory, T2, InnerAIAgentAIAgentConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, AIAgentFactory, T2> combinedResult, Action<Humidifier.Wisdom.AIAgentTypes.AIAgentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AIAgentFactory, InnerAIAgentAIAgentConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, AIAgentFactory> combinedResult, Action<Humidifier.Wisdom.AIAgentTypes.AIAgentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AIAgentFactory, T1, T2, T3, InnerAIAgentAIAgentConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<AIAgentFactory, T1, T2, T3> combinedResult, Action<Humidifier.Wisdom.AIAgentTypes.AIAgentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AIAgentFactory, T2, T3, InnerAIAgentAIAgentConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, AIAgentFactory, T2, T3> combinedResult, Action<Humidifier.Wisdom.AIAgentTypes.AIAgentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AIAgentFactory, T3, InnerAIAgentAIAgentConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, AIAgentFactory, T3> combinedResult, Action<Humidifier.Wisdom.AIAgentTypes.AIAgentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AIAgentFactory, InnerAIAgentAIAgentConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, AIAgentFactory> combinedResult, Action<Humidifier.Wisdom.AIAgentTypes.AIAgentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AIAgentFactory, T1, T2, T3, T4, InnerAIAgentAIAgentConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<AIAgentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.AIAgentTypes.AIAgentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AIAgentFactory, T2, T3, T4, InnerAIAgentAIAgentConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, AIAgentFactory, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.AIAgentTypes.AIAgentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AIAgentFactory, T3, T4, InnerAIAgentAIAgentConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, AIAgentFactory, T3, T4> combinedResult, Action<Humidifier.Wisdom.AIAgentTypes.AIAgentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AIAgentFactory, T4, InnerAIAgentAIAgentConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AIAgentFactory, T4> combinedResult, Action<Humidifier.Wisdom.AIAgentTypes.AIAgentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AIAgentFactory, InnerAIAgentAIAgentConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AIAgentFactory> combinedResult, Action<Humidifier.Wisdom.AIAgentTypes.AIAgentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction));
}
