// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDataQualityJobDefinitionStatisticsResourceFactory(Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.StatisticsResource> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DataQualityJobDefinitionTypes.StatisticsResource>
{

    protected override Humidifier.SageMaker.DataQualityJobDefinitionTypes.StatisticsResource Create()
    {
        var statisticsResourceResult = CreateStatisticsResource();
        factoryAction?.Invoke(statisticsResourceResult);

        return statisticsResourceResult;
    }

    private Humidifier.SageMaker.DataQualityJobDefinitionTypes.StatisticsResource CreateStatisticsResource()
    {
        var statisticsResourceResult = new Humidifier.SageMaker.DataQualityJobDefinitionTypes.StatisticsResource();

        return statisticsResourceResult;
    }

} // End Of Class

public static class InnerDataQualityJobDefinitionStatisticsResourceFactoryExtensions
{
}
