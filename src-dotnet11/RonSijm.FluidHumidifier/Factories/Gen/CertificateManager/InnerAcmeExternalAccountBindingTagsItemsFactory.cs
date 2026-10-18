// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CertificateManager;

public class InnerAcmeExternalAccountBindingTagsItemsFactory(Action<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.TagsItems>
{

    protected override Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.CertificateManager.AcmeExternalAccountBindingTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerAcmeExternalAccountBindingTagsItemsFactoryExtensions
{
}
