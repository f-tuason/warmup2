
//get input from user
Console.Write("Enter x: ");
int counter = Convert.ToInt32(Console.ReadLine());
//this variable controls the number of spaces
int numspaces = 2;

void write(int i)
{
    string numberorasterisk = (i % 2 == 0) ? "*" : i.ToString();
    Console.WriteLine("{0}{1}{2}{3}", new string(' ', (counter-i) * numspaces), numberorasterisk, new string(' ', (i*2-3) * numspaces), numberorasterisk);
}

for (int c = counter; c > 0; c--)
{
    if (c == 1)
    {
        Console.WriteLine("{0}{1}", new string(' ', (counter-c) * numspaces), c.ToString());
    }
    else
    {
        write(c);
    }
}
for (int c = 2; c <= counter; c++)
{
    write(c);
}