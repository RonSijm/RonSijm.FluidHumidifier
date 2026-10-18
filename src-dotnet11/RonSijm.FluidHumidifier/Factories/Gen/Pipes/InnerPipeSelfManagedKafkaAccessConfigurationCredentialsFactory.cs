// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipeSelfManagedKafkaAccessConfigurationCredentialsFactory(Action<Humidifier.Pipes.PipeTypes.SelfManagedKafkaAccessConfigurationCredentials> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.SelfManagedKafkaAccessConfigurationCredentials>
{

    protected override Humidifier.Pipes.PipeTypes.SelfManagedKafkaAccessConfigurationCredentials Create()
    {
        var selfManagedKafkaAccessConfigurationCredentialsResult = CreateSelfManagedKafkaAccessConfigurationCredentials();
        factoryAction?.Invoke(selfManagedKafkaAccessConfigurationCredentialsResult);

        return selfManagedKafkaAccessConfigurationCredentialsResult;
    }

    private Humidifier.Pipes.PipeTypes.SelfManagedKafkaAccessConfigurationCredentials CreateSelfManagedKafkaAccessConfigurationCredentials()
    {
        var selfManagedKafkaAccessConfigurationCredentialsResult = new Humidifier.Pipes.PipeTypes.SelfManagedKafkaAccessConfigurationCredentials();

        return selfManagedKafkaAccessConfigurationCredentialsResult;
    }

} // End Of Class

public static class InnerPipeSelfManagedKafkaAccessConfigurationCredentialsFactoryExtensions
{
}
