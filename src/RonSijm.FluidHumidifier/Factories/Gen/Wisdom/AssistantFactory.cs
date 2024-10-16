// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class AssistantFactory(string resourceName = null, Action<Humidifier.Wisdom.Assistant> factoryAction = null) : ResourceFactory<Humidifier.Wisdom.Assistant>(resourceName)
{

    internal InnerAssistantServerSideEncryptionConfigurationFactory ServerSideEncryptionConfigurationFactory { get; set; }

    protected override Humidifier.Wisdom.Assistant Create()
    {
        var assistantResult = CreateAssistant();
        factoryAction?.Invoke(assistantResult);

        return assistantResult;
    }

    private Humidifier.Wisdom.Assistant CreateAssistant()
    {
        var assistantResult = new Humidifier.Wisdom.Assistant
        {
            GivenName = InputResourceName,
        };

        return assistantResult;
    }
    public override void CreateChildren(Humidifier.Wisdom.Assistant result)
    {
        base.CreateChildren(result);

        result.ServerSideEncryptionConfiguration ??= ServerSideEncryptionConfigurationFactory?.Build();
    }

} // End Of Class

public static class AssistantFactoryExtensions
{
    public static CombinedResult<AssistantFactory, InnerAssistantServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration(this AssistantFactory parentFactory, Action<Humidifier.Wisdom.AssistantTypes.ServerSideEncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.ServerSideEncryptionConfigurationFactory = new InnerAssistantServerSideEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ServerSideEncryptionConfigurationFactory);
    }

    public static CombinedResult<AssistantFactory, T1, InnerAssistantServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1>(this CombinedResult<AssistantFactory, T1> combinedResult, Action<Humidifier.Wisdom.AssistantTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssistantFactory, InnerAssistantServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1>(this CombinedResult<T1, AssistantFactory> combinedResult, Action<Humidifier.Wisdom.AssistantTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AssistantFactory, T1, T2, InnerAssistantServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2>(this CombinedResult<AssistantFactory, T1, T2> combinedResult, Action<Humidifier.Wisdom.AssistantTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssistantFactory, T2, InnerAssistantServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2>(this CombinedResult<T1, AssistantFactory, T2> combinedResult, Action<Humidifier.Wisdom.AssistantTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AssistantFactory, InnerAssistantServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2>(this CombinedResult<T1, T2, AssistantFactory> combinedResult, Action<Humidifier.Wisdom.AssistantTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AssistantFactory, T1, T2, T3, InnerAssistantServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3>(this CombinedResult<AssistantFactory, T1, T2, T3> combinedResult, Action<Humidifier.Wisdom.AssistantTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssistantFactory, T2, T3, InnerAssistantServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, AssistantFactory, T2, T3> combinedResult, Action<Humidifier.Wisdom.AssistantTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AssistantFactory, T3, InnerAssistantServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, AssistantFactory, T3> combinedResult, Action<Humidifier.Wisdom.AssistantTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AssistantFactory, InnerAssistantServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, AssistantFactory> combinedResult, Action<Humidifier.Wisdom.AssistantTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AssistantFactory, T1, T2, T3, T4, InnerAssistantServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<AssistantFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.AssistantTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssistantFactory, T2, T3, T4, InnerAssistantServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, AssistantFactory, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.AssistantTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AssistantFactory, T3, T4, InnerAssistantServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, AssistantFactory, T3, T4> combinedResult, Action<Humidifier.Wisdom.AssistantTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AssistantFactory, T4, InnerAssistantServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AssistantFactory, T4> combinedResult, Action<Humidifier.Wisdom.AssistantTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AssistantFactory, InnerAssistantServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AssistantFactory> combinedResult, Action<Humidifier.Wisdom.AssistantTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T5, subFactoryAction));
}
