// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerMeshMeshServiceDiscoveryFactory(Action<Humidifier.AppMesh.MeshTypes.MeshServiceDiscovery> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.MeshTypes.MeshServiceDiscovery>
{

    protected override Humidifier.AppMesh.MeshTypes.MeshServiceDiscovery Create()
    {
        var meshServiceDiscoveryResult = CreateMeshServiceDiscovery();
        factoryAction?.Invoke(meshServiceDiscoveryResult);

        return meshServiceDiscoveryResult;
    }

    private Humidifier.AppMesh.MeshTypes.MeshServiceDiscovery CreateMeshServiceDiscovery()
    {
        var meshServiceDiscoveryResult = new Humidifier.AppMesh.MeshTypes.MeshServiceDiscovery();

        return meshServiceDiscoveryResult;
    }

} // End Of Class

public static class InnerMeshMeshServiceDiscoveryFactoryExtensions
{
}
