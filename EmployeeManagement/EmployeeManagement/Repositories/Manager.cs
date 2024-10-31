namespace EmployeeManagement.Repositories
{
    public class Manager : IManager
    {
        public bool Login(string email, string password)
        {
            using (var context = new CollectionContext())
            {
                var emp= context.Employees.Where(e => e.email.Equals(email) && e.password.Equals(password)).FirstOrDefault();
                Console.WriteLine(emp);
                if (emp != null )
                {
                    return true;
                }
                return false;
            }

        }
    }
}
