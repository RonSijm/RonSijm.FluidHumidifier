// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelCardUserContextFactory(Action<Humidifier.SageMaker.ModelCardTypes.UserContext> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelCardTypes.UserContext>
{

    protected override Humidifier.SageMaker.ModelCardTypes.UserContext Create()
    {
        var userContextResult = CreateUserContext();
        factoryAction?.Invoke(userContextResult);

        return userContextResult;
    }

    private Humidifier.SageMaker.ModelCardTypes.UserContext CreateUserContext()
    {
        var userContextResult = new Humidifier.SageMaker.ModelCardTypes.UserContext();

        return userContextResult;
    }

} // End Of Class

public static class InnerModelCardUserContextFactoryExtensions
{
}
