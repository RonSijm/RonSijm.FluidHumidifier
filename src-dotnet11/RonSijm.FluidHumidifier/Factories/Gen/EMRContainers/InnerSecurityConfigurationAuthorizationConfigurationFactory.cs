// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerSecurityConfigurationAuthorizationConfigurationFactory(Action<Humidifier.EMRContainers.SecurityConfigurationTypes.AuthorizationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.SecurityConfigurationTypes.AuthorizationConfiguration>
{

    internal InnerSecurityConfigurationLakeFormationConfigurationFactory LakeFormationConfigurationFactory { get; set; }

    protected override Humidifier.EMRContainers.SecurityConfigurationTypes.AuthorizationConfiguration Create()
    {
        var authorizationConfigurationResult = CreateAuthorizationConfiguration();
        factoryAction?.Invoke(authorizationConfigurationResult);

        return authorizationConfigurationResult;
    }

    private Humidifier.EMRContainers.SecurityConfigurationTypes.AuthorizationConfiguration CreateAuthorizationConfiguration()
    {
        var authorizationConfigurationResult = new Humidifier.EMRContainers.SecurityConfigurationTypes.AuthorizationConfiguration();

        return authorizationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.EMRContainers.SecurityConfigurationTypes.AuthorizationConfiguration result)
    {
        base.CreateChildren(result);

        result.LakeFormationConfiguration ??= LakeFormationConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerSecurityConfigurationAuthorizationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerSecurityConfigurationAuthorizationConfigurationFactory, InnerSecurityConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration(this InnerSecurityConfigurationAuthorizationConfigurationFactory parentFactory, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null)
    {
        parentFactory.LakeFormationConfigurationFactory = new InnerSecurityConfigurationLakeFormationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LakeFormationConfigurationFactory);
    }

    public static CombinedResult<InnerSecurityConfigurationAuthorizationConfigurationFactory, T1, InnerSecurityConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1>(this CombinedResult<InnerSecurityConfigurationAuthorizationConfigurationFactory, T1> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityConfigurationAuthorizationConfigurationFactory, InnerSecurityConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1>(this CombinedResult<T1, InnerSecurityConfigurationAuthorizationConfigurationFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerSecurityConfigurationAuthorizationConfigurationFactory, T1, T2, InnerSecurityConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1, T2>(this CombinedResult<InnerSecurityConfigurationAuthorizationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityConfigurationAuthorizationConfigurationFactory, T2, InnerSecurityConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1, T2>(this CombinedResult<T1, InnerSecurityConfigurationAuthorizationConfigurationFactory, T2> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSecurityConfigurationAuthorizationConfigurationFactory, InnerSecurityConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerSecurityConfigurationAuthorizationConfigurationFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerSecurityConfigurationAuthorizationConfigurationFactory, T1, T2, T3, InnerSecurityConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1, T2, T3>(this CombinedResult<InnerSecurityConfigurationAuthorizationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityConfigurationAuthorizationConfigurationFactory, T2, T3, InnerSecurityConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerSecurityConfigurationAuthorizationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSecurityConfigurationAuthorizationConfigurationFactory, T3, InnerSecurityConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerSecurityConfigurationAuthorizationConfigurationFactory, T3> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSecurityConfigurationAuthorizationConfigurationFactory, InnerSecurityConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSecurityConfigurationAuthorizationConfigurationFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerSecurityConfigurationAuthorizationConfigurationFactory, T1, T2, T3, T4, InnerSecurityConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerSecurityConfigurationAuthorizationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityConfigurationAuthorizationConfigurationFactory, T2, T3, T4, InnerSecurityConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerSecurityConfigurationAuthorizationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSecurityConfigurationAuthorizationConfigurationFactory, T3, T4, InnerSecurityConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSecurityConfigurationAuthorizationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSecurityConfigurationAuthorizationConfigurationFactory, T4, InnerSecurityConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSecurityConfigurationAuthorizationConfigurationFactory, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerSecurityConfigurationAuthorizationConfigurationFactory, InnerSecurityConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSecurityConfigurationAuthorizationConfigurationFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T5, subFactoryAction).T2);
}
