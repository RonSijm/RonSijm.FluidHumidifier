// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerActionConnectorClientCredentialsDetailsFactory(Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsDetails> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsDetails>
{

    internal InnerActionConnectorClientCredentialsGrantDetailsFactory ClientCredentialsGrantDetailsFactory { get; set; }

    protected override Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsDetails Create()
    {
        var clientCredentialsDetailsResult = CreateClientCredentialsDetails();
        factoryAction?.Invoke(clientCredentialsDetailsResult);

        return clientCredentialsDetailsResult;
    }

    private Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsDetails CreateClientCredentialsDetails()
    {
        var clientCredentialsDetailsResult = new Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsDetails();

        return clientCredentialsDetailsResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsDetails result)
    {
        base.CreateChildren(result);

        result.ClientCredentialsGrantDetails ??= ClientCredentialsGrantDetailsFactory?.Build();
    }

} // End Of Class

public static class InnerActionConnectorClientCredentialsDetailsFactoryExtensions
{
    public static CombinedResult<InnerActionConnectorClientCredentialsDetailsFactory, InnerActionConnectorClientCredentialsGrantDetailsFactory> WithClientCredentialsGrantDetails(this InnerActionConnectorClientCredentialsDetailsFactory parentFactory, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantDetails> subFactoryAction = null)
    {
        parentFactory.ClientCredentialsGrantDetailsFactory = new InnerActionConnectorClientCredentialsGrantDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ClientCredentialsGrantDetailsFactory);
    }

    public static CombinedResult<InnerActionConnectorClientCredentialsDetailsFactory, T1, InnerActionConnectorClientCredentialsGrantDetailsFactory> WithClientCredentialsGrantDetails<T1>(this CombinedResult<InnerActionConnectorClientCredentialsDetailsFactory, T1> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithClientCredentialsGrantDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerActionConnectorClientCredentialsDetailsFactory, InnerActionConnectorClientCredentialsGrantDetailsFactory> WithClientCredentialsGrantDetails<T1>(this CombinedResult<T1, InnerActionConnectorClientCredentialsDetailsFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithClientCredentialsGrantDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerActionConnectorClientCredentialsDetailsFactory, T1, T2, InnerActionConnectorClientCredentialsGrantDetailsFactory> WithClientCredentialsGrantDetails<T1, T2>(this CombinedResult<InnerActionConnectorClientCredentialsDetailsFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientCredentialsGrantDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerActionConnectorClientCredentialsDetailsFactory, T2, InnerActionConnectorClientCredentialsGrantDetailsFactory> WithClientCredentialsGrantDetails<T1, T2>(this CombinedResult<T1, InnerActionConnectorClientCredentialsDetailsFactory, T2> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientCredentialsGrantDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerActionConnectorClientCredentialsDetailsFactory, InnerActionConnectorClientCredentialsGrantDetailsFactory> WithClientCredentialsGrantDetails<T1, T2>(this CombinedResult<T1, T2, InnerActionConnectorClientCredentialsDetailsFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientCredentialsGrantDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerActionConnectorClientCredentialsDetailsFactory, T1, T2, T3, InnerActionConnectorClientCredentialsGrantDetailsFactory> WithClientCredentialsGrantDetails<T1, T2, T3>(this CombinedResult<InnerActionConnectorClientCredentialsDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientCredentialsGrantDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerActionConnectorClientCredentialsDetailsFactory, T2, T3, InnerActionConnectorClientCredentialsGrantDetailsFactory> WithClientCredentialsGrantDetails<T1, T2, T3>(this CombinedResult<T1, InnerActionConnectorClientCredentialsDetailsFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientCredentialsGrantDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerActionConnectorClientCredentialsDetailsFactory, T3, InnerActionConnectorClientCredentialsGrantDetailsFactory> WithClientCredentialsGrantDetails<T1, T2, T3>(this CombinedResult<T1, T2, InnerActionConnectorClientCredentialsDetailsFactory, T3> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientCredentialsGrantDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerActionConnectorClientCredentialsDetailsFactory, InnerActionConnectorClientCredentialsGrantDetailsFactory> WithClientCredentialsGrantDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerActionConnectorClientCredentialsDetailsFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientCredentialsGrantDetails(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerActionConnectorClientCredentialsDetailsFactory, T1, T2, T3, T4, InnerActionConnectorClientCredentialsGrantDetailsFactory> WithClientCredentialsGrantDetails<T1, T2, T3, T4>(this CombinedResult<InnerActionConnectorClientCredentialsDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientCredentialsGrantDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerActionConnectorClientCredentialsDetailsFactory, T2, T3, T4, InnerActionConnectorClientCredentialsGrantDetailsFactory> WithClientCredentialsGrantDetails<T1, T2, T3, T4>(this CombinedResult<T1, InnerActionConnectorClientCredentialsDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientCredentialsGrantDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerActionConnectorClientCredentialsDetailsFactory, T3, T4, InnerActionConnectorClientCredentialsGrantDetailsFactory> WithClientCredentialsGrantDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerActionConnectorClientCredentialsDetailsFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientCredentialsGrantDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerActionConnectorClientCredentialsDetailsFactory, T4, InnerActionConnectorClientCredentialsGrantDetailsFactory> WithClientCredentialsGrantDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerActionConnectorClientCredentialsDetailsFactory, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientCredentialsGrantDetails(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerActionConnectorClientCredentialsDetailsFactory, InnerActionConnectorClientCredentialsGrantDetailsFactory> WithClientCredentialsGrantDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerActionConnectorClientCredentialsDetailsFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientCredentialsGrantDetails(combinedResult.T5, subFactoryAction).T2);
}
