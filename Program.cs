using RRPS03;

//Singleton s1 = Singleton.GetInstance();
//Singleton s2 = Singleton.GetInstance();

//if (s1.Equals(s2))
//{
//    Console.WriteLine("Singleton works, both variables contain the same instance.");
//}
//else
//{
//    Console.WriteLine("Singleton failed, variables contain different instances.");
//}


//new Client().Main();

//ObserverMain();

IteratorMain();

//static void ObserverMain()
//{
//    // The client code.
//    var subject = new Subject();
//    var observerA = new ConcreteObserverA();
//    subject.Attach(observerA);

//    var observerB = new ConcreteObserverB();
//    subject.Attach(observerB);

//    subject.SomeBusinessLogic();
//    subject.SomeBusinessLogic();

//    subject.Detach(observerB);

//    subject.SomeBusinessLogic();
//}

//static void AdapterMain()
//{
//    Adaptee adaptee = new Adaptee();
//    ITarget target = new Adapter(adaptee);

//    Console.WriteLine("Adaptee interface is incompatible with the client.");
//    Console.WriteLine("But with adapter client can call it's method.");

//    Console.WriteLine(target.GetRequest());
//}

static void IteratorMain()
{
    var collection = new WordsCollection();
    collection.AddItem("First");
    collection.AddItem("Second");
    collection.AddItem("Third");

    Console.WriteLine("Straight traversal:");

    foreach (var element in collection)
    {
        Console.WriteLine(element);
    }
}