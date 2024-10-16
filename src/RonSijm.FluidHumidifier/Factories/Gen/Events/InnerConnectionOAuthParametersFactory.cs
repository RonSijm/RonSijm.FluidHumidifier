// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerConnectionOAuthParametersFactory(Action<Humidifier.Events.ConnectionTypes.OAuthParameters> factoryAction = null) : SubResourceFactory<Humidifier.Events.ConnectionTypes.OAuthParameters>
{

    internal InnerConnectionClientParametersFactory ClientParametersFactory { get; set; }

    internal InnerConnectionConnectionHttpParametersFactory OAuthHttpParametersFactory { get; set; }

    protected override Humidifier.Events.ConnectionTypes.OAuthParameters Create()
    {
        var oAuthParametersResult = CreateOAuthParameters();
        factoryAction?.Invoke(oAuthParametersResult);

        return oAuthParametersResult;
    }

    private Humidifier.Events.ConnectionTypes.OAuthParameters CreateOAuthParameters()
    {
        var oAuthParametersResult = new Humidifier.Events.ConnectionTypes.OAuthParameters();

        return oAuthParametersResult;
    }
    public override void CreateChildren(Humidifier.Events.ConnectionTypes.OAuthParameters result)
    {
        base.CreateChildren(result);

        result.ClientParameters ??= ClientParametersFactory?.Build();
        result.OAuthHttpParameters ??= OAuthHttpParametersFactory?.Build();
    }

} // End Of Class

