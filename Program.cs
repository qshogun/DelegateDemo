public class Individual
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Birthdate { get; set; }

    public Individual()
    {
    }

    public Individual WithFirstName(string firstName)
    {
        FirstName = firstName;
        return this;
    }
    
    public Individual WithLastName(string lastName)
    {
        LastName = lastName;
        return this;
    }
    
    public Individual WithBirthdate(DateTime birthdate)
    {
        Birthdate = birthdate;
        return this;
    }
}

public static class IndividualFactory
{
    public static Individual CreateIndividual(Action<Individual> action)
    {
        return new Individual();
    }


    
    public static List<Individual> CreateIndividuals(int count)
    {
        var individualList = new List<Individual>();
        for (int i = 0; i < count; i++)
        {
            /*
             * You can adjust your method however you please depending on your requirements
             */
            
            //individualList.Add(CreateIndividual(i => i.WithFirstName("Piotr")));
            //individualList.Add(CreateIndividual(i => i.WithLastName("Kurszewski")));
            individualList.Add(CreateIndividual(i => i
            .WithFirstName("Piotr")
            .WithLastName("Kurszewski")
            .WithBirthdate(DateTime.Today)));
        }
        return individualList;
    }
}
