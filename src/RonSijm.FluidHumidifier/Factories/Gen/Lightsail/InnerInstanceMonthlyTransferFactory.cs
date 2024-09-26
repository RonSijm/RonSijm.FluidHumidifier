// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerInstanceMonthlyTransferFactory(Action<Humidifier.Lightsail.InstanceTypes.MonthlyTransfer> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.InstanceTypes.MonthlyTransfer>
{

    protected override Humidifier.Lightsail.InstanceTypes.MonthlyTransfer Create()
    {
        var monthlyTransferResult = CreateMonthlyTransfer();
        factoryAction?.Invoke(monthlyTransferResult);

        return monthlyTransferResult;
    }

    private Humidifier.Lightsail.InstanceTypes.MonthlyTransfer CreateMonthlyTransfer()
    {
        var monthlyTransferResult = new Humidifier.Lightsail.InstanceTypes.MonthlyTransfer();

        return monthlyTransferResult;
    }

} // End Of Class

public static class InnerInstanceMonthlyTransferFactoryExtensions
{
}
