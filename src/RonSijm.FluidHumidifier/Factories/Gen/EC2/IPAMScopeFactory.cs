// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class IPAMScopeFactory(string resourceName = null, Action<Humidifier.EC2.IPAMScope> factoryAction = null) : ResourceFactory<Humidifier.EC2.IPAMScope>(resourceName)
{

    protected override Humidifier.EC2.IPAMScope Create()
    {
        var iPAMScopeResult = CreateIPAMScope();
        factoryAction?.Invoke(iPAMScopeResult);

        return iPAMScopeResult;
    }

    private Humidifier.EC2.IPAMScope CreateIPAMScope()
    {
        var iPAMScopeResult = new Humidifier.EC2.IPAMScope
        {
            GivenName = InputResourceName,
        };

        return iPAMScopeResult;
    }

} // End Of Class

public static class IPAMScopeFactoryExtensions
{
}
