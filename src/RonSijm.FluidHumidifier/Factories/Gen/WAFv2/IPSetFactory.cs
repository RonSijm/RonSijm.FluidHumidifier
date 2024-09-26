// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class IPSetFactory(string resourceName = null, Action<Humidifier.WAFv2.IPSet> factoryAction = null) : ResourceFactory<Humidifier.WAFv2.IPSet>(resourceName)
{

    protected override Humidifier.WAFv2.IPSet Create()
    {
        var iPSetResult = CreateIPSet();
        factoryAction?.Invoke(iPSetResult);

        return iPSetResult;
    }

    private Humidifier.WAFv2.IPSet CreateIPSet()
    {
        var iPSetResult = new Humidifier.WAFv2.IPSet
        {
            GivenName = InputResourceName,
        };

        return iPSetResult;
    }

} // End Of Class

public static class IPSetFactoryExtensions
{
}
