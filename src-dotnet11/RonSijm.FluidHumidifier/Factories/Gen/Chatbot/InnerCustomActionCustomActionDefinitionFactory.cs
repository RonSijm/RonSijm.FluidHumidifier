// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chatbot;

public class InnerCustomActionCustomActionDefinitionFactory(Action<Humidifier.Chatbot.CustomActionTypes.CustomActionDefinition> factoryAction = null) : SubResourceFactory<Humidifier.Chatbot.CustomActionTypes.CustomActionDefinition>
{

    protected override Humidifier.Chatbot.CustomActionTypes.CustomActionDefinition Create()
    {
        var customActionDefinitionResult = CreateCustomActionDefinition();
        factoryAction?.Invoke(customActionDefinitionResult);

        return customActionDefinitionResult;
    }

    private Humidifier.Chatbot.CustomActionTypes.CustomActionDefinition CreateCustomActionDefinition()
    {
        var customActionDefinitionResult = new Humidifier.Chatbot.CustomActionTypes.CustomActionDefinition();

        return customActionDefinitionResult;
    }

} // End Of Class

public static class InnerCustomActionCustomActionDefinitionFactoryExtensions
{
}
