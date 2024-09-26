// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ASK;

public class InnerSkillAuthenticationConfigurationFactory(Action<Humidifier.ASK.SkillTypes.AuthenticationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ASK.SkillTypes.AuthenticationConfiguration>
{

    protected override Humidifier.ASK.SkillTypes.AuthenticationConfiguration Create()
    {
        var authenticationConfigurationResult = CreateAuthenticationConfiguration();
        factoryAction?.Invoke(authenticationConfigurationResult);

        return authenticationConfigurationResult;
    }

    private Humidifier.ASK.SkillTypes.AuthenticationConfiguration CreateAuthenticationConfiguration()
    {
        var authenticationConfigurationResult = new Humidifier.ASK.SkillTypes.AuthenticationConfiguration();

        return authenticationConfigurationResult;
    }

} // End Of Class

public static class InnerSkillAuthenticationConfigurationFactoryExtensions
{
}
