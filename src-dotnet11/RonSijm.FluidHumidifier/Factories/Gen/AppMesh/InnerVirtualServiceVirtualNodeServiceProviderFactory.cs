// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualServiceVirtualNodeServiceProviderFactory(Action<Humidifier.AppMesh.VirtualServiceTypes.VirtualNodeServiceProvider> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualServiceTypes.VirtualNodeServiceProvider>
{

    protected override Humidifier.AppMesh.VirtualServiceTypes.VirtualNodeServiceProvider Create()
    {
        var virtualNodeServiceProviderResult = CreateVirtualNodeServiceProvider();
        factoryAction?.Invoke(virtualNodeServiceProviderResult);

        return virtualNodeServiceProviderResult;
    }

    private Humidifier.AppMesh.VirtualServiceTypes.VirtualNodeServiceProvider CreateVirtualNodeServiceProvider()
    {
        var virtualNodeServiceProviderResult = new Humidifier.AppMesh.VirtualServiceTypes.VirtualNodeServiceProvider();

        return virtualNodeServiceProviderResult;
    }

} // End Of Class

public static class InnerVirtualServiceVirtualNodeServiceProviderFactoryExtensions
{
}
