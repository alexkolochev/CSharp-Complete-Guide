Message hello = () =>
{
    Console.Write("Hello, ");
    Console.WriteLine("World!");
};

hello();
hello();
hello();

delegate void Message();
