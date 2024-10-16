// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowS3InputFormatConfigFactory(Action<Humidifier.AppFlow.FlowTypes.S3InputFormatConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.S3InputFormatConfig>
{

    protected override Humidifier.AppFlow.FlowTypes.S3InputFormatConfig Create()
    {
        var s3InputFormatConfigResult = CreateS3InputFormatConfig();
        factoryAction?.Invoke(s3InputFormatConfigResult);

        return s3InputFormatConfigResult;
    }

    private Humidifier.AppFlow.FlowTypes.S3InputFormatConfig CreateS3InputFormatConfig()
    {
        var s3InputFormatConfigResult = new Humidifier.AppFlow.FlowTypes.S3InputFormatConfig();

        return s3InputFormatConfigResult;
    }

} // End Of Class

public static class InnerFlowS3InputFormatConfigFactoryExtensions
{
}
