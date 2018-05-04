namespace testdata
{
  class Program
  {
    static void Main(string[] args)
    {
      InsertData();
    }

    private static void InsertData()
    {
      using (var context = new SalesContext())
      {
        // Creates the database if not exists
        context.Database.EnsureCreated();

        // Adds a client
        //var clients = new List<Client>
        //{
        //  new Client
        //  {
        //    FirstName = "John",
        //    LastName = "Doe"
        //  },
        //  new Client
        //  {
        //    FirstName = "John",
        //    LastName = "Smith"
        //  },
        //  new Client
        //  {
        //    FirstName = "Marry",
        //    LastName = "Jane"
        //  },
        //  new Client
        //  {
        //    FirstName = "Iker",
        //    LastName = "Robertson"
        //  }
        //};

        //clients.ForEach(x =>
        //{
        //  context.Clients.Add(x);
        //});

        // Saves changes
        context.SaveChanges();
      }
    }
  }
}
