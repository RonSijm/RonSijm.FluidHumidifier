// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSO;

public class InnerApplicationSignInOptionsFactory(Action<Humidifier.SSO.ApplicationTypes.SignInOptions> factoryAction = null) : SubResourceFactory<Humidifier.SSO.ApplicationTypes.SignInOptions>
{

    protected override Humidifier.SSO.ApplicationTypes.SignInOptions Create()
    {
        var signInOptionsResult = CreateSignInOptions();
        factoryAction?.Invoke(signInOptionsResult);

        return signInOptionsResult;
    }

    private Humidifier.SSO.ApplicationTypes.SignInOptions CreateSignInOptions()
    {
        var signInOptionsResult = new Humidifier.SSO.ApplicationTypes.SignInOptions();

        return signInOptionsResult;
    }

} // End Of Class

public static class InnerApplicationSignInOptionsFactoryExtensions
{
}
