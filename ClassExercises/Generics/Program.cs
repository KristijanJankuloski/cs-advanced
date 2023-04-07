using Generics.Entities;

GenericDb<Order> orders = new GenericDb<Order>();

orders.Add(new Order(1, "Phone"));
orders.Add(new Order(2, "Tablet"));
orders.Add(new Order(3, "Shavers"));

orders.PrintItems();