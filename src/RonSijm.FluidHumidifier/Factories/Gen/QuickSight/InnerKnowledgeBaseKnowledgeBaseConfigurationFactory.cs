// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerKnowledgeBaseKnowledgeBaseConfigurationFactory(Action<Humidifier.QuickSight.KnowledgeBaseTypes.KnowledgeBaseConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.KnowledgeBaseTypes.KnowledgeBaseConfiguration>
{

    internal InnerKnowledgeBaseKbTemplateConfigurationFactory TemplateConfigurationFactory { get; set; }

    protected override Humidifier.QuickSight.KnowledgeBaseTypes.KnowledgeBaseConfiguration Create()
    {
        var knowledgeBaseConfigurationResult = CreateKnowledgeBaseConfiguration();
        factoryAction?.Invoke(knowledgeBaseConfigurationResult);

        return knowledgeBaseConfigurationResult;
    }

    private Humidifier.QuickSight.KnowledgeBaseTypes.KnowledgeBaseConfiguration CreateKnowledgeBaseConfiguration()
    {
        var knowledgeBaseConfigurationResult = new Humidifier.QuickSight.KnowledgeBaseTypes.KnowledgeBaseConfiguration();

        return knowledgeBaseConfigurationResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.KnowledgeBaseTypes.KnowledgeBaseConfiguration result)
    {
        base.CreateChildren(result);

        result.TemplateConfiguration ??= TemplateConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerKnowledgeBaseKnowledgeBaseConfigurationFactoryExtensions
{
    public static CombinedResult<InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, InnerKnowledgeBaseKbTemplateConfigurationFactory> WithTemplateConfiguration(this InnerKnowledgeBaseKnowledgeBaseConfigurationFactory parentFactory, Action<Humidifier.QuickSight.KnowledgeBaseTypes.KbTemplateConfiguration> subFactoryAction = null)
    {
        parentFactory.TemplateConfigurationFactory = new InnerKnowledgeBaseKbTemplateConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TemplateConfigurationFactory);
    }

    public static CombinedResult<InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T1, InnerKnowledgeBaseKbTemplateConfigurationFactory> WithTemplateConfiguration<T1>(this CombinedResult<InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T1> combinedResult, Action<Humidifier.QuickSight.KnowledgeBaseTypes.KbTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, InnerKnowledgeBaseKbTemplateConfigurationFactory> WithTemplateConfiguration<T1>(this CombinedResult<T1, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.KnowledgeBaseTypes.KbTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T1, T2, InnerKnowledgeBaseKbTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2>(this CombinedResult<InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.KnowledgeBaseTypes.KbTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T2, InnerKnowledgeBaseKbTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2>(this CombinedResult<T1, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T2> combinedResult, Action<Humidifier.QuickSight.KnowledgeBaseTypes.KbTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, InnerKnowledgeBaseKbTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.KnowledgeBaseTypes.KbTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T1, T2, T3, InnerKnowledgeBaseKbTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3>(this CombinedResult<InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.KnowledgeBaseTypes.KbTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T2, T3, InnerKnowledgeBaseKbTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.KnowledgeBaseTypes.KbTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T3, InnerKnowledgeBaseKbTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T3> combinedResult, Action<Humidifier.QuickSight.KnowledgeBaseTypes.KbTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, InnerKnowledgeBaseKbTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.KnowledgeBaseTypes.KbTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T1, T2, T3, T4, InnerKnowledgeBaseKbTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.KnowledgeBaseTypes.KbTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T2, T3, T4, InnerKnowledgeBaseKbTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.KnowledgeBaseTypes.KbTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T3, T4, InnerKnowledgeBaseKbTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.KnowledgeBaseTypes.KbTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T4, InnerKnowledgeBaseKbTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T4> combinedResult, Action<Humidifier.QuickSight.KnowledgeBaseTypes.KbTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, InnerKnowledgeBaseKbTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.KnowledgeBaseTypes.KbTemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T5, subFactoryAction).T2);
}
