// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerConfigurationSetConditionThresholdFactory(Action<Humidifier.SES.ConfigurationSetTypes.ConditionThreshold> factoryAction = null) : SubResourceFactory<Humidifier.SES.ConfigurationSetTypes.ConditionThreshold>
{

    internal InnerConfigurationSetOverallConfidenceThresholdFactory OverallConfidenceThresholdFactory { get; set; }

    protected override Humidifier.SES.ConfigurationSetTypes.ConditionThreshold Create()
    {
        var conditionThresholdResult = CreateConditionThreshold();
        factoryAction?.Invoke(conditionThresholdResult);

        return conditionThresholdResult;
    }

    private Humidifier.SES.ConfigurationSetTypes.ConditionThreshold CreateConditionThreshold()
    {
        var conditionThresholdResult = new Humidifier.SES.ConfigurationSetTypes.ConditionThreshold();

        return conditionThresholdResult;
    }
    public override void CreateChildren(Humidifier.SES.ConfigurationSetTypes.ConditionThreshold result)
    {
        base.CreateChildren(result);

        result.OverallConfidenceThreshold ??= OverallConfidenceThresholdFactory?.Build();
    }

} // End Of Class

public static class InnerConfigurationSetConditionThresholdFactoryExtensions
{
    public static CombinedResult<InnerConfigurationSetConditionThresholdFactory, InnerConfigurationSetOverallConfidenceThresholdFactory> WithOverallConfidenceThreshold(this InnerConfigurationSetConditionThresholdFactory parentFactory, Action<Humidifier.SES.ConfigurationSetTypes.OverallConfidenceThreshold> subFactoryAction = null)
    {
        parentFactory.OverallConfidenceThresholdFactory = new InnerConfigurationSetOverallConfidenceThresholdFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OverallConfidenceThresholdFactory);
    }

    public static CombinedResult<InnerConfigurationSetConditionThresholdFactory, T1, InnerConfigurationSetOverallConfidenceThresholdFactory> WithOverallConfidenceThreshold<T1>(this CombinedResult<InnerConfigurationSetConditionThresholdFactory, T1> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.OverallConfidenceThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, WithOverallConfidenceThreshold(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfigurationSetConditionThresholdFactory, InnerConfigurationSetOverallConfidenceThresholdFactory> WithOverallConfidenceThreshold<T1>(this CombinedResult<T1, InnerConfigurationSetConditionThresholdFactory> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.OverallConfidenceThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, WithOverallConfidenceThreshold(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConfigurationSetConditionThresholdFactory, T1, T2, InnerConfigurationSetOverallConfidenceThresholdFactory> WithOverallConfidenceThreshold<T1, T2>(this CombinedResult<InnerConfigurationSetConditionThresholdFactory, T1, T2> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.OverallConfidenceThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOverallConfidenceThreshold(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfigurationSetConditionThresholdFactory, T2, InnerConfigurationSetOverallConfidenceThresholdFactory> WithOverallConfidenceThreshold<T1, T2>(this CombinedResult<T1, InnerConfigurationSetConditionThresholdFactory, T2> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.OverallConfidenceThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOverallConfidenceThreshold(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfigurationSetConditionThresholdFactory, InnerConfigurationSetOverallConfidenceThresholdFactory> WithOverallConfidenceThreshold<T1, T2>(this CombinedResult<T1, T2, InnerConfigurationSetConditionThresholdFactory> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.OverallConfidenceThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOverallConfidenceThreshold(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConfigurationSetConditionThresholdFactory, T1, T2, T3, InnerConfigurationSetOverallConfidenceThresholdFactory> WithOverallConfidenceThreshold<T1, T2, T3>(this CombinedResult<InnerConfigurationSetConditionThresholdFactory, T1, T2, T3> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.OverallConfidenceThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverallConfidenceThreshold(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfigurationSetConditionThresholdFactory, T2, T3, InnerConfigurationSetOverallConfidenceThresholdFactory> WithOverallConfidenceThreshold<T1, T2, T3>(this CombinedResult<T1, InnerConfigurationSetConditionThresholdFactory, T2, T3> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.OverallConfidenceThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverallConfidenceThreshold(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfigurationSetConditionThresholdFactory, T3, InnerConfigurationSetOverallConfidenceThresholdFactory> WithOverallConfidenceThreshold<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfigurationSetConditionThresholdFactory, T3> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.OverallConfidenceThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverallConfidenceThreshold(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConfigurationSetConditionThresholdFactory, InnerConfigurationSetOverallConfidenceThresholdFactory> WithOverallConfidenceThreshold<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfigurationSetConditionThresholdFactory> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.OverallConfidenceThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverallConfidenceThreshold(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConfigurationSetConditionThresholdFactory, T1, T2, T3, T4, InnerConfigurationSetOverallConfidenceThresholdFactory> WithOverallConfidenceThreshold<T1, T2, T3, T4>(this CombinedResult<InnerConfigurationSetConditionThresholdFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.OverallConfidenceThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverallConfidenceThreshold(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfigurationSetConditionThresholdFactory, T2, T3, T4, InnerConfigurationSetOverallConfidenceThresholdFactory> WithOverallConfidenceThreshold<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfigurationSetConditionThresholdFactory, T2, T3, T4> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.OverallConfidenceThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverallConfidenceThreshold(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfigurationSetConditionThresholdFactory, T3, T4, InnerConfigurationSetOverallConfidenceThresholdFactory> WithOverallConfidenceThreshold<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfigurationSetConditionThresholdFactory, T3, T4> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.OverallConfidenceThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverallConfidenceThreshold(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConfigurationSetConditionThresholdFactory, T4, InnerConfigurationSetOverallConfidenceThresholdFactory> WithOverallConfidenceThreshold<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfigurationSetConditionThresholdFactory, T4> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.OverallConfidenceThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverallConfidenceThreshold(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConfigurationSetConditionThresholdFactory, InnerConfigurationSetOverallConfidenceThresholdFactory> WithOverallConfidenceThreshold<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfigurationSetConditionThresholdFactory> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.OverallConfidenceThreshold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverallConfidenceThreshold(combinedResult.T5, subFactoryAction).T2);
}
