namespace SOLIDExamples._2___OCP.First_Example
{
    //Class to be overridden by another classe as needed, without changing this class
    public abstract class PersonRegister
    {
        public string Name { get; set; }
        public string RegisterDate { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public abstract void RegisterPerson(string name, string registerDate, string CPF, string email);
    }
}
