// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Budgets;

public class InnerBudgetResourceTagFactory(Action<Humidifier.Budgets.BudgetTypes.ResourceTag> factoryAction = null) : SubResourceFactory<Humidifier.Budgets.BudgetTypes.ResourceTag>
{

    protected override Humidifier.Budgets.BudgetTypes.ResourceTag Create()
    {
        var resourceTagResult = CreateResourceTag();
        factoryAction?.Invoke(resourceTagResult);

        return resourceTagResult;
    }

    private Humidifier.Budgets.BudgetTypes.ResourceTag CreateResourceTag()
    {
        var resourceTagResult = new Humidifier.Budgets.BudgetTypes.ResourceTag();

        return resourceTagResult;
    }

} // End Of Class

public static class InnerBudgetResourceTagFactoryExtensions
{
}
