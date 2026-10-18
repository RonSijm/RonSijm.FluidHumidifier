// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolDomainRoutingTypeFactory(Action<Humidifier.Cognito.UserPoolDomainTypes.RoutingType> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolDomainTypes.RoutingType>
{

    internal InnerUserPoolDomainFailoverTypeFactory FailoverFactory { get; set; }

    protected override Humidifier.Cognito.UserPoolDomainTypes.RoutingType Create()
    {
        var routingTypeResult = CreateRoutingType();
        factoryAction?.Invoke(routingTypeResult);

        return routingTypeResult;
    }

    private Humidifier.Cognito.UserPoolDomainTypes.RoutingType CreateRoutingType()
    {
        var routingTypeResult = new Humidifier.Cognito.UserPoolDomainTypes.RoutingType();

        return routingTypeResult;
    }
    public override void CreateChildren(Humidifier.Cognito.UserPoolDomainTypes.RoutingType result)
    {
        base.CreateChildren(result);

        result.Failover ??= FailoverFactory?.Build();
    }

} // End Of Class

public static class InnerUserPoolDomainRoutingTypeFactoryExtensions
{
    public static CombinedResult<InnerUserPoolDomainRoutingTypeFactory, InnerUserPoolDomainFailoverTypeFactory> WithFailover(this InnerUserPoolDomainRoutingTypeFactory parentFactory, Action<Humidifier.Cognito.UserPoolDomainTypes.FailoverType> subFactoryAction = null)
    {
        parentFactory.FailoverFactory = new InnerUserPoolDomainFailoverTypeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FailoverFactory);
    }

    public static CombinedResult<InnerUserPoolDomainRoutingTypeFactory, T1, InnerUserPoolDomainFailoverTypeFactory> WithFailover<T1>(this CombinedResult<InnerUserPoolDomainRoutingTypeFactory, T1> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.FailoverType> subFactoryAction = null) => new (combinedResult, combinedResult, WithFailover(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerUserPoolDomainRoutingTypeFactory, InnerUserPoolDomainFailoverTypeFactory> WithFailover<T1>(this CombinedResult<T1, InnerUserPoolDomainRoutingTypeFactory> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.FailoverType> subFactoryAction = null) => new (combinedResult, combinedResult, WithFailover(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerUserPoolDomainRoutingTypeFactory, T1, T2, InnerUserPoolDomainFailoverTypeFactory> WithFailover<T1, T2>(this CombinedResult<InnerUserPoolDomainRoutingTypeFactory, T1, T2> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.FailoverType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFailover(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerUserPoolDomainRoutingTypeFactory, T2, InnerUserPoolDomainFailoverTypeFactory> WithFailover<T1, T2>(this CombinedResult<T1, InnerUserPoolDomainRoutingTypeFactory, T2> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.FailoverType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFailover(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerUserPoolDomainRoutingTypeFactory, InnerUserPoolDomainFailoverTypeFactory> WithFailover<T1, T2>(this CombinedResult<T1, T2, InnerUserPoolDomainRoutingTypeFactory> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.FailoverType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFailover(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerUserPoolDomainRoutingTypeFactory, T1, T2, T3, InnerUserPoolDomainFailoverTypeFactory> WithFailover<T1, T2, T3>(this CombinedResult<InnerUserPoolDomainRoutingTypeFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.FailoverType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFailover(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerUserPoolDomainRoutingTypeFactory, T2, T3, InnerUserPoolDomainFailoverTypeFactory> WithFailover<T1, T2, T3>(this CombinedResult<T1, InnerUserPoolDomainRoutingTypeFactory, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.FailoverType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFailover(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerUserPoolDomainRoutingTypeFactory, T3, InnerUserPoolDomainFailoverTypeFactory> WithFailover<T1, T2, T3>(this CombinedResult<T1, T2, InnerUserPoolDomainRoutingTypeFactory, T3> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.FailoverType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFailover(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerUserPoolDomainRoutingTypeFactory, InnerUserPoolDomainFailoverTypeFactory> WithFailover<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerUserPoolDomainRoutingTypeFactory> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.FailoverType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFailover(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerUserPoolDomainRoutingTypeFactory, T1, T2, T3, T4, InnerUserPoolDomainFailoverTypeFactory> WithFailover<T1, T2, T3, T4>(this CombinedResult<InnerUserPoolDomainRoutingTypeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.FailoverType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFailover(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerUserPoolDomainRoutingTypeFactory, T2, T3, T4, InnerUserPoolDomainFailoverTypeFactory> WithFailover<T1, T2, T3, T4>(this CombinedResult<T1, InnerUserPoolDomainRoutingTypeFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.FailoverType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFailover(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerUserPoolDomainRoutingTypeFactory, T3, T4, InnerUserPoolDomainFailoverTypeFactory> WithFailover<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerUserPoolDomainRoutingTypeFactory, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.FailoverType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFailover(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerUserPoolDomainRoutingTypeFactory, T4, InnerUserPoolDomainFailoverTypeFactory> WithFailover<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerUserPoolDomainRoutingTypeFactory, T4> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.FailoverType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFailover(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerUserPoolDomainRoutingTypeFactory, InnerUserPoolDomainFailoverTypeFactory> WithFailover<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerUserPoolDomainRoutingTypeFactory> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.FailoverType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFailover(combinedResult.T5, subFactoryAction).T2);
}
