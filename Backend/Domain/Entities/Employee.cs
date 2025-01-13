    // Employee entity with roles
public class Employee
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public EmployeeRole Role { get; private set; }
    public Guid CompanyId { get; private set; } // NEW

    public Employee(string name, string email, string password, EmployeeRole role, Guid companyId)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        Password = password;
        Role = role;
        CompanyId = companyId;
    }
}
