// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RolesAnywhere;

public class CRLFactory(string resourceName = null, Action<Humidifier.RolesAnywhere.CRL> factoryAction = null) : ResourceFactory<Humidifier.RolesAnywhere.CRL>(resourceName)
{

    protected override Humidifier.RolesAnywhere.CRL Create()
    {
        var cRLResult = CreateCRL();
        factoryAction?.Invoke(cRLResult);

        return cRLResult;
    }

    private Humidifier.RolesAnywhere.CRL CreateCRL()
    {
        var cRLResult = new Humidifier.RolesAnywhere.CRL
        {
            GivenName = InputResourceName,
        };

        return cRLResult;
    }

} // End Of Class

public static class CRLFactoryExtensions
{
}
