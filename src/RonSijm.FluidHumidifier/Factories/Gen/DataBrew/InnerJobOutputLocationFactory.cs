// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerJobOutputLocationFactory(Action<Humidifier.DataBrew.JobTypes.OutputLocation> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.JobTypes.OutputLocation>
{

    protected override Humidifier.DataBrew.JobTypes.OutputLocation Create()
    {
        var outputLocationResult = CreateOutputLocation();
        factoryAction?.Invoke(outputLocationResult);

        return outputLocationResult;
    }

    private Humidifier.DataBrew.JobTypes.OutputLocation CreateOutputLocation()
    {
        var outputLocationResult = new Humidifier.DataBrew.JobTypes.OutputLocation();

        return outputLocationResult;
    }

} // End Of Class

public static class InnerJobOutputLocationFactoryExtensions
{
}
