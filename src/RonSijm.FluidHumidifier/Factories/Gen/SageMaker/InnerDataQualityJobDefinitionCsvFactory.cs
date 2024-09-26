// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDataQualityJobDefinitionCsvFactory(Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Csv> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Csv>
{

    protected override Humidifier.SageMaker.DataQualityJobDefinitionTypes.Csv Create()
    {
        var csvResult = CreateCsv();
        factoryAction?.Invoke(csvResult);

        return csvResult;
    }

    private Humidifier.SageMaker.DataQualityJobDefinitionTypes.Csv CreateCsv()
    {
        var csvResult = new Humidifier.SageMaker.DataQualityJobDefinitionTypes.Csv();

        return csvResult;
    }

} // End Of Class

public static class InnerDataQualityJobDefinitionCsvFactoryExtensions
{
}
