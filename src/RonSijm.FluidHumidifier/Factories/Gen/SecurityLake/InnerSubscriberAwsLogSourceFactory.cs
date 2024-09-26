// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityLake;

public class InnerSubscriberAwsLogSourceFactory(Action<Humidifier.SecurityLake.SubscriberTypes.AwsLogSource> factoryAction = null) : SubResourceFactory<Humidifier.SecurityLake.SubscriberTypes.AwsLogSource>
{

    protected override Humidifier.SecurityLake.SubscriberTypes.AwsLogSource Create()
    {
        var awsLogSourceResult = CreateAwsLogSource();
        factoryAction?.Invoke(awsLogSourceResult);

        return awsLogSourceResult;
    }

    private Humidifier.SecurityLake.SubscriberTypes.AwsLogSource CreateAwsLogSource()
    {
        var awsLogSourceResult = new Humidifier.SecurityLake.SubscriberTypes.AwsLogSource();

        return awsLogSourceResult;
    }

} // End Of Class

public static class InnerSubscriberAwsLogSourceFactoryExtensions
{
}
