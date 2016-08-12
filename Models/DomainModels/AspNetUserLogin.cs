namespace Models.DomainModels
{
    public class AspNetUserLogin
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
