// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class RetrievalInstructionFactory(string resourceName = null, Action<Humidifier.Bedrock.RetrievalInstruction> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.RetrievalInstruction>(resourceName)
{

    internal InnerRetrievalInstructionInstructionFactory InstructionFactory { get; set; }

    protected override Humidifier.Bedrock.RetrievalInstruction Create()
    {
        var retrievalInstructionResult = CreateRetrievalInstruction();
        factoryAction?.Invoke(retrievalInstructionResult);

        return retrievalInstructionResult;
    }

    private Humidifier.Bedrock.RetrievalInstruction CreateRetrievalInstruction()
    {
        var retrievalInstructionResult = new Humidifier.Bedrock.RetrievalInstruction
        {
            GivenName = InputResourceName,
        };

        return retrievalInstructionResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.RetrievalInstruction result)
    {
        base.CreateChildren(result);

        result.Instruction ??= InstructionFactory?.Build();
    }

} // End Of Class

public static class RetrievalInstructionFactoryExtensions
{
    public static CombinedResult<RetrievalInstructionFactory, InnerRetrievalInstructionInstructionFactory> WithInstruction(this RetrievalInstructionFactory parentFactory, Action<Humidifier.Bedrock.RetrievalInstructionTypes.Instruction> subFactoryAction = null)
    {
        parentFactory.InstructionFactory = new InnerRetrievalInstructionInstructionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InstructionFactory);
    }

    public static CombinedResult<RetrievalInstructionFactory, T1, InnerRetrievalInstructionInstructionFactory> WithInstruction<T1>(this CombinedResult<RetrievalInstructionFactory, T1> combinedResult, Action<Humidifier.Bedrock.RetrievalInstructionTypes.Instruction> subFactoryAction = null) => new (combinedResult, combinedResult, WithInstruction(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RetrievalInstructionFactory, InnerRetrievalInstructionInstructionFactory> WithInstruction<T1>(this CombinedResult<T1, RetrievalInstructionFactory> combinedResult, Action<Humidifier.Bedrock.RetrievalInstructionTypes.Instruction> subFactoryAction = null) => new (combinedResult, combinedResult, WithInstruction(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<RetrievalInstructionFactory, T1, T2, InnerRetrievalInstructionInstructionFactory> WithInstruction<T1, T2>(this CombinedResult<RetrievalInstructionFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.RetrievalInstructionTypes.Instruction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstruction(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RetrievalInstructionFactory, T2, InnerRetrievalInstructionInstructionFactory> WithInstruction<T1, T2>(this CombinedResult<T1, RetrievalInstructionFactory, T2> combinedResult, Action<Humidifier.Bedrock.RetrievalInstructionTypes.Instruction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstruction(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RetrievalInstructionFactory, InnerRetrievalInstructionInstructionFactory> WithInstruction<T1, T2>(this CombinedResult<T1, T2, RetrievalInstructionFactory> combinedResult, Action<Humidifier.Bedrock.RetrievalInstructionTypes.Instruction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstruction(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<RetrievalInstructionFactory, T1, T2, T3, InnerRetrievalInstructionInstructionFactory> WithInstruction<T1, T2, T3>(this CombinedResult<RetrievalInstructionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.RetrievalInstructionTypes.Instruction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstruction(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RetrievalInstructionFactory, T2, T3, InnerRetrievalInstructionInstructionFactory> WithInstruction<T1, T2, T3>(this CombinedResult<T1, RetrievalInstructionFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.RetrievalInstructionTypes.Instruction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstruction(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RetrievalInstructionFactory, T3, InnerRetrievalInstructionInstructionFactory> WithInstruction<T1, T2, T3>(this CombinedResult<T1, T2, RetrievalInstructionFactory, T3> combinedResult, Action<Humidifier.Bedrock.RetrievalInstructionTypes.Instruction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstruction(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RetrievalInstructionFactory, InnerRetrievalInstructionInstructionFactory> WithInstruction<T1, T2, T3>(this CombinedResult<T1, T2, T3, RetrievalInstructionFactory> combinedResult, Action<Humidifier.Bedrock.RetrievalInstructionTypes.Instruction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstruction(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<RetrievalInstructionFactory, T1, T2, T3, T4, InnerRetrievalInstructionInstructionFactory> WithInstruction<T1, T2, T3, T4>(this CombinedResult<RetrievalInstructionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.RetrievalInstructionTypes.Instruction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstruction(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RetrievalInstructionFactory, T2, T3, T4, InnerRetrievalInstructionInstructionFactory> WithInstruction<T1, T2, T3, T4>(this CombinedResult<T1, RetrievalInstructionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.RetrievalInstructionTypes.Instruction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstruction(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RetrievalInstructionFactory, T3, T4, InnerRetrievalInstructionInstructionFactory> WithInstruction<T1, T2, T3, T4>(this CombinedResult<T1, T2, RetrievalInstructionFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.RetrievalInstructionTypes.Instruction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstruction(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RetrievalInstructionFactory, T4, InnerRetrievalInstructionInstructionFactory> WithInstruction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RetrievalInstructionFactory, T4> combinedResult, Action<Humidifier.Bedrock.RetrievalInstructionTypes.Instruction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstruction(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, RetrievalInstructionFactory, InnerRetrievalInstructionInstructionFactory> WithInstruction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RetrievalInstructionFactory> combinedResult, Action<Humidifier.Bedrock.RetrievalInstructionTypes.Instruction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstruction(combinedResult.T5, subFactoryAction).T2);
}
