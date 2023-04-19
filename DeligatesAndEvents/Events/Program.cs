using Events.Models;

Market tinex = new Market() { Name = "Tinex", CurrentProductType = ProductType.Food};
Market vero = new Market() { Name = "Vero", CurrentProductType = ProductType.Cosmetics };

User kiko = new User("Kristijna", "Jankuloski", "jankuloksi.k@gmail.com", 25);
User john = new User("John", "Doe", "john.doe@gmail.com", 22);
User bob = new User("Bob", "Bobski", "bob.bobski@gmail.com", 27);

tinex.SubscribeToPromotion(kiko.ReadPromotion, kiko.Email);
tinex.SubscribeToPromotion(john.ReadPromotion, john.Email);
vero.SubscribeToPromotion(bob.ReadPromotion, bob.Email);

tinex.Send();
Thread.Sleep(2000);
vero.Send();
Thread.Sleep(2000);

tinex.Unsubscribe(john.ReadPromotion, john.Email);
tinex.Send();