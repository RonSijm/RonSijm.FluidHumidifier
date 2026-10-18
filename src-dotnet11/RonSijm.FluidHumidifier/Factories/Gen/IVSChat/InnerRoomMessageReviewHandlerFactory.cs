// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVSChat;

public class InnerRoomMessageReviewHandlerFactory(Action<Humidifier.IVSChat.RoomTypes.MessageReviewHandler> factoryAction = null) : SubResourceFactory<Humidifier.IVSChat.RoomTypes.MessageReviewHandler>
{

    protected override Humidifier.IVSChat.RoomTypes.MessageReviewHandler Create()
    {
        var messageReviewHandlerResult = CreateMessageReviewHandler();
        factoryAction?.Invoke(messageReviewHandlerResult);

        return messageReviewHandlerResult;
    }

    private Humidifier.IVSChat.RoomTypes.MessageReviewHandler CreateMessageReviewHandler()
    {
        var messageReviewHandlerResult = new Humidifier.IVSChat.RoomTypes.MessageReviewHandler();

        return messageReviewHandlerResult;
    }

} // End Of Class

public static class InnerRoomMessageReviewHandlerFactoryExtensions
{
}
