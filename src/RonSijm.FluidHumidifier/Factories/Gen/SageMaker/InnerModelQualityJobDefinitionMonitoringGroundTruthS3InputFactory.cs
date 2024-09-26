// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelQualityJobDefinitionMonitoringGroundTruthS3InputFactory(Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.MonitoringGroundTruthS3Input> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.MonitoringGroundTruthS3Input>
{

    protected override Humidifier.SageMaker.ModelQualityJobDefinitionTypes.MonitoringGroundTruthS3Input Create()
    {
        var monitoringGroundTruthS3InputResult = CreateMonitoringGroundTruthS3Input();
        factoryAction?.Invoke(monitoringGroundTruthS3InputResult);

        return monitoringGroundTruthS3InputResult;
    }

    private Humidifier.SageMaker.ModelQualityJobDefinitionTypes.MonitoringGroundTruthS3Input CreateMonitoringGroundTruthS3Input()
    {
        var monitoringGroundTruthS3InputResult = new Humidifier.SageMaker.ModelQualityJobDefinitionTypes.MonitoringGroundTruthS3Input();

        return monitoringGroundTruthS3InputResult;
    }

} // End Of Class

public static class InnerModelQualityJobDefinitionMonitoringGroundTruthS3InputFactoryExtensions
{
}
