namespace certificacao_csharp_roteiro{
    internal class MenuItem{
               
    public MenuItem(string titulo, Type tipoClasse)
        {
            Titulo = titulo;
            TipoClasse = tipoClasse;
        }

        public string Titulo { get; set; }
        public Type TipoClasse { get; set; }
    }
}