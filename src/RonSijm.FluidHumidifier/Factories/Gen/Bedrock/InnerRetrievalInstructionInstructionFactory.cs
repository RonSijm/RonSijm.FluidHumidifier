// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerRetrievalInstructionInstructionFactory(Action<Humidifier.Bedrock.RetrievalInstructionTypes.Instruction> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.RetrievalInstructionTypes.Instruction>
{

    protected override Humidifier.Bedrock.RetrievalInstructionTypes.Instruction Create()
    {
        var instructionResult = CreateInstruction();
        factoryAction?.Invoke(instructionResult);

        return instructionResult;
    }

    private Humidifier.Bedrock.RetrievalInstructionTypes.Instruction CreateInstruction()
    {
        var instructionResult = new Humidifier.Bedrock.RetrievalInstructionTypes.Instruction();

        return instructionResult;
    }

} // End Of Class

public static class InnerRetrievalInstructionInstructionFactoryExtensions
{
}
