// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FIS;

public class InnerExperimentTemplateDataSourcesFactory(Action<Humidifier.FIS.ExperimentTemplateTypes.DataSources> factoryAction = null) : SubResourceFactory<Humidifier.FIS.ExperimentTemplateTypes.DataSources>
{

    protected override Humidifier.FIS.ExperimentTemplateTypes.DataSources Create()
    {
        var dataSourcesResult = CreateDataSources();
        factoryAction?.Invoke(dataSourcesResult);

        return dataSourcesResult;
    }

    private Humidifier.FIS.ExperimentTemplateTypes.DataSources CreateDataSources()
    {
        var dataSourcesResult = new Humidifier.FIS.ExperimentTemplateTypes.DataSources();

        return dataSourcesResult;
    }

} // End Of Class

public static class InnerExperimentTemplateDataSourcesFactoryExtensions
{
}
