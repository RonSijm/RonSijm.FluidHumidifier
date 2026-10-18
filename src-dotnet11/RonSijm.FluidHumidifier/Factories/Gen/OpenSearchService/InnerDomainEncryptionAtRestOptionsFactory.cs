// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainEncryptionAtRestOptionsFactory(Action<Humidifier.OpenSearchService.DomainTypes.EncryptionAtRestOptions> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.EncryptionAtRestOptions>
{

    protected override Humidifier.OpenSearchService.DomainTypes.EncryptionAtRestOptions Create()
    {
        var encryptionAtRestOptionsResult = CreateEncryptionAtRestOptions();
        factoryAction?.Invoke(encryptionAtRestOptionsResult);

        return encryptionAtRestOptionsResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.EncryptionAtRestOptions CreateEncryptionAtRestOptions()
    {
        var encryptionAtRestOptionsResult = new Humidifier.OpenSearchService.DomainTypes.EncryptionAtRestOptions();

        return encryptionAtRestOptionsResult;
    }

} // End Of Class

public static class InnerDomainEncryptionAtRestOptionsFactoryExtensions
{
}
