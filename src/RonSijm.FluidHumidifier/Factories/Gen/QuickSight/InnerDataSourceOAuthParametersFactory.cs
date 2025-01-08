// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceOAuthParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.OAuthParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.OAuthParameters>
{

    internal InnerDataSourceVpcConnectionPropertiesFactory IdentityProviderVpcConnectionPropertiesFactory { get; set; }

    protected override Humidifier.QuickSight.DataSourceTypes.OAuthParameters Create()
    {
        var oAuthParametersResult = CreateOAuthParameters();
        factoryAction?.Invoke(oAuthParametersResult);

        return oAuthParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.OAuthParameters CreateOAuthParameters()
    {
        var oAuthParametersResult = new Humidifier.QuickSight.DataSourceTypes.OAuthParameters();

        return oAuthParametersResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DataSourceTypes.OAuthParameters result)
    {
        base.CreateChildren(result);

        result.IdentityProviderVpcConnectionProperties ??= IdentityProviderVpcConnectionPropertiesFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceOAuthParametersFactoryExtensions
{
    public static CombinedResult<InnerDataSourceOAuthParametersFactory, InnerDataSourceVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties(this InnerDataSourceOAuthParametersFactory parentFactory, Action<Humidifier.QuickSight.DataSourceTypes.VpcConnectionProperties> subFactoryAction = null)
    {
        parentFactory.IdentityProviderVpcConnectionPropertiesFactory = new InnerDataSourceVpcConnectionPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdentityProviderVpcConnectionPropertiesFactory);
    }

    public static CombinedResult<InnerDataSourceOAuthParametersFactory, T1, InnerDataSourceVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1>(this CombinedResult<InnerDataSourceOAuthParametersFactory, T1> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.VpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceOAuthParametersFactory, InnerDataSourceVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1>(this CombinedResult<T1, InnerDataSourceOAuthParametersFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.VpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceOAuthParametersFactory, T1, T2, InnerDataSourceVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1, T2>(this CombinedResult<InnerDataSourceOAuthParametersFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.VpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceOAuthParametersFactory, T2, InnerDataSourceVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1, T2>(this CombinedResult<T1, InnerDataSourceOAuthParametersFactory, T2> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.VpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceOAuthParametersFactory, InnerDataSourceVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceOAuthParametersFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.VpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceOAuthParametersFactory, T1, T2, T3, InnerDataSourceVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1, T2, T3>(this CombinedResult<InnerDataSourceOAuthParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.VpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceOAuthParametersFactory, T2, T3, InnerDataSourceVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceOAuthParametersFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.VpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceOAuthParametersFactory, T3, InnerDataSourceVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceOAuthParametersFactory, T3> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.VpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceOAuthParametersFactory, InnerDataSourceVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceOAuthParametersFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.VpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceOAuthParametersFactory, T1, T2, T3, T4, InnerDataSourceVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceOAuthParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.VpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceOAuthParametersFactory, T2, T3, T4, InnerDataSourceVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceOAuthParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.VpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceOAuthParametersFactory, T3, T4, InnerDataSourceVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceOAuthParametersFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.VpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceOAuthParametersFactory, T4, InnerDataSourceVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceOAuthParametersFactory, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.VpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceOAuthParametersFactory, InnerDataSourceVpcConnectionPropertiesFactory> WithIdentityProviderVpcConnectionProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceOAuthParametersFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.VpcConnectionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderVpcConnectionProperties(combinedResult.T5, subFactoryAction));
}
