namespace Animals
{
    public class Animal
    {
        private double _WalkingSpeed;
        private string _species;
        public string Name {get; }
        public string Species
        {
            get
            {
                return _species;
            }
        } 
        public double WalkingSpeed
        {
            get
            {
                return _WalkingSpeed;
            }
        }
        
        public Animal(string name)
        {
            this.Name= name;
        }
        public void SetSpecies(string species)
        {
            _species= species;
        }
        public void Walk(double speed)
        {
            _WalkingSpeed= speed;
        }
    }
}