// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerTestCaseChatEntryPointParametersFactory(Action<Humidifier.Connect.TestCaseTypes.ChatEntryPointParameters> factoryAction = null) : SubResourceFactory<Humidifier.Connect.TestCaseTypes.ChatEntryPointParameters>
{

    protected override Humidifier.Connect.TestCaseTypes.ChatEntryPointParameters Create()
    {
        var chatEntryPointParametersResult = CreateChatEntryPointParameters();
        factoryAction?.Invoke(chatEntryPointParametersResult);

        return chatEntryPointParametersResult;
    }

    private Humidifier.Connect.TestCaseTypes.ChatEntryPointParameters CreateChatEntryPointParameters()
    {
        var chatEntryPointParametersResult = new Humidifier.Connect.TestCaseTypes.ChatEntryPointParameters();

        return chatEntryPointParametersResult;
    }

} // End Of Class

public static class InnerTestCaseChatEntryPointParametersFactoryExtensions
{
}
