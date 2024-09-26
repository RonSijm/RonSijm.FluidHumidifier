// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipeMQBrokerAccessCredentialsFactory(Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials>
{

    protected override Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials Create()
    {
        var mQBrokerAccessCredentialsResult = CreateMQBrokerAccessCredentials();
        factoryAction?.Invoke(mQBrokerAccessCredentialsResult);

        return mQBrokerAccessCredentialsResult;
    }

    private Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials CreateMQBrokerAccessCredentials()
    {
        var mQBrokerAccessCredentialsResult = new Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials();

        return mQBrokerAccessCredentialsResult;
    }

} // End Of Class

public static class InnerPipeMQBrokerAccessCredentialsFactoryExtensions
{
}
