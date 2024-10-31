namespace EmployeeManagement.Models
{
	public class Employee
	{
		public int id {  get; set; }
		public string name { get; set; }
		public DateTime reg_date { get; set; }
		public string address { get; set; }
		public string mob_num {  get; set; }
		public string email {  get; set; }
		public string password { get; set; }

		public Employee(int id, string name, DateTime reg_date, string address, string mob_num, string email, string password)
		{
			this.id = id;
			this.name = name;
			this.reg_date = reg_date;
			this.address = address;
			this.mob_num = mob_num;
			this.email = email;
			this.password = password;
		}

		public Employee(string name, DateTime reg_date, string address, string mob_num, string email, string password)
		{
			this.name = name;
			this.reg_date = reg_date;
			this.address = address;
			this.mob_num = mob_num;
			this.email = email;
			this.password = password;
		}
	}
}
