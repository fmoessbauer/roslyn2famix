using Fame;



    [FamePackage("FAMIX")]
    [FameDescription("AnnotationType")]
    public class AnnotationType : Type
    {
        [FameProperty(Name = "container") Opposite = "definedAnnotationTypes"]
        public ContainerEntity container { get; set; }








    }
}