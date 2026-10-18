// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CertificateManager;

public class InnerAcmeEndpointTagsItemsFactory(Action<Humidifier.CertificateManager.AcmeEndpointTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.CertificateManager.AcmeEndpointTypes.TagsItems>
{

    protected override Humidifier.CertificateManager.AcmeEndpointTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.CertificateManager.AcmeEndpointTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.CertificateManager.AcmeEndpointTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerAcmeEndpointTagsItemsFactoryExtensions
{
}
