/*
 * Есть класс State, который представляет государство.
 * Добавьте в класс оператор сложения, который бы позволял объединять государства.
 * А также операторы сравнения < и > для сравнения государств по какому-нибудь критерию 
 * (например, по населению или территории).
 */
using Exercise01;

State state1 = new State(100000, 110000);
State state2 = new State(200000, 210000);
State state3 = state1 + state2;
bool isGreater = state1 > state2;

Console.WriteLine($"Population: {state3.Population}; Area: {state3.Area}");
Console.WriteLine(isGreater);
