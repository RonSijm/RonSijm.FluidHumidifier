// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpaces;

public class WorkSpaceApplicationFactory(string resourceName = null, Action<Humidifier.WorkSpaces.WorkSpaceApplication> factoryAction = null) : ResourceFactory<Humidifier.WorkSpaces.WorkSpaceApplication>(resourceName)
{

    protected override Humidifier.WorkSpaces.WorkSpaceApplication Create()
    {
        var workSpaceApplicationResult = CreateWorkSpaceApplication();
        factoryAction?.Invoke(workSpaceApplicationResult);

        return workSpaceApplicationResult;
    }

    private Humidifier.WorkSpaces.WorkSpaceApplication CreateWorkSpaceApplication()
    {
        var workSpaceApplicationResult = new Humidifier.WorkSpaces.WorkSpaceApplication
        {
            GivenName = InputResourceName,
        };

        return workSpaceApplicationResult;
    }

} // End Of Class

public static class WorkSpaceApplicationFactoryExtensions
{
}
