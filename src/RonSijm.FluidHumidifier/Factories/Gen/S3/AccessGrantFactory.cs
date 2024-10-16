// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class AccessGrantFactory(string resourceName = null, Action<Humidifier.S3.AccessGrant> factoryAction = null) : ResourceFactory<Humidifier.S3.AccessGrant>(resourceName)
{

    internal InnerAccessGrantGranteeFactory GranteeFactory { get; set; }

    internal InnerAccessGrantAccessGrantsLocationConfigurationFactory AccessGrantsLocationConfigurationFactory { get; set; }

    protected override Humidifier.S3.AccessGrant Create()
    {
        var accessGrantResult = CreateAccessGrant();
        factoryAction?.Invoke(accessGrantResult);

        return accessGrantResult;
    }

    private Humidifier.S3.AccessGrant CreateAccessGrant()
    {
        var accessGrantResult = new Humidifier.S3.AccessGrant
        {
            GivenName = InputResourceName,
        };

        return accessGrantResult;
    }
    public override void CreateChildren(Humidifier.S3.AccessGrant result)
    {
        base.CreateChildren(result);

        result.Grantee ??= GranteeFactory?.Build();
        result.AccessGrantsLocationConfiguration ??= AccessGrantsLocationConfigurationFactory?.Build();
    }

} // End Of Class

