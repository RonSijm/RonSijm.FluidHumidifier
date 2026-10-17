// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerAppInstanceBotInvokedByFactory(Action<Humidifier.Chime.AppInstanceBotTypes.InvokedBy> factoryAction = null) : SubResourceFactory<Humidifier.Chime.AppInstanceBotTypes.InvokedBy>
{

    protected override Humidifier.Chime.AppInstanceBotTypes.InvokedBy Create()
    {
        var invokedByResult = CreateInvokedBy();
        factoryAction?.Invoke(invokedByResult);

        return invokedByResult;
    }

    private Humidifier.Chime.AppInstanceBotTypes.InvokedBy CreateInvokedBy()
    {
        var invokedByResult = new Humidifier.Chime.AppInstanceBotTypes.InvokedBy();

        return invokedByResult;
    }

} // End Of Class

public static class InnerAppInstanceBotInvokedByFactoryExtensions
{
}
