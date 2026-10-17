// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerConnectionTypeCustomAuthenticationPropertiesFactory(Action<Humidifier.Glue.ConnectionTypeTypes.CustomAuthenticationProperties> factoryAction = null) : SubResourceFactory<Humidifier.Glue.ConnectionTypeTypes.CustomAuthenticationProperties>
{

    protected override Humidifier.Glue.ConnectionTypeTypes.CustomAuthenticationProperties Create()
    {
        var customAuthenticationPropertiesResult = CreateCustomAuthenticationProperties();
        factoryAction?.Invoke(customAuthenticationPropertiesResult);

        return customAuthenticationPropertiesResult;
    }

    private Humidifier.Glue.ConnectionTypeTypes.CustomAuthenticationProperties CreateCustomAuthenticationProperties()
    {
        var customAuthenticationPropertiesResult = new Humidifier.Glue.ConnectionTypeTypes.CustomAuthenticationProperties();

        return customAuthenticationPropertiesResult;
    }

} // End Of Class

public static class InnerConnectionTypeCustomAuthenticationPropertiesFactoryExtensions
{
}
