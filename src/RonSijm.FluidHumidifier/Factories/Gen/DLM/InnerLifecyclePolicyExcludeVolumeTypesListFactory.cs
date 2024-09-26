// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DLM;

public class InnerLifecyclePolicyExcludeVolumeTypesListFactory(Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeVolumeTypesList> factoryAction = null) : SubResourceFactory<Humidifier.DLM.LifecyclePolicyTypes.ExcludeVolumeTypesList>
{

    protected override Humidifier.DLM.LifecyclePolicyTypes.ExcludeVolumeTypesList Create()
    {
        var excludeVolumeTypesListResult = CreateExcludeVolumeTypesList();
        factoryAction?.Invoke(excludeVolumeTypesListResult);

        return excludeVolumeTypesListResult;
    }

    private Humidifier.DLM.LifecyclePolicyTypes.ExcludeVolumeTypesList CreateExcludeVolumeTypesList()
    {
        var excludeVolumeTypesListResult = new Humidifier.DLM.LifecyclePolicyTypes.ExcludeVolumeTypesList();

        return excludeVolumeTypesListResult;
    }

} // End Of Class

public static class InnerLifecyclePolicyExcludeVolumeTypesListFactoryExtensions
{
}
