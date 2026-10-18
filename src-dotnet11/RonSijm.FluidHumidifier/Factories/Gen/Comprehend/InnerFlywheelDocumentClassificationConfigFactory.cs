// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class InnerFlywheelDocumentClassificationConfigFactory(Action<Humidifier.Comprehend.FlywheelTypes.DocumentClassificationConfig> factoryAction = null) : SubResourceFactory<Humidifier.Comprehend.FlywheelTypes.DocumentClassificationConfig>
{

    protected override Humidifier.Comprehend.FlywheelTypes.DocumentClassificationConfig Create()
    {
        var documentClassificationConfigResult = CreateDocumentClassificationConfig();
        factoryAction?.Invoke(documentClassificationConfigResult);

        return documentClassificationConfigResult;
    }

    private Humidifier.Comprehend.FlywheelTypes.DocumentClassificationConfig CreateDocumentClassificationConfig()
    {
        var documentClassificationConfigResult = new Humidifier.Comprehend.FlywheelTypes.DocumentClassificationConfig();

        return documentClassificationConfigResult;
    }

} // End Of Class

public static class InnerFlywheelDocumentClassificationConfigFactoryExtensions
{
}
