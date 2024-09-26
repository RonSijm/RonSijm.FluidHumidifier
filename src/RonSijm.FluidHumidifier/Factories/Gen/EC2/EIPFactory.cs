// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class EIPFactory(string resourceName = null, Action<Humidifier.EC2.EIP> factoryAction = null) : ResourceFactory<Humidifier.EC2.EIP>(resourceName)
{

    protected override Humidifier.EC2.EIP Create()
    {
        var eIPResult = CreateEIP();
        factoryAction?.Invoke(eIPResult);

        return eIPResult;
    }

    private Humidifier.EC2.EIP CreateEIP()
    {
        var eIPResult = new Humidifier.EC2.EIP
        {
            GivenName = InputResourceName,
        };

        return eIPResult;
    }

} // End Of Class

public static class EIPFactoryExtensions
{
}
