// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class InnerEntityRecognizerEntityRecognizerDocumentsFactory(Action<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerDocuments> factoryAction = null) : SubResourceFactory<Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerDocuments>
{

    protected override Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerDocuments Create()
    {
        var entityRecognizerDocumentsResult = CreateEntityRecognizerDocuments();
        factoryAction?.Invoke(entityRecognizerDocumentsResult);

        return entityRecognizerDocumentsResult;
    }

    private Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerDocuments CreateEntityRecognizerDocuments()
    {
        var entityRecognizerDocumentsResult = new Humidifier.Comprehend.EntityRecognizerTypes.EntityRecognizerDocuments();

        return entityRecognizerDocumentsResult;
    }

} // End Of Class

public static class InnerEntityRecognizerEntityRecognizerDocumentsFactoryExtensions
{
}
