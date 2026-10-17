// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MPA;

public class InnerIdentitySourceIamIdentityCenterFactory(Action<Humidifier.MPA.IdentitySourceTypes.IamIdentityCenter> factoryAction = null) : SubResourceFactory<Humidifier.MPA.IdentitySourceTypes.IamIdentityCenter>
{

    protected override Humidifier.MPA.IdentitySourceTypes.IamIdentityCenter Create()
    {
        var iamIdentityCenterResult = CreateIamIdentityCenter();
        factoryAction?.Invoke(iamIdentityCenterResult);

        return iamIdentityCenterResult;
    }

    private Humidifier.MPA.IdentitySourceTypes.IamIdentityCenter CreateIamIdentityCenter()
    {
        var iamIdentityCenterResult = new Humidifier.MPA.IdentitySourceTypes.IamIdentityCenter();

        return iamIdentityCenterResult;
    }

} // End Of Class

public static class InnerIdentitySourceIamIdentityCenterFactoryExtensions
{
}
