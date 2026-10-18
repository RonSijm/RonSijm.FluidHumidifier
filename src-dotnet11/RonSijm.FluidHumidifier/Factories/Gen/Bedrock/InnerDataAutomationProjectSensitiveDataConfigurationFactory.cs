// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationProjectSensitiveDataConfigurationFactory(Action<Humidifier.Bedrock.DataAutomationProjectTypes.SensitiveDataConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationProjectTypes.SensitiveDataConfiguration>
{

    internal InnerDataAutomationProjectPIIEntitiesConfigurationFactory PiiEntitiesConfigurationFactory { get; set; }

    protected override Humidifier.Bedrock.DataAutomationProjectTypes.SensitiveDataConfiguration Create()
    {
        var sensitiveDataConfigurationResult = CreateSensitiveDataConfiguration();
        factoryAction?.Invoke(sensitiveDataConfigurationResult);

        return sensitiveDataConfigurationResult;
    }

    private Humidifier.Bedrock.DataAutomationProjectTypes.SensitiveDataConfiguration CreateSensitiveDataConfiguration()
    {
        var sensitiveDataConfigurationResult = new Humidifier.Bedrock.DataAutomationProjectTypes.SensitiveDataConfiguration();

        return sensitiveDataConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.DataAutomationProjectTypes.SensitiveDataConfiguration result)
    {
        base.CreateChildren(result);

        result.PiiEntitiesConfiguration ??= PiiEntitiesConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDataAutomationProjectSensitiveDataConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataAutomationProjectSensitiveDataConfigurationFactory, InnerDataAutomationProjectPIIEntitiesConfigurationFactory> WithPiiEntitiesConfiguration(this InnerDataAutomationProjectSensitiveDataConfigurationFactory parentFactory, Action<Humidifier.Bedrock.DataAutomationProjectTypes.PIIEntitiesConfiguration> subFactoryAction = null)
    {
        parentFactory.PiiEntitiesConfigurationFactory = new InnerDataAutomationProjectPIIEntitiesConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PiiEntitiesConfigurationFactory);
    }

    public static CombinedResult<InnerDataAutomationProjectSensitiveDataConfigurationFactory, T1, InnerDataAutomationProjectPIIEntitiesConfigurationFactory> WithPiiEntitiesConfiguration<T1>(this CombinedResult<InnerDataAutomationProjectSensitiveDataConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.PIIEntitiesConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPiiEntitiesConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataAutomationProjectSensitiveDataConfigurationFactory, InnerDataAutomationProjectPIIEntitiesConfigurationFactory> WithPiiEntitiesConfiguration<T1>(this CombinedResult<T1, InnerDataAutomationProjectSensitiveDataConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.PIIEntitiesConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPiiEntitiesConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataAutomationProjectSensitiveDataConfigurationFactory, T1, T2, InnerDataAutomationProjectPIIEntitiesConfigurationFactory> WithPiiEntitiesConfiguration<T1, T2>(this CombinedResult<InnerDataAutomationProjectSensitiveDataConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.PIIEntitiesConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPiiEntitiesConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataAutomationProjectSensitiveDataConfigurationFactory, T2, InnerDataAutomationProjectPIIEntitiesConfigurationFactory> WithPiiEntitiesConfiguration<T1, T2>(this CombinedResult<T1, InnerDataAutomationProjectSensitiveDataConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.PIIEntitiesConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPiiEntitiesConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataAutomationProjectSensitiveDataConfigurationFactory, InnerDataAutomationProjectPIIEntitiesConfigurationFactory> WithPiiEntitiesConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDataAutomationProjectSensitiveDataConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.PIIEntitiesConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPiiEntitiesConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataAutomationProjectSensitiveDataConfigurationFactory, T1, T2, T3, InnerDataAutomationProjectPIIEntitiesConfigurationFactory> WithPiiEntitiesConfiguration<T1, T2, T3>(this CombinedResult<InnerDataAutomationProjectSensitiveDataConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.PIIEntitiesConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPiiEntitiesConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataAutomationProjectSensitiveDataConfigurationFactory, T2, T3, InnerDataAutomationProjectPIIEntitiesConfigurationFactory> WithPiiEntitiesConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDataAutomationProjectSensitiveDataConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.PIIEntitiesConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPiiEntitiesConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataAutomationProjectSensitiveDataConfigurationFactory, T3, InnerDataAutomationProjectPIIEntitiesConfigurationFactory> WithPiiEntitiesConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataAutomationProjectSensitiveDataConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.PIIEntitiesConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPiiEntitiesConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataAutomationProjectSensitiveDataConfigurationFactory, InnerDataAutomationProjectPIIEntitiesConfigurationFactory> WithPiiEntitiesConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataAutomationProjectSensitiveDataConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.PIIEntitiesConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPiiEntitiesConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataAutomationProjectSensitiveDataConfigurationFactory, T1, T2, T3, T4, InnerDataAutomationProjectPIIEntitiesConfigurationFactory> WithPiiEntitiesConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDataAutomationProjectSensitiveDataConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.PIIEntitiesConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPiiEntitiesConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataAutomationProjectSensitiveDataConfigurationFactory, T2, T3, T4, InnerDataAutomationProjectPIIEntitiesConfigurationFactory> WithPiiEntitiesConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataAutomationProjectSensitiveDataConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.PIIEntitiesConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPiiEntitiesConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataAutomationProjectSensitiveDataConfigurationFactory, T3, T4, InnerDataAutomationProjectPIIEntitiesConfigurationFactory> WithPiiEntitiesConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataAutomationProjectSensitiveDataConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.PIIEntitiesConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPiiEntitiesConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataAutomationProjectSensitiveDataConfigurationFactory, T4, InnerDataAutomationProjectPIIEntitiesConfigurationFactory> WithPiiEntitiesConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataAutomationProjectSensitiveDataConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.PIIEntitiesConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPiiEntitiesConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataAutomationProjectSensitiveDataConfigurationFactory, InnerDataAutomationProjectPIIEntitiesConfigurationFactory> WithPiiEntitiesConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataAutomationProjectSensitiveDataConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataAutomationProjectTypes.PIIEntitiesConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPiiEntitiesConfiguration(combinedResult.T5, subFactoryAction).T2);
}
