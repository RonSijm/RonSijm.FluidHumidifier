// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerSourceLocationAccessConfigurationFactory(Action<Humidifier.MediaTailor.SourceLocationTypes.AccessConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.SourceLocationTypes.AccessConfiguration>
{

    internal InnerSourceLocationSecretsManagerAccessTokenConfigurationFactory SecretsManagerAccessTokenConfigurationFactory { get; set; }

    protected override Humidifier.MediaTailor.SourceLocationTypes.AccessConfiguration Create()
    {
        var accessConfigurationResult = CreateAccessConfiguration();
        factoryAction?.Invoke(accessConfigurationResult);

        return accessConfigurationResult;
    }

    private Humidifier.MediaTailor.SourceLocationTypes.AccessConfiguration CreateAccessConfiguration()
    {
        var accessConfigurationResult = new Humidifier.MediaTailor.SourceLocationTypes.AccessConfiguration();

        return accessConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaTailor.SourceLocationTypes.AccessConfiguration result)
    {
        base.CreateChildren(result);

        result.SecretsManagerAccessTokenConfiguration ??= SecretsManagerAccessTokenConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerSourceLocationAccessConfigurationFactoryExtensions
{
    public static CombinedResult<InnerSourceLocationAccessConfigurationFactory, InnerSourceLocationSecretsManagerAccessTokenConfigurationFactory> WithSecretsManagerAccessTokenConfiguration(this InnerSourceLocationAccessConfigurationFactory parentFactory, Action<Humidifier.MediaTailor.SourceLocationTypes.SecretsManagerAccessTokenConfiguration> subFactoryAction = null)
    {
        parentFactory.SecretsManagerAccessTokenConfigurationFactory = new InnerSourceLocationSecretsManagerAccessTokenConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SecretsManagerAccessTokenConfigurationFactory);
    }

    public static CombinedResult<InnerSourceLocationAccessConfigurationFactory, T1, InnerSourceLocationSecretsManagerAccessTokenConfigurationFactory> WithSecretsManagerAccessTokenConfiguration<T1>(this CombinedResult<InnerSourceLocationAccessConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaTailor.SourceLocationTypes.SecretsManagerAccessTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecretsManagerAccessTokenConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSourceLocationAccessConfigurationFactory, InnerSourceLocationSecretsManagerAccessTokenConfigurationFactory> WithSecretsManagerAccessTokenConfiguration<T1>(this CombinedResult<T1, InnerSourceLocationAccessConfigurationFactory> combinedResult, Action<Humidifier.MediaTailor.SourceLocationTypes.SecretsManagerAccessTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecretsManagerAccessTokenConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSourceLocationAccessConfigurationFactory, T1, T2, InnerSourceLocationSecretsManagerAccessTokenConfigurationFactory> WithSecretsManagerAccessTokenConfiguration<T1, T2>(this CombinedResult<InnerSourceLocationAccessConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaTailor.SourceLocationTypes.SecretsManagerAccessTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManagerAccessTokenConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSourceLocationAccessConfigurationFactory, T2, InnerSourceLocationSecretsManagerAccessTokenConfigurationFactory> WithSecretsManagerAccessTokenConfiguration<T1, T2>(this CombinedResult<T1, InnerSourceLocationAccessConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaTailor.SourceLocationTypes.SecretsManagerAccessTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManagerAccessTokenConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSourceLocationAccessConfigurationFactory, InnerSourceLocationSecretsManagerAccessTokenConfigurationFactory> WithSecretsManagerAccessTokenConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerSourceLocationAccessConfigurationFactory> combinedResult, Action<Humidifier.MediaTailor.SourceLocationTypes.SecretsManagerAccessTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManagerAccessTokenConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSourceLocationAccessConfigurationFactory, T1, T2, T3, InnerSourceLocationSecretsManagerAccessTokenConfigurationFactory> WithSecretsManagerAccessTokenConfiguration<T1, T2, T3>(this CombinedResult<InnerSourceLocationAccessConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaTailor.SourceLocationTypes.SecretsManagerAccessTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerAccessTokenConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSourceLocationAccessConfigurationFactory, T2, T3, InnerSourceLocationSecretsManagerAccessTokenConfigurationFactory> WithSecretsManagerAccessTokenConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerSourceLocationAccessConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaTailor.SourceLocationTypes.SecretsManagerAccessTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerAccessTokenConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSourceLocationAccessConfigurationFactory, T3, InnerSourceLocationSecretsManagerAccessTokenConfigurationFactory> WithSecretsManagerAccessTokenConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerSourceLocationAccessConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaTailor.SourceLocationTypes.SecretsManagerAccessTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerAccessTokenConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSourceLocationAccessConfigurationFactory, InnerSourceLocationSecretsManagerAccessTokenConfigurationFactory> WithSecretsManagerAccessTokenConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSourceLocationAccessConfigurationFactory> combinedResult, Action<Humidifier.MediaTailor.SourceLocationTypes.SecretsManagerAccessTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerAccessTokenConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSourceLocationAccessConfigurationFactory, T1, T2, T3, T4, InnerSourceLocationSecretsManagerAccessTokenConfigurationFactory> WithSecretsManagerAccessTokenConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerSourceLocationAccessConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.SourceLocationTypes.SecretsManagerAccessTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerAccessTokenConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSourceLocationAccessConfigurationFactory, T2, T3, T4, InnerSourceLocationSecretsManagerAccessTokenConfigurationFactory> WithSecretsManagerAccessTokenConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerSourceLocationAccessConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.SourceLocationTypes.SecretsManagerAccessTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerAccessTokenConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSourceLocationAccessConfigurationFactory, T3, T4, InnerSourceLocationSecretsManagerAccessTokenConfigurationFactory> WithSecretsManagerAccessTokenConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSourceLocationAccessConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaTailor.SourceLocationTypes.SecretsManagerAccessTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerAccessTokenConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSourceLocationAccessConfigurationFactory, T4, InnerSourceLocationSecretsManagerAccessTokenConfigurationFactory> WithSecretsManagerAccessTokenConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSourceLocationAccessConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaTailor.SourceLocationTypes.SecretsManagerAccessTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerAccessTokenConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSourceLocationAccessConfigurationFactory, InnerSourceLocationSecretsManagerAccessTokenConfigurationFactory> WithSecretsManagerAccessTokenConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSourceLocationAccessConfigurationFactory> combinedResult, Action<Humidifier.MediaTailor.SourceLocationTypes.SecretsManagerAccessTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerAccessTokenConfiguration(combinedResult.T5, subFactoryAction));
}
