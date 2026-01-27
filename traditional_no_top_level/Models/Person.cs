namespace traditional_no_top_level.Models;

public class Person
{
    private string _firstName;
    private string _lastName;
    private int _birthYear;
    private bool _isAlive;

    public string LastName
    {
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Last name can't be null or empty.");
            _lastName = value;
        }
    }
    
    public Person(string firstName, string lastName, int birthYear)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            throw new ArgumentException("First name cannot be empty.", nameof(firstName));
        if (string.IsNullOrWhiteSpace(lastName))
            throw new ArgumentException("Last name cannot be empty.", nameof(lastName));
        if (birthYear < 1900 || birthYear > DateTime.Now.Year)
            throw new ArgumentOutOfRangeException(nameof(birthYear), "Birth year is invalid.");
        
        _firstName = firstName;
        _lastName = lastName;
        _birthYear = birthYear;
        _isAlive = true;
    }

    
    public string ShowFullName()
    {
        return $"{_firstName} {_lastName}";
    }

    public int GetBirthYear()
    {
        return _birthYear;
    }

    public string IsPersonAlive()
    {
        if (_isAlive)
            return "Person is currently alive.";
        else
        {
            return "Person is dead.";
        }
    }
    
    public void PersonIsDead()
    {
        _isAlive = false;
    }
}