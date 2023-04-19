namespace Events.Models
{
    public class Market
    {
        public delegate void PromotionSender(ProductType productType, string name);
        event PromotionSender PromotionSenderEvent;

        public string Name { get; set; }
        public List<string> Emails { get; set; }
        public ProductType CurrentProductType { get; set; }

        public Market()
        {
            Emails = new List<string>();
        }
        public Market(string name)
        {
            Name = name;
            Emails = new List<string>();
        }

        public void SubscribeToPromotion(PromotionSender eventHandler, string email)
        {
            PromotionSenderEvent += eventHandler;
            Emails.Add(email);
        }
        public void Unsubscribe(PromotionSender eventHandler, string email)
        {
            PromotionSenderEvent -= eventHandler;
            string emailToDelete = Emails.FirstOrDefault(x => x == email);
            if (emailToDelete != null) 
                Emails.Remove(emailToDelete);
        }

        public void Send()
        {
            PromotionSenderEvent(CurrentProductType, Name);
        }
    }

    public enum ProductType
    {
        Food,
        Cosmetics,
        Electronics,
        Other
    }
}
