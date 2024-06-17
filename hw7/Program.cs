using Storages;

namespace hw7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Storage> devices = new List<Storage>
            {
                new Flash("flashA", "1.3.4", 350, 128),
                new DVD("dvdA", "1.6.4", 80, "single-sided"),
                new HDD("hddA", "1.7.8", 300, new List<int> { 500 })
            };

            int totalCapacity = CalculateTotalCapacity(devices);
            int dataSize = 565;
            try
            {
                CopyDataToDevices(devices, dataSize);
            }
            catch (InvalidOperationException e) { Console.WriteLine(e.Message); }


            double totalTime = CalculateTotalCopyTime(devices, dataSize);
            Console.WriteLine($"Total memory: {totalCapacity} GB");
            Console.WriteLine($"Total time needed to copy {dataSize}: {totalTime} seconds");
        }

        static int CalculateTotalCapacity(List<Storage> devices)
        {
            int total = 0;
            foreach (var device in devices)
            {
                total += device.GetCapacity();
            }
            return total;
        }

        static void CopyDataToDevices(List<Storage> devices, int dataSize)
        {
            foreach (var device in devices)
            {
                int freeSpace = device.GetRemainingSpace();
                if (dataSize == 0) break;

                if (freeSpace >= dataSize)
                {
                    device.Copy(dataSize);
                    dataSize = 0;
                }

                else
                {
                    device.Copy(freeSpace);
                    dataSize -= freeSpace;
                }
            }

            if (dataSize > 0)
            {
                throw new InvalidOperationException("Not enough space");
            }
        }

        static double CalculateTotalCopyTime(List<Storage> devices, int dataSize)
        {
            double totalTime = 0;
            foreach (var device in devices)
            {
                int freeSpace = device.GetRemainingSpace();
                if (dataSize == 0) break;

                if (freeSpace >= dataSize)
                {
                    totalTime += device.CalculateCopyTime(dataSize);
                    dataSize = 0;
                }
                else
                {
                    totalTime += device.CalculateCopyTime(freeSpace);
                    dataSize -= freeSpace;
                }
            }

            if (dataSize > 0)
            {
                throw new InvalidOperationException("Not enough space to copy all data");
            }

            return totalTime;
        }


        private static void SolveTask1()
        {
            
        }
    }
}
