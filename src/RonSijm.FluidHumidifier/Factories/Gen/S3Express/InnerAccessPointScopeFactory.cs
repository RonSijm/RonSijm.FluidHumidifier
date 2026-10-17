// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Express;

public class InnerAccessPointScopeFactory(Action<Humidifier.S3Express.AccessPointTypes.Scope> factoryAction = null) : SubResourceFactory<Humidifier.S3Express.AccessPointTypes.Scope>
{

    protected override Humidifier.S3Express.AccessPointTypes.Scope Create()
    {
        var scopeResult = CreateScope();
        factoryAction?.Invoke(scopeResult);

        return scopeResult;
    }

    private Humidifier.S3Express.AccessPointTypes.Scope CreateScope()
    {
        var scopeResult = new Humidifier.S3Express.AccessPointTypes.Scope();

        return scopeResult;
    }

} // End Of Class

public static class InnerAccessPointScopeFactoryExtensions
{
}
