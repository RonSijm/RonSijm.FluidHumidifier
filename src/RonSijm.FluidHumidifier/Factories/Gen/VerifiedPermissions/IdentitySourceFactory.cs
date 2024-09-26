// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VerifiedPermissions;

public class IdentitySourceFactory(string resourceName = null, Action<Humidifier.VerifiedPermissions.IdentitySource> factoryAction = null) : ResourceFactory<Humidifier.VerifiedPermissions.IdentitySource>(resourceName)
{

    internal InnerIdentitySourceIdentitySourceConfigurationFactory ConfigurationFactory { get; set; }

    protected override Humidifier.VerifiedPermissions.IdentitySource Create()
    {
        var identitySourceResult = CreateIdentitySource();
        factoryAction?.Invoke(identitySourceResult);

        return identitySourceResult;
    }

    private Humidifier.VerifiedPermissions.IdentitySource CreateIdentitySource()
    {
        var identitySourceResult = new Humidifier.VerifiedPermissions.IdentitySource
        {
            GivenName = InputResourceName,
        };

        return identitySourceResult;
    }
    public override void CreateChildren(Humidifier.VerifiedPermissions.IdentitySource result)
    {
        base.CreateChildren(result);

        result.Configuration ??= ConfigurationFactory?.Build();
    }

} // End Of Class

public static class IdentitySourceFactoryExtensions
{
    public static CombinedResult<IdentitySourceFactory, InnerIdentitySourceIdentitySourceConfigurationFactory> WithConfiguration(this IdentitySourceFactory parentFactory, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.IdentitySourceConfiguration> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerIdentitySourceIdentitySourceConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<IdentitySourceFactory, T1, InnerIdentitySourceIdentitySourceConfigurationFactory> WithConfiguration<T1>(this CombinedResult<IdentitySourceFactory, T1> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.IdentitySourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentitySourceFactory, InnerIdentitySourceIdentitySourceConfigurationFactory> WithConfiguration<T1>(this CombinedResult<T1, IdentitySourceFactory> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.IdentitySourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IdentitySourceFactory, T1, T2, InnerIdentitySourceIdentitySourceConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<IdentitySourceFactory, T1, T2> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.IdentitySourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentitySourceFactory, T2, InnerIdentitySourceIdentitySourceConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, IdentitySourceFactory, T2> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.IdentitySourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdentitySourceFactory, InnerIdentitySourceIdentitySourceConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, IdentitySourceFactory> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.IdentitySourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IdentitySourceFactory, T1, T2, T3, InnerIdentitySourceIdentitySourceConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<IdentitySourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.IdentitySourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentitySourceFactory, T2, T3, InnerIdentitySourceIdentitySourceConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, IdentitySourceFactory, T2, T3> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.IdentitySourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdentitySourceFactory, T3, InnerIdentitySourceIdentitySourceConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, IdentitySourceFactory, T3> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.IdentitySourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdentitySourceFactory, InnerIdentitySourceIdentitySourceConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, IdentitySourceFactory> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.IdentitySourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IdentitySourceFactory, T1, T2, T3, T4, InnerIdentitySourceIdentitySourceConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<IdentitySourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.IdentitySourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdentitySourceFactory, T2, T3, T4, InnerIdentitySourceIdentitySourceConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, IdentitySourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.IdentitySourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdentitySourceFactory, T3, T4, InnerIdentitySourceIdentitySourceConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, IdentitySourceFactory, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.IdentitySourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdentitySourceFactory, T4, InnerIdentitySourceIdentitySourceConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IdentitySourceFactory, T4> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.IdentitySourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IdentitySourceFactory, InnerIdentitySourceIdentitySourceConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IdentitySourceFactory> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.IdentitySourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction));
}
