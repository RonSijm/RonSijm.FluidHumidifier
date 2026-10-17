// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerWebAppEndpointDetailsFactory(Action<Humidifier.Transfer.WebAppTypes.EndpointDetails> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.WebAppTypes.EndpointDetails>
{

    internal InnerWebAppVpcFactory VpcFactory { get; set; }

    protected override Humidifier.Transfer.WebAppTypes.EndpointDetails Create()
    {
        var endpointDetailsResult = CreateEndpointDetails();
        factoryAction?.Invoke(endpointDetailsResult);

        return endpointDetailsResult;
    }

    private Humidifier.Transfer.WebAppTypes.EndpointDetails CreateEndpointDetails()
    {
        var endpointDetailsResult = new Humidifier.Transfer.WebAppTypes.EndpointDetails();

        return endpointDetailsResult;
    }
    public override void CreateChildren(Humidifier.Transfer.WebAppTypes.EndpointDetails result)
    {
        base.CreateChildren(result);

        result.Vpc ??= VpcFactory?.Build();
    }

} // End Of Class

public static class InnerWebAppEndpointDetailsFactoryExtensions
{
    public static CombinedResult<InnerWebAppEndpointDetailsFactory, InnerWebAppVpcFactory> WithVpc(this InnerWebAppEndpointDetailsFactory parentFactory, Action<Humidifier.Transfer.WebAppTypes.Vpc> subFactoryAction = null)
    {
        parentFactory.VpcFactory = new InnerWebAppVpcFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcFactory);
    }

    public static CombinedResult<InnerWebAppEndpointDetailsFactory, T1, InnerWebAppVpcFactory> WithVpc<T1>(this CombinedResult<InnerWebAppEndpointDetailsFactory, T1> combinedResult, Action<Humidifier.Transfer.WebAppTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpc(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebAppEndpointDetailsFactory, InnerWebAppVpcFactory> WithVpc<T1>(this CombinedResult<T1, InnerWebAppEndpointDetailsFactory> combinedResult, Action<Humidifier.Transfer.WebAppTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpc(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerWebAppEndpointDetailsFactory, T1, T2, InnerWebAppVpcFactory> WithVpc<T1, T2>(this CombinedResult<InnerWebAppEndpointDetailsFactory, T1, T2> combinedResult, Action<Humidifier.Transfer.WebAppTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebAppEndpointDetailsFactory, T2, InnerWebAppVpcFactory> WithVpc<T1, T2>(this CombinedResult<T1, InnerWebAppEndpointDetailsFactory, T2> combinedResult, Action<Humidifier.Transfer.WebAppTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWebAppEndpointDetailsFactory, InnerWebAppVpcFactory> WithVpc<T1, T2>(this CombinedResult<T1, T2, InnerWebAppEndpointDetailsFactory> combinedResult, Action<Humidifier.Transfer.WebAppTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerWebAppEndpointDetailsFactory, T1, T2, T3, InnerWebAppVpcFactory> WithVpc<T1, T2, T3>(this CombinedResult<InnerWebAppEndpointDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Transfer.WebAppTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebAppEndpointDetailsFactory, T2, T3, InnerWebAppVpcFactory> WithVpc<T1, T2, T3>(this CombinedResult<T1, InnerWebAppEndpointDetailsFactory, T2, T3> combinedResult, Action<Humidifier.Transfer.WebAppTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWebAppEndpointDetailsFactory, T3, InnerWebAppVpcFactory> WithVpc<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebAppEndpointDetailsFactory, T3> combinedResult, Action<Humidifier.Transfer.WebAppTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWebAppEndpointDetailsFactory, InnerWebAppVpcFactory> WithVpc<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebAppEndpointDetailsFactory> combinedResult, Action<Humidifier.Transfer.WebAppTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerWebAppEndpointDetailsFactory, T1, T2, T3, T4, InnerWebAppVpcFactory> WithVpc<T1, T2, T3, T4>(this CombinedResult<InnerWebAppEndpointDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.WebAppTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebAppEndpointDetailsFactory, T2, T3, T4, InnerWebAppVpcFactory> WithVpc<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebAppEndpointDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.WebAppTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWebAppEndpointDetailsFactory, T3, T4, InnerWebAppVpcFactory> WithVpc<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebAppEndpointDetailsFactory, T3, T4> combinedResult, Action<Humidifier.Transfer.WebAppTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWebAppEndpointDetailsFactory, T4, InnerWebAppVpcFactory> WithVpc<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebAppEndpointDetailsFactory, T4> combinedResult, Action<Humidifier.Transfer.WebAppTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerWebAppEndpointDetailsFactory, InnerWebAppVpcFactory> WithVpc<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebAppEndpointDetailsFactory> combinedResult, Action<Humidifier.Transfer.WebAppTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T5, subFactoryAction).T2);
}
