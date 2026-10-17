// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class GeneratedTemplateFactory(string resourceName = null, Action<Humidifier.CloudFormation.GeneratedTemplate> factoryAction = null) : ResourceFactory<Humidifier.CloudFormation.GeneratedTemplate>(resourceName)
{

    internal InnerGeneratedTemplateTemplateConfigurationFactory TemplateConfigurationFactory { get; set; }

    protected override Humidifier.CloudFormation.GeneratedTemplate Create()
    {
        var generatedTemplateResult = CreateGeneratedTemplate();
        factoryAction?.Invoke(generatedTemplateResult);

        return generatedTemplateResult;
    }

    private Humidifier.CloudFormation.GeneratedTemplate CreateGeneratedTemplate()
    {
        var generatedTemplateResult = new Humidifier.CloudFormation.GeneratedTemplate
        {
            GivenName = InputResourceName,
        };

        return generatedTemplateResult;
    }
    public override void CreateChildren(Humidifier.CloudFormation.GeneratedTemplate result)
    {
        base.CreateChildren(result);

        result.TemplateConfiguration ??= TemplateConfigurationFactory?.Build();
    }

} // End Of Class

public static class GeneratedTemplateFactoryExtensions
{
    public static CombinedResult<GeneratedTemplateFactory, InnerGeneratedTemplateTemplateConfigurationFactory> WithTemplateConfiguration(this GeneratedTemplateFactory parentFactory, Action<Humidifier.CloudFormation.GeneratedTemplateTypes.TemplateConfiguration> subFactoryAction = null)
    {
        parentFactory.TemplateConfigurationFactory = new InnerGeneratedTemplateTemplateConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TemplateConfigurationFactory);
    }

    public static CombinedResult<GeneratedTemplateFactory, T1, InnerGeneratedTemplateTemplateConfigurationFactory> WithTemplateConfiguration<T1>(this CombinedResult<GeneratedTemplateFactory, T1> combinedResult, Action<Humidifier.CloudFormation.GeneratedTemplateTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GeneratedTemplateFactory, InnerGeneratedTemplateTemplateConfigurationFactory> WithTemplateConfiguration<T1>(this CombinedResult<T1, GeneratedTemplateFactory> combinedResult, Action<Humidifier.CloudFormation.GeneratedTemplateTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<GeneratedTemplateFactory, T1, T2, InnerGeneratedTemplateTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2>(this CombinedResult<GeneratedTemplateFactory, T1, T2> combinedResult, Action<Humidifier.CloudFormation.GeneratedTemplateTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GeneratedTemplateFactory, T2, InnerGeneratedTemplateTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2>(this CombinedResult<T1, GeneratedTemplateFactory, T2> combinedResult, Action<Humidifier.CloudFormation.GeneratedTemplateTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, GeneratedTemplateFactory, InnerGeneratedTemplateTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2>(this CombinedResult<T1, T2, GeneratedTemplateFactory> combinedResult, Action<Humidifier.CloudFormation.GeneratedTemplateTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<GeneratedTemplateFactory, T1, T2, T3, InnerGeneratedTemplateTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3>(this CombinedResult<GeneratedTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFormation.GeneratedTemplateTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GeneratedTemplateFactory, T2, T3, InnerGeneratedTemplateTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3>(this CombinedResult<T1, GeneratedTemplateFactory, T2, T3> combinedResult, Action<Humidifier.CloudFormation.GeneratedTemplateTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, GeneratedTemplateFactory, T3, InnerGeneratedTemplateTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, GeneratedTemplateFactory, T3> combinedResult, Action<Humidifier.CloudFormation.GeneratedTemplateTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, GeneratedTemplateFactory, InnerGeneratedTemplateTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, GeneratedTemplateFactory> combinedResult, Action<Humidifier.CloudFormation.GeneratedTemplateTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<GeneratedTemplateFactory, T1, T2, T3, T4, InnerGeneratedTemplateTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<GeneratedTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.GeneratedTemplateTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GeneratedTemplateFactory, T2, T3, T4, InnerGeneratedTemplateTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, GeneratedTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.GeneratedTemplateTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, GeneratedTemplateFactory, T3, T4, InnerGeneratedTemplateTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, GeneratedTemplateFactory, T3, T4> combinedResult, Action<Humidifier.CloudFormation.GeneratedTemplateTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, GeneratedTemplateFactory, T4, InnerGeneratedTemplateTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GeneratedTemplateFactory, T4> combinedResult, Action<Humidifier.CloudFormation.GeneratedTemplateTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, GeneratedTemplateFactory, InnerGeneratedTemplateTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GeneratedTemplateFactory> combinedResult, Action<Humidifier.CloudFormation.GeneratedTemplateTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T5, subFactoryAction).T2);
}
