namespace ProjectB
{
    using AutoMapper;
    using Newtonsoft.Json;
    
    public static class ClassB
    {
        public static void DoSomething()
        {
            var mapperConfig = new MapperConfiguration(a => a.AddGlobalIgnore("d"));
            var json = JsonSerializer.Create();
        }
    }
}