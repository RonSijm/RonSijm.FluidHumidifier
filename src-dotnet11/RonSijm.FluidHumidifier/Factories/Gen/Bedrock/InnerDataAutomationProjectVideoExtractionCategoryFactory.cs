// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationProjectVideoExtractionCategoryFactory(Action<Humidifier.Bedrock.DataAutomationProjectTypes.VideoExtractionCategory> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationProjectTypes.VideoExtractionCategory>
{

    protected override Humidifier.Bedrock.DataAutomationProjectTypes.VideoExtractionCategory Create()
    {
        var videoExtractionCategoryResult = CreateVideoExtractionCategory();
        factoryAction?.Invoke(videoExtractionCategoryResult);

        return videoExtractionCategoryResult;
    }

    private Humidifier.Bedrock.DataAutomationProjectTypes.VideoExtractionCategory CreateVideoExtractionCategory()
    {
        var videoExtractionCategoryResult = new Humidifier.Bedrock.DataAutomationProjectTypes.VideoExtractionCategory();

        return videoExtractionCategoryResult;
    }

} // End Of Class

public static class InnerDataAutomationProjectVideoExtractionCategoryFactoryExtensions
{
}
