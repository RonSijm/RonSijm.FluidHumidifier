// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Budgets;

public class InnerBudgetsActionSubscriberFactory(Action<Humidifier.Budgets.BudgetsActionTypes.Subscriber> factoryAction = null) : SubResourceFactory<Humidifier.Budgets.BudgetsActionTypes.Subscriber>
{

    protected override Humidifier.Budgets.BudgetsActionTypes.Subscriber Create()
    {
        var subscriberResult = CreateSubscriber();
        factoryAction?.Invoke(subscriberResult);

        return subscriberResult;
    }

    private Humidifier.Budgets.BudgetsActionTypes.Subscriber CreateSubscriber()
    {
        var subscriberResult = new Humidifier.Budgets.BudgetsActionTypes.Subscriber();

        return subscriberResult;
    }

} // End Of Class

public static class InnerBudgetsActionSubscriberFactoryExtensions
{
}
