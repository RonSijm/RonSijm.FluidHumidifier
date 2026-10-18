// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceDocumentAttributeValueFactory(Action<Humidifier.Kendra.DataSourceTypes.DocumentAttributeValue> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.DocumentAttributeValue>
{

    protected override Humidifier.Kendra.DataSourceTypes.DocumentAttributeValue Create()
    {
        var documentAttributeValueResult = CreateDocumentAttributeValue();
        factoryAction?.Invoke(documentAttributeValueResult);

        return documentAttributeValueResult;
    }

    private Humidifier.Kendra.DataSourceTypes.DocumentAttributeValue CreateDocumentAttributeValue()
    {
        var documentAttributeValueResult = new Humidifier.Kendra.DataSourceTypes.DocumentAttributeValue();

        return documentAttributeValueResult;
    }

} // End Of Class

public static class InnerDataSourceDocumentAttributeValueFactoryExtensions
{
}
