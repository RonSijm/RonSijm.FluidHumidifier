// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class MethodFactory(string resourceName = null, Action<Humidifier.ApiGateway.Method> factoryAction = null) : ResourceFactory<Humidifier.ApiGateway.Method>(resourceName)
{

    internal List<InnerMethodMethodResponseFactory> MethodResponsesFactories { get; set; } = [];

    internal InnerMethodIntegrationFactory IntegrationFactory { get; set; }

    protected override Humidifier.ApiGateway.Method Create()
    {
        var methodResult = CreateMethod();
        factoryAction?.Invoke(methodResult);

        return methodResult;
    }

    private Humidifier.ApiGateway.Method CreateMethod()
    {
        var methodResult = new Humidifier.ApiGateway.Method
        {
            GivenName = InputResourceName,
        };

        return methodResult;
    }
    public override void CreateChildren(Humidifier.ApiGateway.Method result)
    {
        base.CreateChildren(result);

        result.MethodResponses = MethodResponsesFactories.Any() ? MethodResponsesFactories.Select(x => x.Build()).ToList() : null;
        result.Integration ??= IntegrationFactory?.Build();
    }

} // End Of Class

public static class MethodFactoryExtensions
{
    public static CombinedResult<MethodFactory, InnerMethodMethodResponseFactory> WithMethodResponses(this MethodFactory parentFactory, Action<Humidifier.ApiGateway.MethodTypes.MethodResponse> subFactoryAction = null)
    {
        var factory = new InnerMethodMethodResponseFactory(subFactoryAction);
        parentFactory.MethodResponsesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<MethodFactory, InnerMethodIntegrationFactory> WithIntegration(this MethodFactory parentFactory, Action<Humidifier.ApiGateway.MethodTypes.Integration> subFactoryAction = null)
    {
        parentFactory.IntegrationFactory = new InnerMethodIntegrationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IntegrationFactory);
    }

    public static CombinedResult<MethodFactory, T1, InnerMethodMethodResponseFactory> WithMethodResponses<T1>(this CombinedResult<MethodFactory, T1> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.MethodResponse> subFactoryAction = null) => new (combinedResult, combinedResult, WithMethodResponses(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MethodFactory, InnerMethodMethodResponseFactory> WithMethodResponses<T1>(this CombinedResult<T1, MethodFactory> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.MethodResponse> subFactoryAction = null) => new (combinedResult, combinedResult, WithMethodResponses(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MethodFactory, T1, T2, InnerMethodMethodResponseFactory> WithMethodResponses<T1, T2>(this CombinedResult<MethodFactory, T1, T2> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.MethodResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMethodResponses(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MethodFactory, T2, InnerMethodMethodResponseFactory> WithMethodResponses<T1, T2>(this CombinedResult<T1, MethodFactory, T2> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.MethodResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMethodResponses(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MethodFactory, InnerMethodMethodResponseFactory> WithMethodResponses<T1, T2>(this CombinedResult<T1, T2, MethodFactory> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.MethodResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMethodResponses(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MethodFactory, T1, T2, T3, InnerMethodMethodResponseFactory> WithMethodResponses<T1, T2, T3>(this CombinedResult<MethodFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.MethodResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMethodResponses(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MethodFactory, T2, T3, InnerMethodMethodResponseFactory> WithMethodResponses<T1, T2, T3>(this CombinedResult<T1, MethodFactory, T2, T3> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.MethodResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMethodResponses(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MethodFactory, T3, InnerMethodMethodResponseFactory> WithMethodResponses<T1, T2, T3>(this CombinedResult<T1, T2, MethodFactory, T3> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.MethodResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMethodResponses(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MethodFactory, InnerMethodMethodResponseFactory> WithMethodResponses<T1, T2, T3>(this CombinedResult<T1, T2, T3, MethodFactory> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.MethodResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMethodResponses(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MethodFactory, T1, T2, T3, T4, InnerMethodMethodResponseFactory> WithMethodResponses<T1, T2, T3, T4>(this CombinedResult<MethodFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.MethodResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMethodResponses(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MethodFactory, T2, T3, T4, InnerMethodMethodResponseFactory> WithMethodResponses<T1, T2, T3, T4>(this CombinedResult<T1, MethodFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.MethodResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMethodResponses(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MethodFactory, T3, T4, InnerMethodMethodResponseFactory> WithMethodResponses<T1, T2, T3, T4>(this CombinedResult<T1, T2, MethodFactory, T3, T4> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.MethodResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMethodResponses(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MethodFactory, T4, InnerMethodMethodResponseFactory> WithMethodResponses<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MethodFactory, T4> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.MethodResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMethodResponses(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MethodFactory, InnerMethodMethodResponseFactory> WithMethodResponses<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MethodFactory> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.MethodResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMethodResponses(combinedResult.T5, subFactoryAction));
    public static CombinedResult<MethodFactory, T1, InnerMethodIntegrationFactory> WithIntegration<T1>(this CombinedResult<MethodFactory, T1> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIntegration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MethodFactory, InnerMethodIntegrationFactory> WithIntegration<T1>(this CombinedResult<T1, MethodFactory> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIntegration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MethodFactory, T1, T2, InnerMethodIntegrationFactory> WithIntegration<T1, T2>(this CombinedResult<MethodFactory, T1, T2> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntegration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MethodFactory, T2, InnerMethodIntegrationFactory> WithIntegration<T1, T2>(this CombinedResult<T1, MethodFactory, T2> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntegration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MethodFactory, InnerMethodIntegrationFactory> WithIntegration<T1, T2>(this CombinedResult<T1, T2, MethodFactory> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntegration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MethodFactory, T1, T2, T3, InnerMethodIntegrationFactory> WithIntegration<T1, T2, T3>(this CombinedResult<MethodFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntegration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MethodFactory, T2, T3, InnerMethodIntegrationFactory> WithIntegration<T1, T2, T3>(this CombinedResult<T1, MethodFactory, T2, T3> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntegration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MethodFactory, T3, InnerMethodIntegrationFactory> WithIntegration<T1, T2, T3>(this CombinedResult<T1, T2, MethodFactory, T3> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntegration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MethodFactory, InnerMethodIntegrationFactory> WithIntegration<T1, T2, T3>(this CombinedResult<T1, T2, T3, MethodFactory> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntegration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MethodFactory, T1, T2, T3, T4, InnerMethodIntegrationFactory> WithIntegration<T1, T2, T3, T4>(this CombinedResult<MethodFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntegration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MethodFactory, T2, T3, T4, InnerMethodIntegrationFactory> WithIntegration<T1, T2, T3, T4>(this CombinedResult<T1, MethodFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntegration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MethodFactory, T3, T4, InnerMethodIntegrationFactory> WithIntegration<T1, T2, T3, T4>(this CombinedResult<T1, T2, MethodFactory, T3, T4> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntegration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MethodFactory, T4, InnerMethodIntegrationFactory> WithIntegration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MethodFactory, T4> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntegration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MethodFactory, InnerMethodIntegrationFactory> WithIntegration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MethodFactory> combinedResult, Action<Humidifier.ApiGateway.MethodTypes.Integration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntegration(combinedResult.T5, subFactoryAction));
}
