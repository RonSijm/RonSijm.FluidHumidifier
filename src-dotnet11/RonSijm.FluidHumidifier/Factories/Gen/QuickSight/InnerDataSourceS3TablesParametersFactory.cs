// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceS3TablesParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.S3TablesParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.S3TablesParameters>
{

    protected override Humidifier.QuickSight.DataSourceTypes.S3TablesParameters Create()
    {
        var s3TablesParametersResult = CreateS3TablesParameters();
        factoryAction?.Invoke(s3TablesParametersResult);

        return s3TablesParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.S3TablesParameters CreateS3TablesParameters()
    {
        var s3TablesParametersResult = new Humidifier.QuickSight.DataSourceTypes.S3TablesParameters();

        return s3TablesParametersResult;
    }

} // End Of Class

public static class InnerDataSourceS3TablesParametersFactoryExtensions
{
}
