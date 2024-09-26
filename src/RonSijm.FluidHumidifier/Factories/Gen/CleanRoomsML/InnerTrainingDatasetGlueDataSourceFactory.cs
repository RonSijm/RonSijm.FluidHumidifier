// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRoomsML;

public class InnerTrainingDatasetGlueDataSourceFactory(Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.GlueDataSource> factoryAction = null) : SubResourceFactory<Humidifier.CleanRoomsML.TrainingDatasetTypes.GlueDataSource>
{

    protected override Humidifier.CleanRoomsML.TrainingDatasetTypes.GlueDataSource Create()
    {
        var glueDataSourceResult = CreateGlueDataSource();
        factoryAction?.Invoke(glueDataSourceResult);

        return glueDataSourceResult;
    }

    private Humidifier.CleanRoomsML.TrainingDatasetTypes.GlueDataSource CreateGlueDataSource()
    {
        var glueDataSourceResult = new Humidifier.CleanRoomsML.TrainingDatasetTypes.GlueDataSource();

        return glueDataSourceResult;
    }

} // End Of Class

public static class InnerTrainingDatasetGlueDataSourceFactoryExtensions
{
}
