// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelQualityJobDefinitionCsvFactory(Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Csv> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Csv>
{

    protected override Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Csv Create()
    {
        var csvResult = CreateCsv();
        factoryAction?.Invoke(csvResult);

        return csvResult;
    }

    private Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Csv CreateCsv()
    {
        var csvResult = new Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Csv();

        return csvResult;
    }

} // End Of Class

public static class InnerModelQualityJobDefinitionCsvFactoryExtensions
{
}
