// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerDatasetJsonOptionsFactory(Action<Humidifier.DataBrew.DatasetTypes.JsonOptions> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.DatasetTypes.JsonOptions>
{

    protected override Humidifier.DataBrew.DatasetTypes.JsonOptions Create()
    {
        var jsonOptionsResult = CreateJsonOptions();
        factoryAction?.Invoke(jsonOptionsResult);

        return jsonOptionsResult;
    }

    private Humidifier.DataBrew.DatasetTypes.JsonOptions CreateJsonOptions()
    {
        var jsonOptionsResult = new Humidifier.DataBrew.DatasetTypes.JsonOptions();

        return jsonOptionsResult;
    }

} // End Of Class

public static class InnerDatasetJsonOptionsFactoryExtensions
{
}
