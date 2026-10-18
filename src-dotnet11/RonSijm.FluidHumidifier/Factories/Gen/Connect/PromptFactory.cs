// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class PromptFactory(string resourceName = null, Action<Humidifier.Connect.Prompt> factoryAction = null) : ResourceFactory<Humidifier.Connect.Prompt>(resourceName)
{

    protected override Humidifier.Connect.Prompt Create()
    {
        var promptResult = CreatePrompt();
        factoryAction?.Invoke(promptResult);

        return promptResult;
    }

    private Humidifier.Connect.Prompt CreatePrompt()
    {
        var promptResult = new Humidifier.Connect.Prompt
        {
            GivenName = InputResourceName,
        };

        return promptResult;
    }

} // End Of Class

public static class PromptFactoryExtensions
{
}
