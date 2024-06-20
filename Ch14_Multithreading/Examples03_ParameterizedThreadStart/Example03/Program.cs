using Example03;

Person tom = new Person("Tom", 37);
Thread myThread = new Thread(tom.Print);
myThread.Start();
