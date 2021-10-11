namespace CafeLib
{
    /* Interface: IMood
     * Author: Jonathan Karcher
     * Purpose: Create an interface to get the mood 
     */
    public interface IMood
    {
        /* Parameter:Mood
         * Purpose: Return the mood
         * Restrictions: Read only
         */
        string Mood
        { get; }
    }
    /* Interface: ITakeOrder
     * Author: Jonathan Karcher
     * Purpose: Create an interface to take an order
     */
    public interface ITakeOrder
    {
        /* Method: TakeOrder
         * Purpose: Takes an order
         * Restrictions: None
         */
        void TakeOrder();
    }
    /* Class: HotDrink
     * Author: Jonathan Karcher
     * Purpose: Defines a basic hot drink
     */
    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string size;
        public Customer customer;
        /* Constructor:
         * Purpose: Create an empty HotDrink
         * Restrictions: None
         */
        public HotDrink()
        { }
        /* Constructor: HotDrink
         * Purpose: Create a HotDrink with a specific brand
         * Restrictions: None
         */
        public HotDrink(string brand)
        { }
        /* Method: AddSugar
         * Purpose: Add sugar to the drink
         * Restrictions: None
         */
        public virtual void AddSugar(byte amount)
        {
            sugar = amount;
        }
        /* Method: Steam
         * Purpose: Add the option to steam the drink
         * Restrictions: None
         */
        public abstract void Steam();
    }
    /* Class: Waiter
     * Author: Jonathan Karcher
     * Purpose: Serve the customer a drink
     */
    public class Waiter : IMood
    {
        public string name;
        /* Parameter: Mood
         * Purpose: Returns the mood of the Waiter
         * Restrictions: Read only
         */
        public string Mood
        { get; }
        /* Method: ServeCustomer
         * Purpose: Serve the customer a drink
         * Restrictions: None
         */
        public void ServeCustomer(HotDrink cup)
        { }
    }
    /* Class: Customer
     * Author: Jonathan Karcher
     * Purpose: Recipient of the drink
     */
    public class Customer : IMood
    {
        public string name;
        public string creditCardNumber;
        /* Parameter: Mood
         * Purpose: Returns the mood of the customer
         * Restrictions: Read only
         */
        public string Mood
        { get; }
    }
    /* Class: CupOfCoffee
     * Author: Jonathan Karcher
     * Purpose: Make a CupOfCoffee from a HotDrink
     */
    public class CupOfCoffee : HotDrink, ITakeOrder
    {
        public string beanType;
        /* Constructor: CupOfCoffee
         * Purpose: Create a CupOfCoffee with an entered brand
         * Restrictions: None
         */
        public CupOfCoffee(string brand) : base(brand)
        { }
        /* Method: Steam
         * Purpose: Use the steam option on the CupOfCoffee
         * Restrictions: None
         */
        public override void Steam()
        { }
        /* Method: TakeOrder
         * Purpose: Take the CupOfCoffee as the order
         * Restrictions: None
         */
        public void TakeOrder()
        { }
    }
    /* Class: CupOfTea
     * Author: Jonathan Karcher
     * Purpose: Make a CupOfTea from a HotDrink
     */
    public class CupOfTea : HotDrink, ITakeOrder
    {
        public string leafType;
        /* Constructor: CupOfTea
         * Purpose: Create a CupOfTea from a HotDrink and indicate if the customer Is wealthy
         * Restrictions: None
         */
        public CupOfTea(bool customerIsWealthy)
        { }
        /* Method: Steam
         * Purpose: Use the steam option on the CupOfTea
         * Restrictions: None
         */
        public override void Steam()
        { }
        /* Method: TakeOrder
         * Purpose: Take the CupOfTea as the order
         * Restrictions: None
         */
        public void TakeOrder()
        { }
    }
    /* Class: CupOfCocoa
     * Author: Jonathan Karcher
     * Purpose: Make a CupOfCocoa from a HotDrink
     */
    public class CupOfCocoa : HotDrink, ITakeOrder
    {
        public int numCups;
        public bool marshmellows;
        private string source;
        /* Parameter: Source
         * Purpose: Assign a source to the CupOfCocoa
         * Restrictions: Wright only
         */
        public string Source
        { set { source = value; } }
        /* Method: Steam
         * Purpose: Use the steam option on the CupOfCocoa
         * Restrictions: None
         */
        public override void Steam()
        { }
        /* Method: AddSugar
         * Purpose: Add sugar to the CupOfCocoa
         * Restrictions: None
         */
        public override void AddSugar(byte amount)
        { }
        /* Method: TakeOrder
         * Purpose: Take the CupOfCocoa as the order
         * Restrictions: None
         */
        public void TakeOrder()
        { }
        /* Constructor: CupOfCocoa
         * Purpose: Create a CupOfCocoa assuming that the marshmallows are false
         * Restrictions: None
         */
        public CupOfCocoa() : this(false)
        { }
        /* Constructor: CupOfCocoa
         * Purpose: Create a CupOfCocoa and set the hotDrink brand to Expensive Organic Brand
         * Restrictions: None
         */
        public CupOfCocoa(bool marshmallows) : base("Expensive Organic Brand")
        { }
    }
}
