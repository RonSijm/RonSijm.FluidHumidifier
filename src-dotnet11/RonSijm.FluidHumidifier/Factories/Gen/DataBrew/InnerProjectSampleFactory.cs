// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerProjectSampleFactory(Action<Humidifier.DataBrew.ProjectTypes.Sample> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.ProjectTypes.Sample>
{

    protected override Humidifier.DataBrew.ProjectTypes.Sample Create()
    {
        var sampleResult = CreateSample();
        factoryAction?.Invoke(sampleResult);

        return sampleResult;
    }

    private Humidifier.DataBrew.ProjectTypes.Sample CreateSample()
    {
        var sampleResult = new Humidifier.DataBrew.ProjectTypes.Sample();

        return sampleResult;
    }

} // End Of Class

public static class InnerProjectSampleFactoryExtensions
{
}
