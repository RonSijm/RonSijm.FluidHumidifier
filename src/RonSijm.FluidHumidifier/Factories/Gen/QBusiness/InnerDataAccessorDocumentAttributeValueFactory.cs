// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerDataAccessorDocumentAttributeValueFactory(Action<Humidifier.QBusiness.DataAccessorTypes.DocumentAttributeValue> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.DataAccessorTypes.DocumentAttributeValue>
{

    protected override Humidifier.QBusiness.DataAccessorTypes.DocumentAttributeValue Create()
    {
        var documentAttributeValueResult = CreateDocumentAttributeValue();
        factoryAction?.Invoke(documentAttributeValueResult);

        return documentAttributeValueResult;
    }

    private Humidifier.QBusiness.DataAccessorTypes.DocumentAttributeValue CreateDocumentAttributeValue()
    {
        var documentAttributeValueResult = new Humidifier.QBusiness.DataAccessorTypes.DocumentAttributeValue();

        return documentAttributeValueResult;
    }

} // End Of Class

public static class InnerDataAccessorDocumentAttributeValueFactoryExtensions
{
}
