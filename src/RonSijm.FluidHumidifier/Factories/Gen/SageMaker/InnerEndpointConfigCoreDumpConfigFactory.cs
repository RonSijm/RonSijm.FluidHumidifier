// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointConfigCoreDumpConfigFactory(Action<Humidifier.SageMaker.EndpointConfigTypes.CoreDumpConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointConfigTypes.CoreDumpConfig>
{

    protected override Humidifier.SageMaker.EndpointConfigTypes.CoreDumpConfig Create()
    {
        var coreDumpConfigResult = CreateCoreDumpConfig();
        factoryAction?.Invoke(coreDumpConfigResult);

        return coreDumpConfigResult;
    }

    private Humidifier.SageMaker.EndpointConfigTypes.CoreDumpConfig CreateCoreDumpConfig()
    {
        var coreDumpConfigResult = new Humidifier.SageMaker.EndpointConfigTypes.CoreDumpConfig();

        return coreDumpConfigResult;
    }

} // End Of Class

public static class InnerEndpointConfigCoreDumpConfigFactoryExtensions
{
}
