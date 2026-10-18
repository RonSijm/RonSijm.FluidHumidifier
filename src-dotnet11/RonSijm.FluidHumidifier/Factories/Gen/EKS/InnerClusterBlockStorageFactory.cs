// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterBlockStorageFactory(Action<Humidifier.EKS.ClusterTypes.BlockStorage> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.BlockStorage>
{

    protected override Humidifier.EKS.ClusterTypes.BlockStorage Create()
    {
        var blockStorageResult = CreateBlockStorage();
        factoryAction?.Invoke(blockStorageResult);

        return blockStorageResult;
    }

    private Humidifier.EKS.ClusterTypes.BlockStorage CreateBlockStorage()
    {
        var blockStorageResult = new Humidifier.EKS.ClusterTypes.BlockStorage();

        return blockStorageResult;
    }

} // End Of Class

public static class InnerClusterBlockStorageFactoryExtensions
{
}
