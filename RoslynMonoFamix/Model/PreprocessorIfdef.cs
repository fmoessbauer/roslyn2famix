using Fame;



    [FamePackage("FAMIX")]
    [FameDescription("PreprocessorIfdef")]
    public class PreprocessorIfdef : PreprocessorStatement
    {
        [FameProperty(Name = "negated")]
        public Boolean negated { get; set; }

        [FameProperty(Name = "macro")]
        public String macro { get; set; }







    }
}