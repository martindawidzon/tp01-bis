class Cabaña
{
    int Id;
    string nombre;
    string descripción;
    int capacidad;
    List<string> fotos = new List<string>();
    List<string> ambientes = new List<string>();

    public Cabaña(int Id, string nombre, string descripción, int capacidad, List<string> fotos, List<string> ambientes)
    {
        this.Id = Id;
        this.nombre = nombre;
        this.descripción = descripción;
        this.capacidad = capacidad;
        this.fotos = fotos;
        this.ambientes = ambientes;
    }
    public int getId()
    {
        return this.Id;
    }
    public string getNombre()
    {
        return this.nombre;
    }
    public string getDescripcion()
    {
        return this.descripción;
    }
    public int getCapacidad()
    {
        return this.capacidad;
    }
    public List<string> getFotos()
    {
        return this.fotos;
    }
    public List<string> getAmbientes()
    {
        return this.ambientes;
    }

}