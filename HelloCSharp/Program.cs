string permission = "Admin|Manager";
// string permission = "Guest";

int level = 55;

string greetingSuperAdmin = "Welcome, Super Admin user.";
string greetingAdmin = "Welcome, Admin user.";
string greetingManager = "Contact an Admin for access.";
string greetingNoAccess = "You do not have sufficient privileges.";


if (permission.Contains("Admin"))
{
    Console.WriteLine($"{((level > 55 ? greetingSuperAdmin : greetingAdmin))}");

}
else if (permission.Contains("Manager") && level >= 20)
{
    Console.WriteLine(greetingManager);

}
else
{
    Console.WriteLine(greetingNoAccess);
}
