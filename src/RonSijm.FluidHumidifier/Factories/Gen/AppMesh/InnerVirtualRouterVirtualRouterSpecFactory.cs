// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualRouterVirtualRouterSpecFactory(Action<Humidifier.AppMesh.VirtualRouterTypes.VirtualRouterSpec> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualRouterTypes.VirtualRouterSpec>
{

    protected override Humidifier.AppMesh.VirtualRouterTypes.VirtualRouterSpec Create()
    {
        var virtualRouterSpecResult = CreateVirtualRouterSpec();
        factoryAction?.Invoke(virtualRouterSpecResult);

        return virtualRouterSpecResult;
    }

    private Humidifier.AppMesh.VirtualRouterTypes.VirtualRouterSpec CreateVirtualRouterSpec()
    {
        var virtualRouterSpecResult = new Humidifier.AppMesh.VirtualRouterTypes.VirtualRouterSpec();

        return virtualRouterSpecResult;
    }

} // End Of Class

public static class InnerVirtualRouterVirtualRouterSpecFactoryExtensions
{
}
