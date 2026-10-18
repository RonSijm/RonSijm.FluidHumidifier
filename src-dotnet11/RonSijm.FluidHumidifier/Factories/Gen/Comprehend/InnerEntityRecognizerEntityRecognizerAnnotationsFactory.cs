// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class InnerEntityRecognizerEntityRecognizerAnnotationsFactory(Action<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerAnnotations> factoryAction = null) : SubResourceFactory<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerAnnotations>
{

    protected override Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerAnnotations Create()
    {
        var entityRecognizerAnnotationsResult = CreateEntityRecognizerAnnotations();
        factoryAction?.Invoke(entityRecognizerAnnotationsResult);

        return entityRecognizerAnnotationsResult;
    }

    private Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerAnnotations CreateEntityRecognizerAnnotations()
    {
        var entityRecognizerAnnotationsResult = new Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerAnnotations();

        return entityRecognizerAnnotationsResult;
    }

} // End Of Class

public static class InnerEntityRecognizerEntityRecognizerAnnotationsFactoryExtensions
{
}
