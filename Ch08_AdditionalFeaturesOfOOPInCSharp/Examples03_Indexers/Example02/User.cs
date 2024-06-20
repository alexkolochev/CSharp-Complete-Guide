namespace Example02
{
    internal class User
    {
        private string _name = string.Empty;
        private string _email = string.Empty;
        private string _phone = string.Empty;

        public string this[string propName]
        {
            get
            {
                switch (propName)
                {
                    case "name": return _name;
                    case "email": return _email;
                    case "phone": return _phone;
                    default: throw new Exception("Unknown Property Name");
                }
            }

            set
            {
                switch (propName)
                {
                    case "name":
                        _name = value;
                        break;
                    case "email":
                        _email = value;
                        break;
                    case "phone":
                        _phone = value;
                        break;
                }
            }
        }
    }
}
