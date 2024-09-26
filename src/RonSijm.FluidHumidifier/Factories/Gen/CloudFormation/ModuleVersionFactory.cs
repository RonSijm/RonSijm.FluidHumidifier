// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class ModuleVersionFactory(string resourceName = null, Action<Humidifier.CloudFormation.ModuleVersion> factoryAction = null) : ResourceFactory<Humidifier.CloudFormation.ModuleVersion>(resourceName)
{

    protected override Humidifier.CloudFormation.ModuleVersion Create()
    {
        var moduleVersionResult = CreateModuleVersion();
        factoryAction?.Invoke(moduleVersionResult);

        return moduleVersionResult;
    }

    private Humidifier.CloudFormation.ModuleVersion CreateModuleVersion()
    {
        var moduleVersionResult = new Humidifier.CloudFormation.ModuleVersion
        {
            GivenName = InputResourceName,
        };

        return moduleVersionResult;
    }

} // End Of Class

public static class ModuleVersionFactoryExtensions
{
}
