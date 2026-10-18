// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerPermissionConditionFactory(Action<Humidifier.QBusiness.PermissionTypes.Condition> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.PermissionTypes.Condition>
{

    protected override Humidifier.QBusiness.PermissionTypes.Condition Create()
    {
        var conditionResult = CreateCondition();
        factoryAction?.Invoke(conditionResult);

        return conditionResult;
    }

    private Humidifier.QBusiness.PermissionTypes.Condition CreateCondition()
    {
        var conditionResult = new Humidifier.QBusiness.PermissionTypes.Condition();

        return conditionResult;
    }

} // End Of Class

public static class InnerPermissionConditionFactoryExtensions
{
}
