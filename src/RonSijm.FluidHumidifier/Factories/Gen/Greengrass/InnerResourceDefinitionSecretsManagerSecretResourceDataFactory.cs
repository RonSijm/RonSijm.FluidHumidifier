// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerResourceDefinitionSecretsManagerSecretResourceDataFactory(Action<Humidifier.Greengrass.ResourceDefinitionTypes.SecretsManagerSecretResourceData> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.ResourceDefinitionTypes.SecretsManagerSecretResourceData>
{

    protected override Humidifier.Greengrass.ResourceDefinitionTypes.SecretsManagerSecretResourceData Create()
    {
        var secretsManagerSecretResourceDataResult = CreateSecretsManagerSecretResourceData();
        factoryAction?.Invoke(secretsManagerSecretResourceDataResult);

        return secretsManagerSecretResourceDataResult;
    }

    private Humidifier.Greengrass.ResourceDefinitionTypes.SecretsManagerSecretResourceData CreateSecretsManagerSecretResourceData()
    {
        var secretsManagerSecretResourceDataResult = new Humidifier.Greengrass.ResourceDefinitionTypes.SecretsManagerSecretResourceData();

        return secretsManagerSecretResourceDataResult;
    }

} // End Of Class

public static class InnerResourceDefinitionSecretsManagerSecretResourceDataFactoryExtensions
{
}
