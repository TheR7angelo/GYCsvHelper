using System.Collections.ObjectModel;
using LibsPlaningAChaud.Sql;
using LibsPlaningAChaud.Sql.Struc;

namespace GYCsvHelper.UserControls;

public partial class Zones
{
    private readonly SqlHandler _sqlHandler;
    public ObservableCollection<Zone> CollectionZones { get; } = new();
    
    public Zones(SqlHandler sqlHandler)
    {
        _sqlHandler = sqlHandler;
        InitializeComponent();
    }

    private void GetAllZones()
    {
        var zones = _sqlHandler.GetAllZones();
        
        CollectionZones.Clear();
        foreach (var zone in zones) CollectionZones.Add(zone);
    }
}