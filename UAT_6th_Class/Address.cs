namespace UAT_C_First_Class;

// ==========================================
// CHALLENGE 1: ADDRESS CLASS (Composition)
// ==========================================
// Instead of adding 5 separate address properties directly to Customer,
// grouping them into an Address class keeps related data together and reusable.
public class Address
{
    // Auto-implemented properties (string for HouseNumber supports values like "12A")
    public string HouseNumber { get; set; }
    public string Street { get; set; }
    public string Town { get; set; }
    public string County { get; set; }
    public string Postcode { get; set; }

    // Expression-bodied (read-only) property returning a formatted single-line address
    public string FormattedAddress => $"{HouseNumber} {Street}, {Town}, {County}, {Postcode}";

    // Constructor: runs automatically when creating a new Address object
    public Address(string houseNumber, string street, string town, string county, string postcode)
    {
        HouseNumber = houseNumber;
        Street = street;
        Town = town;
        County = county;
        Postcode = postcode;
    }
}

