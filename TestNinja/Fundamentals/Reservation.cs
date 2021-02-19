namespace TestNinja.Fundamentals
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            ///How was before unity tests and refactoring
            //if (user.IsAdmin)
            //{
            //    return true;
            //}
            //if (MadeBy == user)
            //{
            //    return true;
            //}
            //return false;

            ///---After unity tests and refactoring
            return (user.IsAdmin || MadeBy == user);
        }
        
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}