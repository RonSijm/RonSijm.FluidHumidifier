// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Redshift;

public class InnerClusterParameterGroupParameterFactory(Action<Humidifier.Redshift.ClusterParameterGroupTypes.Parameter> factoryAction = null) : SubResourceFactory<Humidifier.Redshift.ClusterParameterGroupTypes.Parameter>
{

    protected override Humidifier.Redshift.ClusterParameterGroupTypes.Parameter Create()
    {
        var parameterResult = CreateParameter();
        factoryAction?.Invoke(parameterResult);

        return parameterResult;
    }

    private Humidifier.Redshift.ClusterParameterGroupTypes.Parameter CreateParameter()
    {
        var parameterResult = new Humidifier.Redshift.ClusterParameterGroupTypes.Parameter();

        return parameterResult;
    }

} // End Of Class

public static class InnerClusterParameterGroupParameterFactoryExtensions
{
}
