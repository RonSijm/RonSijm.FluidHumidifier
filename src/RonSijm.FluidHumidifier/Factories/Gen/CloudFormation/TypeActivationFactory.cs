// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class TypeActivationFactory(string resourceName = null, Action<Humidifier.CloudFormation.TypeActivation> factoryAction = null) : ResourceFactory<Humidifier.CloudFormation.TypeActivation>(resourceName)
{

    internal InnerTypeActivationLoggingConfigFactory LoggingConfigFactory { get; set; }

    protected override Humidifier.CloudFormation.TypeActivation Create()
    {
        var typeActivationResult = CreateTypeActivation();
        factoryAction?.Invoke(typeActivationResult);

        return typeActivationResult;
    }

    private Humidifier.CloudFormation.TypeActivation CreateTypeActivation()
    {
        var typeActivationResult = new Humidifier.CloudFormation.TypeActivation
        {
            GivenName = InputResourceName,
        };

        return typeActivationResult;
    }
    public override void CreateChildren(Humidifier.CloudFormation.TypeActivation result)
    {
        base.CreateChildren(result);

        result.LoggingConfig ??= LoggingConfigFactory?.Build();
    }

} // End Of Class

public static class TypeActivationFactoryExtensions
{
    public static CombinedResult<TypeActivationFactory, InnerTypeActivationLoggingConfigFactory> WithLoggingConfig(this TypeActivationFactory parentFactory, Action<Humidifier.CloudFormation.TypeActivationTypes.LoggingConfig> subFactoryAction = null)
    {
        parentFactory.LoggingConfigFactory = new InnerTypeActivationLoggingConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LoggingConfigFactory);
    }

    public static CombinedResult<TypeActivationFactory, T1, InnerTypeActivationLoggingConfigFactory> WithLoggingConfig<T1>(this CombinedResult<TypeActivationFactory, T1> combinedResult, Action<Humidifier.CloudFormation.TypeActivationTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TypeActivationFactory, InnerTypeActivationLoggingConfigFactory> WithLoggingConfig<T1>(this CombinedResult<T1, TypeActivationFactory> combinedResult, Action<Humidifier.CloudFormation.TypeActivationTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TypeActivationFactory, T1, T2, InnerTypeActivationLoggingConfigFactory> WithLoggingConfig<T1, T2>(this CombinedResult<TypeActivationFactory, T1, T2> combinedResult, Action<Humidifier.CloudFormation.TypeActivationTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TypeActivationFactory, T2, InnerTypeActivationLoggingConfigFactory> WithLoggingConfig<T1, T2>(this CombinedResult<T1, TypeActivationFactory, T2> combinedResult, Action<Humidifier.CloudFormation.TypeActivationTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TypeActivationFactory, InnerTypeActivationLoggingConfigFactory> WithLoggingConfig<T1, T2>(this CombinedResult<T1, T2, TypeActivationFactory> combinedResult, Action<Humidifier.CloudFormation.TypeActivationTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TypeActivationFactory, T1, T2, T3, InnerTypeActivationLoggingConfigFactory> WithLoggingConfig<T1, T2, T3>(this CombinedResult<TypeActivationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFormation.TypeActivationTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TypeActivationFactory, T2, T3, InnerTypeActivationLoggingConfigFactory> WithLoggingConfig<T1, T2, T3>(this CombinedResult<T1, TypeActivationFactory, T2, T3> combinedResult, Action<Humidifier.CloudFormation.TypeActivationTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TypeActivationFactory, T3, InnerTypeActivationLoggingConfigFactory> WithLoggingConfig<T1, T2, T3>(this CombinedResult<T1, T2, TypeActivationFactory, T3> combinedResult, Action<Humidifier.CloudFormation.TypeActivationTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TypeActivationFactory, InnerTypeActivationLoggingConfigFactory> WithLoggingConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, TypeActivationFactory> combinedResult, Action<Humidifier.CloudFormation.TypeActivationTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TypeActivationFactory, T1, T2, T3, T4, InnerTypeActivationLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<TypeActivationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.TypeActivationTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TypeActivationFactory, T2, T3, T4, InnerTypeActivationLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<T1, TypeActivationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.TypeActivationTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TypeActivationFactory, T3, T4, InnerTypeActivationLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, TypeActivationFactory, T3, T4> combinedResult, Action<Humidifier.CloudFormation.TypeActivationTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TypeActivationFactory, T4, InnerTypeActivationLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TypeActivationFactory, T4> combinedResult, Action<Humidifier.CloudFormation.TypeActivationTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TypeActivationFactory, InnerTypeActivationLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TypeActivationFactory> combinedResult, Action<Humidifier.CloudFormation.TypeActivationTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T5, subFactoryAction));
}
