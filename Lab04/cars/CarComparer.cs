namespace Lab04.cars;

public class CarComparer : IComparer<Car>
{
    public enum SortField
    {
        Name,
        ProductionYear,
        MaxSpeed
    }

    private SortField field;

    public CarComparer(SortField field) => this.field = field;

    public int Compare(Car? x, Car? y)
    {
        if (x == null || y == null)
            return 0;

        switch (field)
        {
            case SortField.Name:
                return x.Name.CompareTo(y.Name);
            case SortField.ProductionYear:
                return x.ProductionYear.CompareTo(y.ProductionYear);
            default:
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
        }
    }
}