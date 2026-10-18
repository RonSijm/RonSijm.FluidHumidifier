// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerEventSourceMappingDocumentDBEventSourceConfigFactory(Action<Humidifier.Lambda.EventSourceMappingTypes.DocumentDBEventSourceConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.EventSourceMappingTypes.DocumentDBEventSourceConfig>
{

    protected override Humidifier.Lambda.EventSourceMappingTypes.DocumentDBEventSourceConfig Create()
    {
        var documentDBEventSourceConfigResult = CreateDocumentDBEventSourceConfig();
        factoryAction?.Invoke(documentDBEventSourceConfigResult);

        return documentDBEventSourceConfigResult;
    }

    private Humidifier.Lambda.EventSourceMappingTypes.DocumentDBEventSourceConfig CreateDocumentDBEventSourceConfig()
    {
        var documentDBEventSourceConfigResult = new Humidifier.Lambda.EventSourceMappingTypes.DocumentDBEventSourceConfig();

        return documentDBEventSourceConfigResult;
    }

} // End Of Class

public static class InnerEventSourceMappingDocumentDBEventSourceConfigFactoryExtensions
{
}
