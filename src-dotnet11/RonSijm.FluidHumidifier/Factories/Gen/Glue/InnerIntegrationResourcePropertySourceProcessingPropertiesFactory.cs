// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerIntegrationResourcePropertySourceProcessingPropertiesFactory(Action<Humidifier.Glue.IntegrationResourcePropertyTypes.SourceProcessingProperties> factoryAction = null) : SubResourceFactory<Humidifier.Glue.IntegrationResourcePropertyTypes.SourceProcessingProperties>
{

    protected override Humidifier.Glue.IntegrationResourcePropertyTypes.SourceProcessingProperties Create()
    {
        var sourceProcessingPropertiesResult = CreateSourceProcessingProperties();
        factoryAction?.Invoke(sourceProcessingPropertiesResult);

        return sourceProcessingPropertiesResult;
    }

    private Humidifier.Glue.IntegrationResourcePropertyTypes.SourceProcessingProperties CreateSourceProcessingProperties()
    {
        var sourceProcessingPropertiesResult = new Humidifier.Glue.IntegrationResourcePropertyTypes.SourceProcessingProperties();

        return sourceProcessingPropertiesResult;
    }

} // End Of Class

public static class InnerIntegrationResourcePropertySourceProcessingPropertiesFactoryExtensions
{
}
