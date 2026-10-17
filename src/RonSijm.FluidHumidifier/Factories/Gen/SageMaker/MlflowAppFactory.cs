// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class MlflowAppFactory(string resourceName = null, Action<Humidifier.SageMaker.MlflowApp> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.MlflowApp>(resourceName)
{

    protected override Humidifier.SageMaker.MlflowApp Create()
    {
        var mlflowAppResult = CreateMlflowApp();
        factoryAction?.Invoke(mlflowAppResult);

        return mlflowAppResult;
    }

    private Humidifier.SageMaker.MlflowApp CreateMlflowApp()
    {
        var mlflowAppResult = new Humidifier.SageMaker.MlflowApp
        {
            GivenName = InputResourceName,
        };

        return mlflowAppResult;
    }

} // End Of Class

public static class MlflowAppFactoryExtensions
{
}
