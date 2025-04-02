namespace Poo.Conceitos
{
    public struct Medida
    {
        public Medida(int largura, int perfil, char construcao, 
                      float aro, IndiceCargaPneu indiceCarga, 
                      string indiceVelocidade)
        {
            Largura = largura;
            Perfil = perfil;
            Construcao = construcao;
            Aro = aro;
            IndiceCarga = indiceCarga;
            IndiceVelocidade = indiceVelocidade;
        }

        public int Largura { get; }
        public int Perfil { get; }
        public char Construcao { get; }
        public float Aro { get; }

        public IndiceCargaPneu IndiceCarga { get; }

        public string IndiceVelocidade { get; }
    }
}