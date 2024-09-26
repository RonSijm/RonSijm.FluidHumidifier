// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerAccessPolicyProjectFactory(Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Project> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.AccessPolicyTypes.Project>
{

    protected override Humidifier.IoTSiteWise.AccessPolicyTypes.Project Create()
    {
        var projectResult = CreateProject();
        factoryAction?.Invoke(projectResult);

        return projectResult;
    }

    private Humidifier.IoTSiteWise.AccessPolicyTypes.Project CreateProject()
    {
        var projectResult = new Humidifier.IoTSiteWise.AccessPolicyTypes.Project();

        return projectResult;
    }

} // End Of Class

public static class InnerAccessPolicyProjectFactoryExtensions
{
}
