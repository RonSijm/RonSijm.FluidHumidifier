// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerResourceDefinitionVersionSecretsManagerSecretResourceDataFactory(Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.SecretsManagerSecretResourceData> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.ResourceDefinitionVersionTypes.SecretsManagerSecretResourceData>
{

    protected override Humidifier.Greengrass.ResourceDefinitionVersionTypes.SecretsManagerSecretResourceData Create()
    {
        var secretsManagerSecretResourceDataResult = CreateSecretsManagerSecretResourceData();
        factoryAction?.Invoke(secretsManagerSecretResourceDataResult);

        return secretsManagerSecretResourceDataResult;
    }

    private Humidifier.Greengrass.ResourceDefinitionVersionTypes.SecretsManagerSecretResourceData CreateSecretsManagerSecretResourceData()
    {
        var secretsManagerSecretResourceDataResult = new Humidifier.Greengrass.ResourceDefinitionVersionTypes.SecretsManagerSecretResourceData();

        return secretsManagerSecretResourceDataResult;
    }

} // End Of Class

public static class InnerResourceDefinitionVersionSecretsManagerSecretResourceDataFactoryExtensions
{
}
