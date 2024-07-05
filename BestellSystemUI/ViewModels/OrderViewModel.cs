
using BestellSystemUI.Commands;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BestellSystemUI.ViewModels;

class OrderViewModel:ViewModelBase
{

    // burda belirtilen özellikler ekranda görünmesi istenen özelliklerdir
    //public List<Posten> Bestellposten=> _bestellung.Bestellposten;
    private Bestellung _bestellung { get; set; }
    public ObservableCollection<Posten> Bestellposten => new ObservableCollection<Posten>(_bestellung.Bestellposten);
    public double GesamtPreis => _bestellung.BerechneBestellung();
    public Posten AktuellerPosten { get; set; }
    public ICommand AddPostenCommand { get; set; }
    public ICommand DeletePostenCommand { get; set; }
    public int Itemzahl
    {
        get => Bestellposten.Count;
        set
        {
           // Itemzahl=Bestellposten.Count; 
            OnPropertyChanged(nameof(Itemzahl));
        }
    }
    
    public bool BitAndByte
    {
        get => _bestellung.BitAndByteCard;
        set
        {
            _bestellung.BitAndByteCard = value;
            OnPropertyChanged(nameof(GesamtPreis));
        }

    }
  

    public OrderViewModel()// bu model baslangicta cstor sadece baslangic ürünleri ekleniyor
    {
        _bestellung = new Bestellung();
        _bestellung.AddPosten(Bestellpostentyp.Bier);
        _bestellung.AddPosten(Bestellpostentyp.Pizza);
        _bestellung.AddPosten(Bestellpostentyp.Cola);
        _bestellung.AddPosten(Bestellpostentyp.Fanta);
        Itemzahl = Bestellposten.Count();
   
        AddPostenCommand = new RelayCommand(AddPosten);
        DeletePostenCommand = new RelayCommand(DeletePosten);

    }

    private void AddPosten(object? param)
    {

        Enum.TryParse((param as string), out Bestellpostentyp type);

        _bestellung.AddPosten(type);
        OnPropertyChanged(nameof(GesamtPreis));
        OnPropertyChanged(nameof(Bestellposten));
        OnPropertyChanged(nameof(Itemzahl));
    }

    private void DeletePosten(object? param)
    {
        if (AktuellerPosten == null) return;

        _bestellung.DeletePosten(AktuellerPosten);
        OnPropertyChanged(nameof(GesamtPreis));
        OnPropertyChanged(nameof(Bestellposten));
        OnPropertyChanged(nameof(Itemzahl));
    }










}
