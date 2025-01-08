// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceStarburstParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.StarburstParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.StarburstParameters>
{

    internal InnerDataSourceOAuthParametersFactory OAuthParametersFactory { get; set; }

    protected override Humidifier.QuickSight.DataSourceTypes.StarburstParameters Create()
    {
        var starburstParametersResult = CreateStarburstParameters();
        factoryAction?.Invoke(starburstParametersResult);

        return starburstParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.StarburstParameters CreateStarburstParameters()
    {
        var starburstParametersResult = new Humidifier.QuickSight.DataSourceTypes.StarburstParameters();

        return starburstParametersResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DataSourceTypes.StarburstParameters result)
    {
        base.CreateChildren(result);

        result.OAuthParameters ??= OAuthParametersFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceStarburstParametersFactoryExtensions
{
    public static CombinedResult<InnerDataSourceStarburstParametersFactory, InnerDataSourceOAuthParametersFactory> WithOAuthParameters(this InnerDataSourceStarburstParametersFactory parentFactory, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null)
    {
        parentFactory.OAuthParametersFactory = new InnerDataSourceOAuthParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OAuthParametersFactory);
    }

    public static CombinedResult<InnerDataSourceStarburstParametersFactory, T1, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1>(this CombinedResult<InnerDataSourceStarburstParametersFactory, T1> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithOAuthParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceStarburstParametersFactory, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1>(this CombinedResult<T1, InnerDataSourceStarburstParametersFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithOAuthParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceStarburstParametersFactory, T1, T2, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2>(this CombinedResult<InnerDataSourceStarburstParametersFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceStarburstParametersFactory, T2, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2>(this CombinedResult<T1, InnerDataSourceStarburstParametersFactory, T2> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceStarburstParametersFactory, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceStarburstParametersFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceStarburstParametersFactory, T1, T2, T3, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3>(this CombinedResult<InnerDataSourceStarburstParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceStarburstParametersFactory, T2, T3, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceStarburstParametersFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceStarburstParametersFactory, T3, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceStarburstParametersFactory, T3> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceStarburstParametersFactory, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceStarburstParametersFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceStarburstParametersFactory, T1, T2, T3, T4, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceStarburstParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceStarburstParametersFactory, T2, T3, T4, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceStarburstParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceStarburstParametersFactory, T3, T4, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceStarburstParametersFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceStarburstParametersFactory, T4, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceStarburstParametersFactory, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceStarburstParametersFactory, InnerDataSourceOAuthParametersFactory> WithOAuthParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceStarburstParametersFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthParameters(combinedResult.T5, subFactoryAction));
}
