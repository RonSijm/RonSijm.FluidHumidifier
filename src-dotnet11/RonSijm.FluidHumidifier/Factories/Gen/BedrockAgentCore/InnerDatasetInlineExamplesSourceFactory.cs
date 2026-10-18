// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerDatasetInlineExamplesSourceFactory(Action<Humidifier.BedrockAgentCore.DatasetTypes.InlineExamplesSource> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.DatasetTypes.InlineExamplesSource>
{

    protected override Humidifier.BedrockAgentCore.DatasetTypes.InlineExamplesSource Create()
    {
        var inlineExamplesSourceResult = CreateInlineExamplesSource();
        factoryAction?.Invoke(inlineExamplesSourceResult);

        return inlineExamplesSourceResult;
    }

    private Humidifier.BedrockAgentCore.DatasetTypes.InlineExamplesSource CreateInlineExamplesSource()
    {
        var inlineExamplesSourceResult = new Humidifier.BedrockAgentCore.DatasetTypes.InlineExamplesSource();

        return inlineExamplesSourceResult;
    }

} // End Of Class

public static class InnerDatasetInlineExamplesSourceFactoryExtensions
{
}
