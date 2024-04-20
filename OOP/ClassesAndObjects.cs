class ClassesAndObjects
{
    public static void main(String[] args)
    {
        // Patiant is the CLASS
        // "P1" is the OBJECT (Instance of the Class)

        Patient p1 = new Patient();
        
        Patient p2 = new Patient();

        p1.name = "Shane";
        p2.name = "Rashini";
         
    }

    class Patient()
    {
        public string name { get; set; }

        public string age { get; set; }

        public string address { get; set; }        

    }
}
