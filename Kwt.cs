namespace Forbrugs_Program
{
    public class Kwt
    {
        private double _tidTændt;
        private double _watt;
        private double _kiloWattPris;
        private string _navn;
        public Kwt(double kiloWattPris, double watt, double tidTændt, string navn) // kan mulighvis fjerne kwt fra ctor, da de kan settes i props.
        {
            _tidTændt = tidTændt;
            _watt = watt;
            _kiloWattPris = kiloWattPris;
            _navn = navn;
        }

        public double KwtPris
        {
            get { return _kiloWattPris; }
            set { _kiloWattPris = value; }
        }

        public double tidTændt
        {
            get { return _tidTændt; }
            set { _tidTændt = value; }
        }

        public double watt
        {
            get { return _watt; }
            set { _watt = value; }
        }
        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }
        public double udregnKWT()
        {
            double pris = _watt * _kiloWattPris * _tidTændt;
            return pris;
        }

        
    }
}