public static class AccessGrantFactoryExtensions
{
    public static CombinedResult<AccessGrantFactory, InnerAccessGrantGranteeFactory> WithGrantee(this AccessGrantFactory parentFactory, Action<Humidifier.S3.AccessGrantTypes.Grantee> subFactoryAction = null)
    {
        parentFactory.GranteeFactory = new InnerAccessGrantGranteeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GranteeFactory);
    }

    public static CombinedResult<AccessGrantFactory, InnerAccessGrantAccessGrantsLocationConfigurationFactory> WithAccessGrantsLocationConfiguration(this AccessGrantFactory parentFactory, Action<Humidifier.S3.AccessGrantTypes.AccessGrantsLocationConfiguration> subFactoryAction = null)
    {
        parentFactory.AccessGrantsLocationConfigurationFactory = new InnerAccessGrantAccessGrantsLocationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AccessGrantsLocationConfigurationFactory);
    }

    public static CombinedResult<AccessGrantFactory, T1, InnerAccessGrantGranteeFactory> WithGrantee<T1>(this CombinedResult<AccessGrantFactory, T1> combinedResult, Action<Humidifier.S3.AccessGrantTypes.Grantee> subFactoryAction = null) => new (combinedResult, combinedResult, WithGrantee(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessGrantFactory, InnerAccessGrantGranteeFactory> WithGrantee<T1>(this CombinedResult<T1, AccessGrantFactory> combinedResult, Action<Humidifier.S3.AccessGrantTypes.Grantee> subFactoryAction = null) => new (combinedResult, combinedResult, WithGrantee(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AccessGrantFactory, T1, T2, InnerAccessGrantGranteeFactory> WithGrantee<T1, T2>(this CombinedResult<AccessGrantFactory, T1, T2> combinedResult, Action<Humidifier.S3.AccessGrantTypes.Grantee> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGrantee(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessGrantFactory, T2, InnerAccessGrantGranteeFactory> WithGrantee<T1, T2>(this CombinedResult<T1, AccessGrantFactory, T2> combinedResult, Action<Humidifier.S3.AccessGrantTypes.Grantee> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGrantee(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessGrantFactory, InnerAccessGrantGranteeFactory> WithGrantee<T1, T2>(this CombinedResult<T1, T2, AccessGrantFactory> combinedResult, Action<Humidifier.S3.AccessGrantTypes.Grantee> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGrantee(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AccessGrantFactory, T1, T2, T3, InnerAccessGrantGranteeFactory> WithGrantee<T1, T2, T3>(this CombinedResult<AccessGrantFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.AccessGrantTypes.Grantee> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGrantee(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessGrantFactory, T2, T3, InnerAccessGrantGranteeFactory> WithGrantee<T1, T2, T3>(this CombinedResult<T1, AccessGrantFactory, T2, T3> combinedResult, Action<Humidifier.S3.AccessGrantTypes.Grantee> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGrantee(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessGrantFactory, T3, InnerAccessGrantGranteeFactory> WithGrantee<T1, T2, T3>(this CombinedResult<T1, T2, AccessGrantFactory, T3> combinedResult, Action<Humidifier.S3.AccessGrantTypes.Grantee> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGrantee(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AccessGrantFactory, InnerAccessGrantGranteeFactory> WithGrantee<T1, T2, T3>(this CombinedResult<T1, T2, T3, AccessGrantFactory> combinedResult, Action<Humidifier.S3.AccessGrantTypes.Grantee> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGrantee(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AccessGrantFactory, T1, T2, T3, T4, InnerAccessGrantGranteeFactory> WithGrantee<T1, T2, T3, T4>(this CombinedResult<AccessGrantFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.AccessGrantTypes.Grantee> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGrantee(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessGrantFactory, T2, T3, T4, InnerAccessGrantGranteeFactory> WithGrantee<T1, T2, T3, T4>(this CombinedResult<T1, AccessGrantFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.AccessGrantTypes.Grantee> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGrantee(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessGrantFactory, T3, T4, InnerAccessGrantGranteeFactory> WithGrantee<T1, T2, T3, T4>(this CombinedResult<T1, T2, AccessGrantFactory, T3, T4> combinedResult, Action<Humidifier.S3.AccessGrantTypes.Grantee> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGrantee(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AccessGrantFactory, T4, InnerAccessGrantGranteeFactory> WithGrantee<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AccessGrantFactory, T4> combinedResult, Action<Humidifier.S3.AccessGrantTypes.Grantee> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGrantee(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AccessGrantFactory, InnerAccessGrantGranteeFactory> WithGrantee<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AccessGrantFactory> combinedResult, Action<Humidifier.S3.AccessGrantTypes.Grantee> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGrantee(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AccessGrantFactory, T1, InnerAccessGrantAccessGrantsLocationConfigurationFactory> WithAccessGrantsLocationConfiguration<T1>(this CombinedResult<AccessGrantFactory, T1> combinedResult, Action<Humidifier.S3.AccessGrantTypes.AccessGrantsLocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessGrantsLocationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessGrantFactory, InnerAccessGrantAccessGrantsLocationConfigurationFactory> WithAccessGrantsLocationConfiguration<T1>(this CombinedResult<T1, AccessGrantFactory> combinedResult, Action<Humidifier.S3.AccessGrantTypes.AccessGrantsLocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessGrantsLocationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AccessGrantFactory, T1, T2, InnerAccessGrantAccessGrantsLocationConfigurationFactory> WithAccessGrantsLocationConfiguration<T1, T2>(this CombinedResult<AccessGrantFactory, T1, T2> combinedResult, Action<Humidifier.S3.AccessGrantTypes.AccessGrantsLocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessGrantsLocationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessGrantFactory, T2, InnerAccessGrantAccessGrantsLocationConfigurationFactory> WithAccessGrantsLocationConfiguration<T1, T2>(this CombinedResult<T1, AccessGrantFactory, T2> combinedResult, Action<Humidifier.S3.AccessGrantTypes.AccessGrantsLocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessGrantsLocationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessGrantFactory, InnerAccessGrantAccessGrantsLocationConfigurationFactory> WithAccessGrantsLocationConfiguration<T1, T2>(this CombinedResult<T1, T2, AccessGrantFactory> combinedResult, Action<Humidifier.S3.AccessGrantTypes.AccessGrantsLocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessGrantsLocationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AccessGrantFactory, T1, T2, T3, InnerAccessGrantAccessGrantsLocationConfigurationFactory> WithAccessGrantsLocationConfiguration<T1, T2, T3>(this CombinedResult<AccessGrantFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.AccessGrantTypes.AccessGrantsLocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessGrantsLocationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessGrantFactory, T2, T3, InnerAccessGrantAccessGrantsLocationConfigurationFactory> WithAccessGrantsLocationConfiguration<T1, T2, T3>(this CombinedResult<T1, AccessGrantFactory, T2, T3> combinedResult, Action<Humidifier.S3.AccessGrantTypes.AccessGrantsLocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessGrantsLocationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessGrantFactory, T3, InnerAccessGrantAccessGrantsLocationConfigurationFactory> WithAccessGrantsLocationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, AccessGrantFactory, T3> combinedResult, Action<Humidifier.S3.AccessGrantTypes.AccessGrantsLocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessGrantsLocationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AccessGrantFactory, InnerAccessGrantAccessGrantsLocationConfigurationFactory> WithAccessGrantsLocationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, AccessGrantFactory> combinedResult, Action<Humidifier.S3.AccessGrantTypes.AccessGrantsLocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessGrantsLocationConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AccessGrantFactory, T1, T2, T3, T4, InnerAccessGrantAccessGrantsLocationConfigurationFactory> WithAccessGrantsLocationConfiguration<T1, T2, T3, T4>(this CombinedResult<AccessGrantFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.AccessGrantTypes.AccessGrantsLocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessGrantsLocationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessGrantFactory, T2, T3, T4, InnerAccessGrantAccessGrantsLocationConfigurationFactory> WithAccessGrantsLocationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, AccessGrantFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.AccessGrantTypes.AccessGrantsLocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessGrantsLocationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessGrantFactory, T3, T4, InnerAccessGrantAccessGrantsLocationConfigurationFactory> WithAccessGrantsLocationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, AccessGrantFactory, T3, T4> combinedResult, Action<Humidifier.S3.AccessGrantTypes.AccessGrantsLocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessGrantsLocationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AccessGrantFactory, T4, InnerAccessGrantAccessGrantsLocationConfigurationFactory> WithAccessGrantsLocationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AccessGrantFactory, T4> combinedResult, Action<Humidifier.S3.AccessGrantTypes.AccessGrantsLocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessGrantsLocationConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AccessGrantFactory, InnerAccessGrantAccessGrantsLocationConfigurationFactory> WithAccessGrantsLocationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AccessGrantFactory> combinedResult, Action<Humidifier.S3.AccessGrantTypes.AccessGrantsLocationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessGrantsLocationConfiguration(combinedResult.T5, subFactoryAction));
}
