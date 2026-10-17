// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAutoMLJobAutoMLS3DataSourceFactory(Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLS3DataSource> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AutoMLJobTypes.AutoMLS3DataSource>
{

    protected override Humidifier.SageMaker.AutoMLJobTypes.AutoMLS3DataSource Create()
    {
        var autoMLS3DataSourceResult = CreateAutoMLS3DataSource();
        factoryAction?.Invoke(autoMLS3DataSourceResult);

        return autoMLS3DataSourceResult;
    }

    private Humidifier.SageMaker.AutoMLJobTypes.AutoMLS3DataSource CreateAutoMLS3DataSource()
    {
        var autoMLS3DataSourceResult = new Humidifier.SageMaker.AutoMLJobTypes.AutoMLS3DataSource();

        return autoMLS3DataSourceResult;
    }

} // End Of Class

public static class InnerAutoMLJobAutoMLS3DataSourceFactoryExtensions
{
}
