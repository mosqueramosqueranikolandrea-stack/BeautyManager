
namespace Banco
{
    internal class CuentaBancaria
    {
        private string v1;
        private string v2;
        private int v3;

        public CuentaBancaria(string v1, string v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        internal string ConsultarSaldo()
        {
            throw new NotImplementedException();
        }

        internal void Depositar(int v)
        {
            throw new NotImplementedException();
        }

        internal void MostrarInfo()
        {
            throw new NotImplementedException();
        }

        internal void Retirar(int v)
        {
            throw new NotImplementedException();
        }
    }
}