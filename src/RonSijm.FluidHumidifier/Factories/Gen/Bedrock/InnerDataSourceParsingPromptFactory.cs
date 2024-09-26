// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceParsingPromptFactory(Action<Humidifier.Bedrock.DataSourceTypes.ParsingPrompt> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.ParsingPrompt>
{

    protected override Humidifier.Bedrock.DataSourceTypes.ParsingPrompt Create()
    {
        var parsingPromptResult = CreateParsingPrompt();
        factoryAction?.Invoke(parsingPromptResult);

        return parsingPromptResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.ParsingPrompt CreateParsingPrompt()
    {
        var parsingPromptResult = new Humidifier.Bedrock.DataSourceTypes.ParsingPrompt();

        return parsingPromptResult;
    }

} // End Of Class

public static class InnerDataSourceParsingPromptFactoryExtensions
{
}
