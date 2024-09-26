// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDataQualityJobDefinitionDataQualityJobInputFactory(Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DataQualityJobInput> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DataQualityJobInput>
{

    internal InnerDataQualityJobDefinitionBatchTransformInputFactory BatchTransformInputFactory { get; set; }

    internal InnerDataQualityJobDefinitionEndpointInputFactory EndpointInputFactory { get; set; }

    protected override Humidifier.SageMaker.DataQualityJobDefinitionTypes.DataQualityJobInput Create()
    {
        var dataQualityJobInputResult = CreateDataQualityJobInput();
        factoryAction?.Invoke(dataQualityJobInputResult);

        return dataQualityJobInputResult;
    }

    private Humidifier.SageMaker.DataQualityJobDefinitionTypes.DataQualityJobInput CreateDataQualityJobInput()
    {
        var dataQualityJobInputResult = new Humidifier.SageMaker.DataQualityJobDefinitionTypes.DataQualityJobInput();

        return dataQualityJobInputResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.DataQualityJobDefinitionTypes.DataQualityJobInput result)
    {
        base.CreateChildren(result);

        result.BatchTransformInput ??= BatchTransformInputFactory?.Build();
        result.EndpointInput ??= EndpointInputFactory?.Build();
    }

} // End Of Class

public static class InnerDataQualityJobDefinitionDataQualityJobInputFactoryExtensions
{
    public static CombinedResult<InnerDataQualityJobDefinitionDataQualityJobInputFactory, InnerDataQualityJobDefinitionBatchTransformInputFactory> WithBatchTransformInput(this InnerDataQualityJobDefinitionDataQualityJobInputFactory parentFactory, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.BatchTransformInput> subFactoryAction = null)
    {
        parentFactory.BatchTransformInputFactory = new InnerDataQualityJobDefinitionBatchTransformInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BatchTransformInputFactory);
    }

    public static CombinedResult<InnerDataQualityJobDefinitionDataQualityJobInputFactory, InnerDataQualityJobDefinitionEndpointInputFactory> WithEndpointInput(this InnerDataQualityJobDefinitionDataQualityJobInputFactory parentFactory, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.EndpointInput> subFactoryAction = null)
    {
        parentFactory.EndpointInputFactory = new InnerDataQualityJobDefinitionEndpointInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EndpointInputFactory);
    }

    public static CombinedResult<InnerDataQualityJobDefinitionDataQualityJobInputFactory, T1, InnerDataQualityJobDefinitionBatchTransformInputFactory> WithBatchTransformInput<T1>(this CombinedResult<InnerDataQualityJobDefinitionDataQualityJobInputFactory, T1> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.BatchTransformInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithBatchTransformInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionDataQualityJobInputFactory, InnerDataQualityJobDefinitionBatchTransformInputFactory> WithBatchTransformInput<T1>(this CombinedResult<T1, InnerDataQualityJobDefinitionDataQualityJobInputFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.BatchTransformInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithBatchTransformInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataQualityJobDefinitionDataQualityJobInputFactory, T1, T2, InnerDataQualityJobDefinitionBatchTransformInputFactory> WithBatchTransformInput<T1, T2>(this CombinedResult<InnerDataQualityJobDefinitionDataQualityJobInputFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.BatchTransformInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBatchTransformInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionDataQualityJobInputFactory, T2, InnerDataQualityJobDefinitionBatchTransformInputFactory> WithBatchTransformInput<T1, T2>(this CombinedResult<T1, InnerDataQualityJobDefinitionDataQualityJobInputFactory, T2> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.BatchTransformInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBatchTransformInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataQualityJobDefinitionDataQualityJobInputFactory, InnerDataQualityJobDefinitionBatchTransformInputFactory> WithBatchTransformInput<T1, T2>(this CombinedResult<T1, T2, InnerDataQualityJobDefinitionDataQualityJobInputFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.BatchTransformInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBatchTransformInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataQualityJobDefinitionDataQualityJobInputFactory, T1, T2, T3, InnerDataQualityJobDefinitionBatchTransformInputFactory> WithBatchTransformInput<T1, T2, T3>(this CombinedResult<InnerDataQualityJobDefinitionDataQualityJobInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.BatchTransformInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBatchTransformInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionDataQualityJobInputFactory, T2, T3, InnerDataQualityJobDefinitionBatchTransformInputFactory> WithBatchTransformInput<T1, T2, T3>(this CombinedResult<T1, InnerDataQualityJobDefinitionDataQualityJobInputFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.BatchTransformInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBatchTransformInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataQualityJobDefinitionDataQualityJobInputFactory, T3, InnerDataQualityJobDefinitionBatchTransformInputFactory> WithBatchTransformInput<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataQualityJobDefinitionDataQualityJobInputFactory, T3> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.BatchTransformInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBatchTransformInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionDataQualityJobInputFactory, InnerDataQualityJobDefinitionBatchTransformInputFactory> WithBatchTransformInput<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionDataQualityJobInputFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.BatchTransformInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBatchTransformInput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataQualityJobDefinitionDataQualityJobInputFactory, T1, T2, T3, T4, InnerDataQualityJobDefinitionBatchTransformInputFactory> WithBatchTransformInput<T1, T2, T3, T4>(this CombinedResult<InnerDataQualityJobDefinitionDataQualityJobInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.BatchTransformInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBatchTransformInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionDataQualityJobInputFactory, T2, T3, T4, InnerDataQualityJobDefinitionBatchTransformInputFactory> WithBatchTransformInput<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataQualityJobDefinitionDataQualityJobInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.BatchTransformInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBatchTransformInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataQualityJobDefinitionDataQualityJobInputFactory, T3, T4, InnerDataQualityJobDefinitionBatchTransformInputFactory> WithBatchTransformInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataQualityJobDefinitionDataQualityJobInputFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.BatchTransformInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBatchTransformInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionDataQualityJobInputFactory, T4, InnerDataQualityJobDefinitionBatchTransformInputFactory> WithBatchTransformInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionDataQualityJobInputFactory, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.BatchTransformInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBatchTransformInput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataQualityJobDefinitionDataQualityJobInputFactory, InnerDataQualityJobDefinitionBatchTransformInputFactory> WithBatchTransformInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataQualityJobDefinitionDataQualityJobInputFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.BatchTransformInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBatchTransformInput(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerDataQualityJobDefinitionDataQualityJobInputFactory, T1, InnerDataQualityJobDefinitionEndpointInputFactory> WithEndpointInput<T1>(this CombinedResult<InnerDataQualityJobDefinitionDataQualityJobInputFactory, T1> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.EndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndpointInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionDataQualityJobInputFactory, InnerDataQualityJobDefinitionEndpointInputFactory> WithEndpointInput<T1>(this CombinedResult<T1, InnerDataQualityJobDefinitionDataQualityJobInputFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.EndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndpointInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataQualityJobDefinitionDataQualityJobInputFactory, T1, T2, InnerDataQualityJobDefinitionEndpointInputFactory> WithEndpointInput<T1, T2>(this CombinedResult<InnerDataQualityJobDefinitionDataQualityJobInputFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.EndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpointInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionDataQualityJobInputFactory, T2, InnerDataQualityJobDefinitionEndpointInputFactory> WithEndpointInput<T1, T2>(this CombinedResult<T1, InnerDataQualityJobDefinitionDataQualityJobInputFactory, T2> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.EndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpointInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataQualityJobDefinitionDataQualityJobInputFactory, InnerDataQualityJobDefinitionEndpointInputFactory> WithEndpointInput<T1, T2>(this CombinedResult<T1, T2, InnerDataQualityJobDefinitionDataQualityJobInputFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.EndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpointInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataQualityJobDefinitionDataQualityJobInputFactory, T1, T2, T3, InnerDataQualityJobDefinitionEndpointInputFactory> WithEndpointInput<T1, T2, T3>(this CombinedResult<InnerDataQualityJobDefinitionDataQualityJobInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.EndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionDataQualityJobInputFactory, T2, T3, InnerDataQualityJobDefinitionEndpointInputFactory> WithEndpointInput<T1, T2, T3>(this CombinedResult<T1, InnerDataQualityJobDefinitionDataQualityJobInputFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.EndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataQualityJobDefinitionDataQualityJobInputFactory, T3, InnerDataQualityJobDefinitionEndpointInputFactory> WithEndpointInput<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataQualityJobDefinitionDataQualityJobInputFactory, T3> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.EndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionDataQualityJobInputFactory, InnerDataQualityJobDefinitionEndpointInputFactory> WithEndpointInput<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionDataQualityJobInputFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.EndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointInput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataQualityJobDefinitionDataQualityJobInputFactory, T1, T2, T3, T4, InnerDataQualityJobDefinitionEndpointInputFactory> WithEndpointInput<T1, T2, T3, T4>(this CombinedResult<InnerDataQualityJobDefinitionDataQualityJobInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.EndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionDataQualityJobInputFactory, T2, T3, T4, InnerDataQualityJobDefinitionEndpointInputFactory> WithEndpointInput<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataQualityJobDefinitionDataQualityJobInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.EndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataQualityJobDefinitionDataQualityJobInputFactory, T3, T4, InnerDataQualityJobDefinitionEndpointInputFactory> WithEndpointInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataQualityJobDefinitionDataQualityJobInputFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.EndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionDataQualityJobInputFactory, T4, InnerDataQualityJobDefinitionEndpointInputFactory> WithEndpointInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionDataQualityJobInputFactory, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.EndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointInput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataQualityJobDefinitionDataQualityJobInputFactory, InnerDataQualityJobDefinitionEndpointInputFactory> WithEndpointInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataQualityJobDefinitionDataQualityJobInputFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.EndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointInput(combinedResult.T5, subFactoryAction));
}
