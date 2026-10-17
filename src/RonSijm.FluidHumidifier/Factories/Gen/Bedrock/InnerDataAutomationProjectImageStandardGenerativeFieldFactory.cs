// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationProjectImageStandardGenerativeFieldFactory(Action<Humidifier.Bedrock.DataAutomationProjectTypes.ImageStandardGenerativeField> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationProjectTypes.ImageStandardGenerativeField>
{

    protected override Humidifier.Bedrock.DataAutomationProjectTypes.ImageStandardGenerativeField Create()
    {
        var imageStandardGenerativeFieldResult = CreateImageStandardGenerativeField();
        factoryAction?.Invoke(imageStandardGenerativeFieldResult);

        return imageStandardGenerativeFieldResult;
    }

    private Humidifier.Bedrock.DataAutomationProjectTypes.ImageStandardGenerativeField CreateImageStandardGenerativeField()
    {
        var imageStandardGenerativeFieldResult = new Humidifier.Bedrock.DataAutomationProjectTypes.ImageStandardGenerativeField();

        return imageStandardGenerativeFieldResult;
    }

} // End Of Class

public static class InnerDataAutomationProjectImageStandardGenerativeFieldFactoryExtensions
{
}
