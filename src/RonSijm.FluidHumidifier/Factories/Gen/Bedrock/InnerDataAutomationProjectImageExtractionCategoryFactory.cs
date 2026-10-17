// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationProjectImageExtractionCategoryFactory(Action<Humidifier.Bedrock.DataAutomationProjectTypes.ImageExtractionCategory> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationProjectTypes.ImageExtractionCategory>
{

    protected override Humidifier.Bedrock.DataAutomationProjectTypes.ImageExtractionCategory Create()
    {
        var imageExtractionCategoryResult = CreateImageExtractionCategory();
        factoryAction?.Invoke(imageExtractionCategoryResult);

        return imageExtractionCategoryResult;
    }

    private Humidifier.Bedrock.DataAutomationProjectTypes.ImageExtractionCategory CreateImageExtractionCategory()
    {
        var imageExtractionCategoryResult = new Humidifier.Bedrock.DataAutomationProjectTypes.ImageExtractionCategory();

        return imageExtractionCategoryResult;
    }

} // End Of Class

public static class InnerDataAutomationProjectImageExtractionCategoryFactoryExtensions
{
}
