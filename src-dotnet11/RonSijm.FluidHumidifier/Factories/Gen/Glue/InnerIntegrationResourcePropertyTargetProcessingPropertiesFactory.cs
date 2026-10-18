// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerIntegrationResourcePropertyTargetProcessingPropertiesFactory(Action<Humidifier.Glue.IntegrationResourcePropertyTypes.TargetProcessingProperties> factoryAction = null) : SubResourceFactory<Humidifier.Glue.IntegrationResourcePropertyTypes.TargetProcessingProperties>
{

    protected override Humidifier.Glue.IntegrationResourcePropertyTypes.TargetProcessingProperties Create()
    {
        var targetProcessingPropertiesResult = CreateTargetProcessingProperties();
        factoryAction?.Invoke(targetProcessingPropertiesResult);

        return targetProcessingPropertiesResult;
    }

    private Humidifier.Glue.IntegrationResourcePropertyTypes.TargetProcessingProperties CreateTargetProcessingProperties()
    {
        var targetProcessingPropertiesResult = new Humidifier.Glue.IntegrationResourcePropertyTypes.TargetProcessingProperties();

        return targetProcessingPropertiesResult;
    }

} // End Of Class

public static class InnerIntegrationResourcePropertyTargetProcessingPropertiesFactoryExtensions
{
}
