// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerIndexDocumentAttributeConfigurationFactory(Action<Humidifier.QBusiness.IndexTypes.DocumentAttributeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.IndexTypes.DocumentAttributeConfiguration>
{

    protected override Humidifier.QBusiness.IndexTypes.DocumentAttributeConfiguration Create()
    {
        var documentAttributeConfigurationResult = CreateDocumentAttributeConfiguration();
        factoryAction?.Invoke(documentAttributeConfigurationResult);

        return documentAttributeConfigurationResult;
    }

    private Humidifier.QBusiness.IndexTypes.DocumentAttributeConfiguration CreateDocumentAttributeConfiguration()
    {
        var documentAttributeConfigurationResult = new Humidifier.QBusiness.IndexTypes.DocumentAttributeConfiguration();

        return documentAttributeConfigurationResult;
    }

} // End Of Class

public static class InnerIndexDocumentAttributeConfigurationFactoryExtensions
{
}
