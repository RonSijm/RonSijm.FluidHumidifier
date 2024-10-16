// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationReferenceDataSourceCSVMappingParametersFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.CSVMappingParameters> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.CSVMappingParameters>
{

    protected override Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.CSVMappingParameters Create()
    {
        var cSVMappingParametersResult = CreateCSVMappingParameters();
        factoryAction?.Invoke(cSVMappingParametersResult);

        return cSVMappingParametersResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.CSVMappingParameters CreateCSVMappingParameters()
    {
        var cSVMappingParametersResult = new Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.CSVMappingParameters();

        return cSVMappingParametersResult;
    }

} // End Of Class

public static class InnerApplicationReferenceDataSourceCSVMappingParametersFactoryExtensions
{
}
