// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class VirtualRouterFactory(string resourceName = null, Action<Humidifier.AppMesh.VirtualRouter> factoryAction = null) : ResourceFactory<Humidifier.AppMesh.VirtualRouter>(resourceName)
{

    internal InnerVirtualRouterVirtualRouterSpecFactory SpecFactory { get; set; }

    protected override Humidifier.AppMesh.VirtualRouter Create()
    {
        var virtualRouterResult = CreateVirtualRouter();
        factoryAction?.Invoke(virtualRouterResult);

        return virtualRouterResult;
    }

    private Humidifier.AppMesh.VirtualRouter CreateVirtualRouter()
    {
        var virtualRouterResult = new Humidifier.AppMesh.VirtualRouter
        {
            GivenName = InputResourceName,
        };

        return virtualRouterResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.VirtualRouter result)
    {
        base.CreateChildren(result);

        result.Spec ??= SpecFactory?.Build();
    }

} // End Of Class

public static class VirtualRouterFactoryExtensions
{
    public static CombinedResult<VirtualRouterFactory, InnerVirtualRouterVirtualRouterSpecFactory> WithSpec(this VirtualRouterFactory parentFactory, Action<Humidifier.AppMesh.VirtualRouterTypes.VirtualRouterSpec> subFactoryAction = null)
    {
        parentFactory.SpecFactory = new InnerVirtualRouterVirtualRouterSpecFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpecFactory);
    }

    public static CombinedResult<VirtualRouterFactory, T1, InnerVirtualRouterVirtualRouterSpecFactory> WithSpec<T1>(this CombinedResult<VirtualRouterFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualRouterTypes.VirtualRouterSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VirtualRouterFactory, InnerVirtualRouterVirtualRouterSpecFactory> WithSpec<T1>(this CombinedResult<T1, VirtualRouterFactory> combinedResult, Action<Humidifier.AppMesh.VirtualRouterTypes.VirtualRouterSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<VirtualRouterFactory, T1, T2, InnerVirtualRouterVirtualRouterSpecFactory> WithSpec<T1, T2>(this CombinedResult<VirtualRouterFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualRouterTypes.VirtualRouterSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VirtualRouterFactory, T2, InnerVirtualRouterVirtualRouterSpecFactory> WithSpec<T1, T2>(this CombinedResult<T1, VirtualRouterFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualRouterTypes.VirtualRouterSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VirtualRouterFactory, InnerVirtualRouterVirtualRouterSpecFactory> WithSpec<T1, T2>(this CombinedResult<T1, T2, VirtualRouterFactory> combinedResult, Action<Humidifier.AppMesh.VirtualRouterTypes.VirtualRouterSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<VirtualRouterFactory, T1, T2, T3, InnerVirtualRouterVirtualRouterSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<VirtualRouterFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualRouterTypes.VirtualRouterSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VirtualRouterFactory, T2, T3, InnerVirtualRouterVirtualRouterSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<T1, VirtualRouterFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualRouterTypes.VirtualRouterSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VirtualRouterFactory, T3, InnerVirtualRouterVirtualRouterSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<T1, T2, VirtualRouterFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualRouterTypes.VirtualRouterSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VirtualRouterFactory, InnerVirtualRouterVirtualRouterSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<T1, T2, T3, VirtualRouterFactory> combinedResult, Action<Humidifier.AppMesh.VirtualRouterTypes.VirtualRouterSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<VirtualRouterFactory, T1, T2, T3, T4, InnerVirtualRouterVirtualRouterSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<VirtualRouterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualRouterTypes.VirtualRouterSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VirtualRouterFactory, T2, T3, T4, InnerVirtualRouterVirtualRouterSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, VirtualRouterFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualRouterTypes.VirtualRouterSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VirtualRouterFactory, T3, T4, InnerVirtualRouterVirtualRouterSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, VirtualRouterFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualRouterTypes.VirtualRouterSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VirtualRouterFactory, T4, InnerVirtualRouterVirtualRouterSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VirtualRouterFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualRouterTypes.VirtualRouterSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, VirtualRouterFactory, InnerVirtualRouterVirtualRouterSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VirtualRouterFactory> combinedResult, Action<Humidifier.AppMesh.VirtualRouterTypes.VirtualRouterSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T5, subFactoryAction));
}
