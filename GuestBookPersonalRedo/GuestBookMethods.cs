using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookPersonalRedo
{
    public static class GuestBookMethods
    {
        public static void WelcomeTheUser()
        {
            Console.WriteLine("Welcome to the guest book App.");
            Console.WriteLine("******************************");
        }

        public static string GetPartyName()
        {
            Console.Write("Enter the name: ");
            string partyName = Console.ReadLine();
            return partyName;
        }

        public static int GetPartyCount()
        {
            bool isValidParty;
            int partyCount;
            do
            {
                Console.Write("Enter the number in the party: ");
                string partyText = Console.ReadLine();
                isValidParty = int.TryParse(partyText, out partyCount);
                if (!isValidParty)
                {
                    Console.WriteLine("Invalid number");
                }
            } while (!isValidParty);

            return partyCount;
        }

        public static bool ContinueLooping()
        {
            Console.Write("Are there any guests coming (yes/no): ");
            string continueLooping = Console.ReadLine();
            bool continueLoopingBool = (continueLooping == "yes");
            return continueLoopingBool;

        }

        public static (int totalGuests, Dictionary<string, int> AllPartiesWithCount) GetTotalGuests()
        {
            int totalGuests = 0;
            string partyName;
            int partyCount;
            Dictionary<string, int> partyNamesWithCount = new Dictionary<string, int>();

            do
            {
                partyName = GetPartyName();
                partyCount = GetPartyCount();

                totalGuests += partyCount;
                partyNamesWithCount.Add(partyName, partyCount);

            } while (ContinueLooping());

            return (totalGuests, partyNamesWithCount);
        }

        public static void LoopOverGuestsWithCount(Dictionary<string, int> AllPartiesWithCount)
        {
            foreach (var partyWithCount in AllPartiesWithCount)
            {
                Console.WriteLine($"{partyWithCount.Key}: {partyWithCount.Value}");
            }
        }
    }
}
