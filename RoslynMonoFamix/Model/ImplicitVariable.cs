using Fame;



    [FamePackage("FAMIX")]
    [FameDescription("ImplicitVariable")]
    public class ImplicitVariable : StructuralEntity
    {
        [FameProperty(Name = "parentBehaviouralEntity") Opposite = "implicitVariables"]
        public BehaviouralEntity parentBehaviouralEntity { get; set; }







    }
}