// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDLPSettingMicrosoftPurviewProviderConfigFactory(Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewProviderConfig> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewProviderConfig>
{

    internal InnerDLPSettingMicrosoftPurviewCredentialsFactory CredentialsFactory { get; set; }

    protected override Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewProviderConfig Create()
    {
        var microsoftPurviewProviderConfigResult = CreateMicrosoftPurviewProviderConfig();
        factoryAction?.Invoke(microsoftPurviewProviderConfigResult);

        return microsoftPurviewProviderConfigResult;
    }

    private Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewProviderConfig CreateMicrosoftPurviewProviderConfig()
    {
        var microsoftPurviewProviderConfigResult = new Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewProviderConfig();

        return microsoftPurviewProviderConfigResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewProviderConfig result)
    {
        base.CreateChildren(result);

        result.Credentials ??= CredentialsFactory?.Build();
    }

} // End Of Class

public static class InnerDLPSettingMicrosoftPurviewProviderConfigFactoryExtensions
{
    public static CombinedResult<InnerDLPSettingMicrosoftPurviewProviderConfigFactory, InnerDLPSettingMicrosoftPurviewCredentialsFactory> WithCredentials(this InnerDLPSettingMicrosoftPurviewProviderConfigFactory parentFactory, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewCredentials> subFactoryAction = null)
    {
        parentFactory.CredentialsFactory = new InnerDLPSettingMicrosoftPurviewCredentialsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CredentialsFactory);
    }

    public static CombinedResult<InnerDLPSettingMicrosoftPurviewProviderConfigFactory, T1, InnerDLPSettingMicrosoftPurviewCredentialsFactory> WithCredentials<T1>(this CombinedResult<InnerDLPSettingMicrosoftPurviewProviderConfigFactory, T1> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, WithCredentials(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDLPSettingMicrosoftPurviewProviderConfigFactory, InnerDLPSettingMicrosoftPurviewCredentialsFactory> WithCredentials<T1>(this CombinedResult<T1, InnerDLPSettingMicrosoftPurviewProviderConfigFactory> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, WithCredentials(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDLPSettingMicrosoftPurviewProviderConfigFactory, T1, T2, InnerDLPSettingMicrosoftPurviewCredentialsFactory> WithCredentials<T1, T2>(this CombinedResult<InnerDLPSettingMicrosoftPurviewProviderConfigFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDLPSettingMicrosoftPurviewProviderConfigFactory, T2, InnerDLPSettingMicrosoftPurviewCredentialsFactory> WithCredentials<T1, T2>(this CombinedResult<T1, InnerDLPSettingMicrosoftPurviewProviderConfigFactory, T2> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDLPSettingMicrosoftPurviewProviderConfigFactory, InnerDLPSettingMicrosoftPurviewCredentialsFactory> WithCredentials<T1, T2>(this CombinedResult<T1, T2, InnerDLPSettingMicrosoftPurviewProviderConfigFactory> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDLPSettingMicrosoftPurviewProviderConfigFactory, T1, T2, T3, InnerDLPSettingMicrosoftPurviewCredentialsFactory> WithCredentials<T1, T2, T3>(this CombinedResult<InnerDLPSettingMicrosoftPurviewProviderConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDLPSettingMicrosoftPurviewProviderConfigFactory, T2, T3, InnerDLPSettingMicrosoftPurviewCredentialsFactory> WithCredentials<T1, T2, T3>(this CombinedResult<T1, InnerDLPSettingMicrosoftPurviewProviderConfigFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDLPSettingMicrosoftPurviewProviderConfigFactory, T3, InnerDLPSettingMicrosoftPurviewCredentialsFactory> WithCredentials<T1, T2, T3>(this CombinedResult<T1, T2, InnerDLPSettingMicrosoftPurviewProviderConfigFactory, T3> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDLPSettingMicrosoftPurviewProviderConfigFactory, InnerDLPSettingMicrosoftPurviewCredentialsFactory> WithCredentials<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDLPSettingMicrosoftPurviewProviderConfigFactory> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDLPSettingMicrosoftPurviewProviderConfigFactory, T1, T2, T3, T4, InnerDLPSettingMicrosoftPurviewCredentialsFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<InnerDLPSettingMicrosoftPurviewProviderConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDLPSettingMicrosoftPurviewProviderConfigFactory, T2, T3, T4, InnerDLPSettingMicrosoftPurviewCredentialsFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<T1, InnerDLPSettingMicrosoftPurviewProviderConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDLPSettingMicrosoftPurviewProviderConfigFactory, T3, T4, InnerDLPSettingMicrosoftPurviewCredentialsFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDLPSettingMicrosoftPurviewProviderConfigFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDLPSettingMicrosoftPurviewProviderConfigFactory, T4, InnerDLPSettingMicrosoftPurviewCredentialsFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDLPSettingMicrosoftPurviewProviderConfigFactory, T4> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDLPSettingMicrosoftPurviewProviderConfigFactory, InnerDLPSettingMicrosoftPurviewCredentialsFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDLPSettingMicrosoftPurviewProviderConfigFactory> combinedResult, Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T5, subFactoryAction).T2);
}
