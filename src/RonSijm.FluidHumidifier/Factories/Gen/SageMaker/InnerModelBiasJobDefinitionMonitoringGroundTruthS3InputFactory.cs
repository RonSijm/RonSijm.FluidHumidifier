// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelBiasJobDefinitionMonitoringGroundTruthS3InputFactory(Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.MonitoringGroundTruthS3Input> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.MonitoringGroundTruthS3Input>
{

    protected override Humidifier.SageMaker.ModelBiasJobDefinitionTypes.MonitoringGroundTruthS3Input Create()
    {
        var monitoringGroundTruthS3InputResult = CreateMonitoringGroundTruthS3Input();
        factoryAction?.Invoke(monitoringGroundTruthS3InputResult);

        return monitoringGroundTruthS3InputResult;
    }

    private Humidifier.SageMaker.ModelBiasJobDefinitionTypes.MonitoringGroundTruthS3Input CreateMonitoringGroundTruthS3Input()
    {
        var monitoringGroundTruthS3InputResult = new Humidifier.SageMaker.ModelBiasJobDefinitionTypes.MonitoringGroundTruthS3Input();

        return monitoringGroundTruthS3InputResult;
    }

} // End Of Class

public static class InnerModelBiasJobDefinitionMonitoringGroundTruthS3InputFactoryExtensions
{
}
