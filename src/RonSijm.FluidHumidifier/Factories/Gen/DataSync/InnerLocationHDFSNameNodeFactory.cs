// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationHDFSNameNodeFactory(Action<Humidifier.DataSync.LocationHDFSTypes.NameNode> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationHDFSTypes.NameNode>
{

    protected override Humidifier.DataSync.LocationHDFSTypes.NameNode Create()
    {
        var nameNodeResult = CreateNameNode();
        factoryAction?.Invoke(nameNodeResult);

        return nameNodeResult;
    }

    private Humidifier.DataSync.LocationHDFSTypes.NameNode CreateNameNode()
    {
        var nameNodeResult = new Humidifier.DataSync.LocationHDFSTypes.NameNode();

        return nameNodeResult;
    }

} // End Of Class

public static class InnerLocationHDFSNameNodeFactoryExtensions
{
}
