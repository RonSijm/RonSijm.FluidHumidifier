// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerConfigurationSetValidationOptionsFactory(Action<Humidifier.SES.ConfigurationSetTypes.ValidationOptions> factoryAction = null) : SubResourceFactory<Humidifier.SES.ConfigurationSetTypes.ValidationOptions>
{

    internal InnerConfigurationSetConditionThresholdFactory ConditionThresholdFactory { get; set; }

    protected override Humidifier.SES.ConfigurationSetTypes.ValidationOptions Create()
    {
        var validationOptionsResult = CreateValidationOptions();
        factoryAction?.Invoke(validationOptionsResult);

        return validationOptionsResult;
    }

    private Humidifier.SES.ConfigurationSetTypes.ValidationOptions CreateValidationOptions()
    {
        var validationOptionsResult = new Humidifier.SES.ConfigurationSetTypes.ValidationOptions();

        return validationOptionsResult;
    }
    public override void CreateChildren(Humidifier.SES.ConfigurationSetTypes.ValidationOptions result)
    {
        base.CreateChildren(result);

        result.ConditionThreshold ??= ConditionThresholdFactory?.Build();
    }

} // End Of Class

public static class InnerConfigurationSetValidationOptionsFactoryExtensions
{
    public static CombinedResult<InnerConfigurationSetValidationOptionsFactory, InnerConfigurationSetConditionThresholdFactory> WithConditionThreshold(this InnerConfigurationSetValidationOptionsFactory parentFactory, Action<Humidifier.SES.ConfigurationSetTypes.ConditionThreshold> subFactoryAction = null)
    {
        parentFactory.ConditionThresholdFactory = new InnerConfigurationSetConditionThresholdFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConditionThresholdFactory);
    }

    public static CombinedResult<InnerConfigurationSetValidationOptionsFactory, T1, InnerConfigurationSetConditionThresholdFactory> WithConditionThreshold<T1>(this CombinedResult<InnerConfigurationSetValidationOptionsFactory, T1> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ConditionThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, WithConditionThreshold(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfigurationSetValidationOptionsFactory, InnerConfigurationSetConditionThresholdFactory> WithConditionThreshold<T1>(this CombinedResult<T1, InnerConfigurationSetValidationOptionsFactory> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ConditionThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, WithConditionThreshold(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConfigurationSetValidationOptionsFactory, T1, T2, InnerConfigurationSetConditionThresholdFactory> WithConditionThreshold<T1, T2>(this CombinedResult<InnerConfigurationSetValidationOptionsFactory, T1, T2> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ConditionThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditionThreshold(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfigurationSetValidationOptionsFactory, T2, InnerConfigurationSetConditionThresholdFactory> WithConditionThreshold<T1, T2>(this CombinedResult<T1, InnerConfigurationSetValidationOptionsFactory, T2> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ConditionThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditionThreshold(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfigurationSetValidationOptionsFactory, InnerConfigurationSetConditionThresholdFactory> WithConditionThreshold<T1, T2>(this CombinedResult<T1, T2, InnerConfigurationSetValidationOptionsFactory> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ConditionThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditionThreshold(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConfigurationSetValidationOptionsFactory, T1, T2, T3, InnerConfigurationSetConditionThresholdFactory> WithConditionThreshold<T1, T2, T3>(this CombinedResult<InnerConfigurationSetValidationOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ConditionThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditionThreshold(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfigurationSetValidationOptionsFactory, T2, T3, InnerConfigurationSetConditionThresholdFactory> WithConditionThreshold<T1, T2, T3>(this CombinedResult<T1, InnerConfigurationSetValidationOptionsFactory, T2, T3> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ConditionThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditionThreshold(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfigurationSetValidationOptionsFactory, T3, InnerConfigurationSetConditionThresholdFactory> WithConditionThreshold<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfigurationSetValidationOptionsFactory, T3> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ConditionThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditionThreshold(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConfigurationSetValidationOptionsFactory, InnerConfigurationSetConditionThresholdFactory> WithConditionThreshold<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfigurationSetValidationOptionsFactory> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ConditionThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditionThreshold(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConfigurationSetValidationOptionsFactory, T1, T2, T3, T4, InnerConfigurationSetConditionThresholdFactory> WithConditionThreshold<T1, T2, T3, T4>(this CombinedResult<InnerConfigurationSetValidationOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ConditionThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditionThreshold(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfigurationSetValidationOptionsFactory, T2, T3, T4, InnerConfigurationSetConditionThresholdFactory> WithConditionThreshold<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfigurationSetValidationOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ConditionThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditionThreshold(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfigurationSetValidationOptionsFactory, T3, T4, InnerConfigurationSetConditionThresholdFactory> WithConditionThreshold<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfigurationSetValidationOptionsFactory, T3, T4> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ConditionThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditionThreshold(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConfigurationSetValidationOptionsFactory, T4, InnerConfigurationSetConditionThresholdFactory> WithConditionThreshold<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfigurationSetValidationOptionsFactory, T4> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ConditionThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditionThreshold(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConfigurationSetValidationOptionsFactory, InnerConfigurationSetConditionThresholdFactory> WithConditionThreshold<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfigurationSetValidationOptionsFactory> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ConditionThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditionThreshold(combinedResult.T5, subFactoryAction).T2);
}
