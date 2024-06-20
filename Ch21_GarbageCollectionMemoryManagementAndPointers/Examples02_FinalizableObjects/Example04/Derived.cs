namespace Example04
{
    internal class Derived : Base
    {
        private bool _disposed = false;

        protected override void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
                // Освобождение управляемых ресурсов
            }
            _disposed = true;
            // Обращение к методу Dispose базового класса
            base.Dispose(disposing);
        }
    }
}
