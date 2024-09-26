// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerAgentAPISchemaFactory(Action<Humidifier.Bedrock.AgentTypes.APISchema> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.AgentTypes.APISchema>
{

    internal InnerAgentS3IdentifierFactory S3Factory { get; set; }

    protected override Humidifier.Bedrock.AgentTypes.APISchema Create()
    {
        var aPISchemaResult = CreateAPISchema();
        factoryAction?.Invoke(aPISchemaResult);

        return aPISchemaResult;
    }

    private Humidifier.Bedrock.AgentTypes.APISchema CreateAPISchema()
    {
        var aPISchemaResult = new Humidifier.Bedrock.AgentTypes.APISchema();

        return aPISchemaResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.AgentTypes.APISchema result)
    {
        base.CreateChildren(result);

        result.S3 ??= S3Factory?.Build();
    }

} // End Of Class

public static class InnerAgentAPISchemaFactoryExtensions
{
    public static CombinedResult<InnerAgentAPISchemaFactory, InnerAgentS3IdentifierFactory> WithS3(this InnerAgentAPISchemaFactory parentFactory, Action<Humidifier.Bedrock.AgentTypes.S3Identifier> subFactoryAction = null)
    {
        parentFactory.S3Factory = new InnerAgentS3IdentifierFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3Factory);
    }

    public static CombinedResult<InnerAgentAPISchemaFactory, T1, InnerAgentS3IdentifierFactory> WithS3<T1>(this CombinedResult<InnerAgentAPISchemaFactory, T1> combinedResult, Action<Humidifier.Bedrock.AgentTypes.S3Identifier> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAgentAPISchemaFactory, InnerAgentS3IdentifierFactory> WithS3<T1>(this CombinedResult<T1, InnerAgentAPISchemaFactory> combinedResult, Action<Humidifier.Bedrock.AgentTypes.S3Identifier> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAgentAPISchemaFactory, T1, T2, InnerAgentS3IdentifierFactory> WithS3<T1, T2>(this CombinedResult<InnerAgentAPISchemaFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.AgentTypes.S3Identifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAgentAPISchemaFactory, T2, InnerAgentS3IdentifierFactory> WithS3<T1, T2>(this CombinedResult<T1, InnerAgentAPISchemaFactory, T2> combinedResult, Action<Humidifier.Bedrock.AgentTypes.S3Identifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAgentAPISchemaFactory, InnerAgentS3IdentifierFactory> WithS3<T1, T2>(this CombinedResult<T1, T2, InnerAgentAPISchemaFactory> combinedResult, Action<Humidifier.Bedrock.AgentTypes.S3Identifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAgentAPISchemaFactory, T1, T2, T3, InnerAgentS3IdentifierFactory> WithS3<T1, T2, T3>(this CombinedResult<InnerAgentAPISchemaFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.AgentTypes.S3Identifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAgentAPISchemaFactory, T2, T3, InnerAgentS3IdentifierFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, InnerAgentAPISchemaFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.AgentTypes.S3Identifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAgentAPISchemaFactory, T3, InnerAgentS3IdentifierFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, InnerAgentAPISchemaFactory, T3> combinedResult, Action<Humidifier.Bedrock.AgentTypes.S3Identifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAgentAPISchemaFactory, InnerAgentS3IdentifierFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAgentAPISchemaFactory> combinedResult, Action<Humidifier.Bedrock.AgentTypes.S3Identifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAgentAPISchemaFactory, T1, T2, T3, T4, InnerAgentS3IdentifierFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<InnerAgentAPISchemaFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.AgentTypes.S3Identifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAgentAPISchemaFactory, T2, T3, T4, InnerAgentS3IdentifierFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, InnerAgentAPISchemaFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.AgentTypes.S3Identifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAgentAPISchemaFactory, T3, T4, InnerAgentS3IdentifierFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAgentAPISchemaFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.AgentTypes.S3Identifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAgentAPISchemaFactory, T4, InnerAgentS3IdentifierFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAgentAPISchemaFactory, T4> combinedResult, Action<Humidifier.Bedrock.AgentTypes.S3Identifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAgentAPISchemaFactory, InnerAgentS3IdentifierFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAgentAPISchemaFactory> combinedResult, Action<Humidifier.Bedrock.AgentTypes.S3Identifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T5, subFactoryAction));
}
