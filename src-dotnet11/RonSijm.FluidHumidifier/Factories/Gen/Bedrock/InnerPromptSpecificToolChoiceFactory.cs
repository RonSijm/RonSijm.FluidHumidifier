// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerPromptSpecificToolChoiceFactory(Action<Humidifier.Bedrock.PromptTypes.SpecificToolChoice> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.PromptTypes.SpecificToolChoice>
{

    protected override Humidifier.Bedrock.PromptTypes.SpecificToolChoice Create()
    {
        var specificToolChoiceResult = CreateSpecificToolChoice();
        factoryAction?.Invoke(specificToolChoiceResult);

        return specificToolChoiceResult;
    }

    private Humidifier.Bedrock.PromptTypes.SpecificToolChoice CreateSpecificToolChoice()
    {
        var specificToolChoiceResult = new Humidifier.Bedrock.PromptTypes.SpecificToolChoice();

        return specificToolChoiceResult;
    }

} // End Of Class

public static class InnerPromptSpecificToolChoiceFactoryExtensions
{
}
