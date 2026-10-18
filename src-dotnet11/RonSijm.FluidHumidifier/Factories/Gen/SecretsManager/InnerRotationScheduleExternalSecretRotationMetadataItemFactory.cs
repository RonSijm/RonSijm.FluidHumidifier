// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecretsManager;

public class InnerRotationScheduleExternalSecretRotationMetadataItemFactory(Action<Humidifier.SecretsManager.RotationScheduleTypes.ExternalSecretRotationMetadataItem> factoryAction = null) : SubResourceFactory<Humidifier.SecretsManager.RotationScheduleTypes.ExternalSecretRotationMetadataItem>
{

    protected override Humidifier.SecretsManager.RotationScheduleTypes.ExternalSecretRotationMetadataItem Create()
    {
        var externalSecretRotationMetadataItemResult = CreateExternalSecretRotationMetadataItem();
        factoryAction?.Invoke(externalSecretRotationMetadataItemResult);

        return externalSecretRotationMetadataItemResult;
    }

    private Humidifier.SecretsManager.RotationScheduleTypes.ExternalSecretRotationMetadataItem CreateExternalSecretRotationMetadataItem()
    {
        var externalSecretRotationMetadataItemResult = new Humidifier.SecretsManager.RotationScheduleTypes.ExternalSecretRotationMetadataItem();

        return externalSecretRotationMetadataItemResult;
    }

} // End Of Class

public static class InnerRotationScheduleExternalSecretRotationMetadataItemFactoryExtensions
{
}
