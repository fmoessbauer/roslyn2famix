using Fame;



    [FamePackage("FAMIX")]
    [FameDescription("Header")]
    public class Header : CFile
    {
        [FameProperty(Name = "module") Opposite = "header"]
        public Module module { get; set; }







    }
}