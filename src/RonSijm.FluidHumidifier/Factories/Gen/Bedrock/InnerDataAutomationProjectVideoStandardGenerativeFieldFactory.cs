// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationProjectVideoStandardGenerativeFieldFactory(Action<Humidifier.Bedrock.DataAutomationProjectTypes.VideoStandardGenerativeField> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationProjectTypes.VideoStandardGenerativeField>
{

    protected override Humidifier.Bedrock.DataAutomationProjectTypes.VideoStandardGenerativeField Create()
    {
        var videoStandardGenerativeFieldResult = CreateVideoStandardGenerativeField();
        factoryAction?.Invoke(videoStandardGenerativeFieldResult);

        return videoStandardGenerativeFieldResult;
    }

    private Humidifier.Bedrock.DataAutomationProjectTypes.VideoStandardGenerativeField CreateVideoStandardGenerativeField()
    {
        var videoStandardGenerativeFieldResult = new Humidifier.Bedrock.DataAutomationProjectTypes.VideoStandardGenerativeField();

        return videoStandardGenerativeFieldResult;
    }

} // End Of Class

public static class InnerDataAutomationProjectVideoStandardGenerativeFieldFactoryExtensions
{
}
