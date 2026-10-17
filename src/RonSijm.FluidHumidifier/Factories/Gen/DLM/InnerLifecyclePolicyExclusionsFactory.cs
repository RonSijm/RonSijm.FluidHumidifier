// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DLM;

public class InnerLifecyclePolicyExclusionsFactory(Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> factoryAction = null) : SubResourceFactory<Humidifier.DLM.LifecyclePolicyTypes.Exclusions>
{

    protected override Humidifier.DLM.LifecyclePolicyTypes.Exclusions Create()
    {
        var exclusionsResult = CreateExclusions();
        factoryAction?.Invoke(exclusionsResult);

        return exclusionsResult;
    }

    private Humidifier.DLM.LifecyclePolicyTypes.Exclusions CreateExclusions()
    {
        var exclusionsResult = new Humidifier.DLM.LifecyclePolicyTypes.Exclusions();

        return exclusionsResult;
    }

} // End Of Class

public static class InnerLifecyclePolicyExclusionsFactoryExtensions
{
}
