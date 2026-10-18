// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Budgets;

public class InnerBudgetNotificationFactory(Action<Humidifier.Budgets.BudgetTypes.Notification> factoryAction = null) : SubResourceFactory<Humidifier.Budgets.BudgetTypes.Notification>
{

    protected override Humidifier.Budgets.BudgetTypes.Notification Create()
    {
        var notificationResult = CreateNotification();
        factoryAction?.Invoke(notificationResult);

        return notificationResult;
    }

    private Humidifier.Budgets.BudgetTypes.Notification CreateNotification()
    {
        var notificationResult = new Humidifier.Budgets.BudgetTypes.Notification();

        return notificationResult;
    }

} // End Of Class

public static class InnerBudgetNotificationFactoryExtensions
{
}
