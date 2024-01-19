namespace Day05.Quis
{
    internal class Employee : AbstractPerson
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string HomePhone { get; set; }
        public int Extension { get; set; }
        public string Photo { get; set; }
        public string Notes { get; set; }
        public int? ReportsTo { get; set; }
        public string PhotoPath { get; set; }

        public override string ToString()
        {
            return $"Employee ID: {EmployeeID}\n" +
                   $"Name: {TitleOfCourtesy} {FirstName} {LastName}\n" +
                   $"Title: {Title}\n" +
                   $"Birth Date: {BirthDate.ToShortDateString()}\n" +
                   $"Hire Date: {HireDate.ToShortDateString()}\n" +
                   $"Home Phone: {HomePhone}\n" +
                   $"Extension: {Extension}\n" +
                   $"Photo: {Photo}\n" +
                   $"Notes: {Notes}\n" +
                   $"Reports To: {ReportsTo}\n" +
                   $"Photo Path: {PhotoPath}\n" +
                   $"Address: {Address}\n" +
                   $"City: {City}\n" +
                   $"Region: {Region}\n" +
                   $"Postal Code: {PostalCode}\n" +
                   $"Country: {Country}\n";
        }
    }


}
