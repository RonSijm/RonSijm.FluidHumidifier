// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelExplainabilityJobDefinitionCsvFactory(Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.Csv> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.Csv>
{

    protected override Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.Csv Create()
    {
        var csvResult = CreateCsv();
        factoryAction?.Invoke(csvResult);

        return csvResult;
    }

    private Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.Csv CreateCsv()
    {
        var csvResult = new Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.Csv();

        return csvResult;
    }

} // End Of Class

public static class InnerModelExplainabilityJobDefinitionCsvFactoryExtensions
{
}
