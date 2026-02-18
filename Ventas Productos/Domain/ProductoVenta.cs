using System.ComponentModel;

public class ProductoVenta : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    public int Id { get; set; }
    public string Nombre { get; set; }

    private int _cantidad;
    public int Cantidad
    {
        get => _cantidad;
        set
        {
            if (_cantidad == value) return;
            _cantidad = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Cantidad)));
        }
    }
    public decimal Precio { get; set; }
}
