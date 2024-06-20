namespace Example04
{
    internal class Base : IDisposable
    {
        private bool _disposed = false;

        public void Dispose()
        {
            // освобождаем неуправляемые ресурсы
            Dispose(true);
            // подавляем финализацию
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
                // Освобождаем управляемые ресурсы
            }
            // освобождаем неуправляемые объекты
            _disposed = true;
        }

        ~Base()
        {
            Dispose(false);
        }
    }
}
