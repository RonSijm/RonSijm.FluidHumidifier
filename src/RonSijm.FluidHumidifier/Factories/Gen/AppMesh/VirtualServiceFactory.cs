// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class VirtualServiceFactory(string resourceName = null, Action<Humidifier.AppMesh.VirtualService> factoryAction = null) : ResourceFactory<Humidifier.AppMesh.VirtualService>(resourceName)
{

    internal InnerVirtualServiceVirtualServiceSpecFactory SpecFactory { get; set; }

    protected override Humidifier.AppMesh.VirtualService Create()
    {
        var virtualServiceResult = CreateVirtualService();
        factoryAction?.Invoke(virtualServiceResult);

        return virtualServiceResult;
    }

    private Humidifier.AppMesh.VirtualService CreateVirtualService()
    {
        var virtualServiceResult = new Humidifier.AppMesh.VirtualService
        {
            GivenName = InputResourceName,
        };

        return virtualServiceResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.VirtualService result)
    {
        base.CreateChildren(result);

        result.Spec ??= SpecFactory?.Build();
    }

} // End Of Class

public static class VirtualServiceFactoryExtensions
{
    public static CombinedResult<VirtualServiceFactory, InnerVirtualServiceVirtualServiceSpecFactory> WithSpec(this VirtualServiceFactory parentFactory, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceSpec> subFactoryAction = null)
    {
        parentFactory.SpecFactory = new InnerVirtualServiceVirtualServiceSpecFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpecFactory);
    }

    public static CombinedResult<VirtualServiceFactory, T1, InnerVirtualServiceVirtualServiceSpecFactory> WithSpec<T1>(this CombinedResult<VirtualServiceFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VirtualServiceFactory, InnerVirtualServiceVirtualServiceSpecFactory> WithSpec<T1>(this CombinedResult<T1, VirtualServiceFactory> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<VirtualServiceFactory, T1, T2, InnerVirtualServiceVirtualServiceSpecFactory> WithSpec<T1, T2>(this CombinedResult<VirtualServiceFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VirtualServiceFactory, T2, InnerVirtualServiceVirtualServiceSpecFactory> WithSpec<T1, T2>(this CombinedResult<T1, VirtualServiceFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VirtualServiceFactory, InnerVirtualServiceVirtualServiceSpecFactory> WithSpec<T1, T2>(this CombinedResult<T1, T2, VirtualServiceFactory> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<VirtualServiceFactory, T1, T2, T3, InnerVirtualServiceVirtualServiceSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<VirtualServiceFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VirtualServiceFactory, T2, T3, InnerVirtualServiceVirtualServiceSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<T1, VirtualServiceFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VirtualServiceFactory, T3, InnerVirtualServiceVirtualServiceSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<T1, T2, VirtualServiceFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VirtualServiceFactory, InnerVirtualServiceVirtualServiceSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<T1, T2, T3, VirtualServiceFactory> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<VirtualServiceFactory, T1, T2, T3, T4, InnerVirtualServiceVirtualServiceSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<VirtualServiceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VirtualServiceFactory, T2, T3, T4, InnerVirtualServiceVirtualServiceSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, VirtualServiceFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VirtualServiceFactory, T3, T4, InnerVirtualServiceVirtualServiceSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, VirtualServiceFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VirtualServiceFactory, T4, InnerVirtualServiceVirtualServiceSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VirtualServiceFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, VirtualServiceFactory, InnerVirtualServiceVirtualServiceSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VirtualServiceFactory> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T5, subFactoryAction));
}
