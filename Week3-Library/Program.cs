using Week3_Library;

class Program
{
    static void Main(string[] args)
    {

        Book book = new Book("C# for beginners", "Bill Gates", 
            "12345678");

        book.DisplayInfo();

        Member member = new Member(1, "John Smith","1 High Street",
            0790090090);
        Member member1 = new Member(2, "Mary Jones", "102 High Street",
            0790345666);

        Console.WriteLine("Current library members");
        member.DisplayInfo();
        member1.DisplayInfo();
    }
}


