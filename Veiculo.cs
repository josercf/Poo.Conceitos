
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

            float pesoPorPneu = CalcularPesoPorPneu();
            if (!pneu.SuportaPeso(pesoPorPneu))
            {
                throw new Exception("O pneu não suporta o peso do veículo");
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
