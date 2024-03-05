namespace DPGI1
{

    /// <summary>
    /// Creating class Hello for greeting
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Hello hello = new Hello("Deny");
            hello.Greeting();
        }
    }

    class Hello
    {
        private String Name { get; set; }
        public Hello(String Name)
        {
            this.Name = Name;
        }
        public void Greeting()
        {
            Console.WriteLine($"Hello {Name} !");
        }

    }
}
