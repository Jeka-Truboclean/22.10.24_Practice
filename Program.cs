using _22._10._24_Practice.Data;
using _22._10._24_Practice.Models;

namespace _22._10._24_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SportsEventContext())
            {
                var sportEvent = new SportEvent
                {
                    Name = "Football Match",
                    Date = new DateTime(2024, 11, 10),
                    Location = "Stadium A",
                    Description = "Championship final"
                };
                context.SportEvents.Add(sportEvent);
                context.SaveChanges();
                Console.WriteLine("New sport event added.");

                var eventToUpdate = context.SportEvents.FirstOrDefault(e => e.Id == sportEvent.Id);
                if (eventToUpdate != null)
                {
                    eventToUpdate.Name = "Updated Football Match";
                    eventToUpdate.Date = new DateTime(2024, 12, 15);
                    eventToUpdate.Location = "Updated Stadium B";
                    eventToUpdate.Description = "Updated championship final";
                    context.SaveChanges();
                    Console.WriteLine("Sport event updated.");
                }

                var eventToDelete = context.SportEvents.FirstOrDefault(e => e.Id == sportEvent.Id);
                if (eventToDelete != null)
                {
                    context.SportEvents.Remove(eventToDelete);
                    context.SaveChanges();
                    Console.WriteLine("Sport event deleted.");
                }

                var allEvents = context.SportEvents.ToList();
                Console.WriteLine("List of all sport events:");
                foreach (var ev in allEvents)
                {
                    Console.WriteLine($"Name: {ev.Name}, Date: {ev.Date}, Location: {ev.Location}, Description: {ev.Description}");
                }
            }
        }
    }
}
