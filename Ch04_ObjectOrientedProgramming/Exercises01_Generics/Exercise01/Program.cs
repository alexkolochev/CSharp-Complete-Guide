﻿/*
 * Напишите обобщенный класс, который может хранить в массиве объекты любого типа. 
 * Кроме того, данный класс должен иметь методы для добавления данных в массив, удаления из массива, 
 * получения элемента из массива по индексу и метод, возвращающий длину массива.
 * Для упрощения работы можно пересоздавать массив при каждой операции добавления и удаления.
 */

using Exercise01;

ArrayList<int> list = new ArrayList<int>([0, 1, 2, 3, 4, 4, 4, 5]);
//Console.WriteLine(list.Count());
//list.Add(7);
//list.Put(6, 6);
list.RemoveAt(3);
list.Remove(4);
list.PrintList();