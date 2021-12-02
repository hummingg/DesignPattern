namespace DesignPattern.FacadePattern
{
    /// <summary>
    /// 电脑  facede角色
    /// </summary>
    public class Computer
    {
        private CPU cpu;
        private Memory memory;
        private Disk disk;

        public Computer()
        {
            this.cpu = new CPU();
            this.memory = new Memory();
            this.disk = new Disk();
        }

        public void Start()
        {
            cpu.CPUStart();
            memory.MemoryStart();
            disk.DiskStart();
            Console.WriteLine("computer start end!");
        }

        public void Shutdown()
        {
            cpu.CPUShutdown();
            memory.MemoryShutdown();
            disk.DiskShutdown();
            Console.WriteLine("computer shutdown end!");
        }
    }
}
