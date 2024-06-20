using System.Dynamic;

namespace Example02
{
    internal class PersonObject : DynamicObject
    {
        // словарь для хранения всех свойств
        Dictionary<string, object> members = new();

        // установка свойства
        public override bool TrySetMember(SetMemberBinder binder, object? value)
        {
            if (value is not null)
            {
                members[binder.Name] = value;
                return true;
            }
            return false;
        }

        // получение свойства
        public override bool TryGetMember(GetMemberBinder binder, out object? result)
        {
            result = null;
            if (members.ContainsKey(binder.Name))
            {
                result = members[binder.Name];
                return true;
            }
            return false;
        }

        // вызов метода
        public override bool TryInvokeMember(InvokeMemberBinder binder, object?[]? args, out object? result)
        {
            result = null;
            if (args?[0] is int number)
            {
                // получаем метод по имени
                dynamic method = members[binder.Name];

                // вызываем метод, передавая его параметру значение args?[0]
                result = method(number);
            }

            // если result не равен null, то вызов метода прошел успешно
            return result != null;
        }
    }
}
