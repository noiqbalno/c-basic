namespace Day05.Quis
{
    internal class Customer : AbstractPersonContact
    {
        public int CustomerID { get; set;}
        public override string ToString()
        {
            return $"CustomerID: {CustomerID}\n" +
                   $"CompanyName: {CompanyName}\n" +
                   $"ContactName: {ContactName}\n" +
                   $"ContactTitle: {ContactTitle}\n" +
                   $"Address: {Address}\n" +
                   $"City: {City}\n" +
                   $"Region: {Region}\n" +
                   $"Postal Code: {PostalCode}\n" +
                   $"Country: {Country}\n";
        }
    }


}
