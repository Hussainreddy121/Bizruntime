function show<T, U>(v1: T, v2: U): void
{
    console.log(v1 + " " + v2);
}

show(45,43);
show<number, number>(2,5);
show(45, "ravi");
show("mahesh", "raju");
show<string, number>("hussain", 47);