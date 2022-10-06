using System.Diagnostics;

namespace FootballPlayers
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public int ShirtNo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        public void ValidateName()
        {

            if (Name.Length < 2)
                throw new ArgumentOutOfRangeException("Name must contain two character" + Name);


        }

        public override string ToString()
        {
            return Id + "," + Name + "," + Age + "," + ShirtNo;
        }
        public void ValidateAge()
        {
            if (Age < 1)
                throw new ArgumentOutOfRangeException("Age Must be above one" + Age);
        }
        public void ValidateShirtNo()
        {
            if (ShirtNo < 1 || ShirtNo>99)
             throw new ArgumentOutOfRangeException("ShirtNo cannot be less than 1" + ShirtNo);
           

        }

        public void Validate()
        {
            ValidateAge();
            ValidateName();
            ValidateShirtNo();  
        }


    }





}