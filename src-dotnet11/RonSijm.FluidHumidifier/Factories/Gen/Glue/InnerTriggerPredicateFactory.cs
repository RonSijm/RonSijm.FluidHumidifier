// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTriggerPredicateFactory(Action<Humidifier.Glue.TriggerTypes.Predicate> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TriggerTypes.Predicate>
{

    protected override Humidifier.Glue.TriggerTypes.Predicate Create()
    {
        var predicateResult = CreatePredicate();
        factoryAction?.Invoke(predicateResult);

        return predicateResult;
    }

    private Humidifier.Glue.TriggerTypes.Predicate CreatePredicate()
    {
        var predicateResult = new Humidifier.Glue.TriggerTypes.Predicate();

        return predicateResult;
    }

} // End Of Class

public static class InnerTriggerPredicateFactoryExtensions
{
}
