// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerActionConnectorAuthConfigFactory(Action<Humidifier.QuickSight.ActionConnectorTypes.AuthConfig> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ActionConnectorTypes.AuthConfig>
{

    internal InnerActionConnectorAuthenticationMetadataFactory AuthenticationMetadataFactory { get; set; }

    protected override Humidifier.QuickSight.ActionConnectorTypes.AuthConfig Create()
    {
        var authConfigResult = CreateAuthConfig();
        factoryAction?.Invoke(authConfigResult);

        return authConfigResult;
    }

    private Humidifier.QuickSight.ActionConnectorTypes.AuthConfig CreateAuthConfig()
    {
        var authConfigResult = new Humidifier.QuickSight.ActionConnectorTypes.AuthConfig();

        return authConfigResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.ActionConnectorTypes.AuthConfig result)
    {
        base.CreateChildren(result);

        result.AuthenticationMetadata ??= AuthenticationMetadataFactory?.Build();
    }

} // End Of Class

public static class InnerActionConnectorAuthConfigFactoryExtensions
{
    public static CombinedResult<InnerActionConnectorAuthConfigFactory, InnerActionConnectorAuthenticationMetadataFactory> WithAuthenticationMetadata(this InnerActionConnectorAuthConfigFactory parentFactory, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthenticationMetadata> subFactoryAction = null)
    {
        parentFactory.AuthenticationMetadataFactory = new InnerActionConnectorAuthenticationMetadataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthenticationMetadataFactory);
    }

    public static CombinedResult<InnerActionConnectorAuthConfigFactory, T1, InnerActionConnectorAuthenticationMetadataFactory> WithAuthenticationMetadata<T1>(this CombinedResult<InnerActionConnectorAuthConfigFactory, T1> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthenticationMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthenticationMetadata(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerActionConnectorAuthConfigFactory, InnerActionConnectorAuthenticationMetadataFactory> WithAuthenticationMetadata<T1>(this CombinedResult<T1, InnerActionConnectorAuthConfigFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthenticationMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthenticationMetadata(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerActionConnectorAuthConfigFactory, T1, T2, InnerActionConnectorAuthenticationMetadataFactory> WithAuthenticationMetadata<T1, T2>(this CombinedResult<InnerActionConnectorAuthConfigFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthenticationMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthenticationMetadata(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerActionConnectorAuthConfigFactory, T2, InnerActionConnectorAuthenticationMetadataFactory> WithAuthenticationMetadata<T1, T2>(this CombinedResult<T1, InnerActionConnectorAuthConfigFactory, T2> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthenticationMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthenticationMetadata(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerActionConnectorAuthConfigFactory, InnerActionConnectorAuthenticationMetadataFactory> WithAuthenticationMetadata<T1, T2>(this CombinedResult<T1, T2, InnerActionConnectorAuthConfigFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthenticationMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthenticationMetadata(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerActionConnectorAuthConfigFactory, T1, T2, T3, InnerActionConnectorAuthenticationMetadataFactory> WithAuthenticationMetadata<T1, T2, T3>(this CombinedResult<InnerActionConnectorAuthConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthenticationMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationMetadata(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerActionConnectorAuthConfigFactory, T2, T3, InnerActionConnectorAuthenticationMetadataFactory> WithAuthenticationMetadata<T1, T2, T3>(this CombinedResult<T1, InnerActionConnectorAuthConfigFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthenticationMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationMetadata(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerActionConnectorAuthConfigFactory, T3, InnerActionConnectorAuthenticationMetadataFactory> WithAuthenticationMetadata<T1, T2, T3>(this CombinedResult<T1, T2, InnerActionConnectorAuthConfigFactory, T3> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthenticationMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationMetadata(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerActionConnectorAuthConfigFactory, InnerActionConnectorAuthenticationMetadataFactory> WithAuthenticationMetadata<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerActionConnectorAuthConfigFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthenticationMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationMetadata(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerActionConnectorAuthConfigFactory, T1, T2, T3, T4, InnerActionConnectorAuthenticationMetadataFactory> WithAuthenticationMetadata<T1, T2, T3, T4>(this CombinedResult<InnerActionConnectorAuthConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthenticationMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationMetadata(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerActionConnectorAuthConfigFactory, T2, T3, T4, InnerActionConnectorAuthenticationMetadataFactory> WithAuthenticationMetadata<T1, T2, T3, T4>(this CombinedResult<T1, InnerActionConnectorAuthConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthenticationMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationMetadata(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerActionConnectorAuthConfigFactory, T3, T4, InnerActionConnectorAuthenticationMetadataFactory> WithAuthenticationMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerActionConnectorAuthConfigFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthenticationMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationMetadata(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerActionConnectorAuthConfigFactory, T4, InnerActionConnectorAuthenticationMetadataFactory> WithAuthenticationMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerActionConnectorAuthConfigFactory, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthenticationMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationMetadata(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerActionConnectorAuthConfigFactory, InnerActionConnectorAuthenticationMetadataFactory> WithAuthenticationMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerActionConnectorAuthConfigFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthenticationMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationMetadata(combinedResult.T5, subFactoryAction).T2);
}
