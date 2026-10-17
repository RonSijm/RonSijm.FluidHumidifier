// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerAnalysisTemplateErrorMessageConfigurationFactory(Action<Humidifier.CleanRooms.AnalysisTemplateTypes.ErrorMessageConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.AnalysisTemplateTypes.ErrorMessageConfiguration>
{

    protected override Humidifier.CleanRooms.AnalysisTemplateTypes.ErrorMessageConfiguration Create()
    {
        var errorMessageConfigurationResult = CreateErrorMessageConfiguration();
        factoryAction?.Invoke(errorMessageConfigurationResult);

        return errorMessageConfigurationResult;
    }

    private Humidifier.CleanRooms.AnalysisTemplateTypes.ErrorMessageConfiguration CreateErrorMessageConfiguration()
    {
        var errorMessageConfigurationResult = new Humidifier.CleanRooms.AnalysisTemplateTypes.ErrorMessageConfiguration();

        return errorMessageConfigurationResult;
    }

} // End Of Class

public static class InnerAnalysisTemplateErrorMessageConfigurationFactoryExtensions
{
}
