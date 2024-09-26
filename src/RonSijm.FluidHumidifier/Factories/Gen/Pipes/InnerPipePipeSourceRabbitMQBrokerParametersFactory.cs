// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipePipeSourceRabbitMQBrokerParametersFactory(Action<Humidifier.Pipes.PipeTypes.PipeSourceRabbitMQBrokerParameters> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.PipeSourceRabbitMQBrokerParameters>
{

    internal InnerPipeMQBrokerAccessCredentialsFactory CredentialsFactory { get; set; }

    protected override Humidifier.Pipes.PipeTypes.PipeSourceRabbitMQBrokerParameters Create()
    {
        var pipeSourceRabbitMQBrokerParametersResult = CreatePipeSourceRabbitMQBrokerParameters();
        factoryAction?.Invoke(pipeSourceRabbitMQBrokerParametersResult);

        return pipeSourceRabbitMQBrokerParametersResult;
    }

    private Humidifier.Pipes.PipeTypes.PipeSourceRabbitMQBrokerParameters CreatePipeSourceRabbitMQBrokerParameters()
    {
        var pipeSourceRabbitMQBrokerParametersResult = new Humidifier.Pipes.PipeTypes.PipeSourceRabbitMQBrokerParameters();

        return pipeSourceRabbitMQBrokerParametersResult;
    }
    public override void CreateChildren(Humidifier.Pipes.PipeTypes.PipeSourceRabbitMQBrokerParameters result)
    {
        base.CreateChildren(result);

        result.Credentials ??= CredentialsFactory?.Build();
    }

} // End Of Class

public static class InnerPipePipeSourceRabbitMQBrokerParametersFactoryExtensions
{
    public static CombinedResult<InnerPipePipeSourceRabbitMQBrokerParametersFactory, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials(this InnerPipePipeSourceRabbitMQBrokerParametersFactory parentFactory, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null)
    {
        parentFactory.CredentialsFactory = new InnerPipeMQBrokerAccessCredentialsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CredentialsFactory);
    }

    public static CombinedResult<InnerPipePipeSourceRabbitMQBrokerParametersFactory, T1, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1>(this CombinedResult<InnerPipePipeSourceRabbitMQBrokerParametersFactory, T1> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, WithCredentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeSourceRabbitMQBrokerParametersFactory, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1>(this CombinedResult<T1, InnerPipePipeSourceRabbitMQBrokerParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, WithCredentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPipePipeSourceRabbitMQBrokerParametersFactory, T1, T2, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1, T2>(this CombinedResult<InnerPipePipeSourceRabbitMQBrokerParametersFactory, T1, T2> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeSourceRabbitMQBrokerParametersFactory, T2, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1, T2>(this CombinedResult<T1, InnerPipePipeSourceRabbitMQBrokerParametersFactory, T2> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipePipeSourceRabbitMQBrokerParametersFactory, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1, T2>(this CombinedResult<T1, T2, InnerPipePipeSourceRabbitMQBrokerParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPipePipeSourceRabbitMQBrokerParametersFactory, T1, T2, T3, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1, T2, T3>(this CombinedResult<InnerPipePipeSourceRabbitMQBrokerParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeSourceRabbitMQBrokerParametersFactory, T2, T3, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1, T2, T3>(this CombinedResult<T1, InnerPipePipeSourceRabbitMQBrokerParametersFactory, T2, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipePipeSourceRabbitMQBrokerParametersFactory, T3, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1, T2, T3>(this CombinedResult<T1, T2, InnerPipePipeSourceRabbitMQBrokerParametersFactory, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipePipeSourceRabbitMQBrokerParametersFactory, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPipePipeSourceRabbitMQBrokerParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPipePipeSourceRabbitMQBrokerParametersFactory, T1, T2, T3, T4, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<InnerPipePipeSourceRabbitMQBrokerParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeSourceRabbitMQBrokerParametersFactory, T2, T3, T4, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<T1, InnerPipePipeSourceRabbitMQBrokerParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipePipeSourceRabbitMQBrokerParametersFactory, T3, T4, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPipePipeSourceRabbitMQBrokerParametersFactory, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipePipeSourceRabbitMQBrokerParametersFactory, T4, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPipePipeSourceRabbitMQBrokerParametersFactory, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPipePipeSourceRabbitMQBrokerParametersFactory, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPipePipeSourceRabbitMQBrokerParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T5, subFactoryAction));
}
