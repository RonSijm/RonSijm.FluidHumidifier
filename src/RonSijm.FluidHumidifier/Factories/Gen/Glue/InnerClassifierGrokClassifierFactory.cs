// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerClassifierGrokClassifierFactory(Action<Humidifier.Glue.ClassifierTypes.GrokClassifier> factoryAction = null) : SubResourceFactory<Humidifier.Glue.ClassifierTypes.GrokClassifier>
{

    protected override Humidifier.Glue.ClassifierTypes.GrokClassifier Create()
    {
        var grokClassifierResult = CreateGrokClassifier();
        factoryAction?.Invoke(grokClassifierResult);

        return grokClassifierResult;
    }

    private Humidifier.Glue.ClassifierTypes.GrokClassifier CreateGrokClassifier()
    {
        var grokClassifierResult = new Humidifier.Glue.ClassifierTypes.GrokClassifier();

        return grokClassifierResult;
    }

} // End Of Class

public static class InnerClassifierGrokClassifierFactoryExtensions
{
}
