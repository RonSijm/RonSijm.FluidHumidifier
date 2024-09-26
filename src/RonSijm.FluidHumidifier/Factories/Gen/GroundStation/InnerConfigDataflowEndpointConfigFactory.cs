// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerConfigDataflowEndpointConfigFactory(Action<Humidifier.GroundStation.ConfigTypes.DataflowEndpointConfig> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.ConfigTypes.DataflowEndpointConfig>
{

    protected override Humidifier.GroundStation.ConfigTypes.DataflowEndpointConfig Create()
    {
        var dataflowEndpointConfigResult = CreateDataflowEndpointConfig();
        factoryAction?.Invoke(dataflowEndpointConfigResult);

        return dataflowEndpointConfigResult;
    }

    private Humidifier.GroundStation.ConfigTypes.DataflowEndpointConfig CreateDataflowEndpointConfig()
    {
        var dataflowEndpointConfigResult = new Humidifier.GroundStation.ConfigTypes.DataflowEndpointConfig();

        return dataflowEndpointConfigResult;
    }

} // End Of Class

public static class InnerConfigDataflowEndpointConfigFactoryExtensions
{
}
