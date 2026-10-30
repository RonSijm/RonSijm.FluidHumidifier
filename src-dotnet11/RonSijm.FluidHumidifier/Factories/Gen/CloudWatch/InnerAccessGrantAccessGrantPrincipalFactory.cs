// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerAccessGrantAccessGrantPrincipalFactory(Action<Humidifier.CloudWatch.AccessGrantTypes.AccessGrantPrincipal> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.AccessGrantTypes.AccessGrantPrincipal>
{

    protected override Humidifier.CloudWatch.AccessGrantTypes.AccessGrantPrincipal Create()
    {
        var accessGrantPrincipalResult = CreateAccessGrantPrincipal();
        factoryAction?.Invoke(accessGrantPrincipalResult);

        return accessGrantPrincipalResult;
    }

    private Humidifier.CloudWatch.AccessGrantTypes.AccessGrantPrincipal CreateAccessGrantPrincipal()
    {
        var accessGrantPrincipalResult = new Humidifier.CloudWatch.AccessGrantTypes.AccessGrantPrincipal();

        return accessGrantPrincipalResult;
    }

} // End Of Class

public static class InnerAccessGrantAccessGrantPrincipalFactoryExtensions
{
}
