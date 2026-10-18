// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class DLPSettingFactory(string resourceName = null, Action<Humidifier.QuickSight.DLPSetting> factoryAction = null) : ResourceFactory<Humidifier.QuickSight.DLPSetting>(resourceName)
{

    internal InnerDLPSettingProviderConfigFactory ProviderConfigFactory { get; set; }

    protected override Humidifier.QuickSight.DLPSetting Create()
    {
        var dLPSettingResult = CreateDLPSetting();
        factoryAction?.Invoke(dLPSettingResult);

        return dLPSettingResult;
    }

    private Humidifier.QuickSight.DLPSetting CreateDLPSetting()
    {
        var dLPSettingResult = new Humidifier.QuickSight.DLPSetting
        {
            GivenName = InputResourceName,
        };

        return dLPSettingResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DLPSetting result)
    {
        base.CreateChildren(result);

        result.ProviderConfig ??= ProviderConfigFactory?.Build();
    }

} // End Of Class

public static class DLPSettingFactoryExtensions
{
    public static CombinedResult<DLPSettingFactory, InnerDLPSettingProviderConfigFactory> WithProviderConfig(this DLPSettingFactory parentFactory, Action<Humidifier.QuickSight.DLPSettingTypes.ProviderConfig> subFactoryAction = null)
    {
        parentFactory.ProviderConfigFactory = new InnerDLPSettingProviderConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProviderConfigFactory);
    }

    public static CombinedResult<DLPSettingFactory, T1, InnerDLPSettingProviderConfigFactory> WithProviderConfig<T1>(this CombinedResult<DLPSettingFactory, T1> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.ProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithProviderConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DLPSettingFactory, InnerDLPSettingProviderConfigFactory> WithProviderConfig<T1>(this CombinedResult<T1, DLPSettingFactory> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.ProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithProviderConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DLPSettingFactory, T1, T2, InnerDLPSettingProviderConfigFactory> WithProviderConfig<T1, T2>(this CombinedResult<DLPSettingFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.ProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProviderConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DLPSettingFactory, T2, InnerDLPSettingProviderConfigFactory> WithProviderConfig<T1, T2>(this CombinedResult<T1, DLPSettingFactory, T2> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.ProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProviderConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DLPSettingFactory, InnerDLPSettingProviderConfigFactory> WithProviderConfig<T1, T2>(this CombinedResult<T1, T2, DLPSettingFactory> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.ProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProviderConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DLPSettingFactory, T1, T2, T3, InnerDLPSettingProviderConfigFactory> WithProviderConfig<T1, T2, T3>(this CombinedResult<DLPSettingFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.ProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DLPSettingFactory, T2, T3, InnerDLPSettingProviderConfigFactory> WithProviderConfig<T1, T2, T3>(this CombinedResult<T1, DLPSettingFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.ProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DLPSettingFactory, T3, InnerDLPSettingProviderConfigFactory> WithProviderConfig<T1, T2, T3>(this CombinedResult<T1, T2, DLPSettingFactory, T3> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.ProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DLPSettingFactory, InnerDLPSettingProviderConfigFactory> WithProviderConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, DLPSettingFactory> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.ProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DLPSettingFactory, T1, T2, T3, T4, InnerDLPSettingProviderConfigFactory> WithProviderConfig<T1, T2, T3, T4>(this CombinedResult<DLPSettingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.ProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DLPSettingFactory, T2, T3, T4, InnerDLPSettingProviderConfigFactory> WithProviderConfig<T1, T2, T3, T4>(this CombinedResult<T1, DLPSettingFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.ProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DLPSettingFactory, T3, T4, InnerDLPSettingProviderConfigFactory> WithProviderConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, DLPSettingFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.ProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DLPSettingFactory, T4, InnerDLPSettingProviderConfigFactory> WithProviderConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DLPSettingFactory, T4> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.ProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DLPSettingFactory, InnerDLPSettingProviderConfigFactory> WithProviderConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DLPSettingFactory> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.ProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfig(combinedResult.T5, subFactoryAction).T2);
}
