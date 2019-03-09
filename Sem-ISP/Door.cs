namespace Sem_ISP
{
    class Door : IDoor
    {
        private bool _isDoorOpen { get; set; }

        public Door()
        {
            _isDoorOpen = true;
        }

        public bool IsDoorOpen()
        {
            return _isDoorOpen;
        }

        public void Lock()
        {
            if (IsDoorOpen())
            {
                _isDoorOpen = false;
            }
        }

        public void Unlock()
        {
            if (!IsDoorOpen())
            {
                _isDoorOpen = true;
            }
        }
    }
}
