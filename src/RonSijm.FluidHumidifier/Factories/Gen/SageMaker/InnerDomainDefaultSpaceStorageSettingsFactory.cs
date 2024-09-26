// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDomainDefaultSpaceStorageSettingsFactory(Action<Humidifier.SageMaker.DomainTypes.DefaultSpaceStorageSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DomainTypes.DefaultSpaceStorageSettings>
{

    internal InnerDomainDefaultEbsStorageSettingsFactory DefaultEbsStorageSettingsFactory { get; set; }

    protected override Humidifier.SageMaker.DomainTypes.DefaultSpaceStorageSettings Create()
    {
        var defaultSpaceStorageSettingsResult = CreateDefaultSpaceStorageSettings();
        factoryAction?.Invoke(defaultSpaceStorageSettingsResult);

        return defaultSpaceStorageSettingsResult;
    }

    private Humidifier.SageMaker.DomainTypes.DefaultSpaceStorageSettings CreateDefaultSpaceStorageSettings()
    {
        var defaultSpaceStorageSettingsResult = new Humidifier.SageMaker.DomainTypes.DefaultSpaceStorageSettings();

        return defaultSpaceStorageSettingsResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.DomainTypes.DefaultSpaceStorageSettings result)
    {
        base.CreateChildren(result);

        result.DefaultEbsStorageSettings ??= DefaultEbsStorageSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerDomainDefaultSpaceStorageSettingsFactoryExtensions
{
    public static CombinedResult<InnerDomainDefaultSpaceStorageSettingsFactory, InnerDomainDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings(this InnerDomainDefaultSpaceStorageSettingsFactory parentFactory, Action<Humidifier.SageMaker.DomainTypes.DefaultEbsStorageSettings> subFactoryAction = null)
    {
        parentFactory.DefaultEbsStorageSettingsFactory = new InnerDomainDefaultEbsStorageSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultEbsStorageSettingsFactory);
    }

    public static CombinedResult<InnerDomainDefaultSpaceStorageSettingsFactory, T1, InnerDomainDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1>(this CombinedResult<InnerDomainDefaultSpaceStorageSettingsFactory, T1> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainDefaultSpaceStorageSettingsFactory, InnerDomainDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1>(this CombinedResult<T1, InnerDomainDefaultSpaceStorageSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDomainDefaultSpaceStorageSettingsFactory, T1, T2, InnerDomainDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1, T2>(this CombinedResult<InnerDomainDefaultSpaceStorageSettingsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainDefaultSpaceStorageSettingsFactory, T2, InnerDomainDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1, T2>(this CombinedResult<T1, InnerDomainDefaultSpaceStorageSettingsFactory, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainDefaultSpaceStorageSettingsFactory, InnerDomainDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1, T2>(this CombinedResult<T1, T2, InnerDomainDefaultSpaceStorageSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDomainDefaultSpaceStorageSettingsFactory, T1, T2, T3, InnerDomainDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1, T2, T3>(this CombinedResult<InnerDomainDefaultSpaceStorageSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainDefaultSpaceStorageSettingsFactory, T2, T3, InnerDomainDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1, T2, T3>(this CombinedResult<T1, InnerDomainDefaultSpaceStorageSettingsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainDefaultSpaceStorageSettingsFactory, T3, InnerDomainDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainDefaultSpaceStorageSettingsFactory, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainDefaultSpaceStorageSettingsFactory, InnerDomainDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainDefaultSpaceStorageSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDomainDefaultSpaceStorageSettingsFactory, T1, T2, T3, T4, InnerDomainDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1, T2, T3, T4>(this CombinedResult<InnerDomainDefaultSpaceStorageSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainDefaultSpaceStorageSettingsFactory, T2, T3, T4, InnerDomainDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainDefaultSpaceStorageSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainDefaultSpaceStorageSettingsFactory, T3, T4, InnerDomainDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainDefaultSpaceStorageSettingsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainDefaultSpaceStorageSettingsFactory, T4, InnerDomainDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainDefaultSpaceStorageSettingsFactory, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDomainDefaultSpaceStorageSettingsFactory, InnerDomainDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainDefaultSpaceStorageSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T5, subFactoryAction));
}
