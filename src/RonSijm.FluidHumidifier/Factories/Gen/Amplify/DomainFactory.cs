// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Amplify;

public class DomainFactory(string resourceName = null, Action<Humidifier.Amplify.Domain> factoryAction = null) : ResourceFactory<Humidifier.Amplify.Domain>(resourceName)
{

    internal List<InnerDomainSubDomainSettingFactory> SubDomainSettingsFactories { get; set; } = [];

    internal InnerDomainCertificateSettingsFactory CertificateSettingsFactory { get; set; }

    protected override Humidifier.Amplify.Domain Create()
    {
        var domainResult = CreateDomain();
        factoryAction?.Invoke(domainResult);

        return domainResult;
    }

    private Humidifier.Amplify.Domain CreateDomain()
    {
        var domainResult = new Humidifier.Amplify.Domain
        {
            GivenName = InputResourceName,
        };

        return domainResult;
    }
    public override void CreateChildren(Humidifier.Amplify.Domain result)
    {
        base.CreateChildren(result);

        result.SubDomainSettings = SubDomainSettingsFactories.Any() ? SubDomainSettingsFactories.Select(x => x.Build()).ToList() : null;
        result.CertificateSettings ??= CertificateSettingsFactory?.Build();
    }

} // End Of Class

public static class DomainFactoryExtensions
{
    public static CombinedResult<DomainFactory, InnerDomainSubDomainSettingFactory> WithSubDomainSettings(this DomainFactory parentFactory, Action<Humidifier.Amplify.DomainTypes.SubDomainSetting> subFactoryAction = null)
    {
        var factory = new InnerDomainSubDomainSettingFactory(subFactoryAction);
        parentFactory.SubDomainSettingsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DomainFactory, InnerDomainCertificateSettingsFactory> WithCertificateSettings(this DomainFactory parentFactory, Action<Humidifier.Amplify.DomainTypes.CertificateSettings> subFactoryAction = null)
    {
        parentFactory.CertificateSettingsFactory = new InnerDomainCertificateSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CertificateSettingsFactory);
    }

