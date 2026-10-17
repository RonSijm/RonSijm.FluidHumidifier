// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class UseCaseFactory(string resourceName = null, Action<Humidifier.Connect.UseCase> factoryAction = null) : ResourceFactory<Humidifier.Connect.UseCase>(resourceName)
{

    protected override Humidifier.Connect.UseCase Create()
    {
        var useCaseResult = CreateUseCase();
        factoryAction?.Invoke(useCaseResult);

        return useCaseResult;
    }

    private Humidifier.Connect.UseCase CreateUseCase()
    {
        var useCaseResult = new Humidifier.Connect.UseCase
        {
            GivenName = InputResourceName,
        };

        return useCaseResult;
    }

} // End Of Class

public static class UseCaseFactoryExtensions
{
}
