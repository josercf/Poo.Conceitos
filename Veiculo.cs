
namespace Poo.Conceitos
{
    //uma classe abstrata serve para delimitar o que as classes especialistas deverão ter. 
    //Ela fala sobre O QUE e não sobre COMO
    public abstract class Veiculo
    {
        protected Dictionary<string, Pneu> pneus;

        public IReadOnlyDictionary<string, Pneu> Pneus => pneus;

        public float PesoMaximo { get; set; }
        
        public abstract float Quilometragem { get; set; }

        public Veiculo()
        {
            pneus = new Dictionary<string, Pneu>();
        }


        public virtual bool ValidarPneu(string posicao, Pneu pneu)
        {
            Console.WriteLine("Chamando validar pneu da classe Veiculo");
            if (pneus.ContainsKey(posicao))
            {
                throw new Exception($"Já existe um pneu nessa posição. ({posicao})");
            }

            float pesoPorPneu = CalcularPesoPorPneu();
            if (!pneu.SuportaPeso(pesoPorPneu))
            {
                throw new Exception("O pneu não suporta o peso do veículo");
            }

            return true;
        }

        public void AdicionarPneu(string posicao, Pneu pneu)
        {
          if(ValidarPneu(posicao, pneu))
            pneus.Add(posicao, pneu);
        }


        protected abstract float CalcularPesoPorPneu();

        public override string ToString()
        {
            return "Mustang do Matheus";
        }
    }
}
