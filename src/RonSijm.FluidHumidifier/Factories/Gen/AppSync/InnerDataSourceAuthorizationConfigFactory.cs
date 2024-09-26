// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerDataSourceAuthorizationConfigFactory(Action<Humidifier.AppSync.DataSourceTypes.AuthorizationConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.DataSourceTypes.AuthorizationConfig>
{

    internal InnerDataSourceAwsIamConfigFactory AwsIamConfigFactory { get; set; }

    protected override Humidifier.AppSync.DataSourceTypes.AuthorizationConfig Create()
    {
        var authorizationConfigResult = CreateAuthorizationConfig();
        factoryAction?.Invoke(authorizationConfigResult);

        return authorizationConfigResult;
    }

    private Humidifier.AppSync.DataSourceTypes.AuthorizationConfig CreateAuthorizationConfig()
    {
        var authorizationConfigResult = new Humidifier.AppSync.DataSourceTypes.AuthorizationConfig();

        return authorizationConfigResult;
    }
    public override void CreateChildren(Humidifier.AppSync.DataSourceTypes.AuthorizationConfig result)
    {
        base.CreateChildren(result);

        result.AwsIamConfig ??= AwsIamConfigFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceAuthorizationConfigFactoryExtensions
{
    public static CombinedResult<InnerDataSourceAuthorizationConfigFactory, InnerDataSourceAwsIamConfigFactory> WithAwsIamConfig(this InnerDataSourceAuthorizationConfigFactory parentFactory, Action<Humidifier.AppSync.DataSourceTypes.AwsIamConfig> subFactoryAction = null)
    {
        parentFactory.AwsIamConfigFactory = new InnerDataSourceAwsIamConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AwsIamConfigFactory);
    }

    public static CombinedResult<InnerDataSourceAuthorizationConfigFactory, T1, InnerDataSourceAwsIamConfigFactory> WithAwsIamConfig<T1>(this CombinedResult<InnerDataSourceAuthorizationConfigFactory, T1> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AwsIamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAwsIamConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceAuthorizationConfigFactory, InnerDataSourceAwsIamConfigFactory> WithAwsIamConfig<T1>(this CombinedResult<T1, InnerDataSourceAuthorizationConfigFactory> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AwsIamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAwsIamConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceAuthorizationConfigFactory, T1, T2, InnerDataSourceAwsIamConfigFactory> WithAwsIamConfig<T1, T2>(this CombinedResult<InnerDataSourceAuthorizationConfigFactory, T1, T2> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AwsIamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsIamConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceAuthorizationConfigFactory, T2, InnerDataSourceAwsIamConfigFactory> WithAwsIamConfig<T1, T2>(this CombinedResult<T1, InnerDataSourceAuthorizationConfigFactory, T2> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AwsIamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsIamConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceAuthorizationConfigFactory, InnerDataSourceAwsIamConfigFactory> WithAwsIamConfig<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceAuthorizationConfigFactory> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AwsIamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsIamConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceAuthorizationConfigFactory, T1, T2, T3, InnerDataSourceAwsIamConfigFactory> WithAwsIamConfig<T1, T2, T3>(this CombinedResult<InnerDataSourceAuthorizationConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AwsIamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsIamConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceAuthorizationConfigFactory, T2, T3, InnerDataSourceAwsIamConfigFactory> WithAwsIamConfig<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceAuthorizationConfigFactory, T2, T3> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AwsIamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsIamConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceAuthorizationConfigFactory, T3, InnerDataSourceAwsIamConfigFactory> WithAwsIamConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceAuthorizationConfigFactory, T3> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AwsIamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsIamConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceAuthorizationConfigFactory, InnerDataSourceAwsIamConfigFactory> WithAwsIamConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceAuthorizationConfigFactory> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AwsIamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsIamConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceAuthorizationConfigFactory, T1, T2, T3, T4, InnerDataSourceAwsIamConfigFactory> WithAwsIamConfig<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceAuthorizationConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AwsIamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsIamConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceAuthorizationConfigFactory, T2, T3, T4, InnerDataSourceAwsIamConfigFactory> WithAwsIamConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceAuthorizationConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AwsIamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsIamConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceAuthorizationConfigFactory, T3, T4, InnerDataSourceAwsIamConfigFactory> WithAwsIamConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceAuthorizationConfigFactory, T3, T4> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AwsIamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsIamConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceAuthorizationConfigFactory, T4, InnerDataSourceAwsIamConfigFactory> WithAwsIamConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceAuthorizationConfigFactory, T4> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AwsIamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsIamConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceAuthorizationConfigFactory, InnerDataSourceAwsIamConfigFactory> WithAwsIamConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceAuthorizationConfigFactory> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AwsIamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsIamConfig(combinedResult.T5, subFactoryAction));
}
