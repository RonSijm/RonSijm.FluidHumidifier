// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class PublisherFactory(string resourceName = null, Action<Humidifier.CloudFormation.Publisher> factoryAction = null) : ResourceFactory<Humidifier.CloudFormation.Publisher>(resourceName)
{

    protected override Humidifier.CloudFormation.Publisher Create()
    {
        var publisherResult = CreatePublisher();
        factoryAction?.Invoke(publisherResult);

        return publisherResult;
    }

    private Humidifier.CloudFormation.Publisher CreatePublisher()
    {
        var publisherResult = new Humidifier.CloudFormation.Publisher
        {
            GivenName = InputResourceName,
        };

        return publisherResult;
    }

} // End Of Class

public static class PublisherFactoryExtensions
{
}
