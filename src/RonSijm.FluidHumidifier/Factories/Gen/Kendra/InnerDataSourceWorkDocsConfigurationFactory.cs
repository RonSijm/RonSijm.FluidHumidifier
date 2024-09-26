// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceWorkDocsConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.WorkDocsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.WorkDocsConfiguration>
{

    protected override Humidifier.Kendra.DataSourceTypes.WorkDocsConfiguration Create()
    {
        var workDocsConfigurationResult = CreateWorkDocsConfiguration();
        factoryAction?.Invoke(workDocsConfigurationResult);

        return workDocsConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.WorkDocsConfiguration CreateWorkDocsConfiguration()
    {
        var workDocsConfigurationResult = new Humidifier.Kendra.DataSourceTypes.WorkDocsConfiguration();

        return workDocsConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceWorkDocsConfigurationFactoryExtensions
{
}
