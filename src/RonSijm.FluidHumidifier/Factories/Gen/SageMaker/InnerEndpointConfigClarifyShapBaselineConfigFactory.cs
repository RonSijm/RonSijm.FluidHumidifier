// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointConfigClarifyShapBaselineConfigFactory(Action<Humidifier.SageMaker.EndpointConfigTypes.ClarifyShapBaselineConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointConfigTypes.ClarifyShapBaselineConfig>
{

    protected override Humidifier.SageMaker.EndpointConfigTypes.ClarifyShapBaselineConfig Create()
    {
        var clarifyShapBaselineConfigResult = CreateClarifyShapBaselineConfig();
        factoryAction?.Invoke(clarifyShapBaselineConfigResult);

        return clarifyShapBaselineConfigResult;
    }

    private Humidifier.SageMaker.EndpointConfigTypes.ClarifyShapBaselineConfig CreateClarifyShapBaselineConfig()
    {
        var clarifyShapBaselineConfigResult = new Humidifier.SageMaker.EndpointConfigTypes.ClarifyShapBaselineConfig();

        return clarifyShapBaselineConfigResult;
    }

} // End Of Class

public static class InnerEndpointConfigClarifyShapBaselineConfigFactoryExtensions
{
}
