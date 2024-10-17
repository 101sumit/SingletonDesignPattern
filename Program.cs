using System;
using SingletonDesignPattern;

Thread t1 = new Thread(() =>
{ 
    var obj = SingletonService.GetInstance(1);
});

Thread t2 = new Thread(() =>
{
    var obj = SingletonService.GetInstance(2);
});

t1.Start();
t2.Start();

t1.Join();
t2.Join();
