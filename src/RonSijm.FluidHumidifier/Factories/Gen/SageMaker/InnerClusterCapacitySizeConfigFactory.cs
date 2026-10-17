// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterCapacitySizeConfigFactory(Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig>
{

    protected override Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig Create()
    {
        var capacitySizeConfigResult = CreateCapacitySizeConfig();
        factoryAction?.Invoke(capacitySizeConfigResult);

        return capacitySizeConfigResult;
    }

    private Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig CreateCapacitySizeConfig()
    {
        var capacitySizeConfigResult = new Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig();

        return capacitySizeConfigResult;
    }

} // End Of Class

public static class InnerClusterCapacitySizeConfigFactoryExtensions
{
}