public static class InnerConnectionOAuthParametersFactoryExtensions
{
    public static CombinedResult<InnerConnectionOAuthParametersFactory, InnerConnectionClientParametersFactory> WithClientParameters(this InnerConnectionOAuthParametersFactory parentFactory, Action<Humidifier.Events.ConnectionTypes.ClientParameters> subFactoryAction = null)
    {
        parentFactory.ClientParametersFactory = new InnerConnectionClientParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ClientParametersFactory);
    }

    public static CombinedResult<InnerConnectionOAuthParametersFactory, InnerConnectionConnectionHttpParametersFactory> WithOAuthHttpParameters(this InnerConnectionOAuthParametersFactory parentFactory, Action<Humidifier.Events.ConnectionTypes.ConnectionHttpParameters> subFactoryAction = null)
    {
        parentFactory.OAuthHttpParametersFactory = new InnerConnectionConnectionHttpParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OAuthHttpParametersFactory);
    }

    public static CombinedResult<InnerConnectionOAuthParametersFactory, T1, InnerConnectionClientParametersFactory> WithClientParameters<T1>(this CombinedResult<InnerConnectionOAuthParametersFactory, T1> combinedResult, Action<Humidifier.Events.ConnectionTypes.ClientParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithClientParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectionOAuthParametersFactory, InnerConnectionClientParametersFactory> WithClientParameters<T1>(this CombinedResult<T1, InnerConnectionOAuthParametersFactory> combinedResult, Action<Humidifier.Events.ConnectionTypes.ClientParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithClientParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectionOAuthParametersFactory, T1, T2, InnerConnectionClientParametersFactory> WithClientParameters<T1, T2>(this CombinedResult<InnerConnectionOAuthParametersFactory, T1, T2> combinedResult, Action<Humidifier.Events.ConnectionTypes.ClientParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectionOAuthParametersFactory, T2, InnerConnectionClientParametersFactory> WithClientParameters<T1, T2>(this CombinedResult<T1, InnerConnectionOAuthParametersFactory, T2> combinedResult, Action<Humidifier.Events.ConnectionTypes.ClientParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectionOAuthParametersFactory, InnerConnectionClientParametersFactory> WithClientParameters<T1, T2>(this CombinedResult<T1, T2, InnerConnectionOAuthParametersFactory> combinedResult, Action<Humidifier.Events.ConnectionTypes.ClientParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectionOAuthParametersFactory, T1, T2, T3, InnerConnectionClientParametersFactory> WithClientParameters<T1, T2, T3>(this CombinedResult<InnerConnectionOAuthParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.Events.ConnectionTypes.ClientParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectionOAuthParametersFactory, T2, T3, InnerConnectionClientParametersFactory> WithClientParameters<T1, T2, T3>(this CombinedResult<T1, InnerConnectionOAuthParametersFactory, T2, T3> combinedResult, Action<Humidifier.Events.ConnectionTypes.ClientParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectionOAuthParametersFactory, T3, InnerConnectionClientParametersFactory> WithClientParameters<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectionOAuthParametersFactory, T3> combinedResult, Action<Humidifier.Events.ConnectionTypes.ClientParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectionOAuthParametersFactory, InnerConnectionClientParametersFactory> WithClientParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectionOAuthParametersFactory> combinedResult, Action<Humidifier.Events.ConnectionTypes.ClientParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectionOAuthParametersFactory, T1, T2, T3, T4, InnerConnectionClientParametersFactory> WithClientParameters<T1, T2, T3, T4>(this CombinedResult<InnerConnectionOAuthParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Events.ConnectionTypes.ClientParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectionOAuthParametersFactory, T2, T3, T4, InnerConnectionClientParametersFactory> WithClientParameters<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectionOAuthParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.Events.ConnectionTypes.ClientParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectionOAuthParametersFactory, T3, T4, InnerConnectionClientParametersFactory> WithClientParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectionOAuthParametersFactory, T3, T4> combinedResult, Action<Humidifier.Events.ConnectionTypes.ClientParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectionOAuthParametersFactory, T4, InnerConnectionClientParametersFactory> WithClientParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectionOAuthParametersFactory, T4> combinedResult, Action<Humidifier.Events.ConnectionTypes.ClientParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectionOAuthParametersFactory, InnerConnectionClientParametersFactory> WithClientParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectionOAuthParametersFactory> combinedResult, Action<Humidifier.Events.ConnectionTypes.ClientParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientParameters(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerConnectionOAuthParametersFactory, T1, InnerConnectionConnectionHttpParametersFactory> WithOAuthHttpParameters<T1>(this CombinedResult<InnerConnectionOAuthParametersFactory, T1> combinedResult, Action<Humidifier.Events.ConnectionTypes.ConnectionHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithOAuthHttpParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectionOAuthParametersFactory, InnerConnectionConnectionHttpParametersFactory> WithOAuthHttpParameters<T1>(this CombinedResult<T1, InnerConnectionOAuthParametersFactory> combinedResult, Action<Humidifier.Events.ConnectionTypes.ConnectionHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithOAuthHttpParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectionOAuthParametersFactory, T1, T2, InnerConnectionConnectionHttpParametersFactory> WithOAuthHttpParameters<T1, T2>(this CombinedResult<InnerConnectionOAuthParametersFactory, T1, T2> combinedResult, Action<Humidifier.Events.ConnectionTypes.ConnectionHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthHttpParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectionOAuthParametersFactory, T2, InnerConnectionConnectionHttpParametersFactory> WithOAuthHttpParameters<T1, T2>(this CombinedResult<T1, InnerConnectionOAuthParametersFactory, T2> combinedResult, Action<Humidifier.Events.ConnectionTypes.ConnectionHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthHttpParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectionOAuthParametersFactory, InnerConnectionConnectionHttpParametersFactory> WithOAuthHttpParameters<T1, T2>(this CombinedResult<T1, T2, InnerConnectionOAuthParametersFactory> combinedResult, Action<Humidifier.Events.ConnectionTypes.ConnectionHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthHttpParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectionOAuthParametersFactory, T1, T2, T3, InnerConnectionConnectionHttpParametersFactory> WithOAuthHttpParameters<T1, T2, T3>(this CombinedResult<InnerConnectionOAuthParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.Events.ConnectionTypes.ConnectionHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthHttpParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectionOAuthParametersFactory, T2, T3, InnerConnectionConnectionHttpParametersFactory> WithOAuthHttpParameters<T1, T2, T3>(this CombinedResult<T1, InnerConnectionOAuthParametersFactory, T2, T3> combinedResult, Action<Humidifier.Events.ConnectionTypes.ConnectionHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthHttpParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectionOAuthParametersFactory, T3, InnerConnectionConnectionHttpParametersFactory> WithOAuthHttpParameters<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectionOAuthParametersFactory, T3> combinedResult, Action<Humidifier.Events.ConnectionTypes.ConnectionHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthHttpParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectionOAuthParametersFactory, InnerConnectionConnectionHttpParametersFactory> WithOAuthHttpParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectionOAuthParametersFactory> combinedResult, Action<Humidifier.Events.ConnectionTypes.ConnectionHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthHttpParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectionOAuthParametersFactory, T1, T2, T3, T4, InnerConnectionConnectionHttpParametersFactory> WithOAuthHttpParameters<T1, T2, T3, T4>(this CombinedResult<InnerConnectionOAuthParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Events.ConnectionTypes.ConnectionHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthHttpParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectionOAuthParametersFactory, T2, T3, T4, InnerConnectionConnectionHttpParametersFactory> WithOAuthHttpParameters<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectionOAuthParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.Events.ConnectionTypes.ConnectionHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthHttpParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectionOAuthParametersFactory, T3, T4, InnerConnectionConnectionHttpParametersFactory> WithOAuthHttpParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectionOAuthParametersFactory, T3, T4> combinedResult, Action<Humidifier.Events.ConnectionTypes.ConnectionHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthHttpParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectionOAuthParametersFactory, T4, InnerConnectionConnectionHttpParametersFactory> WithOAuthHttpParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectionOAuthParametersFactory, T4> combinedResult, Action<Humidifier.Events.ConnectionTypes.ConnectionHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthHttpParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectionOAuthParametersFactory, InnerConnectionConnectionHttpParametersFactory> WithOAuthHttpParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectionOAuthParametersFactory> combinedResult, Action<Humidifier.Events.ConnectionTypes.ConnectionHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthHttpParameters(combinedResult.T5, subFactoryAction));
}
