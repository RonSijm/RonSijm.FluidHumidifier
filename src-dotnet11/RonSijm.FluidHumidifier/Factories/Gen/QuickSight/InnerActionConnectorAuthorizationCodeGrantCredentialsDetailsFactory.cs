// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory(Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantCredentialsDetails> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantCredentialsDetails>
{

    internal InnerActionConnectorAuthorizationCodeGrantDetailsFactory AuthorizationCodeGrantDetailsFactory { get; set; }

    protected override Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantCredentialsDetails Create()
    {
        var authorizationCodeGrantCredentialsDetailsResult = CreateAuthorizationCodeGrantCredentialsDetails();
        factoryAction?.Invoke(authorizationCodeGrantCredentialsDetailsResult);

        return authorizationCodeGrantCredentialsDetailsResult;
    }

    private Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantCredentialsDetails CreateAuthorizationCodeGrantCredentialsDetails()
    {
        var authorizationCodeGrantCredentialsDetailsResult = new Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantCredentialsDetails();

        return authorizationCodeGrantCredentialsDetailsResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantCredentialsDetails result)
    {
        base.CreateChildren(result);

        result.AuthorizationCodeGrantDetails ??= AuthorizationCodeGrantDetailsFactory?.Build();
    }

} // End Of Class

public static class InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactoryExtensions
{
    public static CombinedResult<InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, InnerActionConnectorAuthorizationCodeGrantDetailsFactory> WithAuthorizationCodeGrantDetails(this InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory parentFactory, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantDetails> subFactoryAction = null)
    {
        parentFactory.AuthorizationCodeGrantDetailsFactory = new InnerActionConnectorAuthorizationCodeGrantDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthorizationCodeGrantDetailsFactory);
    }

    public static CombinedResult<InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, T1, InnerActionConnectorAuthorizationCodeGrantDetailsFactory> WithAuthorizationCodeGrantDetails<T1>(this CombinedResult<InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, T1> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationCodeGrantDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, InnerActionConnectorAuthorizationCodeGrantDetailsFactory> WithAuthorizationCodeGrantDetails<T1>(this CombinedResult<T1, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationCodeGrantDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, T1, T2, InnerActionConnectorAuthorizationCodeGrantDetailsFactory> WithAuthorizationCodeGrantDetails<T1, T2>(this CombinedResult<InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationCodeGrantDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, T2, InnerActionConnectorAuthorizationCodeGrantDetailsFactory> WithAuthorizationCodeGrantDetails<T1, T2>(this CombinedResult<T1, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, T2> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationCodeGrantDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, InnerActionConnectorAuthorizationCodeGrantDetailsFactory> WithAuthorizationCodeGrantDetails<T1, T2>(this CombinedResult<T1, T2, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationCodeGrantDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, T1, T2, T3, InnerActionConnectorAuthorizationCodeGrantDetailsFactory> WithAuthorizationCodeGrantDetails<T1, T2, T3>(this CombinedResult<InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationCodeGrantDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, T2, T3, InnerActionConnectorAuthorizationCodeGrantDetailsFactory> WithAuthorizationCodeGrantDetails<T1, T2, T3>(this CombinedResult<T1, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationCodeGrantDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, T3, InnerActionConnectorAuthorizationCodeGrantDetailsFactory> WithAuthorizationCodeGrantDetails<T1, T2, T3>(this CombinedResult<T1, T2, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, T3> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationCodeGrantDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, InnerActionConnectorAuthorizationCodeGrantDetailsFactory> WithAuthorizationCodeGrantDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationCodeGrantDetails(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, T1, T2, T3, T4, InnerActionConnectorAuthorizationCodeGrantDetailsFactory> WithAuthorizationCodeGrantDetails<T1, T2, T3, T4>(this CombinedResult<InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationCodeGrantDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, T2, T3, T4, InnerActionConnectorAuthorizationCodeGrantDetailsFactory> WithAuthorizationCodeGrantDetails<T1, T2, T3, T4>(this CombinedResult<T1, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationCodeGrantDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, T3, T4, InnerActionConnectorAuthorizationCodeGrantDetailsFactory> WithAuthorizationCodeGrantDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationCodeGrantDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, T4, InnerActionConnectorAuthorizationCodeGrantDetailsFactory> WithAuthorizationCodeGrantDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationCodeGrantDetails(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory, InnerActionConnectorAuthorizationCodeGrantDetailsFactory> WithAuthorizationCodeGrantDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerActionConnectorAuthorizationCodeGrantCredentialsDetailsFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationCodeGrantDetails(combinedResult.T5, subFactoryAction).T2);
}