    public static CombinedResult<DomainFactory, T1, InnerDomainSubDomainSettingFactory> WithSubDomainSettings<T1>(this CombinedResult<DomainFactory, T1> combinedResult, Action<Humidifier.Amplify.DomainTypes.SubDomainSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubDomainSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, InnerDomainSubDomainSettingFactory> WithSubDomainSettings<T1>(this CombinedResult<T1, DomainFactory> combinedResult, Action<Humidifier.Amplify.DomainTypes.SubDomainSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubDomainSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, InnerDomainSubDomainSettingFactory> WithSubDomainSettings<T1, T2>(this CombinedResult<DomainFactory, T1, T2> combinedResult, Action<Humidifier.Amplify.DomainTypes.SubDomainSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubDomainSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, InnerDomainSubDomainSettingFactory> WithSubDomainSettings<T1, T2>(this CombinedResult<T1, DomainFactory, T2> combinedResult, Action<Humidifier.Amplify.DomainTypes.SubDomainSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubDomainSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, InnerDomainSubDomainSettingFactory> WithSubDomainSettings<T1, T2>(this CombinedResult<T1, T2, DomainFactory> combinedResult, Action<Humidifier.Amplify.DomainTypes.SubDomainSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubDomainSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, T3, InnerDomainSubDomainSettingFactory> WithSubDomainSettings<T1, T2, T3>(this CombinedResult<DomainFactory, T1, T2, T3> combinedResult, Action<Humidifier.Amplify.DomainTypes.SubDomainSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubDomainSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, T3, InnerDomainSubDomainSettingFactory> WithSubDomainSettings<T1, T2, T3>(this CombinedResult<T1, DomainFactory, T2, T3> combinedResult, Action<Humidifier.Amplify.DomainTypes.SubDomainSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubDomainSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, T3, InnerDomainSubDomainSettingFactory> WithSubDomainSettings<T1, T2, T3>(this CombinedResult<T1, T2, DomainFactory, T3> combinedResult, Action<Humidifier.Amplify.DomainTypes.SubDomainSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubDomainSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainFactory, InnerDomainSubDomainSettingFactory> WithSubDomainSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, DomainFactory> combinedResult, Action<Humidifier.Amplify.DomainTypes.SubDomainSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubDomainSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, T3, T4, InnerDomainSubDomainSettingFactory> WithSubDomainSettings<T1, T2, T3, T4>(this CombinedResult<DomainFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Amplify.DomainTypes.SubDomainSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubDomainSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, T3, T4, InnerDomainSubDomainSettingFactory> WithSubDomainSettings<T1, T2, T3, T4>(this CombinedResult<T1, DomainFactory, T2, T3, T4> combinedResult, Action<Humidifier.Amplify.DomainTypes.SubDomainSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubDomainSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, T3, T4, InnerDomainSubDomainSettingFactory> WithSubDomainSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, DomainFactory, T3, T4> combinedResult, Action<Humidifier.Amplify.DomainTypes.SubDomainSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubDomainSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainFactory, T4, InnerDomainSubDomainSettingFactory> WithSubDomainSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DomainFactory, T4> combinedResult, Action<Humidifier.Amplify.DomainTypes.SubDomainSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubDomainSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DomainFactory, InnerDomainSubDomainSettingFactory> WithSubDomainSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DomainFactory> combinedResult, Action<Humidifier.Amplify.DomainTypes.SubDomainSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubDomainSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, InnerDomainCertificateSettingsFactory> WithCertificateSettings<T1>(this CombinedResult<DomainFactory, T1> combinedResult, Action<Humidifier.Amplify.DomainTypes.CertificateSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithCertificateSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, InnerDomainCertificateSettingsFactory> WithCertificateSettings<T1>(this CombinedResult<T1, DomainFactory> combinedResult, Action<Humidifier.Amplify.DomainTypes.CertificateSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithCertificateSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, InnerDomainCertificateSettingsFactory> WithCertificateSettings<T1, T2>(this CombinedResult<DomainFactory, T1, T2> combinedResult, Action<Humidifier.Amplify.DomainTypes.CertificateSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificateSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, InnerDomainCertificateSettingsFactory> WithCertificateSettings<T1, T2>(this CombinedResult<T1, DomainFactory, T2> combinedResult, Action<Humidifier.Amplify.DomainTypes.CertificateSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificateSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, InnerDomainCertificateSettingsFactory> WithCertificateSettings<T1, T2>(this CombinedResult<T1, T2, DomainFactory> combinedResult, Action<Humidifier.Amplify.DomainTypes.CertificateSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCertificateSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, T3, InnerDomainCertificateSettingsFactory> WithCertificateSettings<T1, T2, T3>(this CombinedResult<DomainFactory, T1, T2, T3> combinedResult, Action<Humidifier.Amplify.DomainTypes.CertificateSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, T3, InnerDomainCertificateSettingsFactory> WithCertificateSettings<T1, T2, T3>(this CombinedResult<T1, DomainFactory, T2, T3> combinedResult, Action<Humidifier.Amplify.DomainTypes.CertificateSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, T3, InnerDomainCertificateSettingsFactory> WithCertificateSettings<T1, T2, T3>(this CombinedResult<T1, T2, DomainFactory, T3> combinedResult, Action<Humidifier.Amplify.DomainTypes.CertificateSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainFactory, InnerDomainCertificateSettingsFactory> WithCertificateSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, DomainFactory> combinedResult, Action<Humidifier.Amplify.DomainTypes.CertificateSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, T3, T4, InnerDomainCertificateSettingsFactory> WithCertificateSettings<T1, T2, T3, T4>(this CombinedResult<DomainFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Amplify.DomainTypes.CertificateSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, T3, T4, InnerDomainCertificateSettingsFactory> WithCertificateSettings<T1, T2, T3, T4>(this CombinedResult<T1, DomainFactory, T2, T3, T4> combinedResult, Action<Humidifier.Amplify.DomainTypes.CertificateSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, T3, T4, InnerDomainCertificateSettingsFactory> WithCertificateSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, DomainFactory, T3, T4> combinedResult, Action<Humidifier.Amplify.DomainTypes.CertificateSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainFactory, T4, InnerDomainCertificateSettingsFactory> WithCertificateSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DomainFactory, T4> combinedResult, Action<Humidifier.Amplify.DomainTypes.CertificateSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DomainFactory, InnerDomainCertificateSettingsFactory> WithCertificateSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DomainFactory> combinedResult, Action<Humidifier.Amplify.DomainTypes.CertificateSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCertificateSettings(combinedResult.T5, subFactoryAction));
}
