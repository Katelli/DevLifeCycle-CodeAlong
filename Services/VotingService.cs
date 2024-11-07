using Microsoft.Extensions.Options;

class VotingService
{
    private List<Election> activeElections;

    public VotingService()
    {
        activeElections = new List<Election>();
    }

    // Post
    public Election AddNewElection()
    {
        var hardCodedOptions = new List<ElectionOption>
        {
            new ElectionOption("Høyre"),
            new ElectionOption("Arbeiderpartiet"),
        };

        Election newElection = new Election(hardCodedOptions);

        activeElections.Add(newElection);

        return newElection;
    }
}