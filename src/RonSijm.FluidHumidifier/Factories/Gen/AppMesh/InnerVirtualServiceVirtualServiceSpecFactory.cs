// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualServiceVirtualServiceSpecFactory(Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceSpec> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceSpec>
{

    internal InnerVirtualServiceVirtualServiceProviderFactory ProviderFactory { get; set; }

    protected override Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceSpec Create()
    {
        var virtualServiceSpecResult = CreateVirtualServiceSpec();
        factoryAction?.Invoke(virtualServiceSpecResult);

        return virtualServiceSpecResult;
    }

    private Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceSpec CreateVirtualServiceSpec()
    {
        var virtualServiceSpecResult = new Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceSpec();

        return virtualServiceSpecResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceSpec result)
    {
        base.CreateChildren(result);

        result.Provider ??= ProviderFactory?.Build();
    }

} // End Of Class

public static class InnerVirtualServiceVirtualServiceSpecFactoryExtensions
{
    public static CombinedResult<InnerVirtualServiceVirtualServiceSpecFactory, InnerVirtualServiceVirtualServiceProviderFactory> WithProvider(this InnerVirtualServiceVirtualServiceSpecFactory parentFactory, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceProvider> subFactoryAction = null)
    {
        parentFactory.ProviderFactory = new InnerVirtualServiceVirtualServiceProviderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProviderFactory);
    }

    public static CombinedResult<InnerVirtualServiceVirtualServiceSpecFactory, T1, InnerVirtualServiceVirtualServiceProviderFactory> WithProvider<T1>(this CombinedResult<InnerVirtualServiceVirtualServiceSpecFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualServiceVirtualServiceSpecFactory, InnerVirtualServiceVirtualServiceProviderFactory> WithProvider<T1>(this CombinedResult<T1, InnerVirtualServiceVirtualServiceSpecFactory> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVirtualServiceVirtualServiceSpecFactory, T1, T2, InnerVirtualServiceVirtualServiceProviderFactory> WithProvider<T1, T2>(this CombinedResult<InnerVirtualServiceVirtualServiceSpecFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualServiceVirtualServiceSpecFactory, T2, InnerVirtualServiceVirtualServiceProviderFactory> WithProvider<T1, T2>(this CombinedResult<T1, InnerVirtualServiceVirtualServiceSpecFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualServiceVirtualServiceSpecFactory, InnerVirtualServiceVirtualServiceProviderFactory> WithProvider<T1, T2>(this CombinedResult<T1, T2, InnerVirtualServiceVirtualServiceSpecFactory> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVirtualServiceVirtualServiceSpecFactory, T1, T2, T3, InnerVirtualServiceVirtualServiceProviderFactory> WithProvider<T1, T2, T3>(this CombinedResult<InnerVirtualServiceVirtualServiceSpecFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualServiceVirtualServiceSpecFactory, T2, T3, InnerVirtualServiceVirtualServiceProviderFactory> WithProvider<T1, T2, T3>(this CombinedResult<T1, InnerVirtualServiceVirtualServiceSpecFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualServiceVirtualServiceSpecFactory, T3, InnerVirtualServiceVirtualServiceProviderFactory> WithProvider<T1, T2, T3>(this CombinedResult<T1, T2, InnerVirtualServiceVirtualServiceSpecFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualServiceVirtualServiceSpecFactory, InnerVirtualServiceVirtualServiceProviderFactory> WithProvider<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVirtualServiceVirtualServiceSpecFactory> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVirtualServiceVirtualServiceSpecFactory, T1, T2, T3, T4, InnerVirtualServiceVirtualServiceProviderFactory> WithProvider<T1, T2, T3, T4>(this CombinedResult<InnerVirtualServiceVirtualServiceSpecFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualServiceVirtualServiceSpecFactory, T2, T3, T4, InnerVirtualServiceVirtualServiceProviderFactory> WithProvider<T1, T2, T3, T4>(this CombinedResult<T1, InnerVirtualServiceVirtualServiceSpecFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualServiceVirtualServiceSpecFactory, T3, T4, InnerVirtualServiceVirtualServiceProviderFactory> WithProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVirtualServiceVirtualServiceSpecFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualServiceVirtualServiceSpecFactory, T4, InnerVirtualServiceVirtualServiceProviderFactory> WithProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVirtualServiceVirtualServiceSpecFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVirtualServiceVirtualServiceSpecFactory, InnerVirtualServiceVirtualServiceProviderFactory> WithProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVirtualServiceVirtualServiceSpecFactory> combinedResult, Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualServiceProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T5, subFactoryAction));
}
