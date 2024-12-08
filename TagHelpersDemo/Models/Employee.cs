namespace TagHelpersDemo.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }     // Gender is enum and Gender is property
        public int Age { get; set; }
        public string Designation {  get; set; }

        public int Salary { get; set; }

        public string Married { get; set; }
        public string Description  { get; set; }
    }
    // we make enum  constant for dropdown list which we cant change

    public enum Gender
    {
        Male,Female
    }
}
