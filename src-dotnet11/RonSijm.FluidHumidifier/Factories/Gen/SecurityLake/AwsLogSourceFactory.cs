// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityLake;

public class AwsLogSourceFactory(string resourceName = null, Action<Humidifier.SecurityLake.AwsLogSource> factoryAction = null) : ResourceFactory<Humidifier.SecurityLake.AwsLogSource>(resourceName)
{

    protected override Humidifier.SecurityLake.AwsLogSource Create()
    {
        var awsLogSourceResult = CreateAwsLogSource();
        factoryAction?.Invoke(awsLogSourceResult);

        return awsLogSourceResult;
    }

    private Humidifier.SecurityLake.AwsLogSource CreateAwsLogSource()
    {
        var awsLogSourceResult = new Humidifier.SecurityLake.AwsLogSource
        {
            GivenName = InputResourceName,
        };

        return awsLogSourceResult;
    }

} // End Of Class

public static class AwsLogSourceFactoryExtensions
{
}
