namespace Core.Entities
{
    public class Developer : BaseEntity 
    {
        public string Fullname {get; set;}

        public string Avatar {get; set;}

        public string Profile {get; set;}

        public Address Address {get; set;}

    }


}