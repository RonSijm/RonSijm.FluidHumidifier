// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class InnerVariantStoreReferenceItemFactory(Action<Humidifier.Omics.VariantStoreTypes.ReferenceItem> factoryAction = null) : SubResourceFactory<Humidifier.Omics.VariantStoreTypes.ReferenceItem>
{

    protected override Humidifier.Omics.VariantStoreTypes.ReferenceItem Create()
    {
        var referenceItemResult = CreateReferenceItem();
        factoryAction?.Invoke(referenceItemResult);

        return referenceItemResult;
    }

    private Humidifier.Omics.VariantStoreTypes.ReferenceItem CreateReferenceItem()
    {
        var referenceItemResult = new Humidifier.Omics.VariantStoreTypes.ReferenceItem();

        return referenceItemResult;
    }

} // End Of Class

public static class InnerVariantStoreReferenceItemFactoryExtensions
{
}
