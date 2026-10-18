// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerActionConnectorClientCredentialsGrantMetadataFactory(Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantMetadata> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantMetadata>
{

    internal InnerActionConnectorClientCredentialsDetailsFactory ClientCredentialsDetailsFactory { get; set; }

    protected override Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantMetadata Create()
    {
        var clientCredentialsGrantMetadataResult = CreateClientCredentialsGrantMetadata();
        factoryAction?.Invoke(clientCredentialsGrantMetadataResult);

        return clientCredentialsGrantMetadataResult;
    }

    private Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantMetadata CreateClientCredentialsGrantMetadata()
    {
        var clientCredentialsGrantMetadataResult = new Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantMetadata();

        return clientCredentialsGrantMetadataResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantMetadata result)
    {
        base.CreateChildren(result);

        result.ClientCredentialsDetails ??= ClientCredentialsDetailsFactory?.Build();
    }

} // End Of Class

public static class InnerActionConnectorClientCredentialsGrantMetadataFactoryExtensions
{
    public static CombinedResult<InnerActionConnectorClientCredentialsGrantMetadataFactory, InnerActionConnectorClientCredentialsDetailsFactory> WithClientCredentialsDetails(this InnerActionConnectorClientCredentialsGrantMetadataFactory parentFactory, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsDetails> subFactoryAction = null)
    {
        parentFactory.ClientCredentialsDetailsFactory = new InnerActionConnectorClientCredentialsDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ClientCredentialsDetailsFactory);
    }

    public static CombinedResult<InnerActionConnectorClientCredentialsGrantMetadataFactory, T1, InnerActionConnectorClientCredentialsDetailsFactory> WithClientCredentialsDetails<T1>(this CombinedResult<InnerActionConnectorClientCredentialsGrantMetadataFactory, T1> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithClientCredentialsDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerActionConnectorClientCredentialsGrantMetadataFactory, InnerActionConnectorClientCredentialsDetailsFactory> WithClientCredentialsDetails<T1>(this CombinedResult<T1, InnerActionConnectorClientCredentialsGrantMetadataFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithClientCredentialsDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerActionConnectorClientCredentialsGrantMetadataFactory, T1, T2, InnerActionConnectorClientCredentialsDetailsFactory> WithClientCredentialsDetails<T1, T2>(this CombinedResult<InnerActionConnectorClientCredentialsGrantMetadataFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientCredentialsDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerActionConnectorClientCredentialsGrantMetadataFactory, T2, InnerActionConnectorClientCredentialsDetailsFactory> WithClientCredentialsDetails<T1, T2>(this CombinedResult<T1, InnerActionConnectorClientCredentialsGrantMetadataFactory, T2> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientCredentialsDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerActionConnectorClientCredentialsGrantMetadataFactory, InnerActionConnectorClientCredentialsDetailsFactory> WithClientCredentialsDetails<T1, T2>(this CombinedResult<T1, T2, InnerActionConnectorClientCredentialsGrantMetadataFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientCredentialsDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerActionConnectorClientCredentialsGrantMetadataFactory, T1, T2, T3, InnerActionConnectorClientCredentialsDetailsFactory> WithClientCredentialsDetails<T1, T2, T3>(this CombinedResult<InnerActionConnectorClientCredentialsGrantMetadataFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientCredentialsDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerActionConnectorClientCredentialsGrantMetadataFactory, T2, T3, InnerActionConnectorClientCredentialsDetailsFactory> WithClientCredentialsDetails<T1, T2, T3>(this CombinedResult<T1, InnerActionConnectorClientCredentialsGrantMetadataFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientCredentialsDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerActionConnectorClientCredentialsGrantMetadataFactory, T3, InnerActionConnectorClientCredentialsDetailsFactory> WithClientCredentialsDetails<T1, T2, T3>(this CombinedResult<T1, T2, InnerActionConnectorClientCredentialsGrantMetadataFactory, T3> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientCredentialsDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerActionConnectorClientCredentialsGrantMetadataFactory, InnerActionConnectorClientCredentialsDetailsFactory> WithClientCredentialsDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerActionConnectorClientCredentialsGrantMetadataFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientCredentialsDetails(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerActionConnectorClientCredentialsGrantMetadataFactory, T1, T2, T3, T4, InnerActionConnectorClientCredentialsDetailsFactory> WithClientCredentialsDetails<T1, T2, T3, T4>(this CombinedResult<InnerActionConnectorClientCredentialsGrantMetadataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientCredentialsDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerActionConnectorClientCredentialsGrantMetadataFactory, T2, T3, T4, InnerActionConnectorClientCredentialsDetailsFactory> WithClientCredentialsDetails<T1, T2, T3, T4>(this CombinedResult<T1, InnerActionConnectorClientCredentialsGrantMetadataFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientCredentialsDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerActionConnectorClientCredentialsGrantMetadataFactory, T3, T4, InnerActionConnectorClientCredentialsDetailsFactory> WithClientCredentialsDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerActionConnectorClientCredentialsGrantMetadataFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientCredentialsDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerActionConnectorClientCredentialsGrantMetadataFactory, T4, InnerActionConnectorClientCredentialsDetailsFactory> WithClientCredentialsDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerActionConnectorClientCredentialsGrantMetadataFactory, T4> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientCredentialsDetails(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerActionConnectorClientCredentialsGrantMetadataFactory, InnerActionConnectorClientCredentialsDetailsFactory> WithClientCredentialsDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerActionConnectorClientCredentialsGrantMetadataFactory> combinedResult, Action<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientCredentialsDetails(combinedResult.T5, subFactoryAction).T2);
}
