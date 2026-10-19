// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceDatabricksParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.DatabricksParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.DatabricksParameters>
{

    internal InnerDataSourceOAuthParametersFactory OAuthParametersFactory { get; set; }

    protected override Humidifier.QuickSight.DataSourceTypes.DatabricksParameters Create()
    {
        var databricksParametersResult = CreateDatabricksParameters();
        factoryAction?.Invoke(databricksParametersResult);

        return databricksParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.DatabricksParameters CreateDatabricksParameters()
    {
        var databricksParametersResult = new Humidifier.QuickSight.DataSourceTypes.DatabricksParameters();

        return databricksParametersResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DataSourceTypes.DatabricksParameters result)
    {
        base.CreateChildren(result);

        result.OAuthParameters ??= OAuthParametersFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceDatabricksParametersFactoryExtensions
{
    public static CombinedResult<InnerDataSourceDatabricksParametersFactory, InnerDataSourceOAuthParametersFactory> WithOAuthParameters(this InnerDataSourceDatabricksParametersFactory parentFactory, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null)
    {
        parentFactory.OAuthParametersFactory = new InnerDataSourceOAuthParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OAuthParametersFactory);
    }

    public static CombinedResult<InnerDataSourceDatabricksParametersFactory, T1, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1>(this CombinedResult<InnerDataSourceDatabricksParametersFactory, T1> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithOAuthParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceDatabricksParametersFactory, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1>(this CombinedResult<T1, InnerDataSourceDatabricksParametersFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithOAuthParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceDatabricksParametersFactory, T1, T2, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2>(this CombinedResult<InnerDataSourceDatabricksParametersFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceDatabricksParametersFactory, T2, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2>(this CombinedResult<T1, InnerDataSourceDatabricksParametersFactory, T2> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceDatabricksParametersFactory, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceDatabricksParametersFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceDatabricksParametersFactory, T1, T2, T3, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3>(this CombinedResult<InnerDataSourceDatabricksParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceDatabricksParametersFactory, T2, T3, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceDatabricksParametersFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceDatabricksParametersFactory, T3, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceDatabricksParametersFactory, T3> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataSourceDatabricksParametersFactory, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceDatabricksParametersFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceDatabricksParametersFactory, T1, T2, T3, T4, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceDatabricksParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceDatabricksParametersFactory, T2, T3, T4, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceDatabricksParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceDatabricksParametersFactory, T3, T4, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceDatabricksParametersFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataSourceDatabricksParametersFactory, T4, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceDatabricksParametersFactory, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceDatabricksParametersFactory, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceDatabricksParametersFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T5, subFactoryAction).T2);
}
