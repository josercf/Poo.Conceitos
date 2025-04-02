namespace Poo.Conceitos
{
    public class Medida
    {
        public int Largura { get; set; }
        public int Perfil { get; set; }
        public char Construcao { get; set; }
        public float Aro { get; set; }

        public IndiceCargaPneu IndiceCarga { get; set; }

        public string IndiceVelocidade { get; set; }
    }
}