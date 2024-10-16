// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Budgets;

public class InnerBudgetsActionResourceTagFactory(Action<Humidifier.Budgets.BudgetsActionTypes.ResourceTag> factoryAction = null) : SubResourceFactory<Humidifier.Budgets.BudgetsActionTypes.ResourceTag>
{

    protected override Humidifier.Budgets.BudgetsActionTypes.ResourceTag Create()
    {
        var resourceTagResult = CreateResourceTag();
        factoryAction?.Invoke(resourceTagResult);

        return resourceTagResult;
    }

    private Humidifier.Budgets.BudgetsActionTypes.ResourceTag CreateResourceTag()
    {
        var resourceTagResult = new Humidifier.Budgets.BudgetsActionTypes.ResourceTag();

        return resourceTagResult;
    }

} // End Of Class

public static class InnerBudgetsActionResourceTagFactoryExtensions
{
}
