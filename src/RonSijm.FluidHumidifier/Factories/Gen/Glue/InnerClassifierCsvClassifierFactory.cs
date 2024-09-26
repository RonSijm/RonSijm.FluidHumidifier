// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerClassifierCsvClassifierFactory(Action<Humidifier.Glue.ClassifierTypes.CsvClassifier> factoryAction = null) : SubResourceFactory<Humidifier.Glue.ClassifierTypes.CsvClassifier>
{

    protected override Humidifier.Glue.ClassifierTypes.CsvClassifier Create()
    {
        var csvClassifierResult = CreateCsvClassifier();
        factoryAction?.Invoke(csvClassifierResult);

        return csvClassifierResult;
    }

    private Humidifier.Glue.ClassifierTypes.CsvClassifier CreateCsvClassifier()
    {
        var csvClassifierResult = new Humidifier.Glue.ClassifierTypes.CsvClassifier();

        return csvClassifierResult;
    }

} // End Of Class

public static class InnerClassifierCsvClassifierFactoryExtensions
{
}
