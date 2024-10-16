// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalytics;

public class InnerApplicationReferenceDataSourceCSVMappingParametersFactory(Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.CSVMappingParameters> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.CSVMappingParameters>
{

    protected override Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.CSVMappingParameters Create()
    {
        var cSVMappingParametersResult = CreateCSVMappingParameters();
        factoryAction?.Invoke(cSVMappingParametersResult);

        return cSVMappingParametersResult;
    }

    private Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.CSVMappingParameters CreateCSVMappingParameters()
    {
        var cSVMappingParametersResult = new Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.CSVMappingParameters();

        return cSVMappingParametersResult;
    }

} // End Of Class

public static class InnerApplicationReferenceDataSourceCSVMappingParametersFactoryExtensions
{
}
