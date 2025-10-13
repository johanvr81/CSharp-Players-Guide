using The_Password_Validator;

Console.Title = "The Password Validator";


PasswordValidator validator = new PasswordValidator();

while (true)
{
    Console.Write("Enter a password: ");
    string? password = Console.ReadLine();

    if (password == null) break; 

    if (validator.IsValid(password)) Console.WriteLine("That password is valid.");
    else Console.WriteLine("That password is not valid.");
}