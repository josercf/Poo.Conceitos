namespace Poo.Conceitos
{
    public record Pneu
    {
        public Pneu(string marca, Medida medida)
        {
            Marca = marca;
            Medida = medida;
        }

        public string Marca { get; }
        public Medida Medida { get; }

        public bool SuportaPeso(float peso)
        {
            return peso <= Medida.IndiceCarga.Carga;
        }
    }
}