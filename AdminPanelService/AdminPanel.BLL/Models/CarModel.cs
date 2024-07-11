namespace AdminPanel.BLL.Models;

public class CarModel
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public Guid ManufacturerId { get; set; }
    public ManufacturerModel? Manufacturer { get; set; }

    public IEnumerable<VehicleModel>? Vehicles { get; set; }
}