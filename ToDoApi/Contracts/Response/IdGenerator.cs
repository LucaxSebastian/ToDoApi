namespace ToDoApi.Contracts.Response
{
    public static class IdIncrementer
    {
        private static int Id { get; set; }
    
        public static int GetNextId()
        {
            Id++;
            return Id;
        }
    }
}
