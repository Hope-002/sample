namespace sample
{
       
        public class Employee
        {
        public static int Count { get; internal set; }
        public int ID { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public bool IsActive { get; set; }

        internal static void Add(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
