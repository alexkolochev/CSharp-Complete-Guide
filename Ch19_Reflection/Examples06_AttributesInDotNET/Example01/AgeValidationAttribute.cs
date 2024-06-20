/*
 * Ограничения атрибута:
 * All: используется всеми типами
 * Assembly: атрибут применяется к сборке
 * Constructor: атрибут применяется к конструктору
 * Delegate: атрибут применяется к делегату
 * Enum: применяется к перечислению
 * Event: атрибут применяется к событию
 * Field: применяется к полю типа
 * Interface: атрибут применяется к интерфейсу
 * Method: применяется к методу
 * Property: применяется к свойству
 * Struct: применяется к структуре
*/
namespace Example01
{
    [AttributeUsage(AttributeTargets.Class)] // Ограничение атрибута
    internal class AgeValidationAttribute : Attribute
    {
        public int Age { get; }

        public AgeValidationAttribute() { }

        public AgeValidationAttribute(int age) => Age = age;
    }
}
