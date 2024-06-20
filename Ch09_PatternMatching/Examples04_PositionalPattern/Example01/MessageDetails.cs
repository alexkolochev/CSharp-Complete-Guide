namespace Example01
{
    internal class MessageDetails
    {
        public string Language { get; set; } = string.Empty;
        public string DateTime { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;

        public void Deconstruct(out string lang, out string datetime, out string status)
        {
            lang = Language;
            datetime = DateTime;
            status = Status;
        }
    }
}
