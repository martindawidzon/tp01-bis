class Complejo
{
   Dictionary<int, Cabaña> dicCabañas = new  Dictionary<int, Cabaña>();

   public Complejo(Dictionary<int, Cabaña> dicCabañas)
   {
    this.dicCabañas = dicCabañas;
   }
   public void inicializarCabañas()
   {
    List<string> fotos1 = new List<string>{"https://www.homify.com.ar/libros_de_ideas/1999267/3-casas-de-madera-que-vas-a-querer-tener-para-pasar-el-verano-planos". "https://media-cdn.tripadvisor.com/media/photo-s/0e/18/c5/fc/comedor-cabana.jpg"}
    List<string> ambientes1 = new List<string>{"Cocina equipada", "Habitación matrimonial"}
    Cabaña cabaña1 = new Cabaña(1, "La casa linda", "es muy comoda, 2 ambientes", 3, fotos1, ambientes1);
    dicCabañas.Add(cabaña1);

    List<string> fotos2 = new List<string>{"https://media-cdn.tripadvisor.com/media/photo-s/0e/18/c5/af/exterior-cabana.jpg", "https://media-cdn.tripadvisor.com/media/photo-s/0e/18/c7/2c/terraza-cabana.jpg"}
    List<string> ambientes2 = new List<string>{"Patio con pileta", "Habitacion en suite"}
    Cabaña cabaña2 = new Cabaña(2, "La casa hermosa", "es muy epica, 6 ambientes", 10, fotos2, ambientes2);
    dicCabañas.Add(cabaña2);

    List<string> fotos3 = new List<string>{"https://dynamic-media-cdn.tripadvisor.com/media/partner/bookingcom/photo-o/2e/c2/c4/11/la-posada-de-norma.jpg?w=900&h=-1&s=1", "https://images.trvl-media.com/lodging/90000000/89430000/89420600/89420538/f7cd7ea9.jpg?impolicy=resizecrop&rw=1200&ra=fit"}
    List<string> ambientes3 = new List<string>{"Patio con parrilla", "Garage"}
    Cabaña cabaña3 = new Cabaña(3, "La casa espectacular", "es muy amplia, 3 ambientes", 5, fotos3, ambientes3);
    dicCabañas.Add(cabaña3);
   }
   public Dictionary<int, Cabaña> getDicCabañas()
   {
    return dicCabañas;
   }
   public Cabaña getCabañaPorID(int id){
    if(dicCabañas.ContainsKey(id))
    {
        return  dicCabañas[id];
    }
        return null;
   }
}