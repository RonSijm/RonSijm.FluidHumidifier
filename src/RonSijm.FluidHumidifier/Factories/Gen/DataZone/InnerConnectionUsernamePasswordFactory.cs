// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerConnectionUsernamePasswordFactory(Action<Humidifier.DataZone.ConnectionTypes.UsernamePassword> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ConnectionTypes.UsernamePassword>
{

    protected override Humidifier.DataZone.ConnectionTypes.UsernamePassword Create()
    {
        var usernamePasswordResult = CreateUsernamePassword();
        factoryAction?.Invoke(usernamePasswordResult);

        return usernamePasswordResult;
    }

    private Humidifier.DataZone.ConnectionTypes.UsernamePassword CreateUsernamePassword()
    {
        var usernamePasswordResult = new Humidifier.DataZone.ConnectionTypes.UsernamePassword();

        return usernamePasswordResult;
    }

} // End Of Class

public static class InnerConnectionUsernamePasswordFactoryExtensions
{
}
