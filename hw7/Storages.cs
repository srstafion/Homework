namespace Storages
{
    abstract class Storage
    {
        protected string _name;
        protected string _model;

        public Storage(string name, string model)
        {
            _name = name;
            _model = model;
        }

        public abstract int GetCapacity();
        public abstract void Copy(int dataSize);

        public abstract int GetRemainingSpace();
        public abstract string GetInfo();

        public abstract double CalculateCopyTime(int dataSize);
    }

    class Flash : Storage
    {
        private int _usb3Speed;
        private int _capacity;
        private int _usedSpace;

        public Flash(string name, string model, int speed, int capacity)
            : base(name, model)
        {
            _usb3Speed = speed;
            _capacity = capacity;
            _usedSpace = 0;
        }

        public override int GetCapacity()
        {
            return _capacity;
        }

        public override void Copy(int dataSize)
        {
            if (dataSize > GetFreeSpace())
                throw new InvalidOperationException("Not enough space");
            else _usedSpace += dataSize;
        }

        public override int GetRemainingSpace()
        {
            return _capacity - _usedSpace;
        }

        public override string GetInfo()
        {
            return $"Flash: {_name} {_model}, " +
                $"USB 3.0 Speed: {_usbSpeed} MB/s, " +
                $"Capacity: {_capacity} GB";
        }

        public override double CalculateCopyTime(int dataSize)
        {
            return (double)dataSize / _usb3Speed;
        }
    }

    class DVD : Storage
    {
        private int _readWriteSpeed;
        private int _capacity;
        private int _usedSpace;

        public DVD(string name, string model, int readWriteSpeed, string dvdType)
            : base(name, model)
        {
            _readWriteSpeed = readWriteSpeed;
            _capacity = dvdType == "single-sided" ? 5 : 9;
            _usedSpace = 0;
        }

        public override int GetCapacity()
        {
            return _capacity;
        }

        public override void Copy(int dataSize)
        {
            if (dataSize > GetFreeSpace())
                throw new InvalidOperationException("Not enough space");
            else _usedSpace += dataSize;
        }

        public override int GetRemainingSpace()
        {
            return _capacity - _usedSpace;
        }

        public override string GetInfo()
        {
            return $"DVD: {_name} {_model}, " +
                $"Speed: {_readWriteSpeed} MB/s, " +
                $"Type: {_capacity} GB";
        }

        public override double CalculateCopyTime(int dataSize)
        {
            return (double)dataSize / _readWriteSpeed;
        }
    }

    class HDD : Storage
    {
        private int _usbSpeed;
        private int _capacity;
        private int _usedSpace;
        private int _sectorsCount;

        public HDD(string name, string model, int usbSpeed, List<int> sectors)
            : base(name, model)
        {
            _usbSpeed = usbSpeed;
            _capacity = 0;
            foreach (var sector in sectors)
            {
                _capacity += sector;
            }
            _sectorsCount = sectors.Count();
            _usedSpace = 0;
        }

        public override int GetCapacity()
        {
            return _capacity;
        }

        public override void Copy(int dataSize)
        {
            if (dataSize > GetRemainingSpace())
                throw new InvalidOperationException("Not enough space on HDD.");
            else _usedSpace += dataSize;
        }

        public override int GetRemainingSpace()
        {
            return _capacity - _usedSpace;
        }

        public override string GetInfo()
        {
            return $"HDD: {_name} {_model}, " +
                $"USB 2.0 Speed: {_usbSpeed} MB/s, " +
                $"Capacity: {_capacity} GB";
        }

        public override double CalculateCopyTime(int dataSize)
        {
            return (double)dataSize / _usbSpeed;
        }

        public int GetSectorsCount()
        {
            return _sectorsCount;
        }
    }
}
