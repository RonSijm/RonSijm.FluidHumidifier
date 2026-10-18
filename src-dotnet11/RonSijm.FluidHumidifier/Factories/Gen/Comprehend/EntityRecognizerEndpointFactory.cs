// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class EntityRecognizerEndpointFactory(string resourceName = null, Action<Humidifier.Comprehend.EntityRecognizerEndpoint> factoryAction = null) : ResourceFactory<Humidifier.Comprehend.EntityRecognizerEndpoint>(resourceName)
{

    protected override Humidifier.Comprehend.EntityRecognizerEndpoint Create()
    {
        var entityRecognizerEndpointResult = CreateEntityRecognizerEndpoint();
        factoryAction?.Invoke(entityRecognizerEndpointResult);

        return entityRecognizerEndpointResult;
    }

    private Humidifier.Comprehend.EntityRecognizerEndpoint CreateEntityRecognizerEndpoint()
    {
        var entityRecognizerEndpointResult = new Humidifier.Comprehend.EntityRecognizerEndpoint
        {
            GivenName = InputResourceName,
        };

        return entityRecognizerEndpointResult;
    }

} // End Of Class

public static class EntityRecognizerEndpointFactoryExtensions
{
}
