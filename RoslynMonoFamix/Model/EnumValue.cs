using Fame;



    [FamePackage("FAMIX")]
    [FameDescription("EnumValue")]
    public class EnumValue : StructuralEntity
    {
        [FameProperty(Name = "parentEnum") Opposite = "values"]
        public Enum parentEnum { get; set; }







    }
}