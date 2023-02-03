namespace Lab14_LiliyaBukhtik.Models
{
    public enum Gender
    {
        male,
        female
    }
    public class RegistrationForm
    {
        public string name { get; set; }
        public int  age { get; set; }

        public Gender gender { get; set; }

        public string email { get; set; }

        public string password { get; set; }
        public RegistrationForm(string name, int age, Gender gender, string email, string password)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.email = email;
            this.password = password;
        }
    }
}
