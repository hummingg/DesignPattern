namespace DesignPattern.FacadePattern
{
    /// <summary>
    /// CPU子系统
    /// </summary>
    public class CPU
    {
        public void CPUStart()
        {
            Console.WriteLine("CPU is start...");
        }
        public void CPUShutdown()
        {
            Console.WriteLine("CPU is shot down...");
        }
    }

    /// <summary>
    /// 内存子系统
    /// </summary>
    public class Memory
    {
        public void MemoryStart()
        {
            Console.WriteLine("Memory is start...");
        }
        public void MemoryShutdown()
        {
            Console.WriteLine("Memory is shot down...");
        }
    }

    /// <summary>
    /// 硬盘子系统
    /// </summary>
    public class Disk
    {
        public void DiskStart()
        {
            Console.WriteLine("Disk is start...");
        }
        public void DiskShutdown()
        {
            Console.WriteLine("Disk is shot down...");
        }
    }
}
