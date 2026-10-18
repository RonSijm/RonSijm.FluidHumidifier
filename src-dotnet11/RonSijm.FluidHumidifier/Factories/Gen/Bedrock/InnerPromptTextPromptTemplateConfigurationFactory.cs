// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerPromptTextPromptTemplateConfigurationFactory(Action<Humidifier.Bedrock.PromptTypes.TextPromptTemplateConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.PromptTypes.TextPromptTemplateConfiguration>
{

    internal InnerPromptTextS3LocationFactory TextS3LocationFactory { get; set; }

    internal InnerPromptCachePointBlockFactory CachePointFactory { get; set; }

    protected override Humidifier.Bedrock.PromptTypes.TextPromptTemplateConfiguration Create()
    {
        var textPromptTemplateConfigurationResult = CreateTextPromptTemplateConfiguration();
        factoryAction?.Invoke(textPromptTemplateConfigurationResult);

        return textPromptTemplateConfigurationResult;
    }

    private Humidifier.Bedrock.PromptTypes.TextPromptTemplateConfiguration CreateTextPromptTemplateConfiguration()
    {
        var textPromptTemplateConfigurationResult = new Humidifier.Bedrock.PromptTypes.TextPromptTemplateConfiguration();

        return textPromptTemplateConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.PromptTypes.TextPromptTemplateConfiguration result)
    {
        base.CreateChildren(result);

        result.TextS3Location ??= TextS3LocationFactory?.Build();
        result.CachePoint ??= CachePointFactory?.Build();
    }

} // End Of Class

