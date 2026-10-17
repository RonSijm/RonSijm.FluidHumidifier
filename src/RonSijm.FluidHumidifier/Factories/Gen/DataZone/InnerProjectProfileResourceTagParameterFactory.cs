// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerProjectProfileResourceTagParameterFactory(Action<Humidifier.DataZone.ProjectProfileTypes.ResourceTagParameter> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ProjectProfileTypes.ResourceTagParameter>
{

    protected override Humidifier.DataZone.ProjectProfileTypes.ResourceTagParameter Create()
    {
        var resourceTagParameterResult = CreateResourceTagParameter();
        factoryAction?.Invoke(resourceTagParameterResult);

        return resourceTagParameterResult;
    }

    private Humidifier.DataZone.ProjectProfileTypes.ResourceTagParameter CreateResourceTagParameter()
    {
        var resourceTagParameterResult = new Humidifier.DataZone.ProjectProfileTypes.ResourceTagParameter();

        return resourceTagParameterResult;
    }

} // End Of Class

public static class InnerProjectProfileResourceTagParameterFactoryExtensions
{
}
