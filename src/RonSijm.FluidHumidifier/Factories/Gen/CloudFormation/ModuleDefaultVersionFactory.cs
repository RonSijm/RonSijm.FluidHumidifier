// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class ModuleDefaultVersionFactory(string resourceName = null, Action<Humidifier.CloudFormation.ModuleDefaultVersion> factoryAction = null) : ResourceFactory<Humidifier.CloudFormation.ModuleDefaultVersion>(resourceName)
{

    protected override Humidifier.CloudFormation.ModuleDefaultVersion Create()
    {
        var moduleDefaultVersionResult = CreateModuleDefaultVersion();
        factoryAction?.Invoke(moduleDefaultVersionResult);

        return moduleDefaultVersionResult;
    }

    private Humidifier.CloudFormation.ModuleDefaultVersion CreateModuleDefaultVersion()
    {
        var moduleDefaultVersionResult = new Humidifier.CloudFormation.ModuleDefaultVersion
        {
            GivenName = InputResourceName,
        };

        return moduleDefaultVersionResult;
    }

} // End Of Class

public static class ModuleDefaultVersionFactoryExtensions
{
}
