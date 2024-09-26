// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVSChat;

public class RoomFactory(string resourceName = null, Action<Humidifier.IVSChat.Room> factoryAction = null) : ResourceFactory<Humidifier.IVSChat.Room>(resourceName)
{

    internal InnerRoomMessageReviewHandlerFactory MessageReviewHandlerFactory { get; set; }

    protected override Humidifier.IVSChat.Room Create()
    {
        var roomResult = CreateRoom();
        factoryAction?.Invoke(roomResult);

        return roomResult;
    }

    private Humidifier.IVSChat.Room CreateRoom()
    {
        var roomResult = new Humidifier.IVSChat.Room
        {
            GivenName = InputResourceName,
        };

        return roomResult;
    }
    public override void CreateChildren(Humidifier.IVSChat.Room result)
    {
        base.CreateChildren(result);

        result.MessageReviewHandler ??= MessageReviewHandlerFactory?.Build();
    }

} // End Of Class

public static class RoomFactoryExtensions
{
    public static CombinedResult<RoomFactory, InnerRoomMessageReviewHandlerFactory> WithMessageReviewHandler(this RoomFactory parentFactory, Action<Humidifier.IVSChat.RoomTypes.MessageReviewHandler> subFactoryAction = null)
    {
        parentFactory.MessageReviewHandlerFactory = new InnerRoomMessageReviewHandlerFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MessageReviewHandlerFactory);
    }

    public static CombinedResult<RoomFactory, T1, InnerRoomMessageReviewHandlerFactory> WithMessageReviewHandler<T1>(this CombinedResult<RoomFactory, T1> combinedResult, Action<Humidifier.IVSChat.RoomTypes.MessageReviewHandler> subFactoryAction = null) => new (combinedResult, combinedResult, WithMessageReviewHandler(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RoomFactory, InnerRoomMessageReviewHandlerFactory> WithMessageReviewHandler<T1>(this CombinedResult<T1, RoomFactory> combinedResult, Action<Humidifier.IVSChat.RoomTypes.MessageReviewHandler> subFactoryAction = null) => new (combinedResult, combinedResult, WithMessageReviewHandler(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RoomFactory, T1, T2, InnerRoomMessageReviewHandlerFactory> WithMessageReviewHandler<T1, T2>(this CombinedResult<RoomFactory, T1, T2> combinedResult, Action<Humidifier.IVSChat.RoomTypes.MessageReviewHandler> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMessageReviewHandler(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RoomFactory, T2, InnerRoomMessageReviewHandlerFactory> WithMessageReviewHandler<T1, T2>(this CombinedResult<T1, RoomFactory, T2> combinedResult, Action<Humidifier.IVSChat.RoomTypes.MessageReviewHandler> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMessageReviewHandler(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RoomFactory, InnerRoomMessageReviewHandlerFactory> WithMessageReviewHandler<T1, T2>(this CombinedResult<T1, T2, RoomFactory> combinedResult, Action<Humidifier.IVSChat.RoomTypes.MessageReviewHandler> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMessageReviewHandler(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RoomFactory, T1, T2, T3, InnerRoomMessageReviewHandlerFactory> WithMessageReviewHandler<T1, T2, T3>(this CombinedResult<RoomFactory, T1, T2, T3> combinedResult, Action<Humidifier.IVSChat.RoomTypes.MessageReviewHandler> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMessageReviewHandler(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RoomFactory, T2, T3, InnerRoomMessageReviewHandlerFactory> WithMessageReviewHandler<T1, T2, T3>(this CombinedResult<T1, RoomFactory, T2, T3> combinedResult, Action<Humidifier.IVSChat.RoomTypes.MessageReviewHandler> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMessageReviewHandler(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RoomFactory, T3, InnerRoomMessageReviewHandlerFactory> WithMessageReviewHandler<T1, T2, T3>(this CombinedResult<T1, T2, RoomFactory, T3> combinedResult, Action<Humidifier.IVSChat.RoomTypes.MessageReviewHandler> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMessageReviewHandler(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RoomFactory, InnerRoomMessageReviewHandlerFactory> WithMessageReviewHandler<T1, T2, T3>(this CombinedResult<T1, T2, T3, RoomFactory> combinedResult, Action<Humidifier.IVSChat.RoomTypes.MessageReviewHandler> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMessageReviewHandler(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RoomFactory, T1, T2, T3, T4, InnerRoomMessageReviewHandlerFactory> WithMessageReviewHandler<T1, T2, T3, T4>(this CombinedResult<RoomFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IVSChat.RoomTypes.MessageReviewHandler> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMessageReviewHandler(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RoomFactory, T2, T3, T4, InnerRoomMessageReviewHandlerFactory> WithMessageReviewHandler<T1, T2, T3, T4>(this CombinedResult<T1, RoomFactory, T2, T3, T4> combinedResult, Action<Humidifier.IVSChat.RoomTypes.MessageReviewHandler> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMessageReviewHandler(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RoomFactory, T3, T4, InnerRoomMessageReviewHandlerFactory> WithMessageReviewHandler<T1, T2, T3, T4>(this CombinedResult<T1, T2, RoomFactory, T3, T4> combinedResult, Action<Humidifier.IVSChat.RoomTypes.MessageReviewHandler> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMessageReviewHandler(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RoomFactory, T4, InnerRoomMessageReviewHandlerFactory> WithMessageReviewHandler<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RoomFactory, T4> combinedResult, Action<Humidifier.IVSChat.RoomTypes.MessageReviewHandler> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMessageReviewHandler(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RoomFactory, InnerRoomMessageReviewHandlerFactory> WithMessageReviewHandler<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RoomFactory> combinedResult, Action<Humidifier.IVSChat.RoomTypes.MessageReviewHandler> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMessageReviewHandler(combinedResult.T5, subFactoryAction));
}
