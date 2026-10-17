// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDLPSettingProviderConfigFactory(Action<Humidifier.QuickSight.DLPSettingTypes.ProviderConfig> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DLPSettingTypes.ProviderConfig>
{

    internal InnerDLPSettingMicrosoftPurviewProviderConfigFactory MicrosoftPurviewFactory { get; set; }

    protected override Humidifier.QuickSight.DLPSettingTypes.ProviderConfig Create()
    {
        var providerConfigResult = CreateProviderConfig();
        factoryAction?.Invoke(providerConfigResult);

        return providerConfigResult;
    }

    private Humidifier.QuickSight.DLPSettingTypes.ProviderConfig CreateProviderConfig()
    {
        var providerConfigResult = new Humidifier.QuickSight.DLPSettingTypes.ProviderConfig();

        return providerConfigResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DLPSettingTypes.ProviderConfig result)
    {
        base.CreateChildren(result);

        result.MicrosoftPurview ??= MicrosoftPurviewFactory?.Build();
    }

} // End Of Class

public static class InnerDLPSettingProviderConfigFactoryExtensions
{
    public static CombinedResult<InnerDLPSettingProviderConfigFactory, InnerDLPSettingMicrosoftPurviewProviderConfigFactory> WithMicrosoftPurview(this InnerDLPSettingProviderConfigFactory parentFactory, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewProviderConfig> subFactoryAction = null)
    {
        parentFactory.MicrosoftPurviewFactory = new InnerDLPSettingMicrosoftPurviewProviderConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MicrosoftPurviewFactory);
    }

    public static CombinedResult<InnerDLPSettingProviderConfigFactory, T1, InnerDLPSettingMicrosoftPurviewProviderConfigFactory> WithMicrosoftPurview<T1>(this CombinedResult<InnerDLPSettingProviderConfigFactory, T1> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithMicrosoftPurview(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDLPSettingProviderConfigFactory, InnerDLPSettingMicrosoftPurviewProviderConfigFactory> WithMicrosoftPurview<T1>(this CombinedResult<T1, InnerDLPSettingProviderConfigFactory> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithMicrosoftPurview(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDLPSettingProviderConfigFactory, T1, T2, InnerDLPSettingMicrosoftPurviewProviderConfigFactory> WithMicrosoftPurview<T1, T2>(this CombinedResult<InnerDLPSettingProviderConfigFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMicrosoftPurview(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDLPSettingProviderConfigFactory, T2, InnerDLPSettingMicrosoftPurviewProviderConfigFactory> WithMicrosoftPurview<T1, T2>(this CombinedResult<T1, InnerDLPSettingProviderConfigFactory, T2> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMicrosoftPurview(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDLPSettingProviderConfigFactory, InnerDLPSettingMicrosoftPurviewProviderConfigFactory> WithMicrosoftPurview<T1, T2>(this CombinedResult<T1, T2, InnerDLPSettingProviderConfigFactory> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMicrosoftPurview(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDLPSettingProviderConfigFactory, T1, T2, T3, InnerDLPSettingMicrosoftPurviewProviderConfigFactory> WithMicrosoftPurview<T1, T2, T3>(this CombinedResult<InnerDLPSettingProviderConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMicrosoftPurview(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDLPSettingProviderConfigFactory, T2, T3, InnerDLPSettingMicrosoftPurviewProviderConfigFactory> WithMicrosoftPurview<T1, T2, T3>(this CombinedResult<T1, InnerDLPSettingProviderConfigFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMicrosoftPurview(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDLPSettingProviderConfigFactory, T3, InnerDLPSettingMicrosoftPurviewProviderConfigFactory> WithMicrosoftPurview<T1, T2, T3>(this CombinedResult<T1, T2, InnerDLPSettingProviderConfigFactory, T3> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMicrosoftPurview(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDLPSettingProviderConfigFactory, InnerDLPSettingMicrosoftPurviewProviderConfigFactory> WithMicrosoftPurview<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDLPSettingProviderConfigFactory> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMicrosoftPurview(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDLPSettingProviderConfigFactory, T1, T2, T3, T4, InnerDLPSettingMicrosoftPurviewProviderConfigFactory> WithMicrosoftPurview<T1, T2, T3, T4>(this CombinedResult<InnerDLPSettingProviderConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMicrosoftPurview(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDLPSettingProviderConfigFactory, T2, T3, T4, InnerDLPSettingMicrosoftPurviewProviderConfigFactory> WithMicrosoftPurview<T1, T2, T3, T4>(this CombinedResult<T1, InnerDLPSettingProviderConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMicrosoftPurview(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDLPSettingProviderConfigFactory, T3, T4, InnerDLPSettingMicrosoftPurviewProviderConfigFactory> WithMicrosoftPurview<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDLPSettingProviderConfigFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMicrosoftPurview(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDLPSettingProviderConfigFactory, T4, InnerDLPSettingMicrosoftPurviewProviderConfigFactory> WithMicrosoftPurview<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDLPSettingProviderConfigFactory, T4> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMicrosoftPurview(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDLPSettingProviderConfigFactory, InnerDLPSettingMicrosoftPurviewProviderConfigFactory> WithMicrosoftPurview<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDLPSettingProviderConfigFactory> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMicrosoftPurview(combinedResult.T5, subFactoryAction).T2);
}
