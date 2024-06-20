﻿namespace Example02
{
    internal class SmsMessage : Message
    {
        public SmsMessage(string text) : base(text) { }

        public override void Print() => Console.WriteLine($"SMS: {Text}");
    }
}
