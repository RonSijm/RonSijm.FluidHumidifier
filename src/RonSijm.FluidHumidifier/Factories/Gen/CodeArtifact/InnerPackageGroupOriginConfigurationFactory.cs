// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeArtifact;

public class InnerPackageGroupOriginConfigurationFactory(Action<Humidifier.CodeArtifact.PackageGroupTypes.OriginConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CodeArtifact.PackageGroupTypes.OriginConfiguration>
{

    internal InnerPackageGroupRestrictionsFactory RestrictionsFactory { get; set; }

    protected override Humidifier.CodeArtifact.PackageGroupTypes.OriginConfiguration Create()
    {
        var originConfigurationResult = CreateOriginConfiguration();
        factoryAction?.Invoke(originConfigurationResult);

        return originConfigurationResult;
    }

    private Humidifier.CodeArtifact.PackageGroupTypes.OriginConfiguration CreateOriginConfiguration()
    {
        var originConfigurationResult = new Humidifier.CodeArtifact.PackageGroupTypes.OriginConfiguration();

        return originConfigurationResult;
    }
    public override void CreateChildren(Humidifier.CodeArtifact.PackageGroupTypes.OriginConfiguration result)
    {
        base.CreateChildren(result);

        result.Restrictions ??= RestrictionsFactory?.Build();
    }

} // End Of Class

public static class InnerPackageGroupOriginConfigurationFactoryExtensions
{
    public static CombinedResult<InnerPackageGroupOriginConfigurationFactory, InnerPackageGroupRestrictionsFactory> WithRestrictions(this InnerPackageGroupOriginConfigurationFactory parentFactory, Action<Humidifier.CodeArtifact.PackageGroupTypes.Restrictions> subFactoryAction = null)
    {
        parentFactory.RestrictionsFactory = new InnerPackageGroupRestrictionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RestrictionsFactory);
    }

    public static CombinedResult<InnerPackageGroupOriginConfigurationFactory, T1, InnerPackageGroupRestrictionsFactory> WithRestrictions<T1>(this CombinedResult<InnerPackageGroupOriginConfigurationFactory, T1> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.Restrictions> subFactoryAction = null) => new (combinedResult, combinedResult, WithRestrictions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackageGroupOriginConfigurationFactory, InnerPackageGroupRestrictionsFactory> WithRestrictions<T1>(this CombinedResult<T1, InnerPackageGroupOriginConfigurationFactory> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.Restrictions> subFactoryAction = null) => new (combinedResult, combinedResult, WithRestrictions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPackageGroupOriginConfigurationFactory, T1, T2, InnerPackageGroupRestrictionsFactory> WithRestrictions<T1, T2>(this CombinedResult<InnerPackageGroupOriginConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.Restrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackageGroupOriginConfigurationFactory, T2, InnerPackageGroupRestrictionsFactory> WithRestrictions<T1, T2>(this CombinedResult<T1, InnerPackageGroupOriginConfigurationFactory, T2> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.Restrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackageGroupOriginConfigurationFactory, InnerPackageGroupRestrictionsFactory> WithRestrictions<T1, T2>(this CombinedResult<T1, T2, InnerPackageGroupOriginConfigurationFactory> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.Restrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPackageGroupOriginConfigurationFactory, T1, T2, T3, InnerPackageGroupRestrictionsFactory> WithRestrictions<T1, T2, T3>(this CombinedResult<InnerPackageGroupOriginConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.Restrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackageGroupOriginConfigurationFactory, T2, T3, InnerPackageGroupRestrictionsFactory> WithRestrictions<T1, T2, T3>(this CombinedResult<T1, InnerPackageGroupOriginConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.Restrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackageGroupOriginConfigurationFactory, T3, InnerPackageGroupRestrictionsFactory> WithRestrictions<T1, T2, T3>(this CombinedResult<T1, T2, InnerPackageGroupOriginConfigurationFactory, T3> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.Restrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPackageGroupOriginConfigurationFactory, InnerPackageGroupRestrictionsFactory> WithRestrictions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPackageGroupOriginConfigurationFactory> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.Restrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPackageGroupOriginConfigurationFactory, T1, T2, T3, T4, InnerPackageGroupRestrictionsFactory> WithRestrictions<T1, T2, T3, T4>(this CombinedResult<InnerPackageGroupOriginConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.Restrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPackageGroupOriginConfigurationFactory, T2, T3, T4, InnerPackageGroupRestrictionsFactory> WithRestrictions<T1, T2, T3, T4>(this CombinedResult<T1, InnerPackageGroupOriginConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.Restrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPackageGroupOriginConfigurationFactory, T3, T4, InnerPackageGroupRestrictionsFactory> WithRestrictions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPackageGroupOriginConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.Restrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPackageGroupOriginConfigurationFactory, T4, InnerPackageGroupRestrictionsFactory> WithRestrictions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPackageGroupOriginConfigurationFactory, T4> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.Restrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPackageGroupOriginConfigurationFactory, InnerPackageGroupRestrictionsFactory> WithRestrictions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPackageGroupOriginConfigurationFactory> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.Restrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T5, subFactoryAction));
}
