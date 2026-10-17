// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerConfigurationSetSuppressionOptionsFactory(Action<Humidifier.SES.ConfigurationSetTypes.SuppressionOptions> factoryAction = null) : SubResourceFactory<Humidifier.SES.ConfigurationSetTypes.SuppressionOptions>
{

    internal InnerConfigurationSetValidationOptionsFactory ValidationOptionsFactory { get; set; }

    protected override Humidifier.SES.ConfigurationSetTypes.SuppressionOptions Create()
    {
        var suppressionOptionsResult = CreateSuppressionOptions();
        factoryAction?.Invoke(suppressionOptionsResult);

        return suppressionOptionsResult;
    }

    private Humidifier.SES.ConfigurationSetTypes.SuppressionOptions CreateSuppressionOptions()
    {
        var suppressionOptionsResult = new Humidifier.SES.ConfigurationSetTypes.SuppressionOptions();

        return suppressionOptionsResult;
    }
    public override void CreateChildren(Humidifier.SES.ConfigurationSetTypes.SuppressionOptions result)
    {
        base.CreateChildren(result);

        result.ValidationOptions ??= ValidationOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerConfigurationSetSuppressionOptionsFactoryExtensions
{
    public static CombinedResult<InnerConfigurationSetSuppressionOptionsFactory, InnerConfigurationSetValidationOptionsFactory> WithValidationOptions(this InnerConfigurationSetSuppressionOptionsFactory parentFactory, Action<Humidifier.SES.ConfigurationSetTypes.ValidationOptions> subFactoryAction = null)
    {
        parentFactory.ValidationOptionsFactory = new InnerConfigurationSetValidationOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ValidationOptionsFactory);
    }

    public static CombinedResult<InnerConfigurationSetSuppressionOptionsFactory, T1, InnerConfigurationSetValidationOptionsFactory> WithValidationOptions<T1>(this CombinedResult<InnerConfigurationSetSuppressionOptionsFactory, T1> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithValidationOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfigurationSetSuppressionOptionsFactory, InnerConfigurationSetValidationOptionsFactory> WithValidationOptions<T1>(this CombinedResult<T1, InnerConfigurationSetSuppressionOptionsFactory> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithValidationOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConfigurationSetSuppressionOptionsFactory, T1, T2, InnerConfigurationSetValidationOptionsFactory> WithValidationOptions<T1, T2>(this CombinedResult<InnerConfigurationSetSuppressionOptionsFactory, T1, T2> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidationOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfigurationSetSuppressionOptionsFactory, T2, InnerConfigurationSetValidationOptionsFactory> WithValidationOptions<T1, T2>(this CombinedResult<T1, InnerConfigurationSetSuppressionOptionsFactory, T2> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidationOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfigurationSetSuppressionOptionsFactory, InnerConfigurationSetValidationOptionsFactory> WithValidationOptions<T1, T2>(this CombinedResult<T1, T2, InnerConfigurationSetSuppressionOptionsFactory> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidationOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConfigurationSetSuppressionOptionsFactory, T1, T2, T3, InnerConfigurationSetValidationOptionsFactory> WithValidationOptions<T1, T2, T3>(this CombinedResult<InnerConfigurationSetSuppressionOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidationOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfigurationSetSuppressionOptionsFactory, T2, T3, InnerConfigurationSetValidationOptionsFactory> WithValidationOptions<T1, T2, T3>(this CombinedResult<T1, InnerConfigurationSetSuppressionOptionsFactory, T2, T3> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidationOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfigurationSetSuppressionOptionsFactory, T3, InnerConfigurationSetValidationOptionsFactory> WithValidationOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfigurationSetSuppressionOptionsFactory, T3> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidationOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConfigurationSetSuppressionOptionsFactory, InnerConfigurationSetValidationOptionsFactory> WithValidationOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfigurationSetSuppressionOptionsFactory> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidationOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConfigurationSetSuppressionOptionsFactory, T1, T2, T3, T4, InnerConfigurationSetValidationOptionsFactory> WithValidationOptions<T1, T2, T3, T4>(this CombinedResult<InnerConfigurationSetSuppressionOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidationOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfigurationSetSuppressionOptionsFactory, T2, T3, T4, InnerConfigurationSetValidationOptionsFactory> WithValidationOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfigurationSetSuppressionOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidationOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfigurationSetSuppressionOptionsFactory, T3, T4, InnerConfigurationSetValidationOptionsFactory> WithValidationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfigurationSetSuppressionOptionsFactory, T3, T4> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidationOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConfigurationSetSuppressionOptionsFactory, T4, InnerConfigurationSetValidationOptionsFactory> WithValidationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfigurationSetSuppressionOptionsFactory, T4> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidationOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConfigurationSetSuppressionOptionsFactory, InnerConfigurationSetValidationOptionsFactory> WithValidationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfigurationSetSuppressionOptionsFactory> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.ValidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidationOptions(combinedResult.T5, subFactoryAction).T2);
}
