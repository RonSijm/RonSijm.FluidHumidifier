// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterTieredStorageConfigFactory(Action<Humidifier.SageMaker.ClusterTypes.TieredStorageConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.TieredStorageConfig>
{

    protected override Humidifier.SageMaker.ClusterTypes.TieredStorageConfig Create()
    {
        var tieredStorageConfigResult = CreateTieredStorageConfig();
        factoryAction?.Invoke(tieredStorageConfigResult);

        return tieredStorageConfigResult;
    }

    private Humidifier.SageMaker.ClusterTypes.TieredStorageConfig CreateTieredStorageConfig()
    {
        var tieredStorageConfigResult = new Humidifier.SageMaker.ClusterTypes.TieredStorageConfig();

        return tieredStorageConfigResult;
    }

} // End Of Class

public static class InnerClusterTieredStorageConfigFactoryExtensions
{
}
