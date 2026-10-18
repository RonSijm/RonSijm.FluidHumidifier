// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerSecurityConfigurationLakeFormationConfigurationFactory(Action<Humidifier.EMRContainers.SecurityConfigurationTypes.LakeFormationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.SecurityConfigurationTypes.LakeFormationConfiguration>
{

    internal InnerSecurityConfigurationSecureNamespaceInfoFactory SecureNamespaceInfoFactory { get; set; }

    protected override Humidifier.EMRContainers.SecurityConfigurationTypes.LakeFormationConfiguration Create()
    {
        var lakeFormationConfigurationResult = CreateLakeFormationConfiguration();
        factoryAction?.Invoke(lakeFormationConfigurationResult);

        return lakeFormationConfigurationResult;
    }

    private Humidifier.EMRContainers.SecurityConfigurationTypes.LakeFormationConfiguration CreateLakeFormationConfiguration()
    {
        var lakeFormationConfigurationResult = new Humidifier.EMRContainers.SecurityConfigurationTypes.LakeFormationConfiguration();

        return lakeFormationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.EMRContainers.SecurityConfigurationTypes.LakeFormationConfiguration result)
    {
        base.CreateChildren(result);

        result.SecureNamespaceInfo ??= SecureNamespaceInfoFactory?.Build();
    }

} // End Of Class

public static class InnerSecurityConfigurationLakeFormationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerSecurityConfigurationLakeFormationConfigurationFactory, InnerSecurityConfigurationSecureNamespaceInfoFactory> WithSecureNamespaceInfo(this InnerSecurityConfigurationLakeFormationConfigurationFactory parentFactory, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecureNamespaceInfo> subFactoryAction = null)
    {
        parentFactory.SecureNamespaceInfoFactory = new InnerSecurityConfigurationSecureNamespaceInfoFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SecureNamespaceInfoFactory);
    }

    public static CombinedResult<InnerSecurityConfigurationLakeFormationConfigurationFactory, T1, InnerSecurityConfigurationSecureNamespaceInfoFactory> WithSecureNamespaceInfo<T1>(this CombinedResult<InnerSecurityConfigurationLakeFormationConfigurationFactory, T1> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecureNamespaceInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecureNamespaceInfo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityConfigurationLakeFormationConfigurationFactory, InnerSecurityConfigurationSecureNamespaceInfoFactory> WithSecureNamespaceInfo<T1>(this CombinedResult<T1, InnerSecurityConfigurationLakeFormationConfigurationFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecureNamespaceInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecureNamespaceInfo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerSecurityConfigurationLakeFormationConfigurationFactory, T1, T2, InnerSecurityConfigurationSecureNamespaceInfoFactory> WithSecureNamespaceInfo<T1, T2>(this CombinedResult<InnerSecurityConfigurationLakeFormationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecureNamespaceInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecureNamespaceInfo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityConfigurationLakeFormationConfigurationFactory, T2, InnerSecurityConfigurationSecureNamespaceInfoFactory> WithSecureNamespaceInfo<T1, T2>(this CombinedResult<T1, InnerSecurityConfigurationLakeFormationConfigurationFactory, T2> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecureNamespaceInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecureNamespaceInfo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSecurityConfigurationLakeFormationConfigurationFactory, InnerSecurityConfigurationSecureNamespaceInfoFactory> WithSecureNamespaceInfo<T1, T2>(this CombinedResult<T1, T2, InnerSecurityConfigurationLakeFormationConfigurationFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecureNamespaceInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecureNamespaceInfo(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerSecurityConfigurationLakeFormationConfigurationFactory, T1, T2, T3, InnerSecurityConfigurationSecureNamespaceInfoFactory> WithSecureNamespaceInfo<T1, T2, T3>(this CombinedResult<InnerSecurityConfigurationLakeFormationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecureNamespaceInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecureNamespaceInfo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityConfigurationLakeFormationConfigurationFactory, T2, T3, InnerSecurityConfigurationSecureNamespaceInfoFactory> WithSecureNamespaceInfo<T1, T2, T3>(this CombinedResult<T1, InnerSecurityConfigurationLakeFormationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecureNamespaceInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecureNamespaceInfo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSecurityConfigurationLakeFormationConfigurationFactory, T3, InnerSecurityConfigurationSecureNamespaceInfoFactory> WithSecureNamespaceInfo<T1, T2, T3>(this CombinedResult<T1, T2, InnerSecurityConfigurationLakeFormationConfigurationFactory, T3> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecureNamespaceInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecureNamespaceInfo(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSecurityConfigurationLakeFormationConfigurationFactory, InnerSecurityConfigurationSecureNamespaceInfoFactory> WithSecureNamespaceInfo<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSecurityConfigurationLakeFormationConfigurationFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecureNamespaceInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecureNamespaceInfo(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerSecurityConfigurationLakeFormationConfigurationFactory, T1, T2, T3, T4, InnerSecurityConfigurationSecureNamespaceInfoFactory> WithSecureNamespaceInfo<T1, T2, T3, T4>(this CombinedResult<InnerSecurityConfigurationLakeFormationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecureNamespaceInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecureNamespaceInfo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityConfigurationLakeFormationConfigurationFactory, T2, T3, T4, InnerSecurityConfigurationSecureNamespaceInfoFactory> WithSecureNamespaceInfo<T1, T2, T3, T4>(this CombinedResult<T1, InnerSecurityConfigurationLakeFormationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecureNamespaceInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecureNamespaceInfo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSecurityConfigurationLakeFormationConfigurationFactory, T3, T4, InnerSecurityConfigurationSecureNamespaceInfoFactory> WithSecureNamespaceInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSecurityConfigurationLakeFormationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecureNamespaceInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecureNamespaceInfo(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSecurityConfigurationLakeFormationConfigurationFactory, T4, InnerSecurityConfigurationSecureNamespaceInfoFactory> WithSecureNamespaceInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSecurityConfigurationLakeFormationConfigurationFactory, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecureNamespaceInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecureNamespaceInfo(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerSecurityConfigurationLakeFormationConfigurationFactory, InnerSecurityConfigurationSecureNamespaceInfoFactory> WithSecureNamespaceInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSecurityConfigurationLakeFormationConfigurationFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecureNamespaceInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecureNamespaceInfo(combinedResult.T5, subFactoryAction).T2);
}
