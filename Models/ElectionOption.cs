class ElectionOption
{
    public Guid id;
    public string name;

    public ElectionOption(string name)
    {
        this.name = name;
        id = Guid.NewGuid();
    }
}