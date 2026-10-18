// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerClassifierXMLClassifierFactory(Action<Humidifier.Glue.ClassifierTypes.XMLClassifier> factoryAction = null) : SubResourceFactory<Humidifier.Glue.ClassifierTypes.XMLClassifier>
{

    protected override Humidifier.Glue.ClassifierTypes.XMLClassifier Create()
    {
        var xMLClassifierResult = CreateXMLClassifier();
        factoryAction?.Invoke(xMLClassifierResult);

        return xMLClassifierResult;
    }

    private Humidifier.Glue.ClassifierTypes.XMLClassifier CreateXMLClassifier()
    {
        var xMLClassifierResult = new Humidifier.Glue.ClassifierTypes.XMLClassifier();

        return xMLClassifierResult;
    }

} // End Of Class

public static class InnerClassifierXMLClassifierFactoryExtensions
{
}
