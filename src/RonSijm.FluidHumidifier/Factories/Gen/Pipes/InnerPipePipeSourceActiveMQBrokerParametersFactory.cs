// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipePipeSourceActiveMQBrokerParametersFactory(Action<Humidifier.Pipes.PipeTypes.PipeSourceActiveMQBrokerParameters> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.PipeSourceActiveMQBrokerParameters>
{

    internal InnerPipeMQBrokerAccessCredentialsFactory CredentialsFactory { get; set; }

    protected override Humidifier.Pipes.PipeTypes.PipeSourceActiveMQBrokerParameters Create()
    {
        var pipeSourceActiveMQBrokerParametersResult = CreatePipeSourceActiveMQBrokerParameters();
        factoryAction?.Invoke(pipeSourceActiveMQBrokerParametersResult);

        return pipeSourceActiveMQBrokerParametersResult;
    }

    private Humidifier.Pipes.PipeTypes.PipeSourceActiveMQBrokerParameters CreatePipeSourceActiveMQBrokerParameters()
    {
        var pipeSourceActiveMQBrokerParametersResult = new Humidifier.Pipes.PipeTypes.PipeSourceActiveMQBrokerParameters();

        return pipeSourceActiveMQBrokerParametersResult;
    }
    public override void CreateChildren(Humidifier.Pipes.PipeTypes.PipeSourceActiveMQBrokerParameters result)
    {
        base.CreateChildren(result);

        result.Credentials ??= CredentialsFactory?.Build();
    }

} // End Of Class

public static class InnerPipePipeSourceActiveMQBrokerParametersFactoryExtensions
{
    public static CombinedResult<InnerPipePipeSourceActiveMQBrokerParametersFactory, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials(this InnerPipePipeSourceActiveMQBrokerParametersFactory parentFactory, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null)
    {
        parentFactory.CredentialsFactory = new InnerPipeMQBrokerAccessCredentialsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CredentialsFactory);
    }

    public static CombinedResult<InnerPipePipeSourceActiveMQBrokerParametersFactory, T1, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1>(this CombinedResult<InnerPipePipeSourceActiveMQBrokerParametersFactory, T1> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, WithCredentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeSourceActiveMQBrokerParametersFactory, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1>(this CombinedResult<T1, InnerPipePipeSourceActiveMQBrokerParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, WithCredentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPipePipeSourceActiveMQBrokerParametersFactory, T1, T2, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1, T2>(this CombinedResult<InnerPipePipeSourceActiveMQBrokerParametersFactory, T1, T2> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeSourceActiveMQBrokerParametersFactory, T2, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1, T2>(this CombinedResult<T1, InnerPipePipeSourceActiveMQBrokerParametersFactory, T2> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipePipeSourceActiveMQBrokerParametersFactory, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1, T2>(this CombinedResult<T1, T2, InnerPipePipeSourceActiveMQBrokerParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPipePipeSourceActiveMQBrokerParametersFactory, T1, T2, T3, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1, T2, T3>(this CombinedResult<InnerPipePipeSourceActiveMQBrokerParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeSourceActiveMQBrokerParametersFactory, T2, T3, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1, T2, T3>(this CombinedResult<T1, InnerPipePipeSourceActiveMQBrokerParametersFactory, T2, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipePipeSourceActiveMQBrokerParametersFactory, T3, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1, T2, T3>(this CombinedResult<T1, T2, InnerPipePipeSourceActiveMQBrokerParametersFactory, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipePipeSourceActiveMQBrokerParametersFactory, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPipePipeSourceActiveMQBrokerParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPipePipeSourceActiveMQBrokerParametersFactory, T1, T2, T3, T4, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<InnerPipePipeSourceActiveMQBrokerParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeSourceActiveMQBrokerParametersFactory, T2, T3, T4, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<T1, InnerPipePipeSourceActiveMQBrokerParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipePipeSourceActiveMQBrokerParametersFactory, T3, T4, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPipePipeSourceActiveMQBrokerParametersFactory, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipePipeSourceActiveMQBrokerParametersFactory, T4, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPipePipeSourceActiveMQBrokerParametersFactory, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPipePipeSourceActiveMQBrokerParametersFactory, InnerPipeMQBrokerAccessCredentialsFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPipePipeSourceActiveMQBrokerParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.MQBrokerAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T5, subFactoryAction));
}
