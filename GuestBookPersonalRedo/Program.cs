


using GuestBookPersonalRedo;


GuestBookMethods.WelcomeTheUser();

var (totalGuests, AllPartiesWithCount) = GuestBookMethods.GetTotalGuests();

GuestBookMethods.LoopOverGuestsWithCount(AllPartiesWithCount);

Console.WriteLine($"Total Guests is: {totalGuests}");