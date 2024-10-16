// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerDataSourceDocumentAttributeValueFactory(Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue>
{

    protected override Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue Create()
    {
        var documentAttributeValueResult = CreateDocumentAttributeValue();
        factoryAction?.Invoke(documentAttributeValueResult);

        return documentAttributeValueResult;
    }

    private Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue CreateDocumentAttributeValue()
    {
        var documentAttributeValueResult = new Humidifier.QBusiness.DataSourceTypes.DocumentAttributeValue();

        return documentAttributeValueResult;
    }

} // End Of Class

public static class InnerDataSourceDocumentAttributeValueFactoryExtensions
{
}
