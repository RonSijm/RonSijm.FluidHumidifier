// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpaces;

public class InnerDirectoryGlobalAcceleratorForDirectoryFactory(Action<Humidifier.WorkSpaces.DirectoryTypes.GlobalAcceleratorForDirectory> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpaces.DirectoryTypes.GlobalAcceleratorForDirectory>
{

    protected override Humidifier.WorkSpaces.DirectoryTypes.GlobalAcceleratorForDirectory Create()
    {
        var globalAcceleratorForDirectoryResult = CreateGlobalAcceleratorForDirectory();
        factoryAction?.Invoke(globalAcceleratorForDirectoryResult);

        return globalAcceleratorForDirectoryResult;
    }

    private Humidifier.WorkSpaces.DirectoryTypes.GlobalAcceleratorForDirectory CreateGlobalAcceleratorForDirectory()
    {
        var globalAcceleratorForDirectoryResult = new Humidifier.WorkSpaces.DirectoryTypes.GlobalAcceleratorForDirectory();

        return globalAcceleratorForDirectoryResult;
    }

} // End Of Class

public static class InnerDirectoryGlobalAcceleratorForDirectoryFactoryExtensions
{
}
