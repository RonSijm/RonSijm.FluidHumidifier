// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class DomainFactory(string resourceName = null, Action<Humidifier.SageMaker.Domain> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.Domain>(resourceName)
{

    internal InnerDomainDefaultSpaceSettingsFactory DefaultSpaceSettingsFactory { get; set; }

    internal InnerDomainUserSettingsFactory DefaultUserSettingsFactory { get; set; }

    internal InnerDomainDomainSettingsFactory DomainSettingsFactory { get; set; }

    protected override Humidifier.SageMaker.Domain Create()
    {
        var domainResult = CreateDomain();
        factoryAction?.Invoke(domainResult);

        return domainResult;
    }

    private Humidifier.SageMaker.Domain CreateDomain()
    {
        var domainResult = new Humidifier.SageMaker.Domain
        {
            GivenName = InputResourceName,
        };

        return domainResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.Domain result)
    {
        base.CreateChildren(result);

        result.DefaultSpaceSettings ??= DefaultSpaceSettingsFactory?.Build();
        result.DefaultUserSettings ??= DefaultUserSettingsFactory?.Build();
        result.DomainSettings ??= DomainSettingsFactory?.Build();
    }

} // End Of Class

public static class DomainFactoryExtensions
{
    public static CombinedResult<DomainFactory, InnerDomainDefaultSpaceSettingsFactory> WithDefaultSpaceSettings(this DomainFactory parentFactory, Action<Humidifier.SageMaker.DomainTypes.DefaultSpaceSettings> subFactoryAction = null)
    {
        parentFactory.DefaultSpaceSettingsFactory = new InnerDomainDefaultSpaceSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultSpaceSettingsFactory);
    }

    public static CombinedResult<DomainFactory, InnerDomainUserSettingsFactory> WithDefaultUserSettings(this DomainFactory parentFactory, Action<Humidifier.SageMaker.DomainTypes.UserSettings> subFactoryAction = null)
    {
        parentFactory.DefaultUserSettingsFactory = new InnerDomainUserSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultUserSettingsFactory);
    }

    public static CombinedResult<DomainFactory, InnerDomainDomainSettingsFactory> WithDomainSettings(this DomainFactory parentFactory, Action<Humidifier.SageMaker.DomainTypes.DomainSettings> subFactoryAction = null)
    {
        parentFactory.DomainSettingsFactory = new InnerDomainDomainSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DomainSettingsFactory);
    }

    public static CombinedResult<DomainFactory, T1, InnerDomainDefaultSpaceSettingsFactory> WithDefaultSpaceSettings<T1>(this CombinedResult<DomainFactory, T1> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultSpaceSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, InnerDomainDefaultSpaceSettingsFactory> WithDefaultSpaceSettings<T1>(this CombinedResult<T1, DomainFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultSpaceSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, InnerDomainDefaultSpaceSettingsFactory> WithDefaultSpaceSettings<T1, T2>(this CombinedResult<DomainFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultSpaceSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, InnerDomainDefaultSpaceSettingsFactory> WithDefaultSpaceSettings<T1, T2>(this CombinedResult<T1, DomainFactory, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultSpaceSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, InnerDomainDefaultSpaceSettingsFactory> WithDefaultSpaceSettings<T1, T2>(this CombinedResult<T1, T2, DomainFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultSpaceSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, T3, InnerDomainDefaultSpaceSettingsFactory> WithDefaultSpaceSettings<T1, T2, T3>(this CombinedResult<DomainFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultSpaceSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, T3, InnerDomainDefaultSpaceSettingsFactory> WithDefaultSpaceSettings<T1, T2, T3>(this CombinedResult<T1, DomainFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultSpaceSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, T3, InnerDomainDefaultSpaceSettingsFactory> WithDefaultSpaceSettings<T1, T2, T3>(this CombinedResult<T1, T2, DomainFactory, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultSpaceSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainFactory, InnerDomainDefaultSpaceSettingsFactory> WithDefaultSpaceSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, DomainFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultSpaceSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, T3, T4, InnerDomainDefaultSpaceSettingsFactory> WithDefaultSpaceSettings<T1, T2, T3, T4>(this CombinedResult<DomainFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultSpaceSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, T3, T4, InnerDomainDefaultSpaceSettingsFactory> WithDefaultSpaceSettings<T1, T2, T3, T4>(this CombinedResult<T1, DomainFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultSpaceSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, T3, T4, InnerDomainDefaultSpaceSettingsFactory> WithDefaultSpaceSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, DomainFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultSpaceSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainFactory, T4, InnerDomainDefaultSpaceSettingsFactory> WithDefaultSpaceSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DomainFactory, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultSpaceSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DomainFactory, InnerDomainDefaultSpaceSettingsFactory> WithDefaultSpaceSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DomainFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DefaultSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultSpaceSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, InnerDomainUserSettingsFactory> WithDefaultUserSettings<T1>(this CombinedResult<DomainFactory, T1> combinedResult, Action<Humidifier.SageMaker.DomainTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultUserSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, InnerDomainUserSettingsFactory> WithDefaultUserSettings<T1>(this CombinedResult<T1, DomainFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultUserSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, InnerDomainUserSettingsFactory> WithDefaultUserSettings<T1, T2>(this CombinedResult<DomainFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultUserSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, InnerDomainUserSettingsFactory> WithDefaultUserSettings<T1, T2>(this CombinedResult<T1, DomainFactory, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultUserSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, InnerDomainUserSettingsFactory> WithDefaultUserSettings<T1, T2>(this CombinedResult<T1, T2, DomainFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultUserSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, T3, InnerDomainUserSettingsFactory> WithDefaultUserSettings<T1, T2, T3>(this CombinedResult<DomainFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultUserSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, T3, InnerDomainUserSettingsFactory> WithDefaultUserSettings<T1, T2, T3>(this CombinedResult<T1, DomainFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultUserSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, T3, InnerDomainUserSettingsFactory> WithDefaultUserSettings<T1, T2, T3>(this CombinedResult<T1, T2, DomainFactory, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultUserSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainFactory, InnerDomainUserSettingsFactory> WithDefaultUserSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, DomainFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultUserSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, T3, T4, InnerDomainUserSettingsFactory> WithDefaultUserSettings<T1, T2, T3, T4>(this CombinedResult<DomainFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultUserSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, T3, T4, InnerDomainUserSettingsFactory> WithDefaultUserSettings<T1, T2, T3, T4>(this CombinedResult<T1, DomainFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultUserSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, T3, T4, InnerDomainUserSettingsFactory> WithDefaultUserSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, DomainFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultUserSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainFactory, T4, InnerDomainUserSettingsFactory> WithDefaultUserSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DomainFactory, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultUserSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DomainFactory, InnerDomainUserSettingsFactory> WithDefaultUserSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DomainFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultUserSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, InnerDomainDomainSettingsFactory> WithDomainSettings<T1>(this CombinedResult<DomainFactory, T1> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithDomainSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, InnerDomainDomainSettingsFactory> WithDomainSettings<T1>(this CombinedResult<T1, DomainFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithDomainSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, InnerDomainDomainSettingsFactory> WithDomainSettings<T1, T2>(this CombinedResult<DomainFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, InnerDomainDomainSettingsFactory> WithDomainSettings<T1, T2>(this CombinedResult<T1, DomainFactory, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, InnerDomainDomainSettingsFactory> WithDomainSettings<T1, T2>(this CombinedResult<T1, T2, DomainFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, T3, InnerDomainDomainSettingsFactory> WithDomainSettings<T1, T2, T3>(this CombinedResult<DomainFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, T3, InnerDomainDomainSettingsFactory> WithDomainSettings<T1, T2, T3>(this CombinedResult<T1, DomainFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, T3, InnerDomainDomainSettingsFactory> WithDomainSettings<T1, T2, T3>(this CombinedResult<T1, T2, DomainFactory, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainFactory, InnerDomainDomainSettingsFactory> WithDomainSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, DomainFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, T3, T4, InnerDomainDomainSettingsFactory> WithDomainSettings<T1, T2, T3, T4>(this CombinedResult<DomainFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, T3, T4, InnerDomainDomainSettingsFactory> WithDomainSettings<T1, T2, T3, T4>(this CombinedResult<T1, DomainFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, T3, T4, InnerDomainDomainSettingsFactory> WithDomainSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, DomainFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainFactory, T4, InnerDomainDomainSettingsFactory> WithDomainSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DomainFactory, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DomainFactory, InnerDomainDomainSettingsFactory> WithDomainSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DomainFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainSettings(combinedResult.T5, subFactoryAction));
}
