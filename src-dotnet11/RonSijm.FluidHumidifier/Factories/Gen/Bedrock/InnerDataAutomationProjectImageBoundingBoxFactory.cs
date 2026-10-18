// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationProjectImageBoundingBoxFactory(Action<Humidifier.Bedrock.DataAutomationProjectTypes.ImageBoundingBox> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationProjectTypes.ImageBoundingBox>
{

    protected override Humidifier.Bedrock.DataAutomationProjectTypes.ImageBoundingBox Create()
    {
        var imageBoundingBoxResult = CreateImageBoundingBox();
        factoryAction?.Invoke(imageBoundingBoxResult);

        return imageBoundingBoxResult;
    }

    private Humidifier.Bedrock.DataAutomationProjectTypes.ImageBoundingBox CreateImageBoundingBox()
    {
        var imageBoundingBoxResult = new Humidifier.Bedrock.DataAutomationProjectTypes.ImageBoundingBox();

        return imageBoundingBoxResult;
    }

} // End Of Class

public static class InnerDataAutomationProjectImageBoundingBoxFactoryExtensions
{
}
