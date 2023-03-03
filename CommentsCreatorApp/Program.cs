
using Humanizer;

namespace CommentsCreatorApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var comments = new List<Comments>
            {
                new Comments
                {
                    Owner = "Abdulrhman Hosny",
                    Comment = "I think ASP NET core is the most powerful web framework",
                    CreatedAt = new DateTime(2021, 01, 01, 10, 30, 00)
                },
                new Comments
                {
                    Owner = "Omar Hosny",
                    Comment = "Aru you OKAY?? Speak to meee",
                    CreatedAt = new DateTime(2022, 03, 07, 05, 40, 15)
                },
                new Comments
                {
                    Owner = "Muhammed Ali",
                    Comment = "Fire On Fire will normally kill us",
                    CreatedAt = new DateTime(2023, 11, 12, 11, 05, 00)
                },
                new Comments
                {
                    Owner = "Youusef Ayman",
                    Comment = "I have to parctise more so i can gain knowledge",
                    CreatedAt = DateTime.Now,
                },
                new Comments
                {
                    Owner = "Ibrahim Kamel",
                    Comment = "Last Comment haha. It has to be a little longer!",
                    CreatedAt = DateTime.Now.AddYears(-2).AddDays(5).AddHours(3),
                },
            };

            foreach (var comment in comments)
            {
                Console.WriteLine(comment);
            }
            Console.ReadLine();
        }
    }
class Comments
{
    public string Owner { get; set; }
    public string Comment { get; set; }

    public DateTime CreatedAt { get; set; }

    public override string ToString()
    {
        return $"{Owner} says: \n" +
               $"\"{Comment}\"" +
               $"\n\t\t\t\t {CreatedAt.Humanize()}";
    }

}
}