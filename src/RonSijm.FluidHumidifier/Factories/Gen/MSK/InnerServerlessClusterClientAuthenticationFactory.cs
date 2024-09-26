// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerServerlessClusterClientAuthenticationFactory(Action<Humidifier.MSK.ServerlessClusterTypes.ClientAuthentication> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ServerlessClusterTypes.ClientAuthentication>
{

    internal InnerServerlessClusterSaslFactory SaslFactory { get; set; }

    protected override Humidifier.MSK.ServerlessClusterTypes.ClientAuthentication Create()
    {
        var clientAuthenticationResult = CreateClientAuthentication();
        factoryAction?.Invoke(clientAuthenticationResult);

        return clientAuthenticationResult;
    }

    private Humidifier.MSK.ServerlessClusterTypes.ClientAuthentication CreateClientAuthentication()
    {
        var clientAuthenticationResult = new Humidifier.MSK.ServerlessClusterTypes.ClientAuthentication();

        return clientAuthenticationResult;
    }
    public override void CreateChildren(Humidifier.MSK.ServerlessClusterTypes.ClientAuthentication result)
    {
        base.CreateChildren(result);

        result.Sasl ??= SaslFactory?.Build();
    }

} // End Of Class

public static class InnerServerlessClusterClientAuthenticationFactoryExtensions
{
    public static CombinedResult<InnerServerlessClusterClientAuthenticationFactory, InnerServerlessClusterSaslFactory> WithSasl(this InnerServerlessClusterClientAuthenticationFactory parentFactory, Action<Humidifier.MSK.ServerlessClusterTypes.Sasl> subFactoryAction = null)
    {
        parentFactory.SaslFactory = new InnerServerlessClusterSaslFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SaslFactory);
    }

    public static CombinedResult<InnerServerlessClusterClientAuthenticationFactory, T1, InnerServerlessClusterSaslFactory> WithSasl<T1>(this CombinedResult<InnerServerlessClusterClientAuthenticationFactory, T1> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, WithSasl(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServerlessClusterClientAuthenticationFactory, InnerServerlessClusterSaslFactory> WithSasl<T1>(this CombinedResult<T1, InnerServerlessClusterClientAuthenticationFactory> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, WithSasl(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerServerlessClusterClientAuthenticationFactory, T1, T2, InnerServerlessClusterSaslFactory> WithSasl<T1, T2>(this CombinedResult<InnerServerlessClusterClientAuthenticationFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServerlessClusterClientAuthenticationFactory, T2, InnerServerlessClusterSaslFactory> WithSasl<T1, T2>(this CombinedResult<T1, InnerServerlessClusterClientAuthenticationFactory, T2> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServerlessClusterClientAuthenticationFactory, InnerServerlessClusterSaslFactory> WithSasl<T1, T2>(this CombinedResult<T1, T2, InnerServerlessClusterClientAuthenticationFactory> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerServerlessClusterClientAuthenticationFactory, T1, T2, T3, InnerServerlessClusterSaslFactory> WithSasl<T1, T2, T3>(this CombinedResult<InnerServerlessClusterClientAuthenticationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServerlessClusterClientAuthenticationFactory, T2, T3, InnerServerlessClusterSaslFactory> WithSasl<T1, T2, T3>(this CombinedResult<T1, InnerServerlessClusterClientAuthenticationFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServerlessClusterClientAuthenticationFactory, T3, InnerServerlessClusterSaslFactory> WithSasl<T1, T2, T3>(this CombinedResult<T1, T2, InnerServerlessClusterClientAuthenticationFactory, T3> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServerlessClusterClientAuthenticationFactory, InnerServerlessClusterSaslFactory> WithSasl<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServerlessClusterClientAuthenticationFactory> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerServerlessClusterClientAuthenticationFactory, T1, T2, T3, T4, InnerServerlessClusterSaslFactory> WithSasl<T1, T2, T3, T4>(this CombinedResult<InnerServerlessClusterClientAuthenticationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServerlessClusterClientAuthenticationFactory, T2, T3, T4, InnerServerlessClusterSaslFactory> WithSasl<T1, T2, T3, T4>(this CombinedResult<T1, InnerServerlessClusterClientAuthenticationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServerlessClusterClientAuthenticationFactory, T3, T4, InnerServerlessClusterSaslFactory> WithSasl<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServerlessClusterClientAuthenticationFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServerlessClusterClientAuthenticationFactory, T4, InnerServerlessClusterSaslFactory> WithSasl<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServerlessClusterClientAuthenticationFactory, T4> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerServerlessClusterClientAuthenticationFactory, InnerServerlessClusterSaslFactory> WithSasl<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServerlessClusterClientAuthenticationFactory> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Sasl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSasl(combinedResult.T5, subFactoryAction));
}
