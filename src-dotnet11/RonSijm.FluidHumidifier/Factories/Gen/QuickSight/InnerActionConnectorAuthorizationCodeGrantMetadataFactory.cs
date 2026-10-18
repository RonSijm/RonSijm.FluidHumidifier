// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerActionConnectorAuthorizationCodeGrantMetadataFactory(Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantMetadata> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantMetadata>
{

    internal InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory AuthorizationCodeGrantCredentialsDetailsFactory { get; set; }

    protected override Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantMetadata Create()
    {
        var authorizationCodeGrantMetadataResult = CreateAuthorizationCodeGrantMetadata();
        factoryAction?.Invoke(authorizationCodeGrantMetadataResult);

        return authorizationCodeGrantMetadataResult;
    }

    private Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantMetadata CreateAuthorizationCodeGrantMetadata()
    {
        var authorizationCodeGrantMetadataResult = new Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantMetadata();

        return authorizationCodeGrantMetadataResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantMetadata result)
    {
        base.CreateChildren(result);

        result.AuthorizationCodeGrantCredentialsDetails ??= AuthorizationCodeGrantCredentialsDetailsFactory?.Build();
    }

} // End Of Class

public static class InnerActionConnectorAuthorizationCodeGrantMetadataFactoryExtensions
{
    public static CombinedResult<InnerActionConnectorAuthorizationCodeGrantMetadataFactory, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory> WithAuthorizationCodeGrantCredentialsDetails(this InnerActionConnectorAuthorizationCodeGrantMetadataFactory parentFactory, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantCredentialsDetails> subFactoryAction = null)
    {
        parentFactory.AuthorizationCodeGrantCredentialsDetailsFactory = new InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthorizationCodeGrantCredentialsDetailsFactory);
    }

    public static CombinedResult<InnerActionConnectorAuthorizationCodeGrantMetadataFactory, T1, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory> WithAuthorizationCodeGrantCredentialsDetails<T1>(this CombinedResult<InnerActionConnectorAuthorizationCodeGrantMetadataFactory, T1> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationCodeGrantCredentialsDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerActionConnectorAuthorizationCodeGrantMetadataFactory, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory> WithAuthorizationCodeGrantCredentialsDetails<T1>(this CombinedResult<T1, InnerActionConnectorAuthorizationCodeGrantMetadataFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationCodeGrantCredentialsDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerActionConnectorAuthorizationCodeGrantMetadataFactory, T1, T2, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory> WithAuthorizationCodeGrantCredentialsDetails<T1, T2>(this CombinedResult<InnerActionConnectorAuthorizationCodeGrantMetadataFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationCodeGrantCredentialsDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerActionConnectorAuthorizationCodeGrantMetadataFactory, T2, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory> WithAuthorizationCodeGrantCredentialsDetails<T1, T2>(this CombinedResult<T1, InnerActionConnectorAuthorizationCodeGrantMetadataFactory, T2> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationCodeGrantCredentialsDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerActionConnectorAuthorizationCodeGrantMetadataFactory, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory> WithAuthorizationCodeGrantCredentialsDetails<T1, T2>(this CombinedResult<T1, T2, InnerActionConnectorAuthorizationCodeGrantMetadataFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationCodeGrantCredentialsDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerActionConnectorAuthorizationCodeGrantMetadataFactory, T1, T2, T3, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory> WithAuthorizationCodeGrantCredentialsDetails<T1, T2, T3>(this CombinedResult<InnerActionConnectorAuthorizationCodeGrantMetadataFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationCodeGrantCredentialsDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerActionConnectorAuthorizationCodeGrantMetadataFactory, T2, T3, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory> WithAuthorizationCodeGrantCredentialsDetails<T1, T2, T3>(this CombinedResult<T1, InnerActionConnectorAuthorizationCodeGrantMetadataFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationCodeGrantCredentialsDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerActionConnectorAuthorizationCodeGrantMetadataFactory, T3, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory> WithAuthorizationCodeGrantCredentialsDetails<T1, T2, T3>(this CombinedResult<T1, T2, InnerActionConnectorAuthorizationCodeGrantMetadataFactory, T3> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationCodeGrantCredentialsDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerActionConnectorAuthorizationCodeGrantMetadataFactory, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory> WithAuthorizationCodeGrantCredentialsDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerActionConnectorAuthorizationCodeGrantMetadataFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationCodeGrantCredentialsDetails(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerActionConnectorAuthorizationCodeGrantMetadataFactory, T1, T2, T3, T4, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory> WithAuthorizationCodeGrantCredentialsDetails<T1, T2, T3, T4>(this CombinedResult<InnerActionConnectorAuthorizationCodeGrantMetadataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationCodeGrantCredentialsDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerActionConnectorAuthorizationCodeGrantMetadataFactory, T2, T3, T4, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory> WithAuthorizationCodeGrantCredentialsDetails<T1, T2, T3, T4>(this CombinedResult<T1, InnerActionConnectorAuthorizationCodeGrantMetadataFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationCodeGrantCredentialsDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerActionConnectorAuthorizationCodeGrantMetadataFactory, T3, T4, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory> WithAuthorizationCodeGrantCredentialsDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerActionConnectorAuthorizationCodeGrantMetadataFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationCodeGrantCredentialsDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerActionConnectorAuthorizationCodeGrantMetadataFactory, T4, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory> WithAuthorizationCodeGrantCredentialsDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerActionConnectorAuthorizationCodeGrantMetadataFactory, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationCodeGrantCredentialsDetails(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerActionConnectorAuthorizationCodeGrantMetadataFactory, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory> WithAuthorizationCodeGrantCredentialsDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerActionConnectorAuthorizationCodeGrantMetadataFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationCodeGrantCredentialsDetails(combinedResult.T5, subFactoryAction).T2);
}
