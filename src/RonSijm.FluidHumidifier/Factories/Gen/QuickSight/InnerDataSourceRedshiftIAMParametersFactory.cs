// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceRedshiftIAMParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.RedshiftIAMParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.RedshiftIAMParameters>
{

    protected override Humidifier.QuickSight.DataSourceTypes.RedshiftIAMParameters Create()
    {
        var redshiftIAMParametersResult = CreateRedshiftIAMParameters();
        factoryAction?.Invoke(redshiftIAMParametersResult);

        return redshiftIAMParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.RedshiftIAMParameters CreateRedshiftIAMParameters()
    {
        var redshiftIAMParametersResult = new Humidifier.QuickSight.DataSourceTypes.RedshiftIAMParameters();

        return redshiftIAMParametersResult;
    }

} // End Of Class

public static class InnerDataSourceRedshiftIAMParametersFactoryExtensions
{
}
