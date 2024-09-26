// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelBiasJobDefinitionCsvFactory(Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Csv> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Csv>
{

    protected override Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Csv Create()
    {
        var csvResult = CreateCsv();
        factoryAction?.Invoke(csvResult);

        return csvResult;
    }

    private Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Csv CreateCsv()
    {
        var csvResult = new Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Csv();

        return csvResult;
    }

} // End Of Class

public static class InnerModelBiasJobDefinitionCsvFactoryExtensions
{
}
