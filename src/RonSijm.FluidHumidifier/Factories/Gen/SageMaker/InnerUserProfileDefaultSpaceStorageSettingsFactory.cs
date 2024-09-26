// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerUserProfileDefaultSpaceStorageSettingsFactory(Action<Humidifier.SageMaker.UserProfileTypes.DefaultSpaceStorageSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.UserProfileTypes.DefaultSpaceStorageSettings>
{

    internal InnerUserProfileDefaultEbsStorageSettingsFactory DefaultEbsStorageSettingsFactory { get; set; }

    protected override Humidifier.SageMaker.UserProfileTypes.DefaultSpaceStorageSettings Create()
    {
        var defaultSpaceStorageSettingsResult = CreateDefaultSpaceStorageSettings();
        factoryAction?.Invoke(defaultSpaceStorageSettingsResult);

        return defaultSpaceStorageSettingsResult;
    }

    private Humidifier.SageMaker.UserProfileTypes.DefaultSpaceStorageSettings CreateDefaultSpaceStorageSettings()
    {
        var defaultSpaceStorageSettingsResult = new Humidifier.SageMaker.UserProfileTypes.DefaultSpaceStorageSettings();

        return defaultSpaceStorageSettingsResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.UserProfileTypes.DefaultSpaceStorageSettings result)
    {
        base.CreateChildren(result);

        result.DefaultEbsStorageSettings ??= DefaultEbsStorageSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerUserProfileDefaultSpaceStorageSettingsFactoryExtensions
{
    public static CombinedResult<InnerUserProfileDefaultSpaceStorageSettingsFactory, InnerUserProfileDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings(this InnerUserProfileDefaultSpaceStorageSettingsFactory parentFactory, Action<Humidifier.SageMaker.UserProfileTypes.DefaultEbsStorageSettings> subFactoryAction = null)
    {
        parentFactory.DefaultEbsStorageSettingsFactory = new InnerUserProfileDefaultEbsStorageSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultEbsStorageSettingsFactory);
    }

    public static CombinedResult<InnerUserProfileDefaultSpaceStorageSettingsFactory, T1, InnerUserProfileDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1>(this CombinedResult<InnerUserProfileDefaultSpaceStorageSettingsFactory, T1> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserProfileDefaultSpaceStorageSettingsFactory, InnerUserProfileDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1>(this CombinedResult<T1, InnerUserProfileDefaultSpaceStorageSettingsFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerUserProfileDefaultSpaceStorageSettingsFactory, T1, T2, InnerUserProfileDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1, T2>(this CombinedResult<InnerUserProfileDefaultSpaceStorageSettingsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserProfileDefaultSpaceStorageSettingsFactory, T2, InnerUserProfileDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1, T2>(this CombinedResult<T1, InnerUserProfileDefaultSpaceStorageSettingsFactory, T2> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserProfileDefaultSpaceStorageSettingsFactory, InnerUserProfileDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1, T2>(this CombinedResult<T1, T2, InnerUserProfileDefaultSpaceStorageSettingsFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerUserProfileDefaultSpaceStorageSettingsFactory, T1, T2, T3, InnerUserProfileDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1, T2, T3>(this CombinedResult<InnerUserProfileDefaultSpaceStorageSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserProfileDefaultSpaceStorageSettingsFactory, T2, T3, InnerUserProfileDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1, T2, T3>(this CombinedResult<T1, InnerUserProfileDefaultSpaceStorageSettingsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserProfileDefaultSpaceStorageSettingsFactory, T3, InnerUserProfileDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerUserProfileDefaultSpaceStorageSettingsFactory, T3> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerUserProfileDefaultSpaceStorageSettingsFactory, InnerUserProfileDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerUserProfileDefaultSpaceStorageSettingsFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerUserProfileDefaultSpaceStorageSettingsFactory, T1, T2, T3, T4, InnerUserProfileDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1, T2, T3, T4>(this CombinedResult<InnerUserProfileDefaultSpaceStorageSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserProfileDefaultSpaceStorageSettingsFactory, T2, T3, T4, InnerUserProfileDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerUserProfileDefaultSpaceStorageSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserProfileDefaultSpaceStorageSettingsFactory, T3, T4, InnerUserProfileDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerUserProfileDefaultSpaceStorageSettingsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerUserProfileDefaultSpaceStorageSettingsFactory, T4, InnerUserProfileDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerUserProfileDefaultSpaceStorageSettingsFactory, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerUserProfileDefaultSpaceStorageSettingsFactory, InnerUserProfileDefaultEbsStorageSettingsFactory> WithDefaultEbsStorageSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerUserProfileDefaultSpaceStorageSettingsFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.DefaultEbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEbsStorageSettings(combinedResult.T5, subFactoryAction));
}
