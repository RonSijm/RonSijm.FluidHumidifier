// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CertificateManager;

public class InnerAcmeDomainValidationTagsItemsFactory(Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.CertificateManager.AcmeDomainValidationTypes.TagsItems>
{

    protected override Humidifier.CertificateManager.AcmeDomainValidationTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.CertificateManager.AcmeDomainValidationTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.CertificateManager.AcmeDomainValidationTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerAcmeDomainValidationTagsItemsFactoryExtensions
{
}
