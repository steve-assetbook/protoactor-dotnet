﻿using System.Collections.Generic;

namespace Proto
{
    public class MessageEnvelope
    {
        public MessageEnvelope(object message, PID sender, MessageHeader header)
        {
            Sender = sender; // ?? throw new ArgumentNullException(nameof(sender));
            Message = message; // ?? throw new ArgumentNullException(nameof(message));
            Header = header; // ?? throw new ArgumentNullException(nameof(header));
        }

        public PID Sender { get; }
        public object Message { get; }
        public MessageHeader Header { get; }
    }

    public class MessageHeader : Dictionary<string, string>
    {
    }
}