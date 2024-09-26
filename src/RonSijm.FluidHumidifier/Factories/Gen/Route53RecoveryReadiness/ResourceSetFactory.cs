// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53RecoveryReadiness;

public class ResourceSetFactory(string resourceName = null, Action<Humidifier.Route53RecoveryReadiness.ResourceSet> factoryAction = null) : ResourceFactory<Humidifier.Route53RecoveryReadiness.ResourceSet>(resourceName)
{

    internal List<InnerResourceSetResourceFactory> ResourcesFactories { get; set; } = [];

    protected override Humidifier.Route53RecoveryReadiness.ResourceSet Create()
    {
        var resourceSetResult = CreateResourceSet();
        factoryAction?.Invoke(resourceSetResult);

        return resourceSetResult;
    }

    private Humidifier.Route53RecoveryReadiness.ResourceSet CreateResourceSet()
    {
        var resourceSetResult = new Humidifier.Route53RecoveryReadiness.ResourceSet
        {
            GivenName = InputResourceName,
        };

        return resourceSetResult;
    }
    public override void CreateChildren(Humidifier.Route53RecoveryReadiness.ResourceSet result)
    {
        base.CreateChildren(result);

        result.Resources = ResourcesFactories.Any() ? ResourcesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ResourceSetFactoryExtensions
{
    public static CombinedResult<ResourceSetFactory, InnerResourceSetResourceFactory> WithResources(this ResourceSetFactory parentFactory, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.Resource> subFactoryAction = null)
    {
        var factory = new InnerResourceSetResourceFactory(subFactoryAction);
        parentFactory.ResourcesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ResourceSetFactory, T1, InnerResourceSetResourceFactory> WithResources<T1>(this CombinedResult<ResourceSetFactory, T1> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, WithResources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceSetFactory, InnerResourceSetResourceFactory> WithResources<T1>(this CombinedResult<T1, ResourceSetFactory> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, WithResources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ResourceSetFactory, T1, T2, InnerResourceSetResourceFactory> WithResources<T1, T2>(this CombinedResult<ResourceSetFactory, T1, T2> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceSetFactory, T2, InnerResourceSetResourceFactory> WithResources<T1, T2>(this CombinedResult<T1, ResourceSetFactory, T2> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResourceSetFactory, InnerResourceSetResourceFactory> WithResources<T1, T2>(this CombinedResult<T1, T2, ResourceSetFactory> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ResourceSetFactory, T1, T2, T3, InnerResourceSetResourceFactory> WithResources<T1, T2, T3>(this CombinedResult<ResourceSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceSetFactory, T2, T3, InnerResourceSetResourceFactory> WithResources<T1, T2, T3>(this CombinedResult<T1, ResourceSetFactory, T2, T3> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResourceSetFactory, T3, InnerResourceSetResourceFactory> WithResources<T1, T2, T3>(this CombinedResult<T1, T2, ResourceSetFactory, T3> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResourceSetFactory, InnerResourceSetResourceFactory> WithResources<T1, T2, T3>(this CombinedResult<T1, T2, T3, ResourceSetFactory> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ResourceSetFactory, T1, T2, T3, T4, InnerResourceSetResourceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<ResourceSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceSetFactory, T2, T3, T4, InnerResourceSetResourceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<T1, ResourceSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResourceSetFactory, T3, T4, InnerResourceSetResourceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, ResourceSetFactory, T3, T4> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResourceSetFactory, T4, InnerResourceSetResourceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ResourceSetFactory, T4> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ResourceSetFactory, InnerResourceSetResourceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ResourceSetFactory> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T5, subFactoryAction));
}
