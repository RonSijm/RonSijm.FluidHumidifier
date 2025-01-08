// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerTransformerSampleDocumentsFactory(Action<Humidifier.B2BI.TransformerTypes.SampleDocuments> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.TransformerTypes.SampleDocuments>
{

    protected override Humidifier.B2BI.TransformerTypes.SampleDocuments Create()
    {
        var sampleDocumentsResult = CreateSampleDocuments();
        factoryAction?.Invoke(sampleDocumentsResult);

        return sampleDocumentsResult;
    }

    private Humidifier.B2BI.TransformerTypes.SampleDocuments CreateSampleDocuments()
    {
        var sampleDocumentsResult = new Humidifier.B2BI.TransformerTypes.SampleDocuments();

        return sampleDocumentsResult;
    }

} // End Of Class

public static class InnerTransformerSampleDocumentsFactoryExtensions
{
}
