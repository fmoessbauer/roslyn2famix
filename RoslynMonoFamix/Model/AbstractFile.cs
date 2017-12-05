using Fame;



    [FamePackage("FILE")]
    [FameDescription("AbstractFile")]
    public class AbstractFile : Entity
    {
        [FameProperty(Name = "name")]
        public String name { get; set; }

        [FameProperty(Name = "parentFolder") Opposite = "childrenFileSystemEntities"]
        public Folder parentFolder { get; set; }







    }
}