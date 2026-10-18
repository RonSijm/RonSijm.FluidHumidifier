// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerChannelTableCreationFactory(Action<Humidifier.MSK.ChannelTypes.TableCreation> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ChannelTypes.TableCreation>
{

    protected override Humidifier.MSK.ChannelTypes.TableCreation Create()
    {
        var tableCreationResult = CreateTableCreation();
        factoryAction?.Invoke(tableCreationResult);

        return tableCreationResult;
    }

    private Humidifier.MSK.ChannelTypes.TableCreation CreateTableCreation()
    {
        var tableCreationResult = new Humidifier.MSK.ChannelTypes.TableCreation();

        return tableCreationResult;
    }

} // End Of Class

public static class InnerChannelTableCreationFactoryExtensions
{
}
