using Fame;



    [FamePackage("FAMIX")]
    [FameDescription("CaughtException")]
    public class CaughtException : Exception
    {
        [FameProperty(Name = "definingMethod") Opposite = "caughtExceptions"]
        public Method definingMethod { get; set; }







    }
}