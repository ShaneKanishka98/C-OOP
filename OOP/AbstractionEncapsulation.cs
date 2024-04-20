class AbstractionEncapsulation
{
    public static void main(String[] args)
    {
        Patient p1 = new Patient();

        // When the access modifier is PUBLIC : can Access
        // When the access modifier is PRIVATE : can NOT Access
        // p1.checkAddress();

        // ABSTRACTION happen durig the design phase
        // What has to be shown public
        // During the execution phase developer uses ECAPSULATION to implement the ABSTRACTION
        // ENCAPSULATION implements ABSTRACT
    }

    class Patient()
    {
        public string name { get; set; }

        public string age { get; set; }

        public string address { get; set; }

        public void validate() {
            checkName();
            checkAge();
            checkAddress();

        }

        private void checkName() { }

        private void checkAge() { }

        private void checkAddress() { }


    }
}
