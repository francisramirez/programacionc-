using System;


namespace Clase
{
    /// <summary>
    /// Clase para administrar las cuentas corrientes.
    /// </summary>
    public class CuentaCorriente
    {

        #region"Propiedades"
        private string _numeroCuenta;

        public string NumeroCuenta
        {
            get { return _numeroCuenta; }
            set
            {
                _numeroCuenta = value;
            }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private decimal _saldo;

        public decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        #endregion

        #region "Metodos"
        public void Depositar()
        {
            Console.WriteLine("Estoy Depositando");
        }
        public void Girar()
        {
            Console.WriteLine("Estoy Girando");
        }
        public decimal ContultarSaldo()
        {
            return this._saldo;
        }
        #endregion

    }
}
