// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerAccessEntryAccessScopeFactory(Action<Humidifier.EKS.AccessEntryTypes.AccessScope> factoryAction = null) : SubResourceFactory<Humidifier.EKS.AccessEntryTypes.AccessScope>
{

    protected override Humidifier.EKS.AccessEntryTypes.AccessScope Create()
    {
        var accessScopeResult = CreateAccessScope();
        factoryAction?.Invoke(accessScopeResult);

        return accessScopeResult;
    }

    private Humidifier.EKS.AccessEntryTypes.AccessScope CreateAccessScope()
    {
        var accessScopeResult = new Humidifier.EKS.AccessEntryTypes.AccessScope();

        return accessScopeResult;
    }

} // End Of Class

public static class InnerAccessEntryAccessScopeFactoryExtensions
{
}
