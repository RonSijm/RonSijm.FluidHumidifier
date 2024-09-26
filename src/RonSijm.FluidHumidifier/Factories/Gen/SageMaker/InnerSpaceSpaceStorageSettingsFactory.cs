// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerSpaceSpaceStorageSettingsFactory(Action<Humidifier.SageMaker.SpaceTypes.SpaceStorageSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.SpaceTypes.SpaceStorageSettings>
{

    internal InnerSpaceEbsStorageSettingsFactory EbsStorageSettingsFactory { get; set; }

    protected override Humidifier.SageMaker.SpaceTypes.SpaceStorageSettings Create()
    {
        var spaceStorageSettingsResult = CreateSpaceStorageSettings();
        factoryAction?.Invoke(spaceStorageSettingsResult);

        return spaceStorageSettingsResult;
    }

    private Humidifier.SageMaker.SpaceTypes.SpaceStorageSettings CreateSpaceStorageSettings()
    {
        var spaceStorageSettingsResult = new Humidifier.SageMaker.SpaceTypes.SpaceStorageSettings();

        return spaceStorageSettingsResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.SpaceTypes.SpaceStorageSettings result)
    {
        base.CreateChildren(result);

        result.EbsStorageSettings ??= EbsStorageSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerSpaceSpaceStorageSettingsFactoryExtensions
{
    public static CombinedResult<InnerSpaceSpaceStorageSettingsFactory, InnerSpaceEbsStorageSettingsFactory> WithEbsStorageSettings(this InnerSpaceSpaceStorageSettingsFactory parentFactory, Action<Humidifier.SageMaker.SpaceTypes.EbsStorageSettings> subFactoryAction = null)
    {
        parentFactory.EbsStorageSettingsFactory = new InnerSpaceEbsStorageSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EbsStorageSettingsFactory);
    }

    public static CombinedResult<InnerSpaceSpaceStorageSettingsFactory, T1, InnerSpaceEbsStorageSettingsFactory> WithEbsStorageSettings<T1>(this CombinedResult<InnerSpaceSpaceStorageSettingsFactory, T1> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.EbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithEbsStorageSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceSpaceStorageSettingsFactory, InnerSpaceEbsStorageSettingsFactory> WithEbsStorageSettings<T1>(this CombinedResult<T1, InnerSpaceSpaceStorageSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.EbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithEbsStorageSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSpaceSpaceStorageSettingsFactory, T1, T2, InnerSpaceEbsStorageSettingsFactory> WithEbsStorageSettings<T1, T2>(this CombinedResult<InnerSpaceSpaceStorageSettingsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.EbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEbsStorageSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceSpaceStorageSettingsFactory, T2, InnerSpaceEbsStorageSettingsFactory> WithEbsStorageSettings<T1, T2>(this CombinedResult<T1, InnerSpaceSpaceStorageSettingsFactory, T2> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.EbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEbsStorageSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpaceSpaceStorageSettingsFactory, InnerSpaceEbsStorageSettingsFactory> WithEbsStorageSettings<T1, T2>(this CombinedResult<T1, T2, InnerSpaceSpaceStorageSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.EbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEbsStorageSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSpaceSpaceStorageSettingsFactory, T1, T2, T3, InnerSpaceEbsStorageSettingsFactory> WithEbsStorageSettings<T1, T2, T3>(this CombinedResult<InnerSpaceSpaceStorageSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.EbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbsStorageSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceSpaceStorageSettingsFactory, T2, T3, InnerSpaceEbsStorageSettingsFactory> WithEbsStorageSettings<T1, T2, T3>(this CombinedResult<T1, InnerSpaceSpaceStorageSettingsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.EbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbsStorageSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpaceSpaceStorageSettingsFactory, T3, InnerSpaceEbsStorageSettingsFactory> WithEbsStorageSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerSpaceSpaceStorageSettingsFactory, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.EbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbsStorageSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSpaceSpaceStorageSettingsFactory, InnerSpaceEbsStorageSettingsFactory> WithEbsStorageSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSpaceSpaceStorageSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.EbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbsStorageSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSpaceSpaceStorageSettingsFactory, T1, T2, T3, T4, InnerSpaceEbsStorageSettingsFactory> WithEbsStorageSettings<T1, T2, T3, T4>(this CombinedResult<InnerSpaceSpaceStorageSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.EbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbsStorageSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceSpaceStorageSettingsFactory, T2, T3, T4, InnerSpaceEbsStorageSettingsFactory> WithEbsStorageSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerSpaceSpaceStorageSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.EbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbsStorageSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpaceSpaceStorageSettingsFactory, T3, T4, InnerSpaceEbsStorageSettingsFactory> WithEbsStorageSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSpaceSpaceStorageSettingsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.EbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbsStorageSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSpaceSpaceStorageSettingsFactory, T4, InnerSpaceEbsStorageSettingsFactory> WithEbsStorageSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSpaceSpaceStorageSettingsFactory, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.EbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbsStorageSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSpaceSpaceStorageSettingsFactory, InnerSpaceEbsStorageSettingsFactory> WithEbsStorageSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSpaceSpaceStorageSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.EbsStorageSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbsStorageSettings(combinedResult.T5, subFactoryAction));
}
