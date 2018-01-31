namespace MessengerPackage
{
    public interface IMessage
    {
        string Name { get; set; }
        string Message { get; set; }
    }

    /// <summary>
    /// Use interface for sending message from the client to the server
    /// </summary>
    public interface IUnprocessedMessage : IMessage
    {

    }

    /// <summary>
    /// Use interface for sending message from the server to the clients
    /// </summary>
    public interface IProcessedMessage : IMessage
    {

    }
}
