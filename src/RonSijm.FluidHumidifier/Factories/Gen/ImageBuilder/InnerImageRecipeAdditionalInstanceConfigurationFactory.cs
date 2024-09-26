// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerImageRecipeAdditionalInstanceConfigurationFactory(Action<Humidifier.ImageBuilder.ImageRecipeTypes.AdditionalInstanceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.ImageRecipeTypes.AdditionalInstanceConfiguration>
{

    internal InnerImageRecipeSystemsManagerAgentFactory SystemsManagerAgentFactory { get; set; }

    protected override Humidifier.ImageBuilder.ImageRecipeTypes.AdditionalInstanceConfiguration Create()
    {
        var additionalInstanceConfigurationResult = CreateAdditionalInstanceConfiguration();
        factoryAction?.Invoke(additionalInstanceConfigurationResult);

        return additionalInstanceConfigurationResult;
    }

    private Humidifier.ImageBuilder.ImageRecipeTypes.AdditionalInstanceConfiguration CreateAdditionalInstanceConfiguration()
    {
        var additionalInstanceConfigurationResult = new Humidifier.ImageBuilder.ImageRecipeTypes.AdditionalInstanceConfiguration();

        return additionalInstanceConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ImageBuilder.ImageRecipeTypes.AdditionalInstanceConfiguration result)
    {
        base.CreateChildren(result);

        result.SystemsManagerAgent ??= SystemsManagerAgentFactory?.Build();
    }

} // End Of Class

public static class InnerImageRecipeAdditionalInstanceConfigurationFactoryExtensions
{
    public static CombinedResult<InnerImageRecipeAdditionalInstanceConfigurationFactory, InnerImageRecipeSystemsManagerAgentFactory> WithSystemsManagerAgent(this InnerImageRecipeAdditionalInstanceConfigurationFactory parentFactory, Action<Humidifier.ImageBuilder.ImageRecipeTypes.SystemsManagerAgent> subFactoryAction = null)
    {
        parentFactory.SystemsManagerAgentFactory = new InnerImageRecipeSystemsManagerAgentFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SystemsManagerAgentFactory);
    }

    public static CombinedResult<InnerImageRecipeAdditionalInstanceConfigurationFactory, T1, InnerImageRecipeSystemsManagerAgentFactory> WithSystemsManagerAgent<T1>(this CombinedResult<InnerImageRecipeAdditionalInstanceConfigurationFactory, T1> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.SystemsManagerAgent> subFactoryAction = null) => new (combinedResult, combinedResult, WithSystemsManagerAgent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerImageRecipeAdditionalInstanceConfigurationFactory, InnerImageRecipeSystemsManagerAgentFactory> WithSystemsManagerAgent<T1>(this CombinedResult<T1, InnerImageRecipeAdditionalInstanceConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.SystemsManagerAgent> subFactoryAction = null) => new (combinedResult, combinedResult, WithSystemsManagerAgent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerImageRecipeAdditionalInstanceConfigurationFactory, T1, T2, InnerImageRecipeSystemsManagerAgentFactory> WithSystemsManagerAgent<T1, T2>(this CombinedResult<InnerImageRecipeAdditionalInstanceConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.SystemsManagerAgent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSystemsManagerAgent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerImageRecipeAdditionalInstanceConfigurationFactory, T2, InnerImageRecipeSystemsManagerAgentFactory> WithSystemsManagerAgent<T1, T2>(this CombinedResult<T1, InnerImageRecipeAdditionalInstanceConfigurationFactory, T2> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.SystemsManagerAgent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSystemsManagerAgent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerImageRecipeAdditionalInstanceConfigurationFactory, InnerImageRecipeSystemsManagerAgentFactory> WithSystemsManagerAgent<T1, T2>(this CombinedResult<T1, T2, InnerImageRecipeAdditionalInstanceConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.SystemsManagerAgent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSystemsManagerAgent(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerImageRecipeAdditionalInstanceConfigurationFactory, T1, T2, T3, InnerImageRecipeSystemsManagerAgentFactory> WithSystemsManagerAgent<T1, T2, T3>(this CombinedResult<InnerImageRecipeAdditionalInstanceConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.SystemsManagerAgent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSystemsManagerAgent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerImageRecipeAdditionalInstanceConfigurationFactory, T2, T3, InnerImageRecipeSystemsManagerAgentFactory> WithSystemsManagerAgent<T1, T2, T3>(this CombinedResult<T1, InnerImageRecipeAdditionalInstanceConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.SystemsManagerAgent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSystemsManagerAgent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerImageRecipeAdditionalInstanceConfigurationFactory, T3, InnerImageRecipeSystemsManagerAgentFactory> WithSystemsManagerAgent<T1, T2, T3>(this CombinedResult<T1, T2, InnerImageRecipeAdditionalInstanceConfigurationFactory, T3> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.SystemsManagerAgent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSystemsManagerAgent(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerImageRecipeAdditionalInstanceConfigurationFactory, InnerImageRecipeSystemsManagerAgentFactory> WithSystemsManagerAgent<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerImageRecipeAdditionalInstanceConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.SystemsManagerAgent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSystemsManagerAgent(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerImageRecipeAdditionalInstanceConfigurationFactory, T1, T2, T3, T4, InnerImageRecipeSystemsManagerAgentFactory> WithSystemsManagerAgent<T1, T2, T3, T4>(this CombinedResult<InnerImageRecipeAdditionalInstanceConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.SystemsManagerAgent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSystemsManagerAgent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerImageRecipeAdditionalInstanceConfigurationFactory, T2, T3, T4, InnerImageRecipeSystemsManagerAgentFactory> WithSystemsManagerAgent<T1, T2, T3, T4>(this CombinedResult<T1, InnerImageRecipeAdditionalInstanceConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.SystemsManagerAgent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSystemsManagerAgent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerImageRecipeAdditionalInstanceConfigurationFactory, T3, T4, InnerImageRecipeSystemsManagerAgentFactory> WithSystemsManagerAgent<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerImageRecipeAdditionalInstanceConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.SystemsManagerAgent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSystemsManagerAgent(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerImageRecipeAdditionalInstanceConfigurationFactory, T4, InnerImageRecipeSystemsManagerAgentFactory> WithSystemsManagerAgent<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerImageRecipeAdditionalInstanceConfigurationFactory, T4> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.SystemsManagerAgent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSystemsManagerAgent(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerImageRecipeAdditionalInstanceConfigurationFactory, InnerImageRecipeSystemsManagerAgentFactory> WithSystemsManagerAgent<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerImageRecipeAdditionalInstanceConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.ImageRecipeTypes.SystemsManagerAgent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSystemsManagerAgent(combinedResult.T5, subFactoryAction));
}
