using Fame;



    [FamePackage("FAMIX")]
    [FameDescription("Association")]
    public class Association : SourcedEntity
    {
        [FameProperty(Name = "previous") Opposite = "next"]
        public Association previous { get; set; }







    }
}