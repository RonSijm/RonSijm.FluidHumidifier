// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerClassifierJsonClassifierFactory(Action<Humidifier.Glue.ClassifierTypes.JsonClassifier> factoryAction = null) : SubResourceFactory<Humidifier.Glue.ClassifierTypes.JsonClassifier>
{

    protected override Humidifier.Glue.ClassifierTypes.JsonClassifier Create()
    {
        var jsonClassifierResult = CreateJsonClassifier();
        factoryAction?.Invoke(jsonClassifierResult);

        return jsonClassifierResult;
    }

    private Humidifier.Glue.ClassifierTypes.JsonClassifier CreateJsonClassifier()
    {
        var jsonClassifierResult = new Humidifier.Glue.ClassifierTypes.JsonClassifier();

        return jsonClassifierResult;
    }

} // End Of Class

public static class InnerClassifierJsonClassifierFactoryExtensions
{
}
