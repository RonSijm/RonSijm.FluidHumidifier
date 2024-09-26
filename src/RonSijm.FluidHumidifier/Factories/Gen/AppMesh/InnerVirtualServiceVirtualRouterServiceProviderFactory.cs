// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualServiceVirtualRouterServiceProviderFactory(Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualRouterServiceProvider> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualServiceTypes.VirtualRouterServiceProvider>
{

    protected override Humidifier.AppMesh.VirtualServiceTypes.VirtualRouterServiceProvider Create()
    {
        var virtualRouterServiceProviderResult = CreateVirtualRouterServiceProvider();
        factoryAction?.Invoke(virtualRouterServiceProviderResult);

        return virtualRouterServiceProviderResult;
    }

    private Humidifier.AppMesh.VirtualServiceTypes.VirtualRouterServiceProvider CreateVirtualRouterServiceProvider()
    {
        var virtualRouterServiceProviderResult = new Humidifier.AppMesh.VirtualServiceTypes.VirtualRouterServiceProvider();

        return virtualRouterServiceProviderResult;
    }

} // End Of Class

public static class InnerVirtualServiceVirtualRouterServiceProviderFactoryExtensions
{
}
