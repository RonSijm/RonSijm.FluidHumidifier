// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDeviceFleetEdgeOutputConfigFactory(Action<Humidifier.SageMaker.DeviceFleetTypes.EdgeOutputConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DeviceFleetTypes.EdgeOutputConfig>
{

    protected override Humidifier.SageMaker.DeviceFleetTypes.EdgeOutputConfig Create()
    {
        var edgeOutputConfigResult = CreateEdgeOutputConfig();
        factoryAction?.Invoke(edgeOutputConfigResult);

        return edgeOutputConfigResult;
    }

    private Humidifier.SageMaker.DeviceFleetTypes.EdgeOutputConfig CreateEdgeOutputConfig()
    {
        var edgeOutputConfigResult = new Humidifier.SageMaker.DeviceFleetTypes.EdgeOutputConfig();

        return edgeOutputConfigResult;
    }

} // End Of Class

public static class InnerDeviceFleetEdgeOutputConfigFactoryExtensions
{
}