public static class InnerPromptTextPromptTemplateConfigurationFactoryExtensions
{
    public static CombinedResult<InnerPromptTextPromptTemplateConfigurationFactory, InnerPromptTextS3LocationFactory> WithTextS3Location(this InnerPromptTextPromptTemplateConfigurationFactory parentFactory, Action<Humidifier.Bedrock.PromptTypes.TextS3Location> subFactoryAction = null)
    {
        parentFactory.TextS3LocationFactory = new InnerPromptTextS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TextS3LocationFactory);
    }

    public static CombinedResult<InnerPromptTextPromptTemplateConfigurationFactory, InnerPromptCachePointBlockFactory> WithCachePoint(this InnerPromptTextPromptTemplateConfigurationFactory parentFactory, Action<Humidifier.Bedrock.PromptTypes.CachePointBlock> subFactoryAction = null)
    {
        parentFactory.CachePointFactory = new InnerPromptCachePointBlockFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CachePointFactory);
    }

    public static CombinedResult<InnerPromptTextPromptTemplateConfigurationFactory, T1, InnerPromptTextS3LocationFactory> WithTextS3Location<T1>(this CombinedResult<InnerPromptTextPromptTemplateConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithTextS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPromptTextPromptTemplateConfigurationFactory, InnerPromptTextS3LocationFactory> WithTextS3Location<T1>(this CombinedResult<T1, InnerPromptTextPromptTemplateConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithTextS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerPromptTextPromptTemplateConfigurationFactory, T1, T2, InnerPromptTextS3LocationFactory> WithTextS3Location<T1, T2>(this CombinedResult<InnerPromptTextPromptTemplateConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTextS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPromptTextPromptTemplateConfigurationFactory, T2, InnerPromptTextS3LocationFactory> WithTextS3Location<T1, T2>(this CombinedResult<T1, InnerPromptTextPromptTemplateConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTextS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPromptTextPromptTemplateConfigurationFactory, InnerPromptTextS3LocationFactory> WithTextS3Location<T1, T2>(this CombinedResult<T1, T2, InnerPromptTextPromptTemplateConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTextS3Location(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerPromptTextPromptTemplateConfigurationFactory, T1, T2, T3, InnerPromptTextS3LocationFactory> WithTextS3Location<T1, T2, T3>(this CombinedResult<InnerPromptTextPromptTemplateConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTextS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPromptTextPromptTemplateConfigurationFactory, T2, T3, InnerPromptTextS3LocationFactory> WithTextS3Location<T1, T2, T3>(this CombinedResult<T1, InnerPromptTextPromptTemplateConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTextS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPromptTextPromptTemplateConfigurationFactory, T3, InnerPromptTextS3LocationFactory> WithTextS3Location<T1, T2, T3>(this CombinedResult<T1, T2, InnerPromptTextPromptTemplateConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTextS3Location(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPromptTextPromptTemplateConfigurationFactory, InnerPromptTextS3LocationFactory> WithTextS3Location<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPromptTextPromptTemplateConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTextS3Location(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerPromptTextPromptTemplateConfigurationFactory, T1, T2, T3, T4, InnerPromptTextS3LocationFactory> WithTextS3Location<T1, T2, T3, T4>(this CombinedResult<InnerPromptTextPromptTemplateConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTextS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPromptTextPromptTemplateConfigurationFactory, T2, T3, T4, InnerPromptTextS3LocationFactory> WithTextS3Location<T1, T2, T3, T4>(this CombinedResult<T1, InnerPromptTextPromptTemplateConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTextS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPromptTextPromptTemplateConfigurationFactory, T3, T4, InnerPromptTextS3LocationFactory> WithTextS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPromptTextPromptTemplateConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTextS3Location(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPromptTextPromptTemplateConfigurationFactory, T4, InnerPromptTextS3LocationFactory> WithTextS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPromptTextPromptTemplateConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTextS3Location(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerPromptTextPromptTemplateConfigurationFactory, InnerPromptTextS3LocationFactory> WithTextS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPromptTextPromptTemplateConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.TextS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTextS3Location(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerPromptTextPromptTemplateConfigurationFactory, T1, InnerPromptCachePointBlockFactory> WithCachePoint<T1>(this CombinedResult<InnerPromptTextPromptTemplateConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.PromptTypes.CachePointBlock> subFactoryAction = null) => new (combinedResult, combinedResult, WithCachePoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPromptTextPromptTemplateConfigurationFactory, InnerPromptCachePointBlockFactory> WithCachePoint<T1>(this CombinedResult<T1, InnerPromptTextPromptTemplateConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.CachePointBlock> subFactoryAction = null) => new (combinedResult, combinedResult, WithCachePoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerPromptTextPromptTemplateConfigurationFactory, T1, T2, InnerPromptCachePointBlockFactory> WithCachePoint<T1, T2>(this CombinedResult<InnerPromptTextPromptTemplateConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.PromptTypes.CachePointBlock> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCachePoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPromptTextPromptTemplateConfigurationFactory, T2, InnerPromptCachePointBlockFactory> WithCachePoint<T1, T2>(this CombinedResult<T1, InnerPromptTextPromptTemplateConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.PromptTypes.CachePointBlock> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCachePoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPromptTextPromptTemplateConfigurationFactory, InnerPromptCachePointBlockFactory> WithCachePoint<T1, T2>(this CombinedResult<T1, T2, InnerPromptTextPromptTemplateConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.CachePointBlock> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCachePoint(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerPromptTextPromptTemplateConfigurationFactory, T1, T2, T3, InnerPromptCachePointBlockFactory> WithCachePoint<T1, T2, T3>(this CombinedResult<InnerPromptTextPromptTemplateConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.CachePointBlock> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCachePoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPromptTextPromptTemplateConfigurationFactory, T2, T3, InnerPromptCachePointBlockFactory> WithCachePoint<T1, T2, T3>(this CombinedResult<T1, InnerPromptTextPromptTemplateConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.CachePointBlock> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCachePoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPromptTextPromptTemplateConfigurationFactory, T3, InnerPromptCachePointBlockFactory> WithCachePoint<T1, T2, T3>(this CombinedResult<T1, T2, InnerPromptTextPromptTemplateConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.CachePointBlock> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCachePoint(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPromptTextPromptTemplateConfigurationFactory, InnerPromptCachePointBlockFactory> WithCachePoint<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPromptTextPromptTemplateConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.CachePointBlock> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCachePoint(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerPromptTextPromptTemplateConfigurationFactory, T1, T2, T3, T4, InnerPromptCachePointBlockFactory> WithCachePoint<T1, T2, T3, T4>(this CombinedResult<InnerPromptTextPromptTemplateConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.CachePointBlock> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCachePoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPromptTextPromptTemplateConfigurationFactory, T2, T3, T4, InnerPromptCachePointBlockFactory> WithCachePoint<T1, T2, T3, T4>(this CombinedResult<T1, InnerPromptTextPromptTemplateConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.CachePointBlock> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCachePoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPromptTextPromptTemplateConfigurationFactory, T3, T4, InnerPromptCachePointBlockFactory> WithCachePoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPromptTextPromptTemplateConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.CachePointBlock> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCachePoint(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPromptTextPromptTemplateConfigurationFactory, T4, InnerPromptCachePointBlockFactory> WithCachePoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPromptTextPromptTemplateConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.CachePointBlock> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCachePoint(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerPromptTextPromptTemplateConfigurationFactory, InnerPromptCachePointBlockFactory> WithCachePoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPromptTextPromptTemplateConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.CachePointBlock> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCachePoint(combinedResult.T5, subFactoryAction).T2);
}
