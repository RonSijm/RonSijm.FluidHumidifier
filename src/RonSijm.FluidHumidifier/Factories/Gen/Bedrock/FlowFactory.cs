// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class FlowFactory(string resourceName = null, Action<Humidifier.Bedrock.Flow> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.Flow>(resourceName)
{

    internal InnerFlowFlowDefinitionFactory DefinitionFactory { get; set; }

    internal InnerFlowS3LocationFactory DefinitionS3LocationFactory { get; set; }

    protected override Humidifier.Bedrock.Flow Create()
    {
        var flowResult = CreateFlow();
        factoryAction?.Invoke(flowResult);

        return flowResult;
    }

    private Humidifier.Bedrock.Flow CreateFlow()
    {
        var flowResult = new Humidifier.Bedrock.Flow
        {
            GivenName = InputResourceName,
        };

        return flowResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.Flow result)
    {
        base.CreateChildren(result);

        result.Definition ??= DefinitionFactory?.Build();
        result.DefinitionS3Location ??= DefinitionS3LocationFactory?.Build();
    }

} // End Of Class

public static class FlowFactoryExtensions
{
    public static CombinedResult<FlowFactory, InnerFlowFlowDefinitionFactory> WithDefinition(this FlowFactory parentFactory, Action<Humidifier.Bedrock.FlowTypes.FlowDefinition> subFactoryAction = null)
    {
        parentFactory.DefinitionFactory = new InnerFlowFlowDefinitionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefinitionFactory);
    }

    public static CombinedResult<FlowFactory, InnerFlowS3LocationFactory> WithDefinitionS3Location(this FlowFactory parentFactory, Action<Humidifier.Bedrock.FlowTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.DefinitionS3LocationFactory = new InnerFlowS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefinitionS3LocationFactory);
    }

    public static CombinedResult<FlowFactory, T1, InnerFlowFlowDefinitionFactory> WithDefinition<T1>(this CombinedResult<FlowFactory, T1> combinedResult, Action<Humidifier.Bedrock.FlowTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowFactory, InnerFlowFlowDefinitionFactory> WithDefinition<T1>(this CombinedResult<T1, FlowFactory> combinedResult, Action<Humidifier.Bedrock.FlowTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FlowFactory, T1, T2, InnerFlowFlowDefinitionFactory> WithDefinition<T1, T2>(this CombinedResult<FlowFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.FlowTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowFactory, T2, InnerFlowFlowDefinitionFactory> WithDefinition<T1, T2>(this CombinedResult<T1, FlowFactory, T2> combinedResult, Action<Humidifier.Bedrock.FlowTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlowFactory, InnerFlowFlowDefinitionFactory> WithDefinition<T1, T2>(this CombinedResult<T1, T2, FlowFactory> combinedResult, Action<Humidifier.Bedrock.FlowTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FlowFactory, T1, T2, T3, InnerFlowFlowDefinitionFactory> WithDefinition<T1, T2, T3>(this CombinedResult<FlowFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.FlowTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowFactory, T2, T3, InnerFlowFlowDefinitionFactory> WithDefinition<T1, T2, T3>(this CombinedResult<T1, FlowFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.FlowTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlowFactory, T3, InnerFlowFlowDefinitionFactory> WithDefinition<T1, T2, T3>(this CombinedResult<T1, T2, FlowFactory, T3> combinedResult, Action<Humidifier.Bedrock.FlowTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FlowFactory, InnerFlowFlowDefinitionFactory> WithDefinition<T1, T2, T3>(this CombinedResult<T1, T2, T3, FlowFactory> combinedResult, Action<Humidifier.Bedrock.FlowTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FlowFactory, T1, T2, T3, T4, InnerFlowFlowDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<FlowFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.FlowTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowFactory, T2, T3, T4, InnerFlowFlowDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, FlowFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.FlowTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlowFactory, T3, T4, InnerFlowFlowDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, FlowFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.FlowTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FlowFactory, T4, InnerFlowFlowDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FlowFactory, T4> combinedResult, Action<Humidifier.Bedrock.FlowTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FlowFactory, InnerFlowFlowDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FlowFactory> combinedResult, Action<Humidifier.Bedrock.FlowTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T5, subFactoryAction));
    public static CombinedResult<FlowFactory, T1, InnerFlowS3LocationFactory> WithDefinitionS3Location<T1>(this CombinedResult<FlowFactory, T1> combinedResult, Action<Humidifier.Bedrock.FlowTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefinitionS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowFactory, InnerFlowS3LocationFactory> WithDefinitionS3Location<T1>(this CombinedResult<T1, FlowFactory> combinedResult, Action<Humidifier.Bedrock.FlowTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefinitionS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FlowFactory, T1, T2, InnerFlowS3LocationFactory> WithDefinitionS3Location<T1, T2>(this CombinedResult<FlowFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.FlowTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinitionS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowFactory, T2, InnerFlowS3LocationFactory> WithDefinitionS3Location<T1, T2>(this CombinedResult<T1, FlowFactory, T2> combinedResult, Action<Humidifier.Bedrock.FlowTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinitionS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlowFactory, InnerFlowS3LocationFactory> WithDefinitionS3Location<T1, T2>(this CombinedResult<T1, T2, FlowFactory> combinedResult, Action<Humidifier.Bedrock.FlowTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinitionS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FlowFactory, T1, T2, T3, InnerFlowS3LocationFactory> WithDefinitionS3Location<T1, T2, T3>(this CombinedResult<FlowFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.FlowTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowFactory, T2, T3, InnerFlowS3LocationFactory> WithDefinitionS3Location<T1, T2, T3>(this CombinedResult<T1, FlowFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.FlowTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlowFactory, T3, InnerFlowS3LocationFactory> WithDefinitionS3Location<T1, T2, T3>(this CombinedResult<T1, T2, FlowFactory, T3> combinedResult, Action<Humidifier.Bedrock.FlowTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FlowFactory, InnerFlowS3LocationFactory> WithDefinitionS3Location<T1, T2, T3>(this CombinedResult<T1, T2, T3, FlowFactory> combinedResult, Action<Humidifier.Bedrock.FlowTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FlowFactory, T1, T2, T3, T4, InnerFlowS3LocationFactory> WithDefinitionS3Location<T1, T2, T3, T4>(this CombinedResult<FlowFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.FlowTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowFactory, T2, T3, T4, InnerFlowS3LocationFactory> WithDefinitionS3Location<T1, T2, T3, T4>(this CombinedResult<T1, FlowFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.FlowTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlowFactory, T3, T4, InnerFlowS3LocationFactory> WithDefinitionS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, FlowFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.FlowTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FlowFactory, T4, InnerFlowS3LocationFactory> WithDefinitionS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FlowFactory, T4> combinedResult, Action<Humidifier.Bedrock.FlowTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FlowFactory, InnerFlowS3LocationFactory> WithDefinitionS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FlowFactory> combinedResult, Action<Humidifier.Bedrock.FlowTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinitionS3Location(combinedResult.T5, subFactoryAction));
}
