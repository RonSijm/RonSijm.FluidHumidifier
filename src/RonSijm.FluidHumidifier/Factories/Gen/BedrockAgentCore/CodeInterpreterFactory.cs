// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class CodeInterpreterFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.CodeInterpreter> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.CodeInterpreter>(resourceName)
{

    protected override Humidifier.BedrockAgentCore.CodeInterpreter Create()
    {
        var codeInterpreterResult = CreateCodeInterpreter();
        factoryAction?.Invoke(codeInterpreterResult);

        return codeInterpreterResult;
    }

    private Humidifier.BedrockAgentCore.CodeInterpreter CreateCodeInterpreter()
    {
        var codeInterpreterResult = new Humidifier.BedrockAgentCore.CodeInterpreter
        {
            GivenName = InputResourceName,
        };

        return codeInterpreterResult;
    }

} // End Of Class

public static class CodeInterpreterFactoryExtensions
{
}
