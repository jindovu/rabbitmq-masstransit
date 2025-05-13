namespace rabbitmq_message
{
    public record MessagePub
    {
        public int MessageId { get; set; } = default!;
        public string Message { get; set; } = default!;
    }
}
