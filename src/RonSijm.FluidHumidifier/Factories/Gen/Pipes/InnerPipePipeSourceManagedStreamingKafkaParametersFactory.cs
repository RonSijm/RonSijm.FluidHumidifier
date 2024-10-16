// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipePipeSourceManagedStreamingKafkaParametersFactory(Action<Humidifier.Pipes.PipeTypes.PipeSourceManagedStreamingKafkaParameters> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.PipeSourceManagedStreamingKafkaParameters>
{

    internal InnerPipeMSKAccessCredentialsFactory CredentialsFactory { get; set; }

    protected override Humidifier.Pipes.PipeTypes.PipeSourceManagedStreamingKafkaParameters Create()
    {
        var pipeSourceManagedStreamingKafkaParametersResult = CreatePipeSourceManagedStreamingKafkaParameters();
        factoryAction?.Invoke(pipeSourceManagedStreamingKafkaParametersResult);

        return pipeSourceManagedStreamingKafkaParametersResult;
    }

    private Humidifier.Pipes.PipeTypes.PipeSourceManagedStreamingKafkaParameters CreatePipeSourceManagedStreamingKafkaParameters()
    {
        var pipeSourceManagedStreamingKafkaParametersResult = new Humidifier.Pipes.PipeTypes.PipeSourceManagedStreamingKafkaParameters();

        return pipeSourceManagedStreamingKafkaParametersResult;
    }
    public override void CreateChildren(Humidifier.Pipes.PipeTypes.PipeSourceManagedStreamingKafkaParameters result)
    {
        base.CreateChildren(result);

        result.Credentials ??= CredentialsFactory?.Build();
    }

} // End Of Class

public static class InnerPipePipeSourceManagedStreamingKafkaParametersFactoryExtensions
{
    public static CombinedResult<InnerPipePipeSourceManagedStreamingKafkaParametersFactory, InnerPipeMSKAccessCredentialsFactory> WithCredentials(this InnerPipePipeSourceManagedStreamingKafkaParametersFactory parentFactory, Action<Humidifier.Pipes.PipeTypes.MSKAccessCredentials> subFactoryAction = null)
    {
        parentFactory.CredentialsFactory = new InnerPipeMSKAccessCredentialsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CredentialsFactory);
    }

    public static CombinedResult<InnerPipePipeSourceManagedStreamingKafkaParametersFactory, T1, InnerPipeMSKAccessCredentialsFactory> WithCredentials<T1>(this CombinedResult<InnerPipePipeSourceManagedStreamingKafkaParametersFactory, T1> combinedResult, Action<Humidifier.Pipes.PipeTypes.MSKAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, WithCredentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeSourceManagedStreamingKafkaParametersFactory, InnerPipeMSKAccessCredentialsFactory> WithCredentials<T1>(this CombinedResult<T1, InnerPipePipeSourceManagedStreamingKafkaParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.MSKAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, WithCredentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPipePipeSourceManagedStreamingKafkaParametersFactory, T1, T2, InnerPipeMSKAccessCredentialsFactory> WithCredentials<T1, T2>(this CombinedResult<InnerPipePipeSourceManagedStreamingKafkaParametersFactory, T1, T2> combinedResult, Action<Humidifier.Pipes.PipeTypes.MSKAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeSourceManagedStreamingKafkaParametersFactory, T2, InnerPipeMSKAccessCredentialsFactory> WithCredentials<T1, T2>(this CombinedResult<T1, InnerPipePipeSourceManagedStreamingKafkaParametersFactory, T2> combinedResult, Action<Humidifier.Pipes.PipeTypes.MSKAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipePipeSourceManagedStreamingKafkaParametersFactory, InnerPipeMSKAccessCredentialsFactory> WithCredentials<T1, T2>(this CombinedResult<T1, T2, InnerPipePipeSourceManagedStreamingKafkaParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.MSKAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPipePipeSourceManagedStreamingKafkaParametersFactory, T1, T2, T3, InnerPipeMSKAccessCredentialsFactory> WithCredentials<T1, T2, T3>(this CombinedResult<InnerPipePipeSourceManagedStreamingKafkaParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.MSKAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeSourceManagedStreamingKafkaParametersFactory, T2, T3, InnerPipeMSKAccessCredentialsFactory> WithCredentials<T1, T2, T3>(this CombinedResult<T1, InnerPipePipeSourceManagedStreamingKafkaParametersFactory, T2, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.MSKAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipePipeSourceManagedStreamingKafkaParametersFactory, T3, InnerPipeMSKAccessCredentialsFactory> WithCredentials<T1, T2, T3>(this CombinedResult<T1, T2, InnerPipePipeSourceManagedStreamingKafkaParametersFactory, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.MSKAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipePipeSourceManagedStreamingKafkaParametersFactory, InnerPipeMSKAccessCredentialsFactory> WithCredentials<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPipePipeSourceManagedStreamingKafkaParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.MSKAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPipePipeSourceManagedStreamingKafkaParametersFactory, T1, T2, T3, T4, InnerPipeMSKAccessCredentialsFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<InnerPipePipeSourceManagedStreamingKafkaParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.MSKAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeSourceManagedStreamingKafkaParametersFactory, T2, T3, T4, InnerPipeMSKAccessCredentialsFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<T1, InnerPipePipeSourceManagedStreamingKafkaParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.MSKAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipePipeSourceManagedStreamingKafkaParametersFactory, T3, T4, InnerPipeMSKAccessCredentialsFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPipePipeSourceManagedStreamingKafkaParametersFactory, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.MSKAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipePipeSourceManagedStreamingKafkaParametersFactory, T4, InnerPipeMSKAccessCredentialsFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPipePipeSourceManagedStreamingKafkaParametersFactory, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.MSKAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPipePipeSourceManagedStreamingKafkaParametersFactory, InnerPipeMSKAccessCredentialsFactory> WithCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPipePipeSourceManagedStreamingKafkaParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.MSKAccessCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentials(combinedResult.T5, subFactoryAction));
}
