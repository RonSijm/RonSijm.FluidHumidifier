// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerVolumeTieringPolicyFactory(Action<Humidifier.FSx.VolumeTypes.TieringPolicy> factoryAction = null) : SubResourceFactory<Humidifier.FSx.VolumeTypes.TieringPolicy>
{

    protected override Humidifier.FSx.VolumeTypes.TieringPolicy Create()
    {
        var tieringPolicyResult = CreateTieringPolicy();
        factoryAction?.Invoke(tieringPolicyResult);

        return tieringPolicyResult;
    }

    private Humidifier.FSx.VolumeTypes.TieringPolicy CreateTieringPolicy()
    {
        var tieringPolicyResult = new Humidifier.FSx.VolumeTypes.TieringPolicy();

        return tieringPolicyResult;
    }

} // End Of Class

public static class InnerVolumeTieringPolicyFactoryExtensions
{
}
