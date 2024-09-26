// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RefactorSpaces;

public class ApplicationFactory(string resourceName = null, Action<Humidifier.RefactorSpaces.Application> factoryAction = null) : ResourceFactory<Humidifier.RefactorSpaces.Application>(resourceName)
{

    internal InnerApplicationApiGatewayProxyInputFactory ApiGatewayProxyFactory { get; set; }

    protected override Humidifier.RefactorSpaces.Application Create()
    {
        var applicationResult = CreateApplication();
        factoryAction?.Invoke(applicationResult);

        return applicationResult;
    }

    private Humidifier.RefactorSpaces.Application CreateApplication()
    {
        var applicationResult = new Humidifier.RefactorSpaces.Application
        {
            GivenName = InputResourceName,
        };

        return applicationResult;
    }
    public override void CreateChildren(Humidifier.RefactorSpaces.Application result)
    {
        base.CreateChildren(result);

        result.ApiGatewayProxy ??= ApiGatewayProxyFactory?.Build();
    }

} // End Of Class

public static class ApplicationFactoryExtensions
{
    public static CombinedResult<ApplicationFactory, InnerApplicationApiGatewayProxyInputFactory> WithApiGatewayProxy(this ApplicationFactory parentFactory, Action<Humidifier.RefactorSpaces.ApplicationTypes.ApiGatewayProxyInput> subFactoryAction = null)
    {
        parentFactory.ApiGatewayProxyFactory = new InnerApplicationApiGatewayProxyInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApiGatewayProxyFactory);
    }

    public static CombinedResult<ApplicationFactory, T1, InnerApplicationApiGatewayProxyInputFactory> WithApiGatewayProxy<T1>(this CombinedResult<ApplicationFactory, T1> combinedResult, Action<Humidifier.RefactorSpaces.ApplicationTypes.ApiGatewayProxyInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithApiGatewayProxy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, InnerApplicationApiGatewayProxyInputFactory> WithApiGatewayProxy<T1>(this CombinedResult<T1, ApplicationFactory> combinedResult, Action<Humidifier.RefactorSpaces.ApplicationTypes.ApiGatewayProxyInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithApiGatewayProxy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, InnerApplicationApiGatewayProxyInputFactory> WithApiGatewayProxy<T1, T2>(this CombinedResult<ApplicationFactory, T1, T2> combinedResult, Action<Humidifier.RefactorSpaces.ApplicationTypes.ApiGatewayProxyInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiGatewayProxy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, InnerApplicationApiGatewayProxyInputFactory> WithApiGatewayProxy<T1, T2>(this CombinedResult<T1, ApplicationFactory, T2> combinedResult, Action<Humidifier.RefactorSpaces.ApplicationTypes.ApiGatewayProxyInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiGatewayProxy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, InnerApplicationApiGatewayProxyInputFactory> WithApiGatewayProxy<T1, T2>(this CombinedResult<T1, T2, ApplicationFactory> combinedResult, Action<Humidifier.RefactorSpaces.ApplicationTypes.ApiGatewayProxyInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiGatewayProxy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, T3, InnerApplicationApiGatewayProxyInputFactory> WithApiGatewayProxy<T1, T2, T3>(this CombinedResult<ApplicationFactory, T1, T2, T3> combinedResult, Action<Humidifier.RefactorSpaces.ApplicationTypes.ApiGatewayProxyInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiGatewayProxy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, T3, InnerApplicationApiGatewayProxyInputFactory> WithApiGatewayProxy<T1, T2, T3>(this CombinedResult<T1, ApplicationFactory, T2, T3> combinedResult, Action<Humidifier.RefactorSpaces.ApplicationTypes.ApiGatewayProxyInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiGatewayProxy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, T3, InnerApplicationApiGatewayProxyInputFactory> WithApiGatewayProxy<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationFactory, T3> combinedResult, Action<Humidifier.RefactorSpaces.ApplicationTypes.ApiGatewayProxyInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiGatewayProxy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationFactory, InnerApplicationApiGatewayProxyInputFactory> WithApiGatewayProxy<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationFactory> combinedResult, Action<Humidifier.RefactorSpaces.ApplicationTypes.ApiGatewayProxyInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiGatewayProxy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, T3, T4, InnerApplicationApiGatewayProxyInputFactory> WithApiGatewayProxy<T1, T2, T3, T4>(this CombinedResult<ApplicationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RefactorSpaces.ApplicationTypes.ApiGatewayProxyInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiGatewayProxy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, T3, T4, InnerApplicationApiGatewayProxyInputFactory> WithApiGatewayProxy<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationFactory, T2, T3, T4> combinedResult, Action<Humidifier.RefactorSpaces.ApplicationTypes.ApiGatewayProxyInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiGatewayProxy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, T3, T4, InnerApplicationApiGatewayProxyInputFactory> WithApiGatewayProxy<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationFactory, T3, T4> combinedResult, Action<Humidifier.RefactorSpaces.ApplicationTypes.ApiGatewayProxyInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiGatewayProxy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationFactory, T4, InnerApplicationApiGatewayProxyInputFactory> WithApiGatewayProxy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationFactory, T4> combinedResult, Action<Humidifier.RefactorSpaces.ApplicationTypes.ApiGatewayProxyInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiGatewayProxy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApplicationFactory, InnerApplicationApiGatewayProxyInputFactory> WithApiGatewayProxy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationFactory> combinedResult, Action<Humidifier.RefactorSpaces.ApplicationTypes.ApiGatewayProxyInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiGatewayProxy(combinedResult.T5, subFactoryAction));
}
