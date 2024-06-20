/*
 * Пусть даны следующие классы: Word и Dictionary.
 * Класс Word представляет слово, где свойство Target хранит перевод слова.
 * А класс Dictionary представляет словарь слов и хранит все слова в приватном массиве.
 * Добавьте в класс Dictionary индексатор таким образом,
 * чтобы с помощью индексатора можно было по слову получить или изменить его перевод.
 */
using Exercise02;

Dictionary dict = new Dictionary();
Console.WriteLine(dict["blue"]);
dict["blue"] = "голубой";
Console.WriteLine(dict["blue"]);
