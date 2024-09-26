// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalog;

public class ServiceActionFactory(string resourceName = null, Action<Humidifier.ServiceCatalog.ServiceAction> factoryAction = null) : ResourceFactory<Humidifier.ServiceCatalog.ServiceAction>(resourceName)
{

    internal List<InnerServiceActionDefinitionParameterFactory> DefinitionFactories { get; set; } = [];

    protected override Humidifier.ServiceCatalog.ServiceAction Create()
    {
        var serviceActionResult = CreateServiceAction();
        factoryAction?.Invoke(serviceActionResult);

        return serviceActionResult;
    }

    private Humidifier.ServiceCatalog.ServiceAction CreateServiceAction()
    {
        var serviceActionResult = new Humidifier.ServiceCatalog.ServiceAction
        {
            GivenName = InputResourceName,
        };

        return serviceActionResult;
    }
    public override void CreateChildren(Humidifier.ServiceCatalog.ServiceAction result)
    {
        base.CreateChildren(result);

        result.Definition = DefinitionFactories.Any() ? DefinitionFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ServiceActionFactoryExtensions
{
    public static CombinedResult<ServiceActionFactory, InnerServiceActionDefinitionParameterFactory> WithDefinition(this ServiceActionFactory parentFactory, Action<Humidifier.ServiceCatalog.ServiceActionTypes.DefinitionParameter> subFactoryAction = null)
    {
        var factory = new InnerServiceActionDefinitionParameterFactory(subFactoryAction);
        parentFactory.DefinitionFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ServiceActionFactory, T1, InnerServiceActionDefinitionParameterFactory> WithDefinition<T1>(this CombinedResult<ServiceActionFactory, T1> combinedResult, Action<Humidifier.ServiceCatalog.ServiceActionTypes.DefinitionParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceActionFactory, InnerServiceActionDefinitionParameterFactory> WithDefinition<T1>(this CombinedResult<T1, ServiceActionFactory> combinedResult, Action<Humidifier.ServiceCatalog.ServiceActionTypes.DefinitionParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ServiceActionFactory, T1, T2, InnerServiceActionDefinitionParameterFactory> WithDefinition<T1, T2>(this CombinedResult<ServiceActionFactory, T1, T2> combinedResult, Action<Humidifier.ServiceCatalog.ServiceActionTypes.DefinitionParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceActionFactory, T2, InnerServiceActionDefinitionParameterFactory> WithDefinition<T1, T2>(this CombinedResult<T1, ServiceActionFactory, T2> combinedResult, Action<Humidifier.ServiceCatalog.ServiceActionTypes.DefinitionParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceActionFactory, InnerServiceActionDefinitionParameterFactory> WithDefinition<T1, T2>(this CombinedResult<T1, T2, ServiceActionFactory> combinedResult, Action<Humidifier.ServiceCatalog.ServiceActionTypes.DefinitionParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ServiceActionFactory, T1, T2, T3, InnerServiceActionDefinitionParameterFactory> WithDefinition<T1, T2, T3>(this CombinedResult<ServiceActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.ServiceCatalog.ServiceActionTypes.DefinitionParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceActionFactory, T2, T3, InnerServiceActionDefinitionParameterFactory> WithDefinition<T1, T2, T3>(this CombinedResult<T1, ServiceActionFactory, T2, T3> combinedResult, Action<Humidifier.ServiceCatalog.ServiceActionTypes.DefinitionParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceActionFactory, T3, InnerServiceActionDefinitionParameterFactory> WithDefinition<T1, T2, T3>(this CombinedResult<T1, T2, ServiceActionFactory, T3> combinedResult, Action<Humidifier.ServiceCatalog.ServiceActionTypes.DefinitionParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServiceActionFactory, InnerServiceActionDefinitionParameterFactory> WithDefinition<T1, T2, T3>(this CombinedResult<T1, T2, T3, ServiceActionFactory> combinedResult, Action<Humidifier.ServiceCatalog.ServiceActionTypes.DefinitionParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ServiceActionFactory, T1, T2, T3, T4, InnerServiceActionDefinitionParameterFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<ServiceActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ServiceCatalog.ServiceActionTypes.DefinitionParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceActionFactory, T2, T3, T4, InnerServiceActionDefinitionParameterFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, ServiceActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.ServiceCatalog.ServiceActionTypes.DefinitionParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceActionFactory, T3, T4, InnerServiceActionDefinitionParameterFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, ServiceActionFactory, T3, T4> combinedResult, Action<Humidifier.ServiceCatalog.ServiceActionTypes.DefinitionParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServiceActionFactory, T4, InnerServiceActionDefinitionParameterFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ServiceActionFactory, T4> combinedResult, Action<Humidifier.ServiceCatalog.ServiceActionTypes.DefinitionParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ServiceActionFactory, InnerServiceActionDefinitionParameterFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ServiceActionFactory> combinedResult, Action<Humidifier.ServiceCatalog.ServiceActionTypes.DefinitionParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T5, subFactoryAction));
}
