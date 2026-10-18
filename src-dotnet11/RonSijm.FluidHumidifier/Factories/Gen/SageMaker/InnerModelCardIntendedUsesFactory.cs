// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelCardIntendedUsesFactory(Action<Humidifier.SageMaker.ModelCardTypes.IntendedUses> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelCardTypes.IntendedUses>
{

    protected override Humidifier.SageMaker.ModelCardTypes.IntendedUses Create()
    {
        var intendedUsesResult = CreateIntendedUses();
        factoryAction?.Invoke(intendedUsesResult);

        return intendedUsesResult;
    }

    private Humidifier.SageMaker.ModelCardTypes.IntendedUses CreateIntendedUses()
    {
        var intendedUsesResult = new Humidifier.SageMaker.ModelCardTypes.IntendedUses();

        return intendedUsesResult;
    }

} // End Of Class

public static class InnerModelCardIntendedUsesFactoryExtensions
{
}
