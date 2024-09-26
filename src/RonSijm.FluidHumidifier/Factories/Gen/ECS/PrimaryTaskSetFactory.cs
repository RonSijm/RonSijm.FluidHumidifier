// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class PrimaryTaskSetFactory(string resourceName = null, Action<Humidifier.ECS.PrimaryTaskSet> factoryAction = null) : ResourceFactory<Humidifier.ECS.PrimaryTaskSet>(resourceName)
{

    protected override Humidifier.ECS.PrimaryTaskSet Create()
    {
        var primaryTaskSetResult = CreatePrimaryTaskSet();
        factoryAction?.Invoke(primaryTaskSetResult);

        return primaryTaskSetResult;
    }

    private Humidifier.ECS.PrimaryTaskSet CreatePrimaryTaskSet()
    {
        var primaryTaskSetResult = new Humidifier.ECS.PrimaryTaskSet
        {
            GivenName = InputResourceName,
        };

        return primaryTaskSetResult;
    }

} // End Of Class

public static class PrimaryTaskSetFactoryExtensions
{
}
