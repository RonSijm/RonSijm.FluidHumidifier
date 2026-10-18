// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Evidently;

public class InnerProjectAppConfigResourceObjectFactory(Action<Humidifier.Evidently.ProjectTypes.AppConfigResourceObject> factoryAction = null) : SubResourceFactory<Humidifier.Evidently.ProjectTypes.AppConfigResourceObject>
{

    protected override Humidifier.Evidently.ProjectTypes.AppConfigResourceObject Create()
    {
        var appConfigResourceObjectResult = CreateAppConfigResourceObject();
        factoryAction?.Invoke(appConfigResourceObjectResult);

        return appConfigResourceObjectResult;
    }

    private Humidifier.Evidently.ProjectTypes.AppConfigResourceObject CreateAppConfigResourceObject()
    {
        var appConfigResourceObjectResult = new Humidifier.Evidently.ProjectTypes.AppConfigResourceObject();

        return appConfigResourceObjectResult;
    }

} // End Of Class

public static class InnerProjectAppConfigResourceObjectFactoryExtensions
{
}
