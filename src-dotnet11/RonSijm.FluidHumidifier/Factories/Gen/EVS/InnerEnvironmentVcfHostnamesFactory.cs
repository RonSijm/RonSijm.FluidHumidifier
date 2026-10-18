// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EVS;

public class InnerEnvironmentVcfHostnamesFactory(Action<Humidifier.EVS.EnvironmentTypes.VcfHostnames> factoryAction = null) : SubResourceFactory<Humidifier.EVS.EnvironmentTypes.VcfHostnames>
{

    protected override Humidifier.EVS.EnvironmentTypes.VcfHostnames Create()
    {
        var vcfHostnamesResult = CreateVcfHostnames();
        factoryAction?.Invoke(vcfHostnamesResult);

        return vcfHostnamesResult;
    }

    private Humidifier.EVS.EnvironmentTypes.VcfHostnames CreateVcfHostnames()
    {
        var vcfHostnamesResult = new Humidifier.EVS.EnvironmentTypes.VcfHostnames();

        return vcfHostnamesResult;
    }

} // End Of Class

public static class InnerEnvironmentVcfHostnamesFactoryExtensions
{
}
