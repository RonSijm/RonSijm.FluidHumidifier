// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceSnowflakeParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.SnowflakeParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.SnowflakeParameters>
{

    internal InnerDataSourceOAuthParametersFactory OAuthParametersFactory { get; set; }

    protected override Humidifier.QuickSight.DataSourceTypes.SnowflakeParameters Create()
    {
        var snowflakeParametersResult = CreateSnowflakeParameters();
        factoryAction?.Invoke(snowflakeParametersResult);

        return snowflakeParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.SnowflakeParameters CreateSnowflakeParameters()
    {
        var snowflakeParametersResult = new Humidifier.QuickSight.DataSourceTypes.SnowflakeParameters();

        return snowflakeParametersResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DataSourceTypes.SnowflakeParameters result)
    {
        base.CreateChildren(result);

        result.OAuthParameters ??= OAuthParametersFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceSnowflakeParametersFactoryExtensions
{
    public static CombinedResult<InnerDataSourceSnowflakeParametersFactory, InnerDataSourceOAuthParametersFactory> WithOAuthParameters(this InnerDataSourceSnowflakeParametersFactory parentFactory, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null)
    {
        parentFactory.OAuthParametersFactory = new InnerDataSourceOAuthParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OAuthParametersFactory);
    }

    public static CombinedResult<InnerDataSourceSnowflakeParametersFactory, T1, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1>(this CombinedResult<InnerDataSourceSnowflakeParametersFactory, T1> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithOAuthParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceSnowflakeParametersFactory, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1>(this CombinedResult<T1, InnerDataSourceSnowflakeParametersFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithOAuthParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceSnowflakeParametersFactory, T1, T2, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2>(this CombinedResult<InnerDataSourceSnowflakeParametersFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceSnowflakeParametersFactory, T2, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2>(this CombinedResult<T1, InnerDataSourceSnowflakeParametersFactory, T2> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceSnowflakeParametersFactory, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceSnowflakeParametersFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceSnowflakeParametersFactory, T1, T2, T3, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3>(this CombinedResult<InnerDataSourceSnowflakeParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceSnowflakeParametersFactory, T2, T3, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceSnowflakeParametersFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceSnowflakeParametersFactory, T3, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceSnowflakeParametersFactory, T3> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceSnowflakeParametersFactory, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceSnowflakeParametersFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceSnowflakeParametersFactory, T1, T2, T3, T4, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceSnowflakeParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceSnowflakeParametersFactory, T2, T3, T4, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceSnowflakeParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceSnowflakeParametersFactory, T3, T4, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceSnowflakeParametersFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceSnowflakeParametersFactory, T4, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceSnowflakeParametersFactory, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceSnowflakeParametersFactory, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceSnowflakeParametersFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T5, subFactoryAction));
}
