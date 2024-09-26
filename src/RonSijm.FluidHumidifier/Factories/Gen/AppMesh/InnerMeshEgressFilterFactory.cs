// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerMeshEgressFilterFactory(Action<Humidifier.AppMesh.MeshTypes.EgressFilter> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.MeshTypes.EgressFilter>
{

    protected override Humidifier.AppMesh.MeshTypes.EgressFilter Create()
    {
        var egressFilterResult = CreateEgressFilter();
        factoryAction?.Invoke(egressFilterResult);

        return egressFilterResult;
    }

    private Humidifier.AppMesh.MeshTypes.EgressFilter CreateEgressFilter()
    {
        var egressFilterResult = new Humidifier.AppMesh.MeshTypes.EgressFilter();

        return egressFilterResult;
    }

} // End Of Class

public static class InnerMeshEgressFilterFactoryExtensions
{
}
