// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterFSxLustreConfigFactory(Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig>
{

    protected override Humidifier.SageMaker.ClusterTypes.FSxLustreConfig Create()
    {
        var fSxLustreConfigResult = CreateFSxLustreConfig();
        factoryAction?.Invoke(fSxLustreConfigResult);

        return fSxLustreConfigResult;
    }

    private Humidifier.SageMaker.ClusterTypes.FSxLustreConfig CreateFSxLustreConfig()
    {
        var fSxLustreConfigResult = new Humidifier.SageMaker.ClusterTypes.FSxLustreConfig();

        return fSxLustreConfigResult;
    }

} // End Of Class

public static class InnerClusterFSxLustreConfigFactoryExtensions
{
}
