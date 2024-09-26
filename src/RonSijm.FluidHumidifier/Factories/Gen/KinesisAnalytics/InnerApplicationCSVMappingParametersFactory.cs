// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalytics;

public class InnerApplicationCSVMappingParametersFactory(Action<Humidifier.KinesisAnalytics.ApplicationTypes.CSVMappingParameters> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalytics.ApplicationTypes.CSVMappingParameters>
{

    protected override Humidifier.KinesisAnalytics.ApplicationTypes.CSVMappingParameters Create()
    {
        var cSVMappingParametersResult = CreateCSVMappingParameters();
        factoryAction?.Invoke(cSVMappingParametersResult);

        return cSVMappingParametersResult;
    }

    private Humidifier.KinesisAnalytics.ApplicationTypes.CSVMappingParameters CreateCSVMappingParameters()
    {
        var cSVMappingParametersResult = new Humidifier.KinesisAnalytics.ApplicationTypes.CSVMappingParameters();

        return cSVMappingParametersResult;
    }

} // End Of Class

public static class InnerApplicationCSVMappingParametersFactoryExtensions
{
}
