// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class LimitFactory(string resourceName = null, Action<Humidifier.Deadline.Limit> factoryAction = null) : ResourceFactory<Humidifier.Deadline.Limit>(resourceName)
{

    protected override Humidifier.Deadline.Limit Create()
    {
        var limitResult = CreateLimit();
        factoryAction?.Invoke(limitResult);

        return limitResult;
    }

    private Humidifier.Deadline.Limit CreateLimit()
    {
        var limitResult = new Humidifier.Deadline.Limit
        {
            GivenName = InputResourceName,
        };

        return limitResult;
    }

} // End Of Class

public static class LimitFactoryExtensions
{
}
