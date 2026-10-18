// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationProjectVideoBoundingBoxFactory(Action<Humidifier.Bedrock.DataAutomationProjectTypes.VideoBoundingBox> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationProjectTypes.VideoBoundingBox>
{

    protected override Humidifier.Bedrock.DataAutomationProjectTypes.VideoBoundingBox Create()
    {
        var videoBoundingBoxResult = CreateVideoBoundingBox();
        factoryAction?.Invoke(videoBoundingBoxResult);

        return videoBoundingBoxResult;
    }

    private Humidifier.Bedrock.DataAutomationProjectTypes.VideoBoundingBox CreateVideoBoundingBox()
    {
        var videoBoundingBoxResult = new Humidifier.Bedrock.DataAutomationProjectTypes.VideoBoundingBox();

        return videoBoundingBoxResult;
    }

} // End Of Class

public static class InnerDataAutomationProjectVideoBoundingBoxFactoryExtensions
{
}
