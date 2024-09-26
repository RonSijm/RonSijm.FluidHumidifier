// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CE;

public class CostCategoryFactory(string resourceName = null, Action<Humidifier.CE.CostCategory> factoryAction = null) : ResourceFactory<Humidifier.CE.CostCategory>(resourceName)
{

    protected override Humidifier.CE.CostCategory Create()
    {
        var costCategoryResult = CreateCostCategory();
        factoryAction?.Invoke(costCategoryResult);

        return costCategoryResult;
    }

    private Humidifier.CE.CostCategory CreateCostCategory()
    {
        var costCategoryResult = new Humidifier.CE.CostCategory
        {
            GivenName = InputResourceName,
        };

        return costCategoryResult;
    }

} // End Of Class

public static class CostCategoryFactoryExtensions
{
}
