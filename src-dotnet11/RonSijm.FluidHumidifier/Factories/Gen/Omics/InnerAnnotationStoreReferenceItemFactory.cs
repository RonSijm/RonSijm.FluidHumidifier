// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class InnerAnnotationStoreReferenceItemFactory(Action<Humidifier.Omics.AnnotationStoreTypes.ReferenceItem> factoryAction = null) : SubResourceFactory<Humidifier.Omics.AnnotationStoreTypes.ReferenceItem>
{

    protected override Humidifier.Omics.AnnotationStoreTypes.ReferenceItem Create()
    {
        var referenceItemResult = CreateReferenceItem();
        factoryAction?.Invoke(referenceItemResult);

        return referenceItemResult;
    }

    private Humidifier.Omics.AnnotationStoreTypes.ReferenceItem CreateReferenceItem()
    {
        var referenceItemResult = new Humidifier.Omics.AnnotationStoreTypes.ReferenceItem();

        return referenceItemResult;
    }

} // End Of Class

public static class InnerAnnotationStoreReferenceItemFactoryExtensions
{
}
