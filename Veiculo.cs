
namespace Poo.Conceitos
{
    class Veiculo
    {
        private Dictionary<string, Pneu> pneus;

        public IReadOnlyDictionary<string, Pneu> Pneus => pneus;

        public float PesoMaximo { get; set; }

        public Veiculo()
        {
            pneus = new Dictionary<string, Pneu>();
        }



        public void AdicionarPneu(string posicao, Pneu pneu)
        {
            if (pneus.Count() == 4)
            {
                throw new Exception("O veículo já possui 4 pneus");
            }

            if (pneus.ContainsKey(posicao))
            {
                throw new Exception($"Já existe um pneu nessa posição. ({posicao})");
            }

            pneu.Medida.IndiceCarga = "94";
            if (pneu.Medida.IndiceCarga > 94)
            {
                throw new Exception("O índice de carga do pneu não é 94");
            }


            pneus.Add(posicao, pneu);
        }


        private float CalcularPesoPorPneu()
        {
            const int QUANTIDADE_PNEUS = 4;
            return PesoMaximo / QUANTIDADE_PNEUS;
        }
    }
}